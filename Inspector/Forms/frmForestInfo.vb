Public Class frmForestInfo

    Private Sub frmForestInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim wc As ReferencesTableAdapters.R_wood_compositionTableAdapter = _
            Main.dsReferenses.R_wood_composition.GetAdapter(Main.dbConnection)

        Me.cbKind.DataSource = wc.GetKind()
        Me.cbKind.ValueMember = "text"
        Me.cbBoard.DataSource = wc.GetBoard()
        Me.cbBoard.ValueMember = "text"
        Me.cbTimber.DataSource = wc.GetTimber()
        Me.cbTimber.ValueMember = "text"

        Me.cbKind.SelectedIndex = -1
        Me.cbBoard.SelectedIndex = -1

    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class