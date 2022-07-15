Imports Microsoft.VisualBasic

Public Class frmDocBills

    Protected Overrides Property billType() As Boolean
        Get
            Return MyBase.billType
        End Get
        Set(ByVal value As Boolean)
            MyBase.billType = value
            If value = False Then
                Me.Text = "Счета НА ПРЕДОПЛАТУ"
                Me.btnCopyPrePre.Visible = True
                Me.btnCopyPrePost.Visible = True
                Me.btnCopyPostPost.Visible = False

                Me.btnBillPrePreview.Visible = True
                Me.btnBillPreAddPreview.Visible = True
                Me.btnBillPostPreview.Visible = False
                Me.btnBillPostAddPreview.Visible = False

                Me.btnBillPrePrint.Visible = True
                Me.btnBillPreAddPrint.Visible = True
                Me.btnBillPostPrint.Visible = False
                Me.btnBillPostAddPrint.Visible = False

                Me.btnExportTo1C.Visible = False

                Me.lblVans.Visible = True
                Me.txtVans.Visible = True
            Else
                Me.Text = "Счета-ФАКТУРЫ"
                Me.btnCopyPrePre.Visible = False
                Me.btnCopyPrePost.Visible = False
                Me.btnCopyPostPost.Visible = True

                Me.btnBillPrePreview.Visible = False
                Me.btnBillPreAddPreview.Visible = False
                Me.btnBillPostPreview.Visible = True
                Me.btnBillPostAddPreview.Visible = True

                Me.btnBillPrePrint.Visible = False
                Me.btnBillPreAddPrint.Visible = False
                Me.btnBillPostPrint.Visible = True
                Me.btnBillPostAddPrint.Visible = True

                Me.btnExportTo1C.Visible = True

                Me.lblVans.Visible = False
                Me.txtVans.Visible = False
            End If
        End Set
    End Property

    Public Overrides Property isTransacted() As Boolean
        Get
            Return MyBase.isTransacted
        End Get
        Set(ByVal value As Boolean)
            If Me.isEmptyForm = True Then
                Return
            End If
            MyBase.isTransacted = value
            If value Then
                Me.pnlTransaction.BackColor = Color.Green
                Me.txtPaydoc_num.Enabled = False
                Me.dtpPaydoc_date.Enabled = False
                Me.cbCash.Enabled = False
                Me.dgvServices.Enabled = False
                Me.BindingNavigatorDeleteItem.Visible = False
                Me.btnTransact.Text = "Откатить"
            Else
                Me.pnlTransaction.BackColor = Color.Red
                Me.txtPaydoc_num.Enabled = True
                Me.dtpPaydoc_date.Enabled = True
                Me.cbCash.Enabled = True
                Me.dgvServices.Enabled = True
                Me.BindingNavigatorDeleteItem.Visible = True
                Me.btnTransact.Text = "Провести"
            End If

        End Set
    End Property

    Private tblList As New Collection
    Private tblRates As New Inspector.References.R_servicesDataTable
    Private bsRates As New BindingSource
    Private IDs As New DataTable

    Private Sub print(ByVal PrintOrPreview As PrintingType, ByVal DocType As DocumentType)
        Printing.print(DocType, PrintOrPreview, True, 2, Me.bsBills.Current.row)
    End Sub

    Public Function save()

        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        EndEdit()
        'проверка bsBllisPre
        'если новый
        If isNewDocMode Then
            If Me.Client_innMaskedTextBox.Text = "" Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
                Return False
            Else
                Dim guid1 As Guid = Me.taClients.IsInnExists(Me.Client_innMaskedTextBox.Text)
                If guid1 = Guid.Empty Then
                    MsgBox("Такого номера ИНН нет в базе!", MsgBoxStyle.Critical)
                    Return False
                End If

                Dim doc_id As Integer
                If Me.txtDoc_id.Text = "" Then
                    doc_id = Me.taAgreements.DocIDByInn(Me.Client_innMaskedTextBox.Text)
                Else
                    doc_id = Integer.Parse(Me.txtDoc_id.Text)
                End If

                If doc_id = 0 Then
                    MsgBox("Выбранный клиент не имеет действующих договоров!", MsgBoxStyle.Critical)
                    Return False
                End If

                Me.taClients.FillOneByGUID(Me.dsPayments.R_clients, guid1)
                Me.taAgreements.FillByID(Me.dsPayments.Docs_Agreements, doc_id)
                Me.txtDoc_id.Text = Me.bsAgreements.Current.Row.doc_id

                End If
        End If

        Me.bsBills.EndEdit()

        bsBillsPre_CurrentChanged(New Object, New System.EventArgs)

        Try
            Me.taBills.Update(Me.dsPayments.Docs_Bills)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsBillsPre

        'проверка bsServices
        Me.dgvServices.EndEdit()
        Try
            Me.bsServices.EndEdit()
        Catch ex As System.Data.NoNullAllowedException
            If ex.Message.Contains("title") Then
                MsgBox("Пустое название услуги недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("count") Then
                MsgBox("Пустое количество услуг недопустимо!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As System.Data.ConstraintException
            MsgBox("Дублирующиеся названия услуг недопустимы!", MsgBoxStyle.Critical)
            Return False
        End Try
        Try
            Me.taServices.Update(Me.dsPayments.Docs_Bills_Services)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsServices

        'считаем суммы по каждой квитанции
        'Dim recalculateSum As Boolean = False
        For Each row As Docs_Payments.Docs_BillsRow In Me.dsPayments.Docs_Bills.Rows
            'For Each childRow As Docs_Payments.Docs_Bills_ServicesRow In row.GetChildRows("FK_Docs_Bills_Services_Docs_Bills")
            '    If childRow.RowState <> DataRowState.Unchanged Then
            '        recalculateSum = True
            '        Exit For
            '    End If
            'Next childRow
            'If recalculateSum Then
            'вычисляем на стороне БД
            row.doc_sum = Math.Round(Me.taBills.GetSumByLine(row.line_number), 2, MidpointRounding.AwayFromZero)
            'End If
            'recalculateSum = False

            For Each childRow As Docs_Payments.Docs_Bills_ServicesRow In row.GetChildRows("FK_Docs_Bills_Services_Docs_Bills")
                '    If childRow.RowState <> DataRowState.Unchanged Then
                '        recalculateSum = True
                '        Exit For
                '    End If
                childRow.sum = Decimal.Round(childRow.rate * childRow.count * childRow.sum_factor, 2, MidpointRounding.AwayFromZero)
            Next childRow
        Next row
        Me.taBills.Update(Me.dsPayments.Docs_Bills)
        'конец расчёта сумм

        bsClients.ResumeBinding()
        bsAgreements.ResumeBinding()
        If isNewDocMode Then
            Me.txtFactAddress.Text = bsClients.Current.Row.Item("client_adress_fact").ToString()
        End If
        isNewDocMode = False
        Windows.Forms.Cursor.Current = Cursors.Arrow

        Return True
    End Function

    Private Shadows Sub frmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tblList.Add(dsPayments.Docs_Bills)
        tblList.Add(dsPayments.Docs_Bills_Services)

        For Each tbl As Object In tblList
            Dim ta As Object = tbl.GetAdapter(dbConnection)
            ta.ClearBeforeFill = False
            For Each row As DataRow In IDs.Rows
                ta.FillByLine(tbl, row.Item("line_number"))
            Next row
        Next tbl

        Dim tblUnits As Object = dsPayments.R_services_units
        Dim taUnits As Object = tblUnits.GetAdapter(dbConnection)
        taUnits.Fill(tblUnits)

        tblRates = dsReferenses.R_services.GetAdapter(dbConnection).GetActualRates()
        bsRates.DataSource = tblRates

        Column_service_title.DataSource = bsRates 'tblRates
        Column_service_title.DisplayMember = "title_short"
        Column_service_title.ValueMember = "title"

        sum_factor_titleColumn.DataSource = dsReferenses.R_services_sum_factors
        sum_factor_titleColumn.DisplayMember = "title_short"
        sum_factor_titleColumn.ValueMember = "title"

        For Each row As DataRow In dsReferenses.R_bill_patterns.Rows
            cbBillPatterns.Items.Add(row.Item("title"))
        Next row

    End Sub

    Private Sub EndEdit()
        'goods
        dgvServices.EndEdit()
        Dim r As DataRowView = CType(Me.bsServices.Current, DataRowView)
        If (r IsNot Nothing) Then
            If (r.Row("rate").ToString() = "" Or _
                r.Row("service_title").ToString() = "") Then
                r.CancelEdit()
            Else
                r.EndEdit()
            End If
        End If
        bsServices.EndEdit()
        bsServices.ResetCurrentItem()

        'document
        Try
            bsBills.EndEdit()
        Catch ex As NoNullAllowedException
            'не ввели arrived, спросим в сохранении
        End Try

    End Sub

#Region "Перекрытые методы работы с документом"

    Public Overrides Sub newDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.bsBills.AddNew()
        isNewDocMode = True
        Me.bsClients.SuspendBinding()
        Me.bsAgreements.SuspendBinding()
        Client_innMaskedTextBox.Focus()
    End Sub

    Public Overrides Sub delDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Удалить запись?", MsgBoxStyle.YesNo, ) = MsgBoxResult.No Then
            Exit Sub
        Else
            isNewDocMode = False
            Me.bsClients.ResumeBinding()
            Me.bsAgreements.ResumeBinding()
            Me.bsBills.RemoveCurrent()
        End If
    End Sub

    Public Overrides Sub saveDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()
    End Sub

    Public Overrides Sub findDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isSearchMode Then
            Me.Cursor = Cursors.WaitCursor
            Dim t1, t2 As Byte
            Select Case Me.cbTransacted.CheckState
                Case CheckState.Checked
                    t1 = 1
                    t2 = 1
                Case CheckState.Unchecked
                    t1 = 0
                    t2 = 0
                Case CheckState.Indeterminate
                    t1 = 1
                    t2 = 0
            End Select

            Dim client_inn As String = Me.mtbClient_inn.Text.Trim() 'Start(" ").TrimEnd(" ")
            Dim date_low As String = Me.dtpDate_low.Value
            Dim date_high As String = Me.dtpDate_high.Value
            Dim doc_number As String = Me.mtbDoc_number.Text.Trim() 'Start(" ").TrimEnd(" ")

            Me.dsPayments.Clear()

            Dim IDs As DataTable = Me.taBills.GetIDs(billType, doc_number, date_low, date_high, t1, t2, client_inn)
            Dim list As String = Main.getLineNumberList(IDs) '.getLineNumberList 'getDocIdList

            For Each tbl As Object In tblList
                Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
                ta.ClearBeforeFill = False
                ta.FillTableByLine(tbl, list) 'FillTableByLine
            Next tbl

            'Me.bsClients.ResumeBinding()
            'Me.bsAgreements.ResumeBinding()
            Me.bsBills.ResumeBinding()
            'Me.bsServices.ResumeBinding()

            btnSearch.Text = "В режим поиска"
            isSearchMode = False
            Me.Cursor = Cursors.Default
        Else
            'Me.bsClients.SuspendBinding()
            'Me.bsAgreements.SuspendBinding()
            Me.bsBills.SuspendBinding()
            'Me.bsServices.SuspendBinding()

            Me.dtpDate_low.Value = New DateTime(2007, 1, 1) 'DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Me.dtpDate_high.Value = DateTime.Today

            btnSearch.Text = "Найти"
            isSearchMode = True
            Me.mtbDoc_number.Focus()
        End If
    End Sub

    Public Overrides Sub initializeControlLists()
        Me.lstNewDocInVisible.AddRange(New Object() {BindingNavigatorAddNewItem, BindingNavigatorCountItem, _
            BindingNavigatorMoveFirstItem, BindingNavigatorMoveLastItem, BindingNavigatorMoveNextItem, _
            BindingNavigatorMovePreviousItem, BindingNavigatorPositionItem, BindingNavigatorSeparator, _
            BindingNavigatorSeparator1, btnSearch, btnCopy, btnPrint, btnPrintPreview, pnlTransaction, _
            cbBillPatterns, btnFill})
        Me.lstNewDocDisabled.AddRange(New Object() {dgvServices})
        Me.lstNewDocReadOnly.AddRange(New Object() {Client_innMaskedTextBox})
        Me.lstSearchInVisible.AddRange(New Object() {pnlDoc, bnBills, dgvServices})
        Me.lstSearchVisible.AddRange(New Object() {pnlSearch})

        Me.dtClients = Me.dsPayments.R_clients
        Me.bsPrimary = Me.bsBills

        Me.lstEmptyFormDisabled.AddRange(New Object() {pnlDoc, pnlTransaction, dgvServices, _
            BindingNavigatorDeleteItem, cbBillPatterns, btnFill, btnPrint, btnPrintPreview, _
            btnCopy, btnExportTo1C})
    End Sub

#End Region

    Private Sub bsBillsPre_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsBills.CurrentChanged
        Dim p As Docs_Payments.Docs_BillsRow
        If (bsBills.Current Is Nothing) Then
            Exit Sub
        Else
            p = bsBills.Current.Row
        End If
        If (p.Item("doc_id").GetType.Name <> "DBNull") Then

            'If p.doc_date < newDataDate Then
            '    bsRates.Filter = "new_data is NULL or new_data = 0"
            'Else
            '    bsRates.Filter = "new_data = 1"
            'End If

            taAgreements.FillByID(dsPayments.Docs_Agreements, p.doc_id)
            taClients.FillOneByGUID(dsPayments.R_clients, bsAgreements.Current.Item("client_guid"))
        Else 'если новый

            'If DateTime.Now < newDataDate Then
            '    bsRates.Filter = "new_data is NULL or new_data = 0"
            'Else
            '    bsRates.Filter = "new_data = 1"
            'End If

            p.doc_number = Int(taBills.MaxDocNumber(billType)) + 1
            p.doc_user = userName
            p.doc_date = DateTime.Today()
            p.doc_sum = 0
            p.is_russia = True
            p.is_transacted = False
            p.bill_type = billType

            bsBills.ResetCurrentItem()
        End If
    End Sub

    Private Sub Client_innMaskedTextBox_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles Client_innMaskedTextBox.MouseDoubleClick, mtbClient_inn.MouseDoubleClick
        If (Not isNewDocMode) And (Not isSearchMode) Then
            Exit Sub
        End If

        Dim i As String
        i = Me.Client_innMaskedTextBox.Text.TrimStart(" ").TrimEnd(" ")
        If i = "" Then
            i = "g"
        End If

        Dim inn As String
        Dim fact_address As String
        Dim doc_id As Integer
        Dim guid1 As Guid
        Using row = Main.ShowClientsForm(i)
            If row Is Nothing Then
                MsgBox("Клиент не выбран!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                inn = row.Item("client_inn").ToString()
                guid1 = row.Item("client_guid")
                fact_address = row.Item("client_adress_fact").ToString()
            End If
        End Using

        doc_id = Me.taAgreements.DocIDByInn(inn)
        If doc_id = 0 Then
            MsgBox("Выбранный клиент не имеет действующих договоров!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Me.taClients.FillOneByGUID(Me.dsPayments.R_clients, guid1)
        Me.taAgreements.FillByID(Me.dsPayments.Docs_Agreements, doc_id)

        Me.Client_innMaskedTextBox.Text = inn
        Me.mtbClient_inn.Text = inn
        Me.txtDoc_id.Text = doc_id
        Me.txtFactAddress.Text = fact_address
    End Sub

    Private Sub dgvServices_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServices.CellValueChanged
        If e.ColumnIndex = 3 And e.RowIndex <> -1 Then
            'подставляем цены
            Dim rowServices As References.R_servicesRow = Me.tblRates.FindBytitle(dgvServices.Item(3, e.RowIndex).Value)
            dgvServices.Item(4, e.RowIndex).Value = rowServices.unit
            dgvServices.Item(5, e.RowIndex).Value = rowServices.rate
        End If

        If e.ColumnIndex = 8 And e.RowIndex <> -1 Then
            'подставляем название коэффициентов
            Static ta As Inspector.ReferencesTableAdapters.R_services_sum_factorsTableAdapter = Main.dsReferenses.R_services_sum_factors.GetAdapter(Main.dbConnection)
            dgvServices.Item(7, e.RowIndex).Value = ta.GetFactor(dgvServices.Item(8, e.RowIndex).Value)
        End If
    End Sub

    Private Sub btnTransact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransact.Click
        Try
            Me.bsBills.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If Not Me.bsBills.Current.Row.is_transacted Then
            Me.bsBills.Current.Row.is_transacted = True
            Me.bsBills.Current.Row.paydoc_date = dtpPaydoc_date.Value
            Me.bsBills.Current.Row.paydoc_num = txtPaydoc_num.Text
        Else
            Me.bsBills.Current.Row.is_transacted = False
        End If

    End Sub

    'копирование
    Private Function Copy(ByVal new_bill_type As Boolean) As Integer
        If Me.bsBills.Current Is Nothing Then
            Return -1
        End If

        Dim cur_row As Docs_Payments.Docs_BillsRow = Me.bsBills.Current.Row
        Dim row As Docs_Payments.Docs_BillsRow = Me.dsPayments.Docs_Bills.NewDocs_BillsRow

        'копирование счёта
        Dim ln As Integer = row.line_number
        row.ItemArray = cur_row.ItemArray
        row.line_number = ln
        row.bill_type = new_bill_type
        row.is_transacted = False

        If cur_row.Item("paydoc_num") IsNot DBNull.Value Then
            row.paydoc_num = cur_row.paydoc_num
        End If
        If cur_row.Item("paydoc_date") IsNot DBNull.Value Then
            row.paydoc_date = cur_row.paydoc_date
        End If

        row.is_cash = cur_row.is_cash
        row.doc_date = System.DateTime.Today()
        row.doc_number = Int(Me.taBills.MaxDocNumber(new_bill_type)) + 1
        row.doc_user = Main.userName
        row.fact_address = cur_row.fact_address
        Me.dsPayments.Docs_Bills.AddDocs_BillsRow(row)
        Me.taBills.Update(Me.dsPayments.Docs_Bills)

        'копирование услуг
        Dim tbl As DataTable = Me.dsPayments.Docs_Bills_Services
        Dim tbl_temp As DataTable = System.Activator.CreateInstance(tbl.GetType())
        For Each r As DataRow In tbl.Rows
            If (r.RowState <> DataRowState.Deleted) AndAlso (r.Item("doc_line_number") = cur_row.line_number) Then
                Dim p As DataRow = tbl_temp.NewRow
                p.ItemArray = r.ItemArray
                p.Item("doc_id") = row.doc_id
                p.Item("bill_type") = row.bill_type
                p.Item("doc_line_number") = row.line_number
                tbl_temp.Rows.Add(p)
            End If
        Next r

        For Each r As DataRow In tbl_temp.Rows
            tbl.Rows.Add(r.ItemArray)
        Next r

        Me.taServices.Update(Me.dsPayments.Docs_Bills_Services)

        Return row.line_number
    End Function

    Private Sub btnCopyPrePre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyPrePre.Click
        Dim ln As Integer = Copy(False)
        If ln <> -1 Then
            Me.bsBills.MoveLast()
        End If
    End Sub

    Private Sub btnCopyPrePost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyPrePost.Click
        Dim ln As Integer = Copy(True)
        If ln <> -1 Then
            Me.billType = True
            Me.dsPayments.EnforceConstraints = False
            Me.taBills.FillByLine(Me.dsPayments.Docs_Bills, ln)
            Me.taServices.FillByLine(Me.dsPayments.Docs_Bills_Services, ln)
            Me.dsPayments.EnforceConstraints = True
        End If
    End Sub

    Private Sub btnCopyPostPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyPostPost.Click
        Dim ln As Integer = Copy(True)
        If ln <> -1 Then
            Me.bsBills.MoveLast()
        End If
    End Sub

    'предпросмотр
    Private Sub btnBillPrePreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPrePreview.Click
        If save() Then
            print(PrintingType.PreviewDocument, DocumentType.BillsPre)
        End If
    End Sub

    Private Sub btnBillPreAddPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPreAddPreview.Click
        If save() Then
            print(PrintingType.PreviewDocument, DocumentType.BillsPreAdd)
        End If
    End Sub

    Private Sub btnBillPostPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPostPreview.Click
        If save() Then
            print(PrintingType.PreviewDocument, DocumentType.BillsPost)
        End If
    End Sub

    Private Sub btnBillPostAddPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPostAddPreview.Click
        If save() Then
            print(PrintingType.PreviewDocument, DocumentType.BillsPostAdd)
        End If
    End Sub

    'печать
    Private Sub btnBillPrePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPrePrint.Click
        If save() Then
            print(PrintingType.PrintDocument, DocumentType.BillsPre)
        End If
    End Sub

    Private Sub btnBillPreAddPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPreAddPrint.Click
        If save() Then
            print(PrintingType.PrintDocument, DocumentType.BillsPreAdd)
        End If
    End Sub

    Private Sub btnBillPostPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPostPrint.Click
        If save() Then
            print(PrintingType.PrintDocument, DocumentType.BillsPost)
        End If
    End Sub

    Private Sub btnBillPostAddPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPostAddPrint.Click
        If save() Then
            print(PrintingType.PrintDocument, DocumentType.BillsPostAdd)
        End If
    End Sub

    Private Sub btnFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFill.Click
        If Me.cbBillPatterns.Text = "" Or Me.bsBills.Current Is Nothing Then
            Exit Sub
        End If
        'заполняем услуги по данному шаблону
        Dim rowBillPre As Docs_Payments.Docs_BillsRow = Me.bsBills.Current.Row
        Dim dt As References.R_servicesDataTable = _
            Main.dsReferenses.R_services.GetAdapter(Main.dbConnection).GetForPattern(Me.cbBillPatterns.Text)
        'выходим, если нет  услуг
        If dt.Rows.Count = 0 Then
            Exit Sub
        End If

        Try
            Me.bsServices.CancelEdit()
            Me.bsServices.SuspendBinding()
        Catch ex As Exception
            Exit Sub
        End Try

        For Each row As References.R_servicesRow In dt.Rows
            Dim rowBillsServices As Docs_Payments.Docs_Bills_ServicesRow = Me.dsPayments.Docs_Bills_Services.NewRow
            rowBillsServices.doc_id = rowBillPre.doc_id
            rowBillsServices.bill_type = rowBillPre.bill_type
            rowBillsServices.doc_line_number = rowBillPre.line_number
            rowBillsServices.service_title = row.title
            rowBillsServices.rate = row.rate
            rowBillsServices.unit = row.unit
            rowBillsServices.count = 1
            Try
                Me.dsPayments.Docs_Bills_Services.Rows.Add(rowBillsServices)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next row

        Me.bsServices.ResumeBinding()
    End Sub

#Region "Выполнение комманд"

    Public Overrides Sub ExecuteCommand(ByRef Command As CCustomCommand)
        If TypeOf Command Is CCommandBillFormNewPre Then
            Dim cmd As CCommandBillFormNewPre = CType(Command, CCommandBillFormNewPre)

            Dim bill_new As Inspector.Docs_Payments.Docs_BillsRow = Me.dsPayments.Docs_Bills.NewDocs_BillsRow()

            bill_new.Item("doc_id") = cmd.doc_agreement_id
            bill_new.Item("bill_type") = False
            bill_new.Item("doc_number") = 0
            bill_new.Item("doc_user") = Main.userName
            bill_new.Item("doc_date") = System.DateTime.Today()
            bill_new.Item("doc_sum") = cmd.doc_agreement_sum
            bill_new.Item("is_russia") = True
            bill_new.Item("is_transacted") = True
            bill_new.Item("tax_nds") = 0

            Me.dsPayments.Docs_Bills.AddDocs_BillsRow(bill_new)
            Me.taBills.Update(Me.dsPayments.Docs_Bills)

            'добавляем строку

            Dim bill_service_new As Inspector.Docs_Payments.Docs_Bills_ServicesRow = Me.dsPayments.Docs_Bills_Services.NewDocs_Bills_ServicesRow()

            bill_service_new.Item("doc_id") = cmd.doc_agreement_id
            bill_service_new.Item("bill_type") = False
            bill_service_new.Item("service_title") = "Предоплата"
            bill_service_new.Item("doc_line_number") = bill_new.Item("line_number")
            bill_service_new.Item("count") = cmd.doc_agreement_sum
            bill_service_new.Item("rate") = 1

            Me.dsPayments.Docs_Bills_Services.AddDocs_Bills_ServicesRow(bill_service_new)
            Me.taServices.Update(Me.dsPayments.Docs_Bills_Services)

        ElseIf TypeOf Command Is CCommandBillForm Then
            Dim cmd As CCommandBillForm = CType(Command, CCommandBillForm)

            Me.billType = cmd.bill_type
            IDs = taBills.Get3IDs(billType)
            Me.MdiParent = Owner
            Me.Show()
        ElseIf TypeOf Command Is CCommandBillFormOpen Then
            Dim cmd As CCommandBillFormOpen = CType(Command, CCommandBillFormOpen)

            Me.billType = cmd.bill_type
            IDs = taBills.GetID(cmd.line_number)
            Me.MdiParent = Owner
            Me.Show()
        ElseIf TypeOf Command Is CCommandBillFormNew Then
            Dim cmd As CCommandBillFormNew = CType(Command, CCommandBillFormNew)

            Me.billType = cmd.bill_type
            Me.MdiParent = Owner
            Me.Show()

            Me.newDocument(Nothing, New EventArgs())
            Me.txtFactAddress.Text = cmd.fact_address

            Dim doc_id As Integer = cmd.agreement_doc_id

            Me.taClients.FillOneByGUID(Me.dsPayments.R_clients, cmd.guid1)
            Me.taAgreements.FillByID(Me.dsPayments.Docs_Agreements, doc_id)

            Me.txtDoc_id.Text = doc_id
            Me.Client_innMaskedTextBox.Text = cmd.inn

            Me.saveDocument(Nothing, New EventArgs())
        End If
    End Sub

#End Region

    Private Sub btnExportTo1C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЭкспортВ1СToolStripMenuItem.Click

        Dim xmlFileName As String
        Dim sfd As New SaveFileDialog
        sfd.InitialDirectory = Environment.SpecialFolder.Desktop
        sfd.RestoreDirectory = True
        sfd.Filter = "XML files|*.xml"
        sfd.FileName = "ExportTo1C.xml"

        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            xmlFileName = sfd.FileName
        Else
            Exit Sub
        End If

        Dim row1 As Docs_Payments.Docs_BillsRow

        Try
            Cursor.Current = Cursors.WaitCursor

            Dim org As References.R_inspectionRow = Main.dsReferenses.R_inspection.Rows(0)

            Dim export1c As New ЗагрузкаАктов

            Dim list As String = Main.getLineNumberList(dsPayments.Docs_Bills)

            Dim sum As Double = 0
            Dim i As Integer = 1

            For Each row As Docs_Payments.Docs_BillsRow In dsPayments.Docs_Bills
                If row Is Nothing OrElse row.Item("doc_id") Is DBNull.Value Then
                    Continue For
                End If

                Dim user As References.R_usersRow = Main.dsReferenses.R_users.FindByuser_name(row.Item("doc_user"))
                Dim user_division As String = If(user Is Nothing, "01", user.user_division)

                Dim division As String = org.region_number.ToString() + "/" + user_division + "/"

                taAgreements.FillByID(dsPayments.Docs_Agreements, row.doc_id)
                taClients.FillOneByGUID(dsPayments.R_clients, row.Docs_AgreementsRow.client_guid)
                taServices.FillByLine(dsPayments.Docs_Bills_Services, row.line_number)

                Dim paydoc_date As String = String.Empty
                If row.Item("paydoc_date") IsNot DBNull.Value Then
                    paydoc_date = row.paydoc_date.ToString("dd.MM.yyyy")
                End If

                Dim paydoc_num As String = String.Empty
                If row.Item("paydoc_num") IsNot DBNull.Value Then
                    paydoc_num = row.paydoc_num
                End If

                Dim docRow As ЗагрузкаАктов.ДокументRow = export1c.Документ.AddДокументRow( _
                    i.ToString(), "000000004", division + row.doc_number.ToString(), _
                    row.doc_date.ToString("dd.MM.yyyy"), paydoc_date, paydoc_num)

                Dim clientRow As Docs_Payments.R_clientsRow = row.Docs_AgreementsRow.R_clientsRow
                Dim docClientRow As ЗагрузкаАктов.КонтрагентRow = export1c.Контрагент.AddКонтрагентRow(
                    clientRow.client_name,
                    clientRow.client_inn.ToString(),
                    clientRow.client_kpp.ToString(),
                    clientRow.client_adress,
                    clientRow.client_adress_fact,
                    docRow)

                Dim agreementRow As Docs_Payments.Docs_AgreementsRow = row.Docs_AgreementsRow
                Dim docAgreementRow As ЗагрузкаАктов.ДоговорRow = export1c.Договор.AddДоговорRow( _
                    division + agreementRow.doc_number.ToString(), agreementRow.doc_date.ToString("dd.MM.yyyy"), _
                    String.Empty, docClientRow)

                Dim rowsService() As Docs_Payments.Docs_Bills_ServicesRow = row.GetDocs_Bills_ServicesRows()

                For Each rowService As Docs_Payments.Docs_Bills_ServicesRow In rowsService
                    If rowService.Item("unit") IsNot DBNull.Value Then
                        export1c.Строка.AddСтрокаRow(rowService.service_title, _
                            rowService.rate * rowService.sum_factor, rowService.count, _
                            rowService.unit, rowService.unit, "000004", docRow)
                    End If
                Next rowService

                sum += row.doc_sum
                i += 1
            Next row

            export1c.КонтрольныеДанные.AddКонтрольныеДанныеRow(dsPayments.Docs_Bills.Count, sum)

            taServices.FillTableByLine(dsPayments.Docs_Bills_Services, list)

            export1c.WriteXml(xmlFileName)

            MessageBox.Show("Экспорт в файл " + xmlFileName + " успешно завершён.", _
                "Экспорт завершён", MessageBoxButtons.OK, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)

        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MessageBox.Show("Ошибка: " + ex.ToString() + "; " + ex.Message, _
                "Ошибка при экспорте", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub ВосстановлениеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВосстановлениеToolStripMenuItem.Click

        Exit Sub

        Dim xmlFileName As String
        Dim ofd As New OpenFileDialog
        ofd.InitialDirectory = Environment.SpecialFolder.Desktop
        ofd.RestoreDirectory = True
        ofd.Filter = "XML files|*.xml"
        ofd.FileName = "ExportTo1C.xml"

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            xmlFileName = ofd.FileName
        Else
            Exit Sub
        End If

        Dim docs, agreements, clients As Integer

        Try
            Cursor.Current = Cursors.WaitCursor

            Dim export1c As New ЗагрузкаАктов
            export1c.ReadXml(xmlFileName)

            For Each документ As ЗагрузкаАктов.ДокументRow In export1c.Документ

                Dim контрагент As ЗагрузкаАктов.КонтрагентRow = документ.GetКонтрагентRows()(0)
                Dim договор As ЗагрузкаАктов.ДоговорRow = контрагент.GetДоговорRows()(0)
                Dim строки As ЗагрузкаАктов.СтрокаRow() = документ.GetСтрокаRows()

                Dim agreementId As Nullable(Of Integer) = taAgreements.DocIDByInn(контрагент.ИНН)

                If Convert.ToDateTime(документ.ДатаСчФ) < New Date(2012, 7, 9) Then
                    Continue For
                End If

                If Not agreementId.HasValue OrElse agreementId.Value = 0 Then
                    Dim client_guid As Guid = taClients.IsInnExists(контрагент.ИНН)
                    If client_guid = Nothing Then
                        client_guid = Guid.NewGuid()

                        taClients.Insert(контрагент.Наименование, контрагент.ИНН, Nothing, контрагент.АдресЮридический, _
                            контрагент.АдресФактический, String.Empty, String.Empty, Nothing, Nothing, "Свердловская область", _
                            String.Empty, String.Empty, "торгующая организация", String.Empty, client_guid)

                        clients = clients + 1
                    End If

                    Dim newAgreement As Docs_Payments.Docs_AgreementsRow = dsPayments.Docs_Agreements.NewDocs_AgreementsRow()
                    newAgreement.doc_date = договор.ДатаДоговора
                    newAgreement.doc_number = договор.НомерДоговора.Replace("66/01/", String.Empty)
                    newAgreement.doc_user = Main.userName
                    newAgreement.doc_date_limit = New Date(newAgreement.doc_date.Year, 12, 31)
                    newAgreement.client_guid = client_guid

                    'dsPayments.Docs_Agreements.AddDocs_AgreementsRow(newAgreement)
                    taAgreements.Insert(newAgreement.doc_date, newAgreement.doc_date_limit, _
                        newAgreement.doc_number, String.Empty, newAgreement.doc_user, client_guid)

                    agreements = agreements + 1

                    agreementId = taAgreements.GetMaxDocId()
                Else
                    taAgreements.FillByID(dsPayments.Docs_Agreements, agreementId.Value)
                End If

                Dim newBill As Docs_Payments.Docs_BillsRow = dsPayments.Docs_Bills.NewDocs_BillsRow()
                newBill.bill_type = True
                newBill.paydoc_date = документ.ДатаОплаты
                newBill.doc_date = документ.ДатаСчФ
                newBill.doc_id = agreementId
                newBill.paydoc_num = документ.НомерПлатРасчДок
                newBill.doc_number = документ.НомерСчФ.Replace("66/01/", String.Empty)
                newBill.is_transacted = True
                newBill.is_russia = True
                newBill.doc_user = Main.userName

                Dim sum As Integer = 0

                Dim rows As New List(Of Docs_Payments.Docs_Bills_ServicesRow)()

                For Each строка As ЗагрузкаАктов.СтрокаRow In строки
                    Dim newService As Docs_Payments.Docs_Bills_ServicesRow = dsPayments.Docs_Bills_Services.NewDocs_Bills_ServicesRow()
                    newService.doc_id = agreementId
                    newService.bill_type = False

                    newService.service_title = строка.Номенклатура
                    newService.count = строка.Количество
                    newService.unit = строка.ЕдиницаИзмерения
                    newService.sum_factor = 1
                    newService.rate = строка.Цена
                    newService.sum = строка.Цена
                    newService.doc_line_number = newBill.line_number

                    rows.Add(newService)

                    sum += newService.sum

                Next строка

                newBill.doc_sum = sum

                'dsPayments.Docs_Bills.AddDocs_BillsRow(newBill)
                taBills.Insert(agreementId, newBill.doc_number, newBill.doc_sum, newBill.doc_date, 18, _
                    newBill.is_russia, newBill.is_transacted, newBill.paydoc_num, newBill.paydoc_date, newBill.bill_type, Main.userName, True, String.Empty, String.Empty)
                Dim ln As Integer = taBills.GetMaxLineNumber()

                For Each row As Docs_Payments.Docs_Bills_ServicesRow In rows
                    'dsPayments.Docs_Bills_Services.AddDocs_Bills_ServicesRow(row)
                    taServices.Insert(agreementId, newBill.bill_type, row.service_title, row.rate, row.count, _
                        ln, row.unit, row.sum_factor, String.Empty)
                Next row

                docs = docs + 1

            Next документ

        Catch ex As SqlClient.SqlException
            Cursor.Current = Cursors.Default

            MessageBox.Show("Ошибка: " + ex.ToString() + "; " + ex.Message, _
                "Ошибка при экспорте", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MessageBox.Show("Ошибка: " + ex.ToString() + "; " + ex.Message, _
                "Ошибка при экспорте", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        Finally
            Cursor.Current = Cursors.Default

            MessageBox.Show(String.Format("Создано документов: {0}; договоров: {1}; клиентов: {2}", docs, agreements, clients), _
                "Результаты экспорта", MessageBoxButtons.OK, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Try
    End Sub
End Class