Public Class CMediator

    Private Shared med As CMediator = Nothing
    Public Shared ReadOnly Property Instance() As CMediator
        Get
            If med Is Nothing Then
                med = New CMediator()
            End If
            Return med
        End Get
    End Property

    Public Sub SendMessage(ByVal Command As CCustomCommand)
        For Each e As EFormList In [Enum].GetValues(GetType(EFormList))
            ModuleList.Item(e).ExecuteCommand(Command)
        Next e
    End Sub

End Class

Public Enum EFormList
    frmDocAgreements
    frmDocBills
    frmChooseReport
    frmDocConclusionsImport
    frmDocConclusionsExport
    frmDocConclusionsExamination
End Enum

Public Class ModuleList
    Public Shared ReadOnly Property Item(ByVal type As EFormList) As IForm
        Get
            Select Case type
                Case EFormList.frmDocBills
                    Return My.Forms.frmDocBills
                Case EFormList.frmDocAgreements
                    Return My.Forms.frmDocAgreements
                Case EFormList.frmChooseReport
                    Return My.Forms.frmChooseReport
                Case EFormList.frmDocConclusionsImport
                    Return My.Forms.frmDocConclusionsImport
                Case EFormList.frmDocConclusionsExport
                    Return My.Forms.frmDocConclusionsExport
                Case EFormList.frmDocConclusionsExamination
                    Return My.Forms.frmDocConclusionsExamination
                Case Else
                    Return Nothing
            End Select
        End Get
    End Property
End Class

Public Interface IForm
    Sub ExecuteCommand(ByRef Command As CCustomCommand)
End Interface


