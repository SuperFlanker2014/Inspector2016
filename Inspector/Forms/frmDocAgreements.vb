Imports System.Globalization
Imports Microsoft.VisualBasic

Public Class frmDocAgreements

    Private tblList As New Collection

    Public Function save()

        'проверка bsAgreements
        'check if new
        If isNewDocMode Then
            If Me.Client_innMaskedTextBox.Text = "" Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
                Return False
            Else
                Dim guid1 As Guid = Me.taClients.IsInnExists(Me.Client_innMaskedTextBox.Text)
                If guid1 = Guid.Empty Then
                    MsgBox("Такого номера ИНН нет в базе!", MsgBoxStyle.Critical)
                    Return False
                ElseIf Me.bsAgreements.Current.Item("client_guid").GetType.Name = "DBNull" Then
                    Me.bsAgreements.Current.Item("client_guid") = guid1
                End If
            End If
        End If

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Me.bsAgreements.EndEdit()
        Catch ex As NoNullAllowedException
            If ex.Message.Contains("client_inn") Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        End Try

        bsAgreements_CurrentChanged(New Object, New System.EventArgs)

        Try
            Me.taAgreements.Update(Me.dsPayments.Docs_Agreements)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsAgreements

        isNewDocMode = False
        bsClients.ResumeBinding()
        Windows.Forms.Cursor.Current = Cursors.Arrow

        Return True
    End Function

    Private Shadows Sub frmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tblList.Add(Me.dsPayments.Docs_Agreements)
        tblList.Add(Me.dsPayments.Docs_Bills)

        Dim IDs As DataTable = taAgreements.Get3IDs()
        For Each tbl As Object In tblList
            Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
            ta.ClearBeforeFill = False
            For Each row As DataRow In IDs.Rows
                ta.FillByID(tbl, row.Item("doc_id"))
            Next row
        Next tbl

    End Sub

#Region "Перекрытые методы работы с документом"

    Public Overrides Sub newDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.bsAgreements.AddNew()
        isNewDocMode = True
        Me.bsClients.SuspendBinding()
        Client_innMaskedTextBox.Focus()
    End Sub

    Public Overrides Sub delDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Удалить запись?", MsgBoxStyle.YesNo, ) = MsgBoxResult.No Then
            Exit Sub
        Else
            isNewDocMode = False
            Me.bsClients.ResumeBinding()
            Me.bsAgreements.RemoveCurrent()
        End If
    End Sub

    Public Overrides Sub saveDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()
    End Sub

    Public Overrides Sub findDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isSearchMode Then
            Me.Cursor = Cursors.WaitCursor

            Dim client_inn As String = Me.Client_innMaskedTextBox.Text.Trim()
            Dim doc_date_high As String = Doc_date_highDateTimePicker.Value
            Dim doc_date_low As String = Doc_dateDateTimePicker.Value
            Dim doc_number As String = Me.Doc_numberMaskTextBox.Text.Trim()

            Me.dsPayments.Clear()

            Dim IDs As DataTable = Me.taAgreements.GetIDs(doc_date_high, doc_date_low, doc_number, client_inn)
            Dim list As String = Main.getDocIdList(IDs)

            For Each tbl As Object In tblList
                Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
                ta.FillTable(tbl, list)
            Next tbl

            Me.bsAgreements.ResumeBinding()
            Me.bsBillsPre.ResumeBinding()
            Me.bsBillsPost.ResumeBinding()

            btnSearch.Text = "В режим поиска"
            isSearchMode = False
            Me.Doc_numberMaskTextBox.Focus()

            Me.Cursor = Cursors.Default
        Else
            Me.bsAgreements.SuspendBinding()
            Me.bsBillsPre.SuspendBinding()
            Me.bsBillsPost.SuspendBinding()

            Me.Doc_dateDateTimePicker.Value = New DateTime(2007, 1, 1) 'DateTime.Today.Year, DateTime.Today.Month, 1)
            Me.Doc_date_highDateTimePicker.Value = DateTime.Today

            btnSearch.Text = "Найти"
            isSearchMode = True
            Me.Doc_numberMaskTextBox.Focus()
        End If
    End Sub

    Public Overrides Sub initializeControlLists()
        Me.lstNewDocInVisible.AddRange(New Object() {btnNew, BindingNavigatorCountItem,
            BindingNavigatorMoveFirstItem, BindingNavigatorMoveLastItem, BindingNavigatorMoveNextItem,
            BindingNavigatorMovePreviousItem, BindingNavigatorPositionItem, BindingNavigatorSeparator,
            BindingNavigatorSeparator1, btnSearch, pnlMain, btnUpdate, btnPrintMenu,
            btnPrintPreview, btnCopyAll})

        Me.lstSearchInVisible.AddRange(New Object() {pnlMain, bnAgreements, txtClient_name,
            txtClient_address, lblAddress, lblName, Doc_date_highDateTimePicker, lblHighDate, lblMoney,
            txtSum, btnCopyAll})
        Me.lstSearchEnabled.AddRange(New Object() {Doc_numberMaskTextBox, Doc_dateDateTimePicker,
            Client_innMaskedTextBox})
        Me.lstEmptyFormDisabled.AddRange(New Object() {pnlMain, btnDelete, btnUpdate, btnPrintMenu,
            btnPrintPreview, Doc_numberMaskTextBox, Doc_dateDateTimePicker,
            Client_innMaskedTextBox, btnCopyAll})

        Me.dtClients = Me.dsPayments.R_clients
        Me.bsPrimary = Me.bsAgreements
    End Sub

