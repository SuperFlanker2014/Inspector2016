Public Class frmDocActs

    Private tblList As New Collection

    Private Function save() As Boolean

        EndEdit()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        If isNewDocMode Then
            If Me.Client_innMaskedTextBox.Text = "" Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
                Return False
            Else
                Dim guid1 As Guid = Me.taR_clients.IsInnExists(Me.Client_innMaskedTextBox.Text)
                If guid1 = Guid.Empty Then
                    MsgBox("Такого номера ИНН нет в базе!", MsgBoxStyle.Critical)
                    Return False
                ElseIf Me.bsDocs_Acts.Current.Item("client_guid").GetType.Name = "DBNull" Then
                    Me.bsDocs_Acts.Current.Item("client_guid") = guid1
                End If
            End If
        End If

        Docs_ActsBindingSource_CurrentChanged(New Object, New System.EventArgs)

        Try
            Me.bsDocs_Acts.EndEdit()
        Catch ex As NoNullAllowedException
            If ex.Message.Contains("client_inn") Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        End Try

        If isNewDocMode Then
            'копируем данные
            Dim p1 As Object = Me.bsDocs_Acts.Current
            p1.Item("representative") = Me.bsR_clients.Current.Item("client_representative")
            p1.Item("client_adress_warehouse") = Me.bsR_clients.Current.Item("client_adress_warehouse")
        End If

        Try
            Me.bsDocs_Acts_Goods.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try

        Docs_ActsBindingSource_CurrentChanged(New Object, New System.EventArgs)

        Try
            Me.taDocs_Acts.Update(Me.dsDocuments.Docs_Acts)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try

        Try
            Me.taDocs_Acts_Goods.Update(Me.dsDocuments.Docs_Acts_Goods)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try

        isNewDocMode = False
        bsR_clients.ResumeBinding()
        Windows.Forms.Cursor.Current = Cursors.Arrow

        Return True
    End Function

    Private Sub EndEdit()
        'goods
        Me.dgvDocs_Acts_Goods.EndEdit()
        Dim r As DataRowView = CType(Me.bsDocs_Acts_Goods.Current, DataRowView)
        If (r IsNot Nothing) Then
            If (r.Row("production_country").ToString() = "" Or _
                r.Row("good_title").ToString() = "") Then
                r.CancelEdit()
            Else
                r.EndEdit()
            End If
        End If
        Me.bsDocs_Acts_Goods.EndEdit()
        Me.bsDocs_Acts_Goods.ResetCurrentItem()

        'document
        Try
            Me.bsDocs_Acts.EndEdit()
        Catch ex As NoNullAllowedException
            'спросим в сохранении
        End Try

    End Sub

