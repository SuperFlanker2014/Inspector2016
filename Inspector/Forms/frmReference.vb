Public Class frmReference

    Public table_to_show As String

    Private Sub References_CountriesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles References_CountriesBindingNavigatorSaveItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim p As Object = Main.dsReferenses.Tables(table_to_show)
        Me.Validate()
        Me.ReferenceBindingSource.EndEdit()
        Try
            p.GetAdapter(Main.dbConnection).Update(p)
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Нельзя удалить! Остались ссылки на удаляемую запись: " + ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Ошибка сохранения: " + ex.Message, MsgBoxStyle.Critical)
        End Try
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub frmReference_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReferenceBindingNavigator.Enabled = True

        dgvReference.ReadOnly = False
        dgvReference.Columns.Clear()

        Dim p As Object = Main.dsReferenses.Tables(table_to_show)
        Me.ReferenceBindingSource.DataSource = p
        p.GetAdapter(Main.dbConnection).Fill(p)

        'Dim sumWidth As Int16 = 0
        For Each column As DataColumn In p.Columns
            Dim dc As System.Windows.Forms.DataGridViewColumn
            If column.ReadOnly Then Continue For
            Select Case column.DataType.Name
                Case "Boolean"
                    dc = New System.Windows.Forms.DataGridViewCheckBoxColumn
                Case "String"
                    dc = New System.Windows.Forms.DataGridViewTextBoxColumn
                Case Else
                    dc = New System.Windows.Forms.DataGridViewTextBoxColumn
            End Select
            For Each rel As DataRelation In Main.dsReferenses.Relations
                If Not (rel.ExtendedProperties.ContainsKey("substitution") AndAlso _
                    rel.ExtendedProperties("substitution") = True) Then
                    Continue For
                End If
                If (rel.ChildTable Is p) Then
                    If rel.ChildColumns(0) Is column Then
                        Dim dcComboBox As System.Windows.Forms.DataGridViewComboBoxColumn
                        dcComboBox = New System.Windows.Forms.DataGridViewComboBoxColumn
                        dcComboBox.DataSource = rel.ParentTable
                        dcComboBox.DisplayMember = rel.ParentColumns(0).ColumnName
                        dcComboBox.DisplayStyleForCurrentCellOnly = True
                        dc = dcComboBox
                        Exit For
                    End If
                End If
            Next rel

            dc.Name = column.ColumnName
            dc.HeaderText = column.Caption
            dc.DataPropertyName = column.ColumnName
            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            'If Not column.ColumnName = "new_data" Then
            Me.dgvReference.Columns.Add(dc)
            'End If

            'If column.ColumnName = "new_data" Then
            '    If DateTime.Now >= newDataDate Then
            '        ReferenceBindingSource.Filter = "new_data = 1"
            '        dgvReference.ReadOnly = True
            '        ReferenceBindingNavigator.Enabled = False
            '    Else
            '        ReferenceBindingSource.Filter = "new_data is NULL or new_data = 0"
            '    End If
            'End If

            'sumWidth += Me.dgvReference.Columns.GetLastColumn(DataGridViewElementStates.Visible, _
            '                                                  DataGridViewElementStates.None).Width

        Next column

        'Me.Width = Math.Min(Math.Min(sumWidth + 100, 700), 700)

        Me.Text = p.ExtendedProperties.Item("ref_title")
        
        If table_to_show = "R_services_units" And Not My.Settings.allowEditUnits Then
            dgvReference.ReadOnly = True
            ReferenceBindingNavigator.Enabled = False
        End If

    End Sub

End Class