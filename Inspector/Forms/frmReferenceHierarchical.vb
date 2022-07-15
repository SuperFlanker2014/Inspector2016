Public Class frmReferenceHierarchical

    Public relation_to_show As String

    Dim parentTable As New Object
    Dim childTable As New Object
    Dim relation As DataRelation

    Private Sub frmReferenceHierarchical_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        bnChildTable.Enabled = True
        bnParentTable.Enabled = True

        dgvChildTable.ReadOnly = False
        dgvChildTable.ReadOnly = False

        dgvParentTable.Columns.Clear()
        dgvChildTable.Columns.Clear()

        bsParentTable.RemoveFilter()
        bsChildTable.RemoveFilter()

        relation = dsReferenses.Relations(relation_to_show)
        parentTable = relation.ParentTable
        childTable = relation.ChildTable

        dsReferenses.EnforceConstraints = False
        parentTable.GetAdapter(dbConnection).Fill(parentTable)
        childTable.GetAdapter(dbConnection).Fill(childTable)
        dsReferenses.EnforceConstraints = True

        bsParentTable.DataSource = parentTable
        bsChildTable.DataMember = relation.RelationName

        For Each rel As DataRelation In Main.dsReferenses.Relations
            If rel.ChildTable Is parentTable Then

            End If
        Next rel

        For Each column As DataColumn In parentTable.Columns
            Dim dc As System.Windows.Forms.DataGridViewColumn
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
                If (rel.ChildTable Is parentTable) Then
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

            If Not column.AutoIncrement Then 'And Not column.ColumnName = "new_data"
                Me.dgvParentTable.Columns.Add(dc)
            End If

            'If column.ColumnName = "new_data" Then
            '    If DateTime.Now >= newDataDate Then
            '        bsParentTable.Filter = "new_data = 1"
            '        dgvParentTable.ReadOnly = True
            '        bnParentTable.Enabled = False
            '    Else
            '        bsParentTable.Filter = "new_data is NULL or new_data = 0"
            '    End If
            'End If

        Next column

        Dim keyColumns() As DataColumn = relation.ChildColumns()
        Dim keyColumnsNames As New Collection
        For Each dc As DataColumn In keyColumns
            keyColumnsNames.Add(dc.ColumnName, dc.ColumnName)
        Next dc

        For Each column As DataColumn In childTable.Columns
            Dim dc As System.Windows.Forms.DataGridViewColumn
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
                If (rel.ChildTable Is childTable) Then
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

            If Not keyColumnsNames.Contains(column.ColumnName) And Not column.AutoIncrement Then 'And Not column.ColumnName = "new_data"
                Me.dgvChildTable.Columns.Add(dc)
            End If

            'If column.ColumnName = "new_data" Then
            '    If DateTime.Now >= newDataDate Then
            '        bsChildTable.Filter = "new_data = 1"
            '        dgvChildTable.ReadOnly = True
            '        bnChildTable.Enabled = False
            '    Else
            '        bsChildTable.Filter = "new_data is NULL or new_data = 0"
            '    End If
            'End If

        Next column

        Me.Text = relation.ExtendedProperties("ref_title")

        'If relation.ParentTable.TableName = "R_services_groups" Then
        '    dgvParentTable.ReadOnly = True
        '    bnParentTable.Enabled = False
        '    dgvChildTable.ReadOnly = True
        '    bnChildTable.Enabled = False
        'End If

    End Sub

    Private Sub BindingNavigatorChildTableSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_karantinBindingNavigatorSaveItem.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Me.Validate()
            Me.bsChildTable.EndEdit()
            Me.bsParentTable.EndEdit()
            parentTable.GetAdapter(Main.dbConnection).Update(parentTable)
            childTable.GetAdapter(Main.dbConnection).Update(childTable)
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Data.SqlClient.SqlException
            MsgBox("Нельзя удалить! Остались ссылки на удаляемую запись: " + ex.Message, MsgBoxStyle.Critical)
        Catch ex As Data.DBConcurrencyException
            MsgBox("Ошибка сохранения! Удаление записи при наличии ссылок запрещено", MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Ошибка сохранения: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem1.Click
        If MsgBox("Удалить запись?", MsgBoxStyle.YesNo, ) = MsgBoxResult.No Then
            Exit Sub
        Else
            Me.bsParentTable.RemoveCurrent()
        End If
    End Sub
End Class