#Region "Перекрытые методы работы с документом"

    Public Overrides Sub newDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.bsDocs_Acts.AddNew()
        isNewDocMode = True
        bsR_clients.SuspendBinding()
        Client_innMaskedTextBox.Focus()
    End Sub

    Public Overrides Sub delDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Удалить запись?", MsgBoxStyle.YesNo, ) = MsgBoxResult.No Then
            Exit Sub
        Else
            isNewDocMode = False
            bsR_clients.ResumeBinding()
            Me.bsDocs_Acts.RemoveCurrent()
        End If
    End Sub

    Public Overrides Sub saveDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docs_ActsBindingNavigatorSaveItem.Click
        save()
    End Sub

    Public Overrides Sub findDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isSearchMode Then
            Me.Cursor = Cursors.WaitCursor
            Dim doc_number As String = Doc_numberMaskedTextBox.Text
            Dim client_inn As String = Client_innMaskedTextBox.Text.TrimStart(" ").TrimEnd(" ")
            Dim doc_date_low As String = Doc_dateDateTimePicker.Value
            Dim doc_date_high As String = Doc_date_highDateTimePicker.Value
            Dim good_title As String = cbProduction.Text
            Dim production_country As String = cbCountry.Text

            Me.dsDocuments.Clear()

            Dim IDs As DataTable = Me.taDocs_Acts.GetIDs(doc_number, _
                doc_date_low, doc_date_high, good_title, production_country, client_inn)
            Dim list As String = Main.getDocIdList(IDs)

            For Each tbl As Object In tblList
                Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
                ta.FillTable(tbl, list)
            Next tbl

            Me.bsDocs_Acts.ResumeBinding()
            Me.bsDocs_Acts_Goods.ResumeBinding()
            btnSearch.Text = "В режим поиска"
            isSearchMode = False
            Me.Cursor = Cursors.Default
        Else
            cbProduction.SelectedIndex = -1
            cbCountry.SelectedIndex = -1
            Me.Doc_dateDateTimePicker.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Me.Doc_date_highDateTimePicker.Value = DateTime.Today

            Me.bsDocs_Acts.SuspendBinding()
            Me.bsDocs_Acts_Goods.SuspendBinding()

            btnSearch.Text = "Найти"
            isSearchMode = True
            Me.Doc_numberMaskedTextBox.Focus()
        End If
    End Sub

    Public Overrides Sub initializeControlLists()
        Me.lstNewDocInVisible.AddRange(New Object() {BindingNavigatorAddNewItem, BindingNavigatorCountItem, _
            BindingNavigatorMoveFirstItem, BindingNavigatorMoveLastItem, BindingNavigatorMoveNextItem, _
            BindingNavigatorMovePreviousItem, BindingNavigatorPositionItem, BindingNavigatorSeparator, _
              BindingNavigatorSeparator1, btnSearch, btnCopy, btnPrint, btnPrintPreview})
        Me.lstNewDocDisabled.AddRange(New Object() {dgvDocs_Acts_Goods})

        Me.lstSearchInVisible.AddRange(New Object() {dgvDocs_Acts_Goods, bnDocs_Acts, pnlActsAdd})
        Me.lstSearchVisible.AddRange(New Object() {pnlSearchItems})
        Me.lstSearchEnabled.AddRange(New Object() {pnlActs})

        Me.lstEmptyFormDisabled.AddRange(New Object() {Me.dgvDocs_Acts_Goods, _
            Me.pnlActs, Me.pnlActsAdd, Me.BindingNavigatorDeleteItem, Me.btnCopy, Me.btnPrintMenu, Me.btnPrintPreview})

        Me.dtClients = Me.dsDocuments.R_clients
        Me.bsPrimary = Me.bsDocs_Acts
    End Sub

#End Region

    Private Shadows Sub frmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tblList.Add(Me.dsDocuments.Docs_Acts)
        tblList.Add(Me.dsDocuments.Docs_Acts_Goods)

        Dim IDs As DataTable = Me.taDocs_Acts.Get3IDs()
        For Each tbl As Object In tblList
            Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
            ta.ClearBeforeFill = False
            For Each row As DataRow In IDs.Rows
                ta.FillByID(tbl, row.Item("doc_id"))
            Next row
        Next tbl

        Main.dsReferenses.R_countries_and_regions.GetAdapter(Main.dbConnection).Fill(Main.dsReferenses.R_countries_and_regions)

        Me.Column_production_country.DataSource = Main.dsReferenses.R_countries_and_regions
        Me.Column_production_country.ValueMember = "country_title"
        Me.Column_good_title.DataSource = Main.dsReferenses.R_goods
        Me.Column_good_title.DisplayMember = "good_title"
        Me.Column_places_unit.DataSource = Main.dsReferenses.R_places_units
        Me.Column_places_unit.ValueMember = "unit_title"
        Me.Column_weight_unit.DataSource = Main.dsReferenses.R_weight_units
        Me.Column_weight_unit.ValueMember = "unit_title"

        Me.cbProduction.DataSource = Main.dsReferenses.R_goods
        Me.cbProduction.DisplayMember = "good_title"
        Me.cbCountry.DataSource = Main.dsReferenses.R_countries_and_regions
        Me.cbCountry.ValueMember = "country_title"

        Me.dgvDocs_Acts_Goods.DefaultCellStyle.BackColor = My.Settings.backColorText

    End Sub

    Private Sub Docs_ActsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsDocs_Acts.CurrentChanged
        Dim p As Object = bsDocs_Acts.Current
        If (p Is Nothing) Then
            Exit Sub
        End If
        If (p.Item("client_guid").GetType.Name <> "DBNull") Then
            Me.taR_clients.FillOneByGUID(Me.dsDocuments.R_clients, bsDocs_Acts.Current.Item("client_guid"))
        Else
            'если новый
            p.Item("doc_number") = Int(taDocs_Acts.MaxActNumber()) + 1
            p.Item("doc_date") = System.DateTime.Today()
            p.Item("doc_laboratory") = "л1"
            p.Item("doc_user") = Main.userName
            Me.bsDocs_Acts.ResetCurrentItem()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If save() Then
            Printing.print(DocumentType.Act, PrintingType.PrintDocument, True, 1, Me.bsDocs_Acts.Current.Row)
        End If
    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        If save() Then
            Printing.print(DocumentType.Act, PrintingType.PreviewDocument, True, 1, Me.bsDocs_Acts.Current.Row)
        End If
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        BindingNavigatorMoveNextItem.Click, BindingNavigatorMoveLastItem.Click, _
        BindingNavigatorMovePreviousItem.Click, BindingNavigatorMoveFirstItem.Click
        dgvDocs_Acts_Goods.CurrentCell = dgvDocs_Acts_Goods(1, 0)
        If Not dgvDocs_Acts_Goods.EditingControl Is Nothing AndAlso _
            dgvDocs_Acts_Goods.EditingControl.GetType().Name = "DataGridViewComboBoxEditingControl" Then
            Dim cBox As ComboBox = dgvDocs_Acts_Goods.EditingControl
            cBox.DroppedDown = False
            dgvDocs_Acts_Goods.EndEdit()
        End If
    End Sub

    Private Sub Client_innMaskedTextBox_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Client_innMaskedTextBox.MouseDoubleClick

        Dim client_inn As String = Me.Client_innMaskedTextBox.Text.TrimStart(" ").TrimEnd(" ")

        Using row = Main.ShowClientsForm(client_inn)
            If row Is Nothing Then
                MsgBox("Клиент не выбран!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Dim inn As String = row.Item("client_inn").ToString()
                Dim guid1 As Guid = row.Item("client_guid")
                Me.taR_clients.FillOneByGUID(Me.dsDocuments.R_clients, guid1)
                Me.bsDocs_Acts.Current.Item("client_guid") = guid1
                Me.Client_innMaskedTextBox.Text = inn
                Me.Client_adress_warehouseTextBox.Text = row.Item("client_adress_warehouse").ToString()
                Me.txtRepresentative.Text = row.Item("client_representative").ToString()
                cbCountry.SelectedIndex = -1
            End If
        End Using

    End Sub


    Private Sub btnCopyToAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToAct.Click
        If Not Me.bsDocs_Acts.Current Is Nothing Then
            Dim cur_row As Inspector.Documents.Docs_ActsRow = bsDocs_Acts.Current.Row
            Dim row As Inspector.Documents.Docs_ActsRow
            row = Me.dsDocuments.Docs_Acts.NewDocs_ActsRow()
            Dim i As Integer = row.doc_id
            row.ItemArray = cur_row.ItemArray
            row.doc_id = i
            row.doc_number = Int(Me.taDocs_Acts.MaxActNumber()) + 1
            row.doc_date = System.DateTime.Today()
            row.doc_user = Main.userName
            row.representative = cur_row.representative

            Me.dsDocuments.Docs_Acts.AddDocs_ActsRow(row)
            Me.taDocs_Acts.Update(Me.dsDocuments.Docs_Acts)

            Dim ds As New Inspector.Documents.Docs_Acts_GoodsDataTable
            For Each r As Inspector.Documents.Docs_Acts_GoodsRow In Me.dsDocuments.Docs_Acts_Goods.Rows
                If (r.RowState <> DataRowState.Deleted) AndAlso (r.doc_id = cur_row.doc_id) Then
                    Dim p As Inspector.Documents.Docs_Acts_GoodsRow
                    p = ds.NewDocs_Acts_GoodsRow
                    p.ItemArray = r.ItemArray
                    p.doc_id = row.doc_id
                    ds.Rows.Add(p)
                End If
            Next r

            For Each r As Inspector.Documents.Docs_Acts_GoodsRow In ds.Rows
                Me.dsDocuments.Docs_Acts_Goods.Rows.Add(r.ItemArray)
            Next r

            Me.taDocs_Acts_Goods.Update(Me.dsDocuments.Docs_Acts_Goods)
            Me.bsDocs_Acts.MoveLast()
        End If
    End Sub

    Private Sub btnCopyToConclusionImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToConclusionImport.Click
        If Me.bsDocs_Acts.Current Is Nothing Then
            Exit Sub
        End If

        Dim cmd As New CCommandActToIm(Me.bsDocs_Acts.Current.Row, Me.dsDocuments)
        CMediator.Instance.SendMessage(cmd)
    End Sub

    Private Sub btnCopyToConclusionExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToConclusionExport.Click
        If Me.bsDocs_Acts.Current Is Nothing Then
            Exit Sub
        End If

        Dim cmd As New CCommandActToEx(Me.bsDocs_Acts.Current.Row, Me.dsDocuments)
        CMediator.Instance.SendMessage(cmd)
    End Sub

End Class