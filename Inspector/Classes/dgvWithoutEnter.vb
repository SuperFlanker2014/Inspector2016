Public Class dgvWithoutEnter
    Inherits DataGridView

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If msg.WParam.ToInt32() = Keys.Enter Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Protected Overrides Sub OnCellLeave(ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        MyBase.OnCellLeave(e)
        Me.EndEdit()
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Delete Then
            Try
                Dim row As DataRow = MyBase.CurrentRow.DataBoundItem.Row
                Dim s As String = MyBase.Columns(MyBase.CurrentCell.ColumnIndex).DataPropertyName
                row.Item(s) = System.DBNull.Value
                MyBase.UpdateCellValue(MyBase.CurrentCell.ColumnIndex, MyBase.CurrentCell.RowIndex)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Protected Overrides Sub OnDataError(ByVal displayErrorDialogIfNoHandler As Boolean, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        e.Cancel = True
        Exit Sub
        'If e.ColumnIndex = 1 And e.Exception.Message = "DataGridViewComboBoxCell value is not valid." Then
        '    Exit Sub
        'ElseIf e.Exception.GetType().ToString() = "System.Data.ConstraintException" Then
        '    MsgBox("Дублирующиеся название и происхождение продукта недопустимы!", MsgBoxStyle.Critical, "Ошибка!")
        '    e.Cancel = True
        'ElseIf e.Exception.GetType().ToString() = "System.FormatException" Then
        '    Me.CancelEdit()
        '    Me(e.ColumnIndex, e.RowIndex).Value = 0
        'ElseIf e.Exception.GetType().ToString() = "System.Data.NoNullAllowedException" Then
        '    MsgBox("Не все объязательные поля заполнены! Редактирование будет отменено.", MsgBoxStyle.Critical, "Ошибка!")
        'Else
        '    MsgBox(e.Exception.Message, MsgBoxStyle.Critical, "Ошибка!")
        '    'MsgBox(Me.Name, MsgBoxStyle.Critical, "Ошибка!")
        '    MyBase.OnDataError(displayErrorDialogIfNoHandler, e)
        'End If

    End Sub

    'Protected Overrides Sub OnCellEnter(ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    MyBase.OnCellEnter(e)
    '    'If ((e.RowIndex = Me.RowCount) And e.ColumnIndex < 1) Or (e.RowIndex = 0 And e.ColumnIndex = 1) Then
    '    '    Exit Sub
    '    'End If
    '    ''Me.BeginEdit(True)
    '    'If Me.Columns(e.ColumnIndex).GetType().Name = "DataGridViewComboBoxColumn" Then
    '    '    Dim cBox As ComboBox = Me.EditingControl
    '    '    If Not cBox Is Nothing Then cBox.DroppedDown = True
    '    '    'SendKeys.Send("{DOWN}")
    '    '    'SendKeys.Send("{UP}")
    '    'End If
    'End Sub

End Class