#End Region

    Private Sub bsAgreements_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsAgreements.CurrentChanged
        Dim p As Object = bsAgreements.Current
        If (p Is Nothing) Then
            Exit Sub
        End If
        If (p.Item("client_guid").GetType.Name <> "DBNull") Then
            Me.taClients.FillOneByGUID(Me.dsPayments.R_clients, bsAgreements.Current.Item("client_guid"))
            Me.txtSum.Text = Me.taAgreements.SumForAgreement(p.Item("doc_id"))
        Else 'если новый

            p.Item("doc_number") = Int(taAgreements.MaxDocNumber()) + 1
            p.item("doc_user") = Main.userName
            p.Item("doc_date") = System.DateTime.Today()
            p.Item("doc_date_limit") = System.DateTime.ParseExact("31.12." + Today.Year.ToString, "dd.MM.yyyy", CultureInfo.GetCultureInfo("ru-RU"))

            Me.bsAgreements.ResetCurrentItem()
        End If
    End Sub

    Private Sub Client_innMaskedTextBox_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Client_innMaskedTextBox.MouseDoubleClick

        Dim i As String
        i = Me.Client_innMaskedTextBox.Text.TrimStart(" ").TrimEnd(" ")
        If i = "" Then
            i = "g"
        End If

        Using row = Main.ShowClientsForm(i)
            If row Is Nothing Then
                MsgBox("Клиент не выбран!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Dim inn As String = row.Item("client_inn").ToString()
                Dim guid1 As Guid = row.Item("client_guid")
                Me.taClients.FillOneByGUID(Me.dsPayments.R_clients, guid1)
                Me.bsAgreements.Current.Item("client_guid") = guid1
                Me.Client_innMaskedTextBox.Text = inn
            End If
        End Using

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If save() Then
            Printing.print(DocumentType.Agreement, PrintingType.PrintDocument, True, 1, Me.bsAgreements.Current.Row)
        End If
    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        If save() Then
            Printing.print(DocumentType.Agreement, PrintingType.PreviewDocument, True, 1, Me.bsAgreements.Current.Row)
        End If
    End Sub

    Private Sub dgvBills_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) _
        Handles dgvBillsPre.CellMouseDoubleClick, dgvBillsPost.CellMouseDoubleClick
        Dim line_num As Integer = sender.Rows(e.RowIndex).DataBoundItem.Item("line_number")
        Dim bill_type As Boolean = sender.Rows(e.RowIndex).DataBoundItem.Item("bill_type")

        CMediator.Instance.SendMessage(New CCommandBillFormOpen(bill_type, line_num))
    End Sub

    Private Sub dgvBills_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) _
        Handles dgvBillsPre.RowsAdded, dgvBillsPost.RowsAdded
        For Each row As DataGridViewRow In sender.Rows
            Dim c As DataGridViewCell = row.Cells(6)
            Dim c1 As DataGridViewCell = row.Cells(7)
            If c.Value = False Then
                c1.Style.BackColor = Color.Red
                c1.Value = "Не проведено"
            Else
                c1.Style.BackColor = Color.GreenYellow
                c1.Value = "Проведено"
            End If
        Next row
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAddPre.Click, btnAddPost.Click
        Dim p As Docs_Payments.Docs_AgreementsRow
        If bsAgreements.Current Is Nothing Then
            Exit Sub
        Else
            p = Me.bsAgreements.Current.Row
        End If

        Dim bill_type As Boolean
        If sender.Name = "btnAddPre" Then
            bill_type = False
        Else
            bill_type = True
        End If
        Dim c As New Collection
        c.Add(p.R_clientsRow.client_inn, "inn")
        c.Add(Me.bsClients.Current.Row.Item("client_adress_fact"), "fact_address")

        CMediator.Instance.SendMessage(New CCommandBillFormNew(
                                       bill_type, p.Item("client_guid"),
                                       Me.bsClients.Current.Row.Item("client_inn"),
                                       Me.bsClients.Current.Row.Item("client_adress_fact"),
                                       p.Item("doc_id")))
        'Main.ShowBillForm(bill_type, c)
    End Sub

    Private Sub txtSum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSum.TextChanged
        If CDbl(txtSum.Text) < 0 Then
            txtSum.ForeColor = Color.Red
        Else
            txtSum.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim p As Docs_Payments.Docs_AgreementsRow = Me.bsAgreements.Current.Row
        Me.taBills.FillByID(Me.dsPayments.Docs_Bills, p.Item("doc_id"))
        Me.txtSum.Text = Me.taAgreements.SumForAgreement(p.Item("doc_id"))
    End Sub

