Public NotInheritable Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("О программе ""{0}""", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Версия {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub emailLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles emailLink.LinkClicked
        Dim link As String = "mailto:eibragimov_karantin@mail.ru?subject=Письмо"
        System.Diagnostics.Process.Start(link)
    End Sub

    Private Sub siteLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles siteLink.LinkClicked
        Dim link As String = "http://u41539.netangels.ru"
        System.Diagnostics.Process.Start(link)
    End Sub

    Private Sub LabelVersion_Click(sender As Object, e As EventArgs) Handles LabelVersion.Click

    End Sub
End Class
