Imports System.Text.RegularExpressions

Public Class frmClientsReference

    Private fromAct As Boolean = False
    Private _client_inn As String = ""

    Public Overloads Sub ShowDialog(ByVal client_inn As String)
        _client_inn = client_inn
        Me.fromAct = True
        Me.Hide()
        Me.MdiParent = Nothing
        MyBase.ShowDialog()
    End Sub

#Region "Перекрытые методы работы с документом"

    Public Overrides Sub newDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.bsR_clients.AddNew()
        Client_nameTextBox.Focus()
        isNewDocMode = True
    End Sub

    Public Overrides Sub delDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Удалить запись?", MsgBoxStyle.YesNo, ) = MsgBoxResult.No Then
            Exit Sub
        Else
            isNewDocMode = False
            Me.bsR_clients.RemoveCurrent()
        End If
    End Sub

    Public Overrides Sub saveDocument(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_clientsBindingNavigatorSaveItem.Click

        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        'If Not CValidator.ChaekInn(Client_innMaskedTextBox.Text) Then
        '    MsgBox("Неверный формат ИНН", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        If Not String.IsNullOrEmpty(Client_kppMaskedTextBox.Text) AndAlso Not CValidator.СheckKpp(Client_kppMaskedTextBox.Text) Then
            MsgBox("Неверный формат КПП", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If isNewDocMode Then
            If Me.Client_typeComboBox.Text = "" Then
                MsgBox("Пустой тип клиента недопустим!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If Me.Client_regionComboBox.Text = "" Then
                MsgBox("Пустой регион клиента недопустим!", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        Try
            If Not bsR_clients.Current Is Nothing AndAlso bsR_clients.Current.Item("client_guid") Is DBNull.Value Then
                bsR_clients.Current.Item("client_guid") = Guid.NewGuid()
            End If
            Me.bsR_clients.EndEdit()
            'Catch ex As ConstraintException
            '    Dim re As New Regex("Value '(\d+)' is already present")
            '    MsgBox("Не уникальный номер ИНН! " & re.Split(ex.Message)(1) & " уже существует!", MsgBoxStyle.Critical)
            '    Exit Sub
        Catch ex As NoNullAllowedException
            If ex.Message.Contains("client_name") Then
                MsgBox("Пустое название недопустимо!", MsgBoxStyle.Critical)
            ElseIf ex.Message.Contains("client_inn") Then
                MsgBox("Пустой номер ИНН недопустим!", MsgBoxStyle.Critical)
                'ElseIf ex.Message.Contains("client_type") Then
                '    MsgBox("Пустой тип клиента недопустим!", MsgBoxStyle.Critical)
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        'If Not Me.bsR_clients.Current Is Nothing Then
        '    Dim p As Int16 = Me.taR_clients.IsInnExist(Me.Client_innMaskedTextBox.Text)
        '    If p > 0 And isNewDocMode Then
        '        MsgBox("Не уникальный номер ИНН! " & Me.Client_innMaskedTextBox.Text & " уже существует!", MsgBoxStyle.Critical)
        '        Exit Sub
        '    End If
        'End If

        Try
            Me.taR_clients.Update(Me.dsDocuments.R_clients)
        Catch ex As Data.SqlClient.SqlException
            If ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint") Then
                MsgBox("Нельзя удалить клиента, для него существуют документы!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        isNewDocMode = False

        Windows.Forms.Cursor.Current = Cursors.Arrow

    End Sub

    Public Overrides Sub findDocument(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If isSearchMode Then
            taR_clients.FillBySearchInnName(Me.dsDocuments.R_clients, Me.Client_innMaskedTextBox.Text.TrimStart(" ").TrimEnd(" "), Me.Client_nameTextBox.Text)
            bsR_clients.ResumeBinding()
            Me.Client_nameTextBox.Focus()
            btnSearch.Text = "В режим поиска"
            isSearchMode = False
        Else
            bsR_clients.SuspendBinding()
            btnSearch.Text = "Найти"
            isSearchMode = True
            Me.Client_nameTextBox.Focus()
        End If
    End Sub

    Public Overrides Sub initializeControlLists()
        Me.lstNewDocInVisible.AddRange(New Object() {BindingNavigatorAddNewItem, BindingNavigatorCountItem, _
            BindingNavigatorMoveFirstItem, BindingNavigatorMoveLastItem, BindingNavigatorMoveNextItem, _
            BindingNavigatorMovePreviousItem, BindingNavigatorPositionItem, BindingNavigatorSeparator, _
            BindingNavigatorSeparator1})
        Me.lstNewDocDisabled.AddRange(New Object() {btnSearch})

        Me.lstSearchInVisible.AddRange(New Object() {bnR_clients, pnlFieldsType, pnlFields, _
            Me.Client_kppMaskedTextBox, Me.Client_kppLabel})
        Me.lstSearchEnabled.AddRange(New Object() {Me.pnlFieldsMain})

        Me.lstEmptyFormDisabled.AddRange(New Object() {Me.pnlFields, Me.pnlFieldsType, Me.pnlFieldsMain, _
            Me.BindingNavigatorDeleteItem})

        Me.dtClients = Me.dsDocuments.R_clients
        Me.bsPrimary = Me.bsR_clients
    End Sub

#End Region

    Private Shadows Sub frmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Client_bank_nameComboBox.DataSource = Main.dsReferenses.R_banks
        Me.Client_bank_nameComboBox.DisplayMember = "bank_title"
        Me.Client_bank_nameComboBox.ValueMember = "bank_bik"

        Me.Client_regionComboBox.DataSource = Main.dsReferenses.R_countries_and_regions
        Me.Client_regionComboBox.ValueMember = "country_title"

        Me.Client_region_rayonComboBox.DataSource = Main.dsReferenses.R_Sverdlovsk_region_rayons
        Me.Client_region_rayonComboBox.ValueMember = "rayon_title"

        Me.Client_typeComboBox.DataSource = Main.dsReferenses.R_client_types
        Me.Client_typeComboBox.ValueMember = "type_title"

        If Not fromAct Then
            Me.taR_clients.Fill(Me.dsDocuments.R_clients)
        Else
            Me.isEmptyForm = False
            'If Not (_client_inn = "") Then
            'если вызываем из документов, то нужно показать клиента с заданным инн
            Me.taR_clients.FillBySearch(Me.dsDocuments.R_clients, _client_inn)
            'Else
            '    'если вызываем из списка справочников, то заливаем как обычно
            '    Me.taR_clients.Fill(Me.dsDocuments.R_clients)
            'End If
        End If

    End Sub

    Private Sub Client_regionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Client_regionComboBox.SelectedIndexChanged
        If Client_regionComboBox.Text <> "Свердловская область" Then
            Client_region_rayonComboBox.Enabled = False
        Else
            Client_region_rayonComboBox.Enabled = True
        End If
    End Sub

    Private Sub btnNewINN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewINN.Click
        Client_innMaskedTextBox.Text = (CType(taR_clients.MaxInn(), Int64) + 1).ToString()
    End Sub

End Class