#Region "Выполнение комманд"

    Public Overrides Sub ExecuteCommand(ByRef Command As CCustomCommand)
        If TypeOf Command Is CCommandFormAgreementNew Then
            Dim cmd As CCommandFormAgreementNew = CType(Command, CCommandFormAgreementNew)
            Dim sum As Double = Me.taAgreements.SumForAgreement(cmd.doc_agreement.doc_id)

            Dim dog_new As Inspector.Docs_Payments.Docs_AgreementsRow = Me.dsPayments.Docs_Agreements.NewDocs_AgreementsRow()
            dog_new.Item("client_guid") = cmd.doc_agreement.client_guid
            dog_new.Item("doc_number") = Int(taAgreements.MaxDocNumber()) + 1
            dog_new.Item("doc_user") = Main.userName
            dog_new.Item("doc_date") = System.DateTime.Today()
            dog_new.Item("doc_date_limit") = System.DateTime.ParseExact("31.12." + Today.Year.ToString(), "dd.MM.yyyy", CultureInfo.GetCultureInfo("ru-RU"))

            Me.dsPayments.Docs_Agreements.AddDocs_AgreementsRow(dog_new)
            Me.taAgreements.Update(Me.dsPayments.Docs_Agreements)

            Dim cmd_one As New CCommandBillFormNewPre()
            cmd_one.doc_agreement_id = dog_new.Item("doc_id")
            cmd_one.doc_agreement_sum = sum
            CMediator.Instance.SendMessage(cmd_one)

            Me.bsAgreements.MoveLast()

            Me.btnUpdate_Click(Nothing, New System.EventArgs())

        End If
    End Sub

#End Region

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim cmd As New CCommandFormAgreementNew()
        cmd.doc_agreement = Me.bsAgreements.Current.Row
        CMediator.Instance.SendMessage(cmd)
    End Sub

    Private _HidePre As Boolean = False
    Private Property HidePre() As Boolean
        Get
            Return _HidePre
        End Get
        Set(ByVal value As Boolean)
            _HidePre = value
            If value Then
                Me.bsBillsPre.Filter = "bill_type = 0 and is_transacted = 0"
                Me.btnHideTransactedPre.Text = "Показать проведённые"
            Else
                Me.bsBillsPre.Filter = "bill_type = 0"
                Me.btnHideTransactedPre.Text = "Скрыть проведённые"
            End If
        End Set
    End Property

    Private _HidePost As Boolean = False
    Private Property HidePost() As Boolean
        Get
            Return _HidePost
        End Get
        Set(ByVal value As Boolean)
            _HidePost = value
            If value Then
                Me.bsBillsPost.Filter = "bill_type = 1 and is_transacted = 0"
                Me.btnHideTransactedPost.Text = "Показать проведённые"
            Else
                Me.bsBillsPost.Filter = "bill_type = 1"
                Me.btnHideTransactedPost.Text = "Скрыть проведённые"
            End If
        End Set
    End Property

    Private Sub btnHideTransactedPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideTransactedPre.Click
        HidePre = Not HidePre
    End Sub

    Private Sub btnHideTransactedPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideTransactedPost.Click
        HidePost = Not HidePost
    End Sub

    Private Sub btnMakeAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeAct.Click
        CMediator.Instance.SendMessage(New CCommandReviseAct(bsAgreements.Current("doc_id"), bsAgreements.Current("client_guid"), bsClients.Current("client_inn")))
    End Sub
End Class