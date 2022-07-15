

Partial Class Documents
    Partial Public Class Docs_ActsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.DocumentsTableAdapters.Docs_ActsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_Acts_GoodsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.DocumentsTableAdapters.Docs_Acts_GoodsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_clientsRow
        Implements IDisposable

        'Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
        '    MyBase.New(rb)
        'End Sub


        Private disposedValue As Boolean = False        ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: free other state (managed objects).
                End If

                ' TODO: free your own state (unmanaged objects).
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Class

Namespace DocumentsTableAdapters
    Partial Public Class Docs_ActsTableAdapter
        Public Function FillTable(ByVal dataTable As Documents.Docs_ActsDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Acts WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_Acts_GoodsTableAdapter
        Public Function FillTable(ByVal dataTable As Documents.Docs_Acts_GoodsDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Acts_Goods WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class
End Namespace
