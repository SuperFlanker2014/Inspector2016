Public Class frmChangePassword

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim p As Inspector.References.R_usersRow = Main.dsReferenses.R_users.FindByuser_name(Main.userName)
        If Not Me.txtOldPass.Text.GetHashCode() = p.Item("password_hash") Then
            MsgBox("Неверный старый пароль!", MsgBoxStyle.Critical)
            Me.txtOldPass.Focus()
            Me.txtOldPass.SelectAll()
        ElseIf Me.txtNewPass.Text <> Me.txtNewPassTwo.Text Then
            MsgBox("Новые пароли не совпадают!", MsgBoxStyle.Critical)
            Me.txtNewPass.Focus()
            Me.txtNewPass.SelectAll()
        Else
            p.Item("password_hash") = Me.txtNewPass.Text.GetHashCode()
            Main.dsReferenses.R_users.GetAdapter(Main.dbConnection).Update(Main.dsReferenses.R_users)
            MsgBox("Пароль успешно изменён!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
