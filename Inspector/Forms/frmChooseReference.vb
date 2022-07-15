Imports system
Imports System.Reflection
Public Class frmChooseReference

    Private Sub lbReferences_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbReferences.DoubleClick
        Me.Hide()
        Main.showReference(lbReferences.SelectedItem.ToString())
    End Sub

    Private Sub frmChooseReference_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lbReferences.Items.Clear()
        For Each table As DataTable In Main.dsReferenses.Tables
            If table.ExtendedProperties.ContainsKey("ref_title") Then
                Me.lbReferences.Items.Add(table.ExtendedProperties("ref_title").ToString())
            End If
        Next table
        For Each relation As DataRelation In Main.dsReferenses.Relations
            If relation.ExtendedProperties.ContainsKey("ref_title") Then
                Me.lbReferences.Items.Add(relation.ExtendedProperties("ref_title").ToString())
            End If
        Next relation
        For Each form As Form In Main.formsReference
            Me.lbReferences.Items.Add(form.Text)
        Next form
        Me.lbReferences.Sorted = True
    End Sub
End Class