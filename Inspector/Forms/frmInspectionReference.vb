Public Class frmInspectionReference

    Private Sub R_inspectionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmInspectionReference_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.R_inspectionTableAdapter.Fill(Me.References.R_inspection)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.R_inspectionBindingSource.EndEdit()
        Me.R_inspectionTableAdapter.Update(Me.References.R_inspection)
        Main.dsReferenses.R_inspection.GetAdapter(Main.dbConnection).Fill(Main.dsReferenses.R_inspection)
    End Sub

End Class