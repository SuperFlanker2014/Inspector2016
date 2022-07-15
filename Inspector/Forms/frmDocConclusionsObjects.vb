Imports Microsoft.VisualBasic

Public Class frmDocConclusionsObjects

    Private tblList As New Collection

    Private Sub print(ByVal PrintOrPreview As PrintingType)
        Printing.print(DocumentType.ConclusionObjects, PrintOrPreview, True, 1, Me.bsConclusions.Current.Row)
    End Sub

    Public Function save()

        EndEdit()
        'проверка bsConclusions
        'check if new
        If isNewDocMode Then
            If Me.Client_innMaskedTextBox.Text = "" Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
                Return False
            ElseIf Me.cbCategory.Text = "" Then
                MsgBox("Пустой тип документа недопустим!", MsgBoxStyle.Critical)
                Return False
            Else
                Dim guid1 As Guid = Me.taClients.IsInnExists(Me.Client_innMaskedTextBox.Text)
                If guid1 = Guid.Empty Then
                    MsgBox("Такого номера ИНН нет в базе!", MsgBoxStyle.Critical)
                    Return False
                ElseIf Me.bsConclusions.Current.Item("client_guid").GetType.Name = "DBNull" Then
                    Me.bsConclusions.Current.Item("client_guid") = guid1
                End If
            End If
        End If

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Me.bsConclusions.EndEdit()
        Catch ex As NoNullAllowedException
            If ex.Message.Contains("client_inn") Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        End Try

        bsConclusions_CurrentChanged(New Object, New System.EventArgs)
        'если новый копируем данные
        If isNewDocMode Then
            Dim p1 As Object = Me.bsConclusions.Current
            p1.Item("representative") = Me.bsClients.Current.Item("client_representative")
        End If

        Try
            Me.taConclusions.Update(Me.dsConclusions._Docs_Conclusions_Objects)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsConclusions

        'проверка bsObjects
        Me.dgvObjects.EndEdit()
        Try
            Me.bsObjects.EndEdit()
        Catch ex As System.Data.NoNullAllowedException
            If ex.Message.Contains("title") Then
                MsgBox("Пустое название объекта недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("count") Then
                MsgBox("Пустое количество объектов недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("volume_unit") Then
                MsgBox("Пустая единица объёма недопустима!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("volume") Then
                MsgBox("Пустой объём проверки недопустим!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("rayon") Then
                MsgBox("Пустое название района недопустимо!", MsgBoxStyle.Critical)
            Else
                MsgBox("Не все объязательные поля заполнены!", MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As System.Data.ConstraintException
            MsgBox("Дублирующиеся названия объектов недопустимы!", MsgBoxStyle.Critical)
            Return False
        End Try
        Try
            Me.taCO_Objects.Update(Me.dsConclusions.Docs_CO_Objects)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsObjects

        'проверка bsExaminations
        Me.dgvExaminations.EndEdit()
        Me.bsExaminations.EndEdit()
        Try
            Me.taCOO_Examinations.Update(Me.dsConclusions.Docs_COO_Examinations)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsExaminations

        'проверка bsKarantin
        Me.dgvKarantin.EndEdit()
        Try
            Me.bsKarantin.EndEdit()
        Catch ex As System.Data.NoNullAllowedException
            If ex.Message.Contains("object_title") Then
                MsgBox("Пустое название карантинного объекта недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("exam_method") Then
                MsgBox("Пустое название метода обнаружения карантинного объекта недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("exam_count") Then
                MsgBox("Пустое количество карантинного объекта недопустимо!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As System.Data.ConstraintException
            MsgBox("Дублирующиеся названия карантинных объектов недопустимы!", MsgBoxStyle.Critical)
            Return False
        End Try
        Try
            Me.taCOO_Karantin.Update(Me.dsConclusions.Docs_COO_Karantin)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsKarantin

        'проверка bsNotKarantin
        Me.dgvNotKarantin.EndEdit()
        Try
            Me.bsNotKarantin.EndEdit()
        Catch ex As System.Data.NoNullAllowedException
            If ex.Message.Contains("object_title") Then
                MsgBox("Пустое название некарантинного объекта недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("exam_method") Then
                MsgBox("Пустое название метода обнаружения некарантинного объекта недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("exam_count") Then
                MsgBox("Пустое количество некарантинного объекта недопустимо!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As System.Data.ConstraintException
            MsgBox("Дублирующиеся названия некарантинных объектов недопустимы!", MsgBoxStyle.Critical)
            Return False
        End Try
        Try
            Me.taCOO_NotKarantin.Update(Me.dsConclusions.Docs_COO_NotKarantin)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Неверные данные! " + ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
        'конец проверки bsNotKarantin

        isNewDocMode = False
        bsClients.ResumeBinding()
        Windows.Forms.Cursor.Current = Cursors.Arrow

        Return True
    End Function

    Private Shadows Sub frmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tblList.Add(Me.dsConclusions._Docs_Conclusions_Objects)
        tblList.Add(Me.dsConclusions.Docs_CO_Objects)
        tblList.Add(Me.dsConclusions.Docs_COO_Examinations)
        tblList.Add(Me.dsConclusions.Docs_COO_Karantin)
        tblList.Add(Me.dsConclusions.Docs_COO_NotKarantin)

        Dim IDs As DataTable = taConclusions.Get3IDs()
        For Each tbl As Object In tblList
            Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
            ta.ClearBeforeFill = False
            For Each row As DataRow In IDs.Rows
                ta.FillByID(tbl, row.Item("doc_id"))
            Next row
        Next tbl

        Dim ds As References = Main.dsReferenses
        ds.R_countries_and_regions.GetAdapter(Main.dbConnection).Fill(ds.R_countries_and_regions)

        Me.cTitle.DataSource = ds.R_objects
        Me.cTitle.DisplayMember = "object_title"
        Me.cVolumeUnit.DataSource = ds.R_weight_units
        Me.cVolumeUnit.DisplayMember = "unit_title"
        Me.cRayon.DataSource = ds.R_Sverdlovsk_region_rayons
        Me.cRayon.DisplayMember = "rayon_title"

        Me.cNotKarantinObjectTitle.DataSource = ds.R_notkarantin
        Me.cNotKarantinObjectTitle.DisplayMember = "object_title"
        Me.cKarantinObjectTitle.DataSource = ds.R_karantin
        Me.cKarantinObjectTitle.DisplayMember = "object_title"

        Me.cbKarantin.DataSource = ds.R_karantin
        Me.cbKarantin.ValueMember = "object_title"
        Me.cbObject.DataSource = ds.R_objects
        Me.cbObject.ValueMember = "object_title"
        Me.cbRayon.DataSource = ds.R_Sverdlovsk_region_rayons
        Me.cbRayon.DisplayMember = "rayon_title"

        Me.cbCategory.DataSource = ds.R_objects_categories
        Me.cbCategory.ValueMember = "category_title"

        Me.cbTarget.DataSource = ds.R_objects_target_type
        Me.cbTarget.ValueMember = "type_text"

    End Sub

    Private Sub bsConclusions_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsConclusions.CurrentChanged
        Dim p As Object = bsConclusions.Current
        If (p Is Nothing) Then
            Exit Sub
        End If
        If (p.Item("client_guid").GetType.Name <> "DBNull") Then
            Me.taClients.FillOneByGUID(Me.dsConclusions.R_clients, bsConclusions.Current.Item("client_guid"))
        Else 'если новый

            p.Item("doc_number") = Int(taConclusions.MaxDocNumber()) + 1
            p.item("doc_user") = Main.userName

            Dim s As String() = {"doc_date"}
            For Each d As String In s
                p.Item(d) = System.DateTime.Today()
            Next d

            Me.bsConclusions.ResetCurrentItem()
        End If
    End Sub

#Region "Перекрытые методы работы с документом"

    Public Overrides Sub newDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        isNewDocMode = True
        Me.bsConclusions.AddNew()
        Me.bsClients.SuspendBinding()
        Client_innMaskedTextBox.Focus()
    End Sub

    Public Overrides Sub delDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Удалить запись?", MsgBoxStyle.YesNo, ) = MsgBoxResult.No Then
            Exit Sub
        Else
            isNewDocMode = False
            Me.bsClients.ResumeBinding()
            Me.bsConclusions.RemoveCurrent()
        End If
    End Sub

    Public Overrides Sub saveDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docs_Conclusions_ImportBindingNavigatorSaveItem.Click
        save()
    End Sub

    Public Overrides Sub findDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isSearchMode Then
            Me.Cursor = Cursors.WaitCursor
            Dim client_inn As String = Me.Client_innMaskedTextBox.Text
            Dim doc_date_high As String = Doc_date_highDateTimePicker.Value
            Dim doc_date_low As String = Doc_dateDateTimePicker.Value
            Dim object_title As String = cbObject.Text
            Dim rayon As String = cbRayon.Text
            Dim object_karantin_title As String = cbKarantin.Text
            Dim doc_number As String = Doc_numberMaskTextBox.Text

            Me.dsConclusions.Clear()
            Dim IDs As DataTable = taConclusions.GetIDs(object_karantin_title, doc_date_high, doc_date_low, _
                object_title, rayon, doc_number, client_inn)
            Dim list As String = Main.getDocIdList(IDs)

            For Each tbl As Object In tblList
                Dim ta As Object = tbl.GetAdapter(Main.dbConnection)
                ta.FillTable(tbl, list)
            Next tbl

            Me.bsConclusions.ResumeBinding()
            'Me.bsObjects.ResumeBinding()
            'Me.bsExaminations.ResumeBinding()
            'Me.bsKarantin.ResumeBinding()
            'Me.bsNotKarantin.ResumeBinding()

            btnSearch.Text = "В режим поиска"
            isSearchMode = False
            Me.dgvObjects.Focus()
            Me.Cursor = Cursors.Default
        Else

            Me.cbRayon.SelectedIndex = -1
            Me.cbKarantin.SelectedIndex = -1
            Me.cbObject.SelectedIndex = -1

            Me.bsConclusions.SuspendBinding()
            'Me.bsObjects.SuspendBinding()
            'Me.bsExaminations.SuspendBinding()
            'Me.bsKarantin.SuspendBinding()
            'Me.bsNotKarantin.SuspendBinding()

            Me.Doc_dateDateTimePicker.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Me.Doc_date_highDateTimePicker.Value = DateTime.Today

            btnSearch.Text = "Найти"
            isSearchMode = True
            Me.Doc_numberMaskTextBox.Focus()
        End If
    End Sub

    Public Overrides Sub initializeControlLists()
        Me.lstNewDocInVisible.AddRange(New Object() {BindingNavigatorAddNewItem, BindingNavigatorCountItem, _
            BindingNavigatorMoveFirstItem, BindingNavigatorMoveLastItem, BindingNavigatorMoveNextItem, _
            BindingNavigatorMovePreviousItem, BindingNavigatorPositionItem, BindingNavigatorSeparator, _
            BindingNavigatorSeparator1, btnSearch, btnCopy, btnPrint, btnPrintPreview, _
            dgvObjects, tabChildViewes, pnlMain})

        Me.lstSearchEnabled.AddRange(New Object() {Doc_numberMaskTextBox, Doc_dateDateTimePicker, _
            Client_innMaskedTextBox})
        Me.lstSearchInVisible.AddRange(New Object() {pnlGrids, pnlMain, txtClient_name, txtClient_address, _
            lblAddress, lblDocType, cbCategory})
        Me.lstSearchVisible.AddRange(New Object() {pnlSearch})

        Me.dtClients = Me.dsConclusions.R_clients
        Me.bsPrimary = Me.bsConclusions
        Me.lstEmptyFormDisabled.AddRange(New Object() {pnlMain, dgvObjects, tabChildViewes, _
            Doc_dateDateTimePicker, Doc_numberMaskTextBox, Client_innMaskedTextBox, BindingNavigatorDeleteItem, _
            btnPrint, btnPrintPreview, btnCopy, cbCategory})
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

                Dim guid1 As Guid = row.Item("client_guid")
                Me.taClients.FillOneByGUID(Me.dsConclusions.R_clients, guid1)
                Me.bsConclusions.Current.Item("client_guid") = guid1

                Dim representative As String = row.Item("client_representative").ToString()
                Me.Client_innMaskedTextBox.Text = inn
                Me.txtRepresentative.Text = representative
            End If
        End Using

    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If Me.bsConclusions.Current Is Nothing Then
            Exit Sub
        End If

        Dim cur_row As Docs_Conclusions_Objects.Docs_Conclusions_ObjectsRow = bsConclusions.Current.Row
        Dim row As Docs_Conclusions_Objects.Docs_Conclusions_ObjectsRow = Me.dsConclusions._Docs_Conclusions_Objects.NewDocs_Conclusions_ObjectsRow

        'копирование записи
        Dim i As Integer = row.doc_id
        row.ItemArray = cur_row.ItemArray
        row.doc_id = i
        row.doc_number = Int(Me.taConclusions.MaxDocNumber()) + 1
        row.doc_user = Main.userName
        row.doc_date = System.DateTime.Today()
        Me.dsConclusions._Docs_Conclusions_Objects.AddDocs_Conclusions_ObjectsRow(row)
        Me.taConclusions.Update(Me.dsConclusions._Docs_Conclusions_Objects)

        Dim tables As New Collection
        tables.Add(dsConclusions.Docs_CO_Objects)
        tables.Add(dsConclusions.Docs_COO_Examinations)
        tables.Add(dsConclusions.Docs_COO_Karantin)
        tables.Add(dsConclusions.Docs_COO_NotKarantin)

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
        Me.bsConclusions.MoveLast()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If save() Then
            print(PrintingType.PrintDocument)
        End If
    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        If save() Then
            print(PrintingType.PreviewDocument)
        End If
    End Sub

    Private Sub btnAddExaminations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddExaminations.Click
        If Not save() Then
            Exit Sub
        End If

        Dim p As Docs_Conclusions_Objects.Docs_CO_ObjectsRow = bsObjects.Current.Row
        If (p Is Nothing) Or (dgvExaminations.RowCount > 0) Then
            Exit Sub
        ElseIf p.Item("title").GetType.Name = "DBNull" Then
            Exit Sub
        End If
        Dim dt As New References.R_objects_groups_karantinDataTable
        dt = dt.GetAdapter(Main.dbConnection).GetKarantinByObject(p.Item("title"))

        For Each row As DataRow In dt.Rows
            Dim r As DataRow = Me.dsConclusions.Docs_COO_Examinations.NewDocs_COO_ExaminationsRow
            r.Item("doc_id") = p.doc_id
            r.Item("title") = p.title
            r.Item("object_title") = row.Item("karantin_title")
            r.Item("volume") = p.volume
            Me.dsConclusions.Docs_COO_Examinations.AddDocs_COO_ExaminationsRow(r)
        Next row
    End Sub

    Private Sub btnFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFill.Click
        If Not save() Then
            Exit Sub
        End If
        Dim o As Inspector.Docs_Conclusions_Objects.Docs_Conclusions_ObjectsRow = Me.bsConclusions.Current.Row
        If o Is Nothing Then Exit Sub

        'считаем строки экспертиз
        Dim strExams As String = ""
        For Each row As Inspector.Docs_Conclusions_Objects.Docs_COO_ExaminationsRow In Me.dsConclusions.Docs_COO_Examinations.Rows
            If row.doc_id = o.Item("doc_id") Then
                strExams += row.object_title + " - " + row.volume.ToString() + " " + _
                row.GetParentRow("FK_Docs_COO_Examinations_Docs_CO_Objects").Item("volume_unit").ToString() + _
                ", " + ControlChars.CrLf
            End If
        Next row
        strExams += "."
        Me.txtVerdict.Text += ControlChars.CrLf + "Обследовано: " + ControlChars.CrLf + strExams

        'считаем строки обнаруженных карантинных
        Dim htKarantin As New Collections.Hashtable
        For Each row As Inspector.Docs_Conclusions_Objects.Docs_COO_KarantinRow In Me.dsConclusions.Docs_COO_Karantin.Rows
            If row.doc_id = o.Item("doc_id") Then
                Dim r As References.R_karantinRow = Main.dsReferenses.R_karantin.FindByobject_title(row.object_title)
                Dim rco As Docs_Conclusions_Objects.Docs_CO_ObjectsRow = Me.dsConclusions.Docs_CO_Objects.FindBydoc_idtitle(row.doc_id, row.title)
                If htKarantin(r.group_title) Is Nothing Then
                    htKarantin(r.group_title) = ""
                End If
                htKarantin(r.group_title) += row.object_title + " (" + r.object_title_latin + _
                    ") - " + Str(rco.volume) + " " + rco.volume_unit + "; "
            End If
        Next row
        Dim strKarantin As String = ""
        For Each key As String In htKarantin.Keys
            strKarantin += key + ": " + htKarantin(key)
        Next key
        Me.txtVerdict.Text += ControlChars.CrLf + "Обнаружены карантинные: " + strKarantin

        'считаем строки обнаруженных некарантинных
        Dim htNotKarantin As New Collections.Hashtable
        For Each row As Inspector.Docs_Conclusions_Objects.Docs_COO_NotKarantinRow In Me.dsConclusions.Docs_COO_NotKarantin.Rows
            If row.doc_id = o.Item("doc_id") Then
                Dim r As Inspector.References.R_notkarantinRow = Main.dsReferenses.R_notkarantin.FindByobject_title(row.object_title)
                If htNotKarantin(r.group_title) Is Nothing Then
                    htNotKarantin(r.group_title) = ""
                End If
                htNotKarantin(r.group_title) += row.object_title + " (" + r.object_title_latin + "); "
            End If
        Next row
        Dim strNotKarantin As String = ""
        For Each key As String In htNotKarantin.Keys
            strNotKarantin += key + ": " + htNotKarantin(key)
        Next key
        Me.txtVerdict.Text += ControlChars.CrLf + "Обнаружены некарантинные: " + strNotKarantin

    End Sub

    Private Sub EndEdit()
        ''pests
        'Me.dgvDocs_Conclusions_NotKarantin.EndEdit()
        'Dim r As DataRowView = CType(Me.bsDocs_Conclusions_NotKarantin.Current, DataRowView)
        'If (r IsNot Nothing) Then
        '    If (r.Row("production_country").ToString() = "" Or _
        '        r.Row("good_title").ToString() = "" Or _
        '        r.Row("object_title").ToString() = "") Then
        '        r.CancelEdit()
        '    Else
        '        r.EndEdit()
        '    End If
        'End If

        'Me.dgvDocs_Conclusions_Karantin.EndEdit()
        'r = CType(Me.bsDocs_Conclusions_Karantin.Current, DataRowView)
        'If (r IsNot Nothing) Then
        '    If (r.Row("production_country").ToString() = "" Or _
        '        r.Row("good_title").ToString() = "" Or _
        '        r.Row("object_title").ToString() = "") Then
        '        r.CancelEdit()
        '    Else
        '        r.EndEdit()
        '    End If
        'End If

        ''goods
        'Me.dgvDocs_Acts_Goods.EndEdit()
        'r = CType(Me.bsDocs_Acts_Goods.Current, DataRowView)
        'If (r IsNot Nothing) Then
        '    If (r.Row("production_country").ToString() = "" Or _
        '        r.Row("good_title").ToString() = "") Then
        '        r.CancelEdit()
        '    Else
        '        r.EndEdit()
        '    End If
        'End If
        'Me.bsDocs_Acts_Goods.EndEdit()
        'Me.bsDocs_Acts_Goods.ResetCurrentItem()

        ''document
        'Try
        '    Me.bsDocs_Conclusions_Import.EndEdit()
        'Catch ex As NoNullAllowedException
        '    'не ввели arrived, спросим в сохранении
        'End Try
    End Sub

End Class