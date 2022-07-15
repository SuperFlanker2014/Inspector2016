Public Class CCustomCommand

End Class

Public Class CCommandFormAgreementNew
    Inherits CCustomCommand

    Public doc_agreement As Inspector.Docs_Payments.Docs_AgreementsRow
End Class

Public Class CCommandBillFormNewPre
    Inherits CCustomCommand

    Public doc_agreement_id As Integer
    Public doc_agreement_sum As Double
End Class

Public Class CCommandBillForm
    Inherits CCustomCommand

    Public bill_type As Boolean

    Public Sub New(ByVal bt As Boolean)
        bill_type = bt
    End Sub
End Class

Public Class CCommandBillFormOpen
    Inherits CCustomCommand

    Public bill_type As Boolean
    Public line_number As Integer

    Public Sub New(ByVal bt As Boolean, ByVal ln As Integer)
        bill_type = bt
        line_number = ln
    End Sub
End Class

Public Class CCommandBillFormNew
    Inherits CCustomCommand

    Public bill_type As Boolean
    Public guid1 As Guid
    Public inn As String
    Public fact_address As String
    Public agreement_doc_id As Integer

    Public Sub New(ByVal bt As Boolean, ByVal g As Guid, ByVal _inn As String, ByVal fa As String, ByVal adi As Integer)
        bill_type = bt
        guid1 = g
        inn = _inn
        fact_address = fa
        agreement_doc_id = adi
    End Sub
End Class

Public Class CCommandReviseAct
    Inherits CCustomCommand

    Public doc_id As Integer
    Public client_guid As Guid
    Public client_inn As Decimal

    Public Sub New(ByVal di As Integer, ByVal cg As Guid, ByVal ci As Decimal)
        doc_id = di
        client_guid = cg
        client_inn = ci
    End Sub
End Class

Public Class CCommandExamToIm
    Inherits CCustomCommand

    Public row As Inspector.Docs_Conclusions.Docs_Conclusions_ExaminationRow
    Public dsConclusions As Inspector.Docs_Conclusions

    Public Sub New(ByRef _row As Inspector.Docs_Conclusions.Docs_Conclusions_ExaminationRow, _
                    ByRef _dsConclusions As Inspector.Docs_Conclusions)
        row = _row
        dsConclusions = _dsConclusions
    End Sub

End Class

Public Class CCommandExamToEx
    Inherits CCustomCommand

    Public row As Inspector.Docs_Conclusions.Docs_Conclusions_ExaminationRow
    Public dsConclusions As Inspector.Docs_Conclusions

    Public Sub New(ByRef _row As Inspector.Docs_Conclusions.Docs_Conclusions_ExaminationRow, _
                    ByRef _dsConclusions As Inspector.Docs_Conclusions)
        row = _row
        dsConclusions = _dsConclusions
    End Sub

End Class

Public Class CCommandActToIm
    Inherits CCustomCommand

    Public row As Inspector.Documents.Docs_ActsRow
    Public dsDocuments As Inspector.Documents

    Public Sub New(ByRef _row As Inspector.Documents.Docs_ActsRow, _
                    ByRef _dsDocuments As Inspector.Documents)
        row = _row
        dsDocuments = _dsDocuments
    End Sub
End Class

Public Class CCommandActToEx
    Inherits CCustomCommand

    Public row As Inspector.Documents.Docs_ActsRow
    Public dsDocuments As Inspector.Documents

    Public Sub New(ByRef _row As Inspector.Documents.Docs_ActsRow, _
                    ByRef _dsDocuments As Inspector.Documents)
        row = _row
        dsDocuments = _dsDocuments
    End Sub
End Class

Public Class CCommandImToEx
    Inherits CCustomCommand

    Public row As Inspector.Docs_Conclusions.Docs_Conclusions_ImportRow
    Public dsDocs_Conclusions As Inspector.Docs_Conclusions

    Public Sub New(ByRef _row As Inspector.Docs_Conclusions.Docs_Conclusions_ImportRow, _
                    ByRef _dsDocs_Conclusions As Inspector.Docs_Conclusions)
        row = _row
        dsDocs_Conclusions = _dsDocs_Conclusions
    End Sub
End Class

Public Class CCommandImToExam
    Inherits CCustomCommand

    Public row As Inspector.Docs_Conclusions.Docs_Conclusions_ImportRow
    Public dsDocs_Conclusions As Inspector.Docs_Conclusions

    Public Sub New(ByRef _row As Inspector.Docs_Conclusions.Docs_Conclusions_ImportRow, _
                    ByRef _dsDocs_Conclusions As Inspector.Docs_Conclusions)
        row = _row
        dsDocs_Conclusions = _dsDocs_Conclusions
    End Sub
End Class

Public Class CCommandExToExam
    Inherits CCustomCommand

    Public row As Inspector.Docs_Conclusions.Docs_Conclusions_ExportRow
    Public dsDocs_Conclusions As Inspector.Docs_Conclusions

    Public Sub New(ByRef _row As Inspector.Docs_Conclusions.Docs_Conclusions_ExportRow, _
                    ByRef _dsDocs_Conclusions As Inspector.Docs_Conclusions)
        row = _row
        dsDocs_Conclusions = _dsDocs_Conclusions
    End Sub
End Class