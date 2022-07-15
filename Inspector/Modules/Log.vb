Imports System.Collections.Generic
Imports System.Text
Imports System.IO


Public Class Log
    Protected path As String
    Public Shared ReadOnly Property LogPath() As String
        Get
            Return instance1.path
        End Get
    End Property

    Private Shared [syncLock] As New Object()

    Private Shared instance1 As Log

    Protected Sub New(ByVal path As String)
        Me.path = path
    End Sub

    Protected Shared ReadOnly Property Instance()
        Get
            If instance1 Is Nothing Then
                instance1 = New Log(IO.Path.GetDirectoryName(Application.ExecutablePath) + "\Log.txt")
            End If

            Return instance1
        End Get
    End Property

    Public Shared Sub WriteToLog(ByVal message As String)
        ' Текущая дата
        Dim [date] As DateTime = DateTime.Now

        ' Имя файла-лога
        Dim fileName As String = Instance.LogPath()

        SyncLock [syncLock]
            ' Если файл существует
            If File.Exists(fileName) Then
                '' FIFO
                'Dim queue As New Queue(Of String)()
                'Using sr As New StreamReader(fileName, Encoding.[Default])
                '    Dim line As String
                '    While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
                '        queue.Enqueue(line)
                '    End While
                'End Using

                '' Удалить файл
                'File.Delete(fileName)

                '' Записать всё содержимое в файл
                'File.WriteAllLines(fileName, queue.ToArray(), Encoding.[Default])

                ' Дописать актуальное сообщение
                File.AppendAllText(fileName, String.Format("{0} {1}" & vbCr & vbLf, [date], message), Encoding.[Default])
            Else
                ' Записать строку в файл
                File.WriteAllText(fileName, String.Format("{0} {1}" & vbCr & vbLf, [date], message), Encoding.[Default])
            End If
        End SyncLock
    End Sub

    'Public Shared Function GetWholeText() As [String]
    '    If File.Exists(instance1.path) Then
    '        Dim queue As New Queue(Of String)()
    '        Using sr As New StreamReader(instance1.path, Encoding.[Default])
    '            Dim line As String
    '            While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
    '                queue.Enqueue(line)
    '            End While
    '        End Using
    '        Dim result As [String] = ""
    '        For Each str As [String] In queue.ToArray()
    '            result += str + ControlChars.Lf
    '        Next
    '        Return result
    '    Else
    '        Return ""
    '    End If
    'End Function
    'Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
    '    target = value
    '    Return value
    'End Function
End Class
