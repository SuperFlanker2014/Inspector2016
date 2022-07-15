Imports System.ComponentModel

Public Class CAppForm
    Inherits System.Windows.Forms.Form
    Implements IForm

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        If keyData = Keys.Enter Then
            SendKeys.Send("{Tab}")
            Return True
        ElseIf keyData = (Keys.Enter Or Keys.Control) Then
            'keyData = (Keys.Enter Or Keys.Control)
            'SendKeys.Send("{Enter}")
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    Protected _billType As Boolean
    Protected Overridable Property billType() As Boolean
        Get
            Return _billType
        End Get
        Set(ByVal value As Boolean)
            _billType = value
        End Set
    End Property

    Protected _isTransacted As Boolean
    <Category("Misc"), _
     Browsable(True), _
     Editor("System.Windows.Forms.Design.UITypeEditor, System.Design", _
     GetType(System.Drawing.Design.UITypeEditor))> _
    Public Overridable Property isTransacted() As Boolean
        Get
            Return _isTransacted
        End Get
        Set(ByVal value As Boolean)
            _isTransacted = value
        End Set
    End Property

    Private Sub frmControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded
        e.Control.CausesValidation = False
        For Each c As Control In e.Control.Controls
            c.CausesValidation = False
            For Each c1 As Control In c.Controls
                c1.CausesValidation = False
                For Each c2 As Control In c1.Controls
                    c2.CausesValidation = False
                Next c2
            Next c1
        Next c
    End Sub

#Region "Перекрытые методы работы с документом"

    Public Overridable Sub newDocument(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Overridable Sub delDocument(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Overridable Sub saveDocument(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Overridable Sub findDocument(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Sub closeDocument()
        Me.Close()
    End Sub

#End Region

    Private Sub frmKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
        Handles MyBase.KeyDown
        If e.KeyCode = Keys.N And e.Control And Not isSearchMode And Not isNewDocMode Then
            newDocument(sender, New System.EventArgs())
        ElseIf e.KeyCode = Keys.D And e.Control And Not isSearchMode Then
            delDocument(sender, New System.EventArgs())
        ElseIf e.KeyCode = Keys.S And e.Control And Not isSearchMode Then
            saveDocument(sender, New System.EventArgs())
        ElseIf e.KeyCode = Keys.F And e.Control And Not isNewDocMode Then
            findDocument(sender, New System.EventArgs())
            'ElseIf e.KeyCode = Keys.Escape Then
            '    closeDocument()
        End If
    End Sub

    Public lstNewDocVisible As New ArrayList
    Public lstNewDocInVisible As New ArrayList
    Public lstNewDocDisabled As New ArrayList
    Public lstNewDocReadOnly As New ArrayList
    Public lstSearchVisible As New ArrayList
    Public lstSearchInVisible As New ArrayList
    Public lstSearchEnabled As New ArrayList
    Public lstEmptyFormDisabled As New ArrayList

    Public dtClients As DataTable
    Public WithEvents bsPrimary As BindingSource

    Protected _isNewDocMode As Boolean
    Public Property isNewDocMode() As Boolean
        Get
            Return _isNewDocMode
        End Get
        Set(ByVal value As Boolean)
            _isNewDocMode = value
            For Each ctrl As Object In lstNewDocVisible
                ctrl.Visible = value
            Next ctrl
            For Each ctrl As Object In lstNewDocInVisible
                ctrl.Visible = Not value
            Next ctrl
            For Each ctrl As Object In lstNewDocDisabled
                ctrl.Enabled = Not value
            Next ctrl
            For Each ctrl As Object In lstNewDocReadOnly
                ctrl.ReadOnly = Not value
            Next ctrl
        End Set
    End Property

    Protected _isSearchMode As Boolean
    Public Property isSearchMode() As Boolean
        Get
            Return _isSearchMode
        End Get
        Set(ByVal value As Boolean)
            _isSearchMode = value
            For Each ctrl As Object In lstSearchVisible
                ctrl.Visible = value
            Next ctrl
            For Each ctrl As Object In lstSearchInVisible
                ctrl.Visible = Not value
            Next ctrl
            If isEmptyForm Then
                For Each ctrl As Object In lstSearchEnabled
                    ctrl.Enabled = value
                Next ctrl
            End If
        End Set
    End Property

    Protected _isEmptyForm As Boolean
    Public Property isEmptyForm() As Boolean
        Get
            Return _isEmptyForm
        End Get
        Set(ByVal value As Boolean)
            _isEmptyForm = value
            For Each ctrl As Object In lstEmptyFormDisabled
                ctrl.Enabled = Not value
            Next ctrl
        End Set
    End Property

    Public Overridable Sub initializeControlLists()
    End Sub

    Private Sub frmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        initializeControlLists()
        Me.KeyPreview = True
        Me.isEmptyForm = True
    End Sub

    Private Sub bsDocs_Conclusions_Import_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles bsPrimary.PositionChanged
        If Me.bsPrimary.Position = -1 Then 'совсем пусто
            Me.isEmptyForm = True
            Me.dtClients.Clear()
        ElseIf Me.bsPrimary.Position <> -1 And Me.isEmptyForm Then
            Me.isEmptyForm = False
        End If
    End Sub

    Public Overridable Sub ExecuteCommand(ByRef Command As CCustomCommand) Implements IForm.ExecuteCommand
        'MustOverride
    End Sub

End Class
