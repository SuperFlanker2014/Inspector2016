Partial Class Docs_Conclusions_Objects
    Partial Public Class Docs_Conclusions_ObjectsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_Conclusions_ObjectsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_CO_ObjectsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_CO_ObjectsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_COO_ExaminationsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_ExaminationsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_COO_KarantinDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_KarantinTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_COO_NotKarantinDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_NotKarantinTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
End Class

Namespace Docs_Conclusions_ObjectsTableAdapters
    Partial Public Class Docs_Conclusions_ObjectsTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions_Objects.Docs_Conclusions_ObjectsDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Conclusions_Objects WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_CO_ObjectsTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions_Objects.Docs_CO_ObjectsDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_CO_Objects WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_COO_KarantinTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions_Objects.Docs_COO_KarantinDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_COO_Karantin WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_COO_NotKarantinTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions_Objects.Docs_COO_NotKarantinDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_COO_NotKarantin WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_COO_ExaminationsTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions_Objects.Docs_COO_ExaminationsDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_COO_Examinations WHERE doc_id IN ({0})", doc_id_list)
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