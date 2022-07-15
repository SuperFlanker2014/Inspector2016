<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintingAsk
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
        Me.countConcl = New System.Windows.Forms.NumericUpDown
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbPrint = New System.Windows.Forms.ProgressBar
        Me.cntOne = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.countConcl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cntOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'countConcl
        '
        Me.countConcl.Location = New System.Drawing.Point(224, 7)
        Me.countConcl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.countConcl.Name = "countConcl"
        Me.countConcl.Size = New System.Drawing.Size(49, 20)
        Me.countConcl.TabIndex = 0
        Me.countConcl.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(15, 85)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(124, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Печатать"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(148, 85)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Сколько копий заключения"
        '
        'pbPrint
        '
        Me.pbPrint.Location = New System.Drawing.Point(15, 56)
        Me.pbPrint.Name = "pbPrint"
        Me.pbPrint.Size = New System.Drawing.Size(258, 23)
        Me.pbPrint.TabIndex = 6
        '
        'cntOne
        '
        Me.cntOne.Location = New System.Drawing.Point(223, 30)
        Me.cntOne.Name = "cntOne"
        Me.cntOne.Size = New System.Drawing.Size(49, 20)
        Me.cntOne.TabIndex = 7
        Me.cntOne.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Экземпляров заключения"
        '
        'frmPrintingAsk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 119)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cntOne)
        Me.Controls.Add(Me.pbPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.countConcl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintingAsk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Копирование с печатью"
        CType(Me.countConcl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cntOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents countConcl As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbPrint As System.Windows.Forms.ProgressBar
    Friend WithEvents cntOne As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
