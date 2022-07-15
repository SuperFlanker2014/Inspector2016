Partial Public Class Docs_Conclusions
    Partial Public Class Docs_Conclusions_ExaminationDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_ExaminationTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class

    Partial Public Class Docs_Acts_GoodsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_ConclusionsTableAdapters.Docs_Acts_GoodsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_Conclusions_ImportDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_ImportTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_Conclusions_ExportDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_ExportTableAdapter
            p.Connection = dbConnection
            Return p
        End Function

        Private Sub Docs_Conclusions_ExportDataTable_Docs_Conclusions_ExportRowChanging(ByVal sender As System.Object, ByVal e As Docs_Conclusions_ExportRowChangeEvent) Handles Me.Docs_Conclusions_ExportRowChanging

        End Sub

    End Class
    Partial Public Class Docs_Conclusions_KarantinDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_KarantinTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_Conclusions_NotKarantinDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_NotKarantinTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class

End Class

Namespace Docs_ConclusionsTableAdapters
    Partial Public Class Docs_Conclusions_ImportTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions.Docs_Conclusions_ImportDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Conclusions_Import WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_Conclusions_ExportTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions.Docs_Conclusions_ExportDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Conclusions_Export WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_Conclusions_ExaminationTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions.Docs_Conclusions_ExaminationDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Conclusions_Examination WHERE doc_id IN ({0})", doc_id_list)
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
        Public Function FillTable(ByVal dataTable As Docs_Conclusions.Docs_Acts_GoodsDataTable, ByVal doc_id_list As String) As Integer
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

    Partial Public Class Docs_Conclusions_KarantinTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions.Docs_Conclusions_KarantinDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Conclusions_Karantin WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_Conclusions_NotKarantinTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Conclusions.Docs_Conclusions_NotKarantinDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Conclusions_NotKarantin WHERE doc_id IN ({0})", doc_id_list)
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
