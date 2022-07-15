Imports System.ComponentModel
Imports System.Windows.Forms.Design
Imports System.Drawing
Imports System.Drawing.Design

Namespace My

    Partial Friend NotInheritable Class MySettings
        Private Sub MySettings_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) _
        Handles Me.PropertyChanged
            Select Case e.PropertyName
                Case "backColorText"
                    'frmDocActs
                    My.Forms.frmDocActs.dgvDocs_Acts_Goods.DefaultCellStyle.BackColor = My.Settings.backColorText
                    'frmDocConclusionsImport
                    My.Forms.frmDocConclusionsImport.dgvDocs_Acts_Goods.DefaultCellStyle.BackColor = My.Settings.backColorText
                    My.Forms.frmDocConclusionsImport.dgvDocs_Conclusions_Karantin.DefaultCellStyle.BackColor = My.Settings.backColorText
                    My.Forms.frmDocConclusionsImport.dgvDocs_Conclusions_NotKarantin.DefaultCellStyle.BackColor = My.Settings.backColorText
                    'frmDocConclusionsExport
                    My.Forms.frmDocConclusionsExport.dgvDocs_Acts_Goods.DefaultCellStyle.BackColor = My.Settings.backColorText
                    My.Forms.frmDocConclusionsExport.dgvDocs_Conclusions_Karantin.DefaultCellStyle.BackColor = My.Settings.backColorText
                    My.Forms.frmDocConclusionsExport.dgvDocs_Conclusions_NotKarantin.DefaultCellStyle.BackColor = My.Settings.backColorText
                Case "imageFile"
                    If System.IO.File.Exists(My.Settings.imageFile) Then
                        Try
                            My.Forms.frmMain.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.imageFile)
                        Catch
                            My.Forms.frmMain.BackgroundImage = Nothing
                        End Try
                    Else
                        My.Forms.frmMain.BackgroundImage = Nothing
                    End If
            End Select
        End Sub

    End Class

    Class MySettingsWrapper

        Private Shared defaultInstance As MySettingsWrapper = New MySettingsWrapper

        Public Shared ReadOnly Property [Default]() As MySettingsWrapper
            Get
                Return defaultInstance
            End Get
        End Property

        Public Sub Reload()
            My.Settings.Reload()
        End Sub

        Public Sub Save()
            My.Settings.Save()
        End Sub

        <DisplayName("��������")> _
        <Description("���� �������� �����")> _
        <Category("1. �����")> _
        Public Property backColorControl() As Color
            Get
                Return My.Settings.backColorControl
            End Get
            Set(ByVal value As Color)
                My.Settings.backColorControl = value
            End Set
        End Property

        <DisplayName("���� ������")> _
        <Description("���� ���� ������ � �������� � ����� �����")> _
        <Category("1. �����")> _
        Public Property backColorText() As Color
            Get
                Return My.Settings.backColorText
            End Get
            Set(ByVal value As Color)
                My.Settings.backColorText = value
            End Set
        End Property

        <DisplayName("�������")> _
        <Description("���� �������� � ��������")> _
        <Category("1. �����")> _
        Public Property backgroundColor() As Color
            Get
                Return My.Settings.backgroundColor
            End Get
            Set(ByVal value As Color)
                My.Settings.backgroundColor = value
            End Set
        End Property

        <DisplayName("������")> _
        <Description("���� ������ � �������� � ����� �����")> _
        <Category("1. �����")> _
        <[ReadOnly](True)> _
        Public Property textColor() As Color
            Get
                Return My.Settings.textColor
            End Get
            Set(ByVal value As Color)
                My.Settings.textColor = value
            End Set
        End Property

        <DisplayName("��� �����")> _
        <Description("���� � ��������� ��� ����������� � ������� �����")> _
        <Category("2. ��������")> _
        <Editor(GetType(JpgFileEditor), GetType(UITypeEditor))> _
        Public Property imageFile() As String
            Get
                Return My.Settings.imageFile
            End Get
            Set(ByVal value As String)
                My.Settings.imageFile = value
            End Set
        End Property

    End Class

    Class JpgFileEditor
        Inherits FileNameEditor
        Protected Overrides Sub InitializeDialog(ByVal ofd As OpenFileDialog)
            ofd.CheckFileExists = False
            ofd.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*"
        End Sub
    End Class

End Namespace

Public Class settings
    Public Shared ReadOnly Property DBConnectionString() As String
        Get
            Return My.Settings.DBConnectionString
        End Get
    End Property
End Class
