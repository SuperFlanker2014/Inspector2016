Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtPassword.Text.GetHashCode() = cbUsers.SelectedValue Then
            Main.userName = cbUsers.Text
            Main.userRestricts = Main.dsReferenses.R_users.FindByuser_name(cbUsers.Text).Item("restricts").ToString()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Неверный пароль!", MsgBoxStyle.Critical)
            Me.txtPassword.Focus()
            Me.txtPassword.SelectAll()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbUsers.DataSource = Main.dsReferenses.R_users
        cbUsers.DisplayMember = "user_name"
        cbUsers.ValueMember = "password_hash"

        cbUsers.Focus()
    End Sub
End Class
