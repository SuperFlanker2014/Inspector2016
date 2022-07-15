Public Class frmPrintingAsk

    Private frm As IFormWithCopyAndPrint

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        Me.btnCancel.Enabled = False
        Me.btnPrint.Enabled = False
        Me.countConcl.Enabled = False
        Me.cntOne.Enabled = False

        Me.pbPrint.Minimum = 0
        Me.pbPrint.Maximum = CType(Me.countConcl.Value, Integer)
        Me.pbPrint.Value = 0
        For i As Integer = 1 To CType(Me.countConcl.Value, Integer)
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            frm.copy(sender, New System.EventArgs)
            If cntOne.Value > 0 Then
                frm.print(PrintingType.PrintDocument, False, cntOne.Value)
            End If
            Me.pbPrint.Value += 1
        Next i

        Me.btnCancel.Enabled = True
        Me.btnPrint.Enabled = True
        Me.countConcl.Enabled = True
        Me.cntOne.Enabled = True

        Windows.Forms.Cursor.Current = Cursors.Default

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Public Overloads Sub ShowDialog(ByRef f As IFormWithCopyAndPrint)
        frm = f
        MyBase.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub
End Class