Public Interface IFormWithCopyAndPrint
    Sub copy(ByVal sender As Object, ByVal e As System.EventArgs)
    Sub print(ByVal PrintOrPreview As PrintingType, ByVal AskParameters As Boolean, ByVal Count As Integer)
End Interface
