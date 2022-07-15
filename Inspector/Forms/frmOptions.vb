Imports System.Windows.Forms
Imports System.Configuration


Public Class frmOptions

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.propertyGridMySettings.SelectedObject.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.propertyGridMySettings.SelectedObject.Reload()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        propertyGridMySettings.SelectedObject = My.MySettingsWrapper.Default
    End Sub

    Private Sub propertyGrid1_PropertyValueChanged(ByVal s As Object, ByVal e As PropertyValueChangedEventArgs)
        propertyGridMySettings.Refresh()
    End Sub
End Class
