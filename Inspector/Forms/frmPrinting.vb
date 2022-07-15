Public Class frmPrinting
    Public Sub print(Optional ByVal count As Integer = 2, Optional ByVal hide As Boolean = False)
        Windows.Forms.Cursor.Current = Cursors.Default
        Dim p As CrystalDecisions.CrystalReports.Engine.ReportDocument = Me.reportViewer.ReportSource
        Me.printDialog.PrinterSettings.Copies = count
        Dim res As DialogResult = Windows.Forms.DialogResult.Abort
        If Not hide Then
            res = Me.printDialog.ShowDialog()
        End If
        If res <> Windows.Forms.DialogResult.Cancel Then
            p.PrintToPrinter(Me.printDialog.PrinterSettings.Copies, True, 1, 100)
        ElseIf res = Windows.Forms.DialogResult.Abort Then
            p.PrintToPrinter(count, True, 1, 100)
        End If
        'Me.reportViewer.PrintReport()
    End Sub
End Class