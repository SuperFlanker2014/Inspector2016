Public Class frmDocConclusionsExportOld
    Implements IFormWithCopyAndPrint

    Private tblList As New Collection

    Private Sub print(ByVal PrintOrPreview As PrintingType, ByVal AskParameters As Boolean, ByVal Count As Integer) _
        Implements IFormWithCopyAndPrint.print
        Printing.print(DocumentType.ConclusionExport, PrintOrPreview, AskParameters, Count, Me.bsDocs_Conclusions_Export.Current.row)
    End Sub

    Public Function save()

        EndEdit()
        'Проверка bsDocs_Conclusions_Export
        'check if new
        If isNewDocMode Then
            If Me.Client_innMaskedTextBox.Text = "" Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
                Return False
            ElseIf SendingToComboBox.Text = "" Then
                MsgBox("Выберите куда отправляется!", MsgBoxStyle.Exclamation)
                Return False
            Else
                Dim guid1 As Guid = Me.taR_clients.IsInnExists(Me.Client_innMaskedTextBox.Text)
                If guid1 = Guid.Empty Then
                    MsgBox("Такого номера ИНН нет в базе!", MsgBoxStyle.Critical)
                    Return False
                ElseIf Me.bsDocs_Conclusions_Export.Current.Item("client_guid").GetType.Name = "DBNull" Then
                    Me.bsDocs_Conclusions_Export.Current.Item("client_guid") = guid1
                End If
            End If
        End If

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Me.bsDocs_Conclusions_Export.EndEdit()
        Catch ex As NoNullAllowedException
            If ex.Message.Contains("client_inn") Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        End Try

        bsDocs_Conclusions_Export_CurrentChanged(New Object, New System.EventArgs)
        'если новый копируем данные
        If isNewDocMode Then
            Dim p1 As Object = Me.bsDocs_Conclusions_Export.Current
            p1.Item("warehouse") = Me.bsR_clients.Current.Item("client_adress_warehouse")
            p1.Item("representative") = Me.bsR_clients.Current.Item("client_representative")
        End If

        Try
            Me.taDocs_Conclusions_Export.Update(Me.dsConclusions.Docs_Conclusions_Export)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsDocs_Conclusions_Export

        'проверка bsDocs_Acts_Goods
        Me.dgvDocs_Acts_Goods.EndEdit()
        Try
            Me.bsDocs_Acts_Goods.EndEdit()
        Catch ex As System.Data.NoNullAllowedException
            If ex.Message.Contains("production_country") Then
                MsgBox("Пустое происхождение продукта недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("good_title") Then
                MsgBox("Пустое название продукта недопустимо!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As System.Data.ConstraintException
            MsgBox("Дублирующиеся название и происхождение продукта недопустимы!", MsgBoxStyle.Critical)
            Return False
        End Try
        Try
            Me.taDocs_Acts_Goods.Update(Me.dsConclusions.Docs_Acts_Goods)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsDocs_Acts_Goods

        'проверка bsDocs_Conclusions_Karantin
        Me.dgvDocs_Conclusions_Karantin.EndEdit()
        Try
            Me.bsDocs_Conclusions_Karantin.EndEdit()
        Catch ex As System.Data.NoNullAllowedException
            If ex.Message.Contains("object_title") Then
                MsgBox("Пустой карантинный объект недопустим!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("count") Then
                MsgBox("Пустое количество карантинного объекта недопустимо!", MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As System.Data.ConstraintException
            MsgBox("Дублирующиеся названия карантинных объектов недопустимы!", MsgBoxStyle.Critical)
            Return False
        End Try
        Try
            Me.taDocs_Conclusions_Karantin.Update(Me.dsConclusions.Docs_Conclusions_Karantin)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsDocs_Conclusions_Karantin

        'проверка bsDocs_Conclusions_NotKarantin
        Me.dgvDocs_Conclusions_NotKarantin.EndEdit()
        Try
            Me.bsDocs_Conclusions_NotKarantin.EndEdit()
        Catch ex As System.Data.NoNullAllowedException
            If ex.Message.Contains("object_title") Then
                MsgBox("Пустой некарантинный объект недопустим!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As System.Data.ConstraintException
            MsgBox("Дублирующиеся названия некарантинных объектов недопустимы!", MsgBoxStyle.Critical)
            Return False
        End Try
        Try
            Me.taDocs_Conclusions_NotKarantin.Update(Me.dsConclusions.Docs_Conclusions_NotKarantin)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsDocs_Conclusions_NotKarantin

        isNewDocMode = False
        Me.SendingToComboBox.TabIndex = 14
        bsR_clients.ResumeBinding()
        Windows.Forms.Cursor.Current = Cursors.Arrow

        Return True
    End Function

    Private Shadows Sub frmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tblList.Add(Me.dsConclusions.Docs_Conclusions_Export)
        tblList.Add(Me.dsConclusions.Docs_Acts_Goods)
        tblList.Add(Me.dsConclusions.Docs_Conclusions_Karantin)
        tblList.Add(Me.dsConclusions.Docs_Conclusions_NotKarantin)
        Me.dsConclusions.Tables("Docs_Acts_Goods").Constraints.Remove("FK_Docs_Acts_Goods_Docs_Conclusions_Import")
        Me.dsConclusions.Tables("Docs_Acts_Goods").Constraints.Remove("FK_Docs_Acts_Goods_Docs_Conclusions_Examination")

        Dim IDs As DataTable = taDocs_Conclusions_Export.Get3IDs()
        For Each tbl As Object In tblList
            Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
            ta.ClearBeforeFill = False
            For Each row As DataRow In IDs.Rows
                ta.FillByID(tbl, row.Item("doc_id"))
            Next row
        Next tbl

        Dim ds As References = Main.dsReferenses
        ds.R_countries_and_regions.GetAdapter(Main.dbConnection).Fill(ds.R_countries_and_regions)

        Transport_typeComboBox.DataSource = ds.R_transport
        Transport_typeComboBox.ValueMember = "transport_title"
        Bill_typeComboBox.DataSource = ds.R_bill
        Bill_typeComboBox.ValueMember = "bill_title"

        Origin_rayonComboBox.DataSource = ds.R_Sverdlovsk_region_rayons
        Origin_rayonComboBox.ValueMember = "rayon_title"
        MarkComboBox.DataSource = ds.R_marking
        MarkComboBox.ValueMember = "mark_title"
        InspectionComboBox.DataSource = ds.R_inspections
        InspectionComboBox.ValueMember = "inspection_title"
        Samples_actionComboBox.DataSource = ds.R_samples_actions
        Samples_actionComboBox.ValueMember = "action_title"

        For Each c As Control In pnlMain.Controls
            If c.GetType.Name = "ComboBox" Then
                Dim c1 As ComboBox = c
                c1.SelectedIndex = -1
            End If
        Next c

        Me.Column_production_country.DataSource = Main.dsReferenses.R_countries_and_regions
        Me.Column_production_country.ValueMember = "country_title"
        Me.Column_good_title.DataSource = Main.dsReferenses.R_goods
        Me.Column_good_title.DisplayMember = "good_title"
        Me.Column_places_unit.DataSource = Main.dsReferenses.R_places_units
        Me.Column_places_unit.ValueMember = "unit_title"
        Me.Column_weight_unit.DataSource = Main.dsReferenses.R_weight_units
        Me.Column_weight_unit.ValueMember = "unit_title"

        Me.Column_notkarantin_object_title.DataSource = ds.R_notkarantin
        Me.Column_notkarantin_object_title.ValueMember = "object_title"

        Me.Column_karantin_object_title.DataSource = ds.R_karantin
        Me.Column_karantin_object_title.ValueMember = "object_title"
        Me.Column_state.DataSource = ds.R_karantin_state
        Me.Column_state.ValueMember = "state_title"
        Me.Column_state_notkar.DataSource = ds.R_karantin_state
        Me.Column_state_notkar.ValueMember = "state_title"

        Dim arrivedDS As DataTable = ds.R_countries_and_regions.Clone()
        For Each row As DataRow In ds.R_countries_and_regions.Rows
            arrivedDS.Rows.Add(row.ItemArray)
        Next row
        SendingToComboBox.DataSource = arrivedDS
        SendingToComboBox.ValueMember = "country_title"

        For Each row As DataRow In ds.R_countries_and_regions.Rows
            Me.cbCountryFrom.Items.Add(row.Item("country_title"))
            Me.cbCountryProduction.Items.Add(row.Item("country_title"))
        Next row
        Me.cbKarantin.DataSource = ds.R_karantin
        Me.cbKarantin.ValueMember = "object_title"
        Me.cbProduction.DataSource = ds.R_goods
        Me.cbProduction.ValueMember = "good_title"
        Me.cbVerdict.DataSource = ds.R_verdict_patterns
        Me.cbVerdict.ValueMember = "pattern_text"

        AddHandler btnCopy.Click, AddressOf btnCopyToExport_Click

        Me.dgvDocs_Acts_Goods.DefaultCellStyle.BackColor = My.Settings.backColorText
        Me.dgvDocs_Conclusions_Karantin.DefaultCellStyle.BackColor = My.Settings.backColorText
        Me.dgvDocs_Conclusions_NotKarantin.DefaultCellStyle.BackColor = My.Settings.backColorText

        Dim AppendListTA As New Inspector.Docs_ConclusionsTableAdapters.AppendListsTableAdapter()
        Dim AppendListDT As Inspector.Docs_Conclusions.AppendListsDataTable = AppendListTA.GetListExport()
        Dim AppendCollection As New System.Windows.Forms.AutoCompleteStringCollection()
        For Each row As DataRow In AppendListDT
            AppendCollection.Add(row.Item("item").ToString())
        Next row
        Me.AddresseeTextBox.AutoCompleteCustomSource = AppendCollection

    End Sub

    Private Sub bsDocs_Conclusions_Export_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsDocs_Conclusions_Export.CurrentChanged
        Dim p As Object = bsDocs_Conclusions_Export.Current
        If (p Is Nothing) Then
            Exit Sub
        End If
        If (p.Item("client_guid").GetType.Name <> "DBNull") Then
            Me.taR_clients.FillOneByGUID(Me.dsConclusions.R_clients, bsDocs_Conclusions_Export.Current.Item("client_guid"))
        Else 'если новый
            For Each c As Control In pnlMain.Controls
                If c.GetType.Name = "ComboBox" Then
                    Dim c1 As ComboBox = c
                    c1.SelectedIndex = -1
                End If
            Next c

            p.Item("doc_number") = Int(taDocs_Conclusions_Export.MaxDocNumber()) + 1
            p.item("disinfection") = "не проводилось"
            p.Item("verdict") = Main.dsReferenses.R_verdict_patterns.Rows(0).Item("pattern_text")
            p.Item("doc_user") = Main.userName

            p.Item("doc_date") = System.DateTime.Today()

            Me.bsDocs_Conclusions_Export.ResetCurrentItem()
        End If
    End Sub

#Region "Перекрытые методы работы с документом"

    Public Overrides Sub newDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.bsDocs_Conclusions_Export.AddNew()
        isNewDocMode = True
        Me.SendingToComboBox.TabIndex = 4
        Me.bsR_clients.SuspendBinding()
        Client_innMaskedTextBox.Focus()
    End Sub

    Public Overrides Sub delDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Удалить запись?", MsgBoxStyle.YesNo, ) = MsgBoxResult.No Then
            Exit Sub
        Else
            isNewDocMode = False
            Me.SendingToComboBox.TabIndex = 14
            Me.bsR_clients.ResumeBinding()
            Me.bsDocs_Conclusions_Export.RemoveCurrent()
        End If
    End Sub

    Public Overrides Sub saveDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docs_Conclusions_ImportBindingNavigatorSaveItem.Click
        save()
    End Sub

    Public Overrides Sub findDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isSearchMode Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim object_title As String = cbKarantin.Text
            Dim client_inn As String = Client_innMaskedTextBox.Text.TrimStart(" ").TrimEnd(" ")
            Dim doc_number As String = Doc_numberMaskTextBox.Text
            Dim doc_date_low As String = Doc_dateDateTimePicker.Value
            Dim doc_date_high As String = Doc_date_highDateTimePicker.Value
            Dim good_title As String = cbProduction.Text
            Dim sending As String = cbCountryFrom.Text
            Dim arrived_production As String = cbCountryProduction.Text

            Me.dsConclusions.Clear()

            Dim IDs As DataTable = taDocs_Conclusions_Export.GetIDs(doc_number, _
                doc_date_high, doc_date_low, good_title, sending, arrived_production, object_title, client_inn)
            Dim list As String = Main.getDocIdList(IDs)

            For Each tbl As Object In tblList
                Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
                ta.FillTable(tbl, list)
            Next tbl

            Me.bsDocs_Conclusions_Export.ResumeBinding()
            Me.bsDocs_Acts_Goods.ResumeBinding()
            Me.bsDocs_Conclusions_Karantin.ResumeBinding()
            Me.bsDocs_Conclusions_NotKarantin.ResumeBinding()

            btnSearch.Text = "В режим поиска"
            isSearchMode = False
            Me.txtRemark.Focus()
            Windows.Forms.Cursor.Current = Cursors.Default
        Else
            Me.cbCountryFrom.SelectedIndex = -1
            Me.cbCountryProduction.SelectedIndex = -1
            Me.cbKarantin.SelectedIndex = -1
            Me.cbProduction.SelectedIndex = -1

            Me.Doc_dateDateTimePicker.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Me.Doc_date_highDateTimePicker.Value = DateTime.Today.AddDays(1)

            Me.bsDocs_Conclusions_Export.SuspendBinding()
            Me.bsDocs_Acts_Goods.SuspendBinding()
            Me.bsDocs_Conclusions_Karantin.SuspendBinding()
            Me.bsDocs_Conclusions_NotKarantin.SuspendBinding()

            btnSearch.Text = "Найти"
            isSearchMode = True
            Me.Doc_numberMaskTextBox.Focus()
        End If
    End Sub

    Public Overrides Sub initializeControlLists()
        Me.lstNewDocInVisible.AddRange(New Object() {BindingNavigatorAddNewItem, BindingNavigatorCountItem, _
            BindingNavigatorMoveFirstItem, BindingNavigatorMoveLastItem, BindingNavigatorMoveNextItem, _
            BindingNavigatorMovePreviousItem, BindingNavigatorPositionItem, BindingNavigatorSeparator, _
            BindingNavigatorSeparator1, btnSearch, btnCopyTo, btnPrints, btnPreviews})
        Me.lstNewDocDisabled.AddRange(New Object() {dgvDocs_Acts_Goods, dgvDocs_Conclusions_Karantin, _
            dgvDocs_Conclusions_NotKarantin})

        Me.lstSearchEnabled.AddRange(New Object() {Me.Doc_numberMaskTextBox, _
                Me.Doc_dateDateTimePicker, Me.Client_innMaskedTextBox})
        Me.lstSearchInVisible.AddRange(New Object() {pnlMain, pnlDiseases, dgvDocs_Acts_Goods, _
            bnDocs_Conclusions_Export, txtClient_name, txtClient_address, lblAddress, lblFactAddress, txtFactAddress})
        Me.lstSearchVisible.AddRange(New Object() {pnlSearch})

        Me.lstEmptyFormDisabled.AddRange(New Object() {Me.dgvDocs_Acts_Goods, Me.dgvDocs_Conclusions_Karantin, _
            Me.dgvDocs_Conclusions_NotKarantin, Me.pnlMain, Me.Doc_numberMaskTextBox, _
            Me.Doc_dateDateTimePicker, Me.Client_innMaskedTextBox, Me.BindingNavigatorDeleteItem, _
            Me.btnPrints, Me.btnPreviews, Me.btnCopyTo, Me.txtFactAddress})

        Me.dtClients = Me.dsConclusions.R_clients
        Me.bsPrimary = Me.bsDocs_Conclusions_Export
    End Sub

#End Region

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
                Dim warehouse As String = row.Item("client_adress_warehouse").ToString()
                Dim representative As String = row.Item("client_representative").ToString()

                Dim guid1 As Guid = row.Item("client_guid")
                Me.taR_clients.FillOneByGUID(Me.dsConclusions.R_clients, guid1)
                Me.bsDocs_Conclusions_Export.Current.Item("client_guid") = guid1

                Me.Client_innMaskedTextBox.Text = inn
                Me.WarehouseTextBox.Text = warehouse
                Me.RepresentativeTextBox.Text = representative
                Me.txtFactAddress.Text = row.Item("client_adress_fact").ToString()
            End If
        End Using

    End Sub

    Private Sub Label_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Samples_actionLabel.DoubleClick, InspectionLabel.DoubleClick, Origin_rayonLabel.DoubleClick, _
        SendingToLabel.DoubleClick, Bill_typeLabel.DoubleClick, Transport_typeLabel.DoubleClick, _
        MarkLabel.DoubleClick

        'Select Case sender.Name
        '    Case "Samples_actionLabel"
        '        Main.showReference("R_samples_actions")
        '    Case "InspectionLabel"
        '        Main.showReference("R_inspections")
        '    Case "Origin_rayonLabel"
        '        Main.showReference("R_Sverdlovsk_region_rayons")
        '    Case "SendingToLabel"
        '        Main.showReference("R_countries_and_regions")
        '        Me.SendingToComboBox.Items.Clear()
        '        Me.cbCountryFrom.Items.Clear()
        '        Me.cbCountryProduction.Items.Clear()
        '        For Each row As DataRow In Main.dsReferenses.R_countries_and_regions.Rows
        '            Me.cbCountryFrom.Items.Add(row.Item("country_title"))
        '            Me.cbCountryProduction.Items.Add(row.Item("country_title"))
        '            Me.SendingToComboBox.Items.Add(row.Item("country_title"))
        '        Next row
        '    Case "Bill_typeLabel"
        '        Main.showReference("R_bill")
        '    Case "Transport_typeLabel"
        '        Main.showReference("R_transport")
        '    Case "MarkLabel"
        '        Main.showReference("R_marking")
        'End Select
        'Me.bsDocs_Conclusions_Export.ResetCurrentItem()

    End Sub


    Private Sub ComboBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        Transport_typeComboBox.GotFocus, Samples_actionComboBox.GotFocus, InspectionComboBox.GotFocus, _
        Origin_rayonComboBox.GotFocus, Bill_typeComboBox.GotFocus, MarkComboBox.GotFocus

        'sender.DroppedDown = True
    End Sub

    Private Sub Wood_compositionTextBox_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Wood_compositionTextBox.MouseDoubleClick
        Dim childFormForestInfo As frmForestInfo = Main.ShowForm(My.Forms.frmForestInfo, True)

        If childFormForestInfo.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim s As String = ""
            s += "видовой состав древесины: " + childFormForestInfo.cbKind.Text + "; "
            If childFormForestInfo.cbBoard.Text <> "" Then
                s += childFormForestInfo.cbBoard.Text + "; "
            End If
            s = s.TrimEnd(" ").TrimEnd(";")
            Wood_compositionTextBox.Text += s
        End If

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If save() Then
            print(PrintingType.PreviewDocument, True, 2)
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If save() Then
            print(PrintingType.PrintDocument, True, 2)
        End If
    End Sub

    Private Sub ComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
        Handles Transport_typeComboBox.KeyDown, MarkComboBox.KeyDown, Bill_typeComboBox.KeyDown, _
        Origin_rayonComboBox.KeyDown, InspectionComboBox.KeyDown, Samples_actionComboBox.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim s As ComboBox = sender
            s.SelectedValue = System.DBNull.Value
        End If
    End Sub

    Private Sub btnCopyAndPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyAndPrint.Click
        If Not Me.bsDocs_Conclusions_Export.Current Is Nothing Then
            Main.ShowPrintAskForm(Me)
        End If
    End Sub

    Private Sub Client_innMaskedTextBox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Client_innMaskedTextBox.MouseClick
        Client_innMaskedTextBox.SelectAll()
    End Sub

    Private Sub InspectionComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspectionComboBox.SelectedValueChanged
        Try
            tipInspection.SetToolTip(InspectionComboBox, InspectionComboBox.SelectedValue.ToString())
        Catch
        End Try
    End Sub

    Private Sub dgvDocs_Conclusions_NotKarantin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDocs_Conclusions_NotKarantin.Enter
        EndEdit()
    End Sub

    Private Sub dgvDocs_Conclusions_Karantin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDocs_Conclusions_Karantin.Enter
        EndEdit()
    End Sub

    Private Sub EndEdit()
        'pests
        Me.dgvDocs_Conclusions_NotKarantin.EndEdit()
        Dim r As DataRowView = CType(Me.bsDocs_Conclusions_NotKarantin.Current, DataRowView)
        If (r IsNot Nothing) Then
            If (r.Row("production_country").ToString() = "" Or _
                r.Row("good_title").ToString() = "" Or _
                r.Row("object_title").ToString() = "") Then
                r.CancelEdit()
            Else
                r.EndEdit()
            End If
        End If

        Me.dgvDocs_Conclusions_Karantin.EndEdit()
        r = CType(Me.bsDocs_Conclusions_Karantin.Current, DataRowView)
        If (r IsNot Nothing) Then
            If (r.Row("production_country").ToString() = "" Or _
                r.Row("good_title").ToString() = "" Or _
                r.Row("object_title").ToString() = "") Then
                r.CancelEdit()
            Else
                r.EndEdit()
            End If
        End If

        'goods
        Me.dgvDocs_Acts_Goods.EndEdit()
        r = CType(Me.bsDocs_Acts_Goods.Current, DataRowView)
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
            Me.bsDocs_Conclusions_Export.EndEdit()
        Catch ex As NoNullAllowedException
            'не ввели sending_to, спросим в сохранении
        End Try
    End Sub


    Private Sub btnCopyToExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Implements IFormWithCopyAndPrint.copy

        If Me.bsDocs_Conclusions_Export.Current Is Nothing Then
            Exit Sub
        End If

        Dim cur_row As Inspector.Docs_Conclusions.Docs_Conclusions_ExportRow = bsDocs_Conclusions_Export.Current.Row
        Dim row As Inspector.Docs_Conclusions.Docs_Conclusions_ExportRow = Me.dsConclusions.Docs_Conclusions_Export.NewDocs_Conclusions_ExportRow

        'копирование записи
        Dim i As Integer = row.doc_id
        row.ItemArray = cur_row.ItemArray
        row.doc_id = i
        row.doc_number = Int(Me.taDocs_Conclusions_Export.MaxDocNumber()) + 1
        row.doc_user = Main.userName
        row.doc_date = System.DateTime.Today()
        row.representative = cur_row.representative
        Me.dsConclusions.Docs_Conclusions_Export.AddDocs_Conclusions_ExportRow(row)
        Me.taDocs_Conclusions_Export.Update(Me.dsConclusions.Docs_Conclusions_Export)

        Dim tables As New Collection
        tables.Add(dsConclusions.Docs_Acts_Goods)
        tables.Add(dsConclusions.Docs_Conclusions_Karantin)
        tables.Add(dsConclusions.Docs_Conclusions_NotKarantin)

        'копирование груза, карантина и некарантина
        For Each tbl As Object In tables
            Dim ds As Object = System.Activator.CreateInstance(tbl.GetType())
            For Each r As DataRow In tbl.Rows
                If (r.RowState <> DataRowState.Deleted) AndAlso (r.Item("doc_id") = cur_row.doc_id) Then
                    Dim p As DataRow
                    p = ds.NewRow
                    p.ItemArray = r.ItemArray
                    p.Item("doc_id") = row.doc_id
                    ds.Rows.Add(p)
                End If
            Next r

            For Each r As DataRow In ds.Rows
                tbl.Rows.Add(r.ItemArray)
            Next r

            tbl.GetAdapter(Main.dbConnection).update(tbl)

        Next tbl

        'переход к новой записи
        Me.bsDocs_Conclusions_Export.MoveLast()

    End Sub

    Private Sub btnCopyToExamination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToExamination.Click
        If Me.bsDocs_Conclusions_Export.Current Is Nothing Then
            Exit Sub
        End If

        Dim cmd As New CCommandExToExam(Me.bsDocs_Conclusions_Export.Current.row, Me.dsConclusions)
        CMediator.Instance.SendMessage(cmd)
    End Sub

#Region "Выполнение комманд"

    Public Overrides Sub ExecuteCommand(ByRef Command As CCustomCommand)
        If TypeOf Command Is CCommandExamToEx Then

            Main.ShowForm(Me)
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim cmd As CCommandExamToEx = CType(Command, CCommandExamToEx)
            Dim row As Inspector.Docs_Conclusions.Docs_Conclusions_ExportRow = Me.dsConclusions.Docs_Conclusions_Export.NewDocs_Conclusions_ExportRow()

            'копирование записи
            row.doc_number = Int(Me.taDocs_Conclusions_Export.MaxDocNumber()) + 1
            row.doc_user = Main.userName
            row.doc_date = System.DateTime.Today()
            row.client_guid = cmd.row.client_guid
            row.verdict = Main.dsReferenses.R_verdict_patterns.Rows(0).Item("pattern_text")
            row.doc_user = Main.userName

            row("bill_type") = cmd.row("bill_type")
            row("bill_date") = cmd.row("bill_date").ToString()
            row("bill_number") = cmd.row("bill_number").ToString()

            row("transport_type") = cmd.row("transport_type")
            row("transport_number") = cmd.row("transport_number")

            row.addressee = cmd.row.target_or_source

            row.samples_doc = "Свидетельство карантинной экспертизы"
            row.samples_doc_number = cmd.row.doc_number
            row.samples_doc_date = cmd.row.doc_date.ToShortDateString()
            row.fact_address = cmd.row("fact_address").ToString()
            row.sending_to = "Англия"
            Me.dsConclusions.Docs_Conclusions_Export.AddDocs_Conclusions_ExportRow(row)
            Me.taDocs_Conclusions_Export.Update(Me.dsConclusions.Docs_Conclusions_Export)

            'копирование груза, карантина и некарантина
            Dim tables As New Collection
            tables.Add(cmd.dsConclusions.Docs_Acts_Goods)
            tables.Add(cmd.dsConclusions.Docs_Conclusions_Karantin)
            tables.Add(cmd.dsConclusions.Docs_Conclusions_NotKarantin)
            tables.Add(Me.dsConclusions.Docs_Acts_Goods)
            tables.Add(Me.dsConclusions.Docs_Conclusions_Karantin)
            tables.Add(Me.dsConclusions.Docs_Conclusions_NotKarantin)

            For i As Integer = 1 To 3
                Dim ds As Object = System.Activator.CreateInstance(tables(i).GetType())
                For Each r As DataRow In tables(i).Rows
                    If (r.RowState <> DataRowState.Deleted) AndAlso (r.Item("doc_id") = cmd.row.doc_id) Then
                        Dim p As DataRow
                        p = ds.NewRow
                        p.ItemArray = r.ItemArray
                        p.Item("doc_id") = row.doc_id
                        ds.Rows.Add(p)
                    End If
                Next r

                For Each r As DataRow In ds.Rows
                    tables(i + 3).Rows.Add(r.ItemArray)
                Next r

                tables(i + 3).GetAdapter(Main.dbConnection).update(tables(i + 3))

            Next i

            'переход к новой записи
            Me.bsDocs_Conclusions_Export.MoveLast()

            Windows.Forms.Cursor.Current = Cursors.Default
        ElseIf TypeOf Command Is CCommandActToEx Then

            Main.ShowForm(Me)
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim cmd As CCommandActToEx = CType(Command, CCommandActToEx)
            Dim row As Inspector.Docs_Conclusions.Docs_Conclusions_ExportRow = Me.dsConclusions.Docs_Conclusions_Export.NewDocs_Conclusions_ExportRow()

            row.client_guid = cmd.row.client_guid
            row.sending_to = "Англия"
            row.verdict = Main.dsReferenses.R_verdict_patterns.Rows(0).Item("pattern_text").ToString()
            row.doc_date = System.DateTime.Today()
            row.doc_number = Int(Me.taDocs_Conclusions_Export.MaxDocNumber()) + 1
            row.doc_user = Main.userName

            row.samples_doc = "Акт отбора образцов"
            row.samples_doc_number = cmd.row.doc_number
            row.samples_doc_date = cmd.row.doc_date
            row.warehouse = cmd.dsDocuments.R_clients.Rows(0)("client_adress_warehouse").ToString()
            row.representative = Main.getGenetiveForFIO(cmd.row.representative.ToString())
            row.fact_address = cmd.dsDocuments.R_clients.Rows(0)("client_adress_fact").ToString()

            Me.dsConclusions.Docs_Conclusions_Export.AddDocs_Conclusions_ExportRow(row)
            Me.taDocs_Conclusions_Export.Update(Me.dsConclusions.Docs_Conclusions_Export)

            Dim ds As New Inspector.Docs_Conclusions.Docs_Acts_GoodsDataTable
            For Each r As Inspector.Documents.Docs_Acts_GoodsRow In cmd.dsDocuments.Docs_Acts_Goods.Rows
                If (r.RowState <> DataRowState.Deleted) AndAlso (r.doc_id = cmd.row.doc_id) Then
                    Dim p As Inspector.Docs_Conclusions.Docs_Acts_GoodsRow
                    p = ds.NewDocs_Acts_GoodsRow
                    p.ItemArray = r.ItemArray
                    p.doc_id = row.doc_id
                    ds.Rows.Add(p)
                End If
            Next r

            For Each r As Inspector.Docs_Conclusions.Docs_Acts_GoodsRow In ds.Rows
                Me.dsConclusions.Docs_Acts_Goods.Rows.Add(r.ItemArray)
            Next r

            Me.taDocs_Acts_Goods.Update(Me.dsConclusions.Docs_Acts_Goods)
            Me.bsDocs_Conclusions_Export.MoveLast()
        ElseIf TypeOf Command Is CCommandImToEx Then
            Main.ShowForm(Me)
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim cmd As CCommandImToEx = CType(Command, CCommandImToEx)
            Dim row As Inspector.Docs_Conclusions.Docs_Conclusions_ExportRow = Me.dsConclusions.Docs_Conclusions_Export.NewDocs_Conclusions_ExportRow()

            row.client_guid = cmd.row.client_guid
            row.warehouse = cmd.row.warehouse.ToString()
            row.representative = cmd.row.representative.ToString()
            row.sending_to = "Англия"
            row.doc_number = Int(Me.taDocs_Conclusions_Export.MaxDocNumber()) + 1
            row.verdict = Main.dsReferenses.R_verdict_patterns.Rows(0).Item("pattern_text")
            row.doc_user = Main.userName
            row.doc_date = System.DateTime.Today()

            row.samples_doc = "Заключением"
            row.samples_doc_number = cmd.row.doc_number
            row.samples_doc_date = cmd.row.doc_date.ToShortDateString()
            row.fact_address = cmd.row("fact_address").ToString()

            Me.dsConclusions.Docs_Conclusions_Export.AddDocs_Conclusions_ExportRow(row)
            Me.taDocs_Conclusions_Export.Update(Me.dsConclusions.Docs_Conclusions_Export)

            Dim tables As New Collection
            tables.Add(cmd.dsDocs_Conclusions.Docs_Acts_Goods)
            tables.Add(cmd.dsDocs_Conclusions.Docs_Conclusions_Karantin)
            tables.Add(cmd.dsDocs_Conclusions.Docs_Conclusions_NotKarantin)
            tables.Add(Me.dsConclusions.Docs_Acts_Goods)
            tables.Add(Me.dsConclusions.Docs_Conclusions_Karantin)
            tables.Add(Me.dsConclusions.Docs_Conclusions_NotKarantin)

            'копирование груза, карантина и некарантина
            For i As Integer = 1 To 3
                Dim ds As Object = System.Activator.CreateInstance(tables(i).GetType())
                For Each r As DataRow In tables(i).Rows
                    If (r.RowState <> DataRowState.Deleted) AndAlso (r.Item("doc_id") = cmd.row.doc_id) Then
                        Dim p As DataRow
                        p = ds.NewRow
                        p.ItemArray = r.ItemArray
                        p.Item("doc_id") = row.doc_id
                        ds.Rows.Add(p)
                    End If
                Next r

                For Each r As DataRow In ds.Rows
                    tables(i + 3).Rows.Add(r.ItemArray)
                Next r

                tables(i + 3).GetAdapter(Main.dbConnection).update(tables(i + 3))

            Next i

            'переход к новой записи
            Me.bsDocs_Conclusions_Export.MoveLast()
        End If
    End Sub

#End Region

End Class