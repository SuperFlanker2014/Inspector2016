Imports System.Windows.Forms

Public Class frmMain

    Private Sub applyUserRestricts()
        If Main.userRestricts.Contains("A") Then
            Me.btnDocuments.Visible = False
            Me.mnuContext.Items("ДокументыToolStripMenuItem").Visible = False
        End If
        If Main.userRestricts.Contains("B") Then
            Me.btnPayments.Visible = False
            Me.mnuContext.Items("ПлатежиToolStripMenuItem").Visible = False
        End If
        If Main.userRestricts.Contains("C") Then
            Me.btnChooseReference.Visible = False
            Me.mnuContext.Items("contextReferences").Visible = False
        End If
        If Main.userRestricts.Contains("D") Then
            Me.btnReports.Visible = False
            Me.mnuContext.Items("ОтчётыToolStripMenuItem").Visible = False
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        applyUserRestricts()
    End Sub

    Private Sub btnClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnotextActs.Click, btnClients.Click
        Main.ShowForm(My.Forms.frmClientsReference)
    End Sub

    Private Sub btnChooseReference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextReferences.Click, btnChooseReference.Click
        Main.ShowForm(My.Forms.frmChooseReference, True)
    End Sub

    Private Sub btnDocsActs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles АктыToolStripMenuItem.Click, btnActs.Click
        Main.ShowForm(My.Forms.frmDocActs)
    End Sub

    Private Sub btnConclusionsImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаключенияToolStripMenuItem.Click, btnConclusonsImport.Click
        Main.ShowForm(My.Forms.frmDocConclusionsImport)
    End Sub

    Private Sub btnConclusionsExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаключениявывозToolStripMenuItem.Click, btnConclusonsExport.Click
        Main.ShowForm(My.Forms.frmDocConclusionsExport)
    End Sub

    Private Sub btnConclusonsObjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusonsObjects.Click, ЗаключенияНаОбъектыToolStripMenuItem.Click
        Main.ShowForm(My.Forms.frmDocConclusionsObjects)
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыходToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub СменитьПарольToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СменитьПарольToolStripMenuItem.Click
        Main.ShowForm(My.Forms.frmChangePassword, True)
    End Sub

    Private Sub btnAgreements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgreements.Click, ДоговорыToolStripMenuItem.Click
        Main.ShowForm(My.Forms.frmDocAgreements)
    End Sub

    Private Sub btnBillsPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillsPre.Click, СчетаНаПредоплатуToolStripMenuItem.Click
        CMediator.Instance.SendMessage(New CCommandBillForm(False))
    End Sub

    Private Sub btnBillsPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillsPost.Click, СчетафактурыToolStripMenuItem.Click
        CMediator.Instance.SendMessage(New CCommandBillForm(True))
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click, ОтчётыToolStripMenuItem.Click
        Main.ShowForm(My.Forms.frmChooseReport)
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        Main.ShowForm(My.Forms.frmAbout, True)
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click, НастройкиToolStripMenuItem.Click
        Main.ShowForm(My.Forms.frmOptions, True)
    End Sub

    Private Sub btnExaminations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminations.Click, СвидетельстваЭкспертизыToolStripMenuItem.Click
        Main.ShowForm(My.Forms.frmDocConclusionsExamination)
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Main.OnMainFormClosing()
    End Sub
End Class
