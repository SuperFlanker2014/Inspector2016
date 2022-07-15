Namespace ReportsTableAdapters
    Partial Public Class GetXMLTableAdapter
        Public Overridable Overloads Function FillNew(ByVal dataTable As Reports.GetXMLDataTable, ByVal date_begin As Global.System.Nullable(Of Date), ByVal date_end As Global.System.Nullable(Of Date), ByVal amplifyer_mod As Global.System.Nullable(Of Integer), ByVal division As String) As Integer
            Me.CommandCollection(0).CommandTimeout = 600
            Return Me.Fill(dataTable, date_begin, date_end, amplifyer_mod, division)
        End Function
    End Class
End Namespace

Partial Class Reports
End Class
