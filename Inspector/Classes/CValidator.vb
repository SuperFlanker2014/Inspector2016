Imports System
Imports System.Text.RegularExpressions

Public Class CValidator

    Public Shared Function ChaekInn(innString As String) As Boolean
        If (String.IsNullOrEmpty(innString) OrElse (innString.Length <> 10 AndAlso innString.Length <> 12)) Then
            Return False
        End If

        Dim inn As Long

        If (Not Long.TryParse(innString, inn)) Then
            Return False
        End If

        If (innString.Length = 10) Then

            Dim dgt10 As Integer = 0

            Try
                dgt10 = (((2 * Int32.Parse(innString.Substring(0, 1)) _
                        + 4 * Int32.Parse(innString.Substring(1, 1)) _
                        + 10 * Int32.Parse(innString.Substring(2, 1)) _
                        + 3 * Int32.Parse(innString.Substring(3, 1)) _
                        + 5 * Int32.Parse(innString.Substring(4, 1)) _
                        + 9 * Int32.Parse(innString.Substring(5, 1)) _
                        + 4 * Int32.Parse(innString.Substring(6, 1)) _
                        + 6 * Int32.Parse(innString.Substring(7, 1)) _
                        + 8 * Int32.Parse(innString.Substring(8, 1))) Mod 11) Mod 10)
            Catch
                Return False
            End Try

            If (Int32.Parse(innString.Substring(9, 1)) <> dgt10) Then
                Return False
            End If

        Else ' для физического лица
            Dim dgt11 As Integer = 0
            Dim dgt12 As Integer = 0

            Try
                dgt11 = (((
                        7 * Int32.Parse(innString.Substring(0, 1)) _
                        + 2 * Int32.Parse(innString.Substring(1, 1)) _
                        + 4 * Int32.Parse(innString.Substring(2, 1)) _
                        + 10 * Int32.Parse(innString.Substring(3, 1)) _
                        + 3 * Int32.Parse(innString.Substring(4, 1)) _
                        + 5 * Int32.Parse(innString.Substring(5, 1)) _
                        + 9 * Int32.Parse(innString.Substring(6, 1)) _
                        + 4 * Int32.Parse(innString.Substring(7, 1)) _
                        + 6 * Int32.Parse(innString.Substring(8, 1)) _
                        + 8 * Int32.Parse(innString.Substring(9, 1))) Mod 11) Mod 10)

                dgt12 = (((
                        3 * Int32.Parse(innString.Substring(0, 1)) _
                        + 7 * Int32.Parse(innString.Substring(1, 1)) _
                        + 2 * Int32.Parse(innString.Substring(2, 1)) _
                        + 4 * Int32.Parse(innString.Substring(3, 1)) _
                        + 10 * Int32.Parse(innString.Substring(4, 1)) _
                        + 3 * Int32.Parse(innString.Substring(5, 1)) _
                        + 5 * Int32.Parse(innString.Substring(6, 1)) _
                        + 9 * Int32.Parse(innString.Substring(7, 1)) _
                        + 4 * Int32.Parse(innString.Substring(8, 1)) _
                        + 6 * Int32.Parse(innString.Substring(9, 1)) _
                        + 8 * Int32.Parse(innString.Substring(10, 1))) Mod 11) Mod 10)

            Catch
                Return False
            End Try

            If (Int32.Parse(innString.Substring(10, 1)) <> dgt11 OrElse Int32.Parse(innString.Substring(11, 1)) <> dgt12) Then
                Return False
            End If
        End If
        Return True
    End Function

    Public Shared Function СheckKpp(kpp As String) As Boolean
        Return New Regex("\d{4}[\dA-Z][\dA-Z]\d{3}").IsMatch(kpp)
    End Function

End Class
