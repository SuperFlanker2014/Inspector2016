<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForestInfo
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
        Me.cbKind = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbBoard = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbTimber = New System.Windows.Forms.ComboBox
        Me.btnCommit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cbKind
        '
        Me.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKind.FormattingEnabled = True
        Me.cbKind.Location = New System.Drawing.Point(7, 25)
        Me.cbKind.Name = "cbKind"
        Me.cbKind.Size = New System.Drawing.Size(416, 21)
        Me.cbKind.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Видовой состав древесины"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(253, 132)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Отменить"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Пиломатериал"
        '
        'cbBoard
        '
        Me.cbBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBoard.FormattingEnabled = True
        Me.cbBoard.Location = New System.Drawing.Point(7, 65)
        Me.cbBoard.Name = "cbBoard"
        Me.cbBoard.Size = New System.Drawing.Size(416, 21)
        Me.cbBoard.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Лесоматериал"
        Me.Label3.Visible = False
        '
        'cbTimber
        '
        Me.cbTimber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimber.FormattingEnabled = True
        Me.cbTimber.Location = New System.Drawing.Point(7, 105)
        Me.cbTimber.Name = "cbTimber"
        Me.cbTimber.Size = New System.Drawing.Size(416, 21)
        Me.cbTimber.TabIndex = 5
        Me.cbTimber.Visible = False
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(98, 132)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommit.TabIndex = 7
        Me.btnCommit.Text = "Добавить"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'frmForestInfo
        '
        Me.AcceptButton = Me.btnCommit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(427, 163)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.cbTimber)
        Me.Controls.Add(Me.cbBoard)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbKind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmForestInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ввод сведений о лесоматериалах"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbKind As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbBoard As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTimber As System.Windows.Forms.ComboBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
End Class
