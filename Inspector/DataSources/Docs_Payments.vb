
Partial Class Docs_Payments
    Partial Public Class R_clientsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_PaymentsTableAdapters.R_clientsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_AgreementsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_PaymentsTableAdapters.Docs_AgreementsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_BillsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_PaymentsTableAdapters.Docs_BillsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class Docs_Bills_ServicesDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_PaymentsTableAdapters.Docs_Bills_ServicesTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_services_unitsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.Docs_PaymentsTableAdapters.R_services_unitsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
End Class





Namespace Docs_PaymentsTableAdapters
    Partial Public Class Docs_AgreementsTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Payments.Docs_AgreementsDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Agreements WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_BillsTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Payments.Docs_BillsDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Bills WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
        Public Function FillTableByLine(ByVal dataTable As Docs_Payments.Docs_BillsDataTable, ByVal line_number_list As String) As Integer
            Dim sql As String = String.Format("SELECT * FROM Docs_Bills WHERE line_number IN ({0})", line_number_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
    End Class

    Partial Public Class Docs_Bills_ServicesTableAdapter
        Public Function FillTable(ByVal dataTable As Docs_Payments.Docs_Bills_ServicesDataTable, ByVal doc_id_list As String) As Integer
            Dim sql As String = String.Format("SELECT doc_id,bill_type,doc_line_number,service_title,line_number,rate,unit,[count],sum_factor,sum_factor_title FROM Docs_Bills_Services WHERE doc_id IN ({0})", doc_id_list)
            Me.Adapter.SelectCommand = New SqlClient.SqlCommand(sql)
            Me.Adapter.SelectCommand.Connection = Me.Connection
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
        Public Function FillTableByLine(ByVal dataTable As Docs_Payments.Docs_Bills_ServicesDataTable, ByVal line_number_list As String) As Integer
            Dim sql As String = String.Format("SELECT doc_id,bill_type,doc_line_number,service_title,line_number,rate,unit,[count],sum_factor,sum_factor_title,sum FROM Docs_Bills_Services WHERE doc_line_number IN ({0})", line_number_list)
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