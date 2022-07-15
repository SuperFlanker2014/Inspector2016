Partial Public Class H_Queries
    Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection) As Inspector.H_QueriesTableAdapters.H_QueriesTableAdapter
        Dim p As New Inspector.H_QueriesTableAdapters.H_QueriesTableAdapter
        p.Connection = dbConnection
        Return p
    End Function
End Class
