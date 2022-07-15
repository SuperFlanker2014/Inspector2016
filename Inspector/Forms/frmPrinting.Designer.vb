<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.reportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.printDialog = New System.Windows.Forms.PrintDialog
        Me.SuspendLayout()
        '
        'reportViewer
        '
        Me.reportViewer.ActiveViewIndex = -1
        Me.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportViewer.DisplayGroupTree = False
        Me.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportViewer.Location = New System.Drawing.Point(0, 0)
        Me.reportViewer.Name = "reportViewer"
        Me.reportViewer.SelectionFormula = ""
        Me.reportViewer.ShowCloseButton = False
        Me.reportViewer.ShowGroupTreeButton = False
        Me.reportViewer.ShowRefreshButton = False
        Me.reportViewer.ShowTextSearchButton = False
        Me.reportViewer.Size = New System.Drawing.Size(628, 379)
        Me.reportViewer.TabIndex = 0
        Me.reportViewer.ViewTimeSelectionFormula = ""
        '
        'printDialog
        '
        Me.printDialog.UseEXDialog = True
        '
        'frmPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 379)
        Me.Controls.Add(Me.reportViewer)
        Me.Name = "frmPrinting"
        Me.Text = "Печать"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents printDialog As System.Windows.Forms.PrintDialog
End Class
