Public Class CNumberToString
    ' Представление числа прописью на русском языке.
    ' Поддержка чисел типа Currency во всем диапазоне (т.е до ~922 триллионов рублей)
    ' При втором аргументе функции равном 0, вывод только числа прописью,
    ' при втором аргументе функции равном 1, дополнительно вывод рублей и копеек

    Private Shared Skl As Byte

    Public Shared Function Num2Str(ByVal n As Decimal, Optional ByVal rub As Boolean = False, Optional ByVal m As Boolean = True) As String

        Dim s As String, R As String, K As String
        Dim t, u, v, w As Integer

        s = ""

        If n < 0 Then
            n = Math.Abs(n)
            s = "минус"
        End If
        '-----------------------------------------------------------------------------
        v = (n - Fix(n)) * 100 ' Число копеек
        w = Val(Right(Format(v), 1)) ' Получить число единиц копеек

        n = Fix(n) ' Целое число рублей
        t = Val(Right(Format(n), 2)) ' Получить две последние цифры рублей
        u = Val(Right(t, 1)) ' Получить число единиц рублей

        If t > 10 And t < 15 Then
            R = " рублей" ' Получить подпись для рублей
        ElseIf u = 1 Then
            R = " рубль"
        ElseIf u > 1 And u < 5 Then
            R = " рубля"
        Else
            R = " рублей"
        End If

        If v > 10 And v < 15 Then
            K = " копеек." ' Получить подпись для копеек
        ElseIf w = 1 Then
            K = " копейка"
        ElseIf w > 1 And w < 5 Then
            K = " копейки"
        Else
            K = " копеек"
        End If

        '-----------------------------------------------------------------------------
        If n > 1000000000000.0# Then
            s = AddStr(s, Num2Str2(Int(n / 1000000000000.0#), True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "триллион")
                Case 1
                    s = AddStr(s, "триллиона")
                Case 2
                    s = AddStr(s, "триллионов")
            End Select
            n = n - Int(n / 1000000000000.0#) * 1000000000000.0#
        End If

        If n > 1000000000 Then
            s = AddStr(s, Num2Str2(Int(n / 1000000000), True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "миллиард")
                Case 1
                    s = AddStr(s, "миллиарда")
                Case 2
                    s = AddStr(s, "миллиардов")
            End Select
            n = n - Int(n / 1000000000) * 1000000000
        End If

        If n > 1000000 Then
            s = AddStr(s, Num2Str2(n \ 1000000, True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "миллион")
                Case 1
                    s = AddStr(s, "миллиона")
                Case 2
                    s = AddStr(s, "миллионов")
            End Select
            n = n Mod 1000000
        End If

        If n > 1000 Then
            s = AddStr(s, Num2Str2(n \ 1000, True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "тысяча")
                Case 1
                    s = AddStr(s, "тысячи")
                Case 2
                    s = AddStr(s, "тысяч")
            End Select
            n = n Mod 1000
        End If

        If n > 0 Then
            s = AddStr(s, Num2Str2(n, m))
        End If

        If s = "" Then
            s = "ноль"
        ElseIf s = "минус" Then
            s = s + " ноль"
        End If

        Num2Str = StrConv(Mid(s, 1, 1), vbUpperCase) + Mid(s, 2, Len(s) - 1)
        If (rub) Then Num2Str = Num2Str & R & " " & Num2Str(v, False, False).ToString.ToLower & K

    End Function

    Private Shared Function Num2Str2(ByVal n As Decimal, ByVal male As Boolean) As String
        Dim s As String
        s = ""
        If n >= 100 Then
            s = Num2Str1(((n \ 100) * 100), male)
            n = n Mod 100
        End If
        If n >= 20 Then
            s = AddStr(s, Num2Str1(((n \ 10) * 10), male))
            n = n Mod 10
        End If
        Num2Str2 = AddStr(s, Num2Str1(n, male))
    End Function

    Private Shared Function Num2Str1(ByVal n As Decimal, ByVal male As Boolean) As String
        Skl = 2
        Select Case n
            Case 100
                Num2Str1 = "сто"
            Case 200
                Num2Str1 = "двести"
            Case 300
                Num2Str1 = "триста"
            Case 400
                Num2Str1 = "четыреста"
            Case 500
                Num2Str1 = "пятьсот"
            Case 600
                Num2Str1 = "шестьсот"
            Case 700
                Num2Str1 = "семьсот"
            Case 800
                Num2Str1 = "восемьсот"
            Case 900
                Num2Str1 = "девятьсот"
            Case 11
                Num2Str1 = "одиннадцать"
            Case 12
                Num2Str1 = "двенадцать"
            Case 13
                Num2Str1 = "тринадцать"
            Case 14
                Num2Str1 = "четырнадцать"
            Case 15
                Num2Str1 = "пятнадцать"
            Case 16
                Num2Str1 = "шестнадцать"
            Case 17
                Num2Str1 = "семнадцать"
            Case 18
                Num2Str1 = "восемнадцать"
            Case 19
                Num2Str1 = "девятнадцать"
            Case 20
                Num2Str1 = "двадцать"
            Case 30
                Num2Str1 = "тридцать"
            Case 40
                Num2Str1 = "сорок"
            Case 50
                Num2Str1 = "пятьдесят"
            Case 60
                Num2Str1 = "шестьдесят"
            Case 70
                Num2Str1 = "семьдесят"
            Case 80
                Num2Str1 = "восемьдесят"
            Case 90
                Num2Str1 = "девяносто"
            Case 1
                Skl = 0
                If male Then
                    Num2Str1 = "один"
                Else
                    Num2Str1 = "одна"
                End If
            Case 2
                Skl = 1
                If male Then
                    Num2Str1 = "два"
                Else
                    Num2Str1 = "две"
                End If
            Case 3
                Skl = 1
                Num2Str1 = "три"
            Case 4
                Skl = 1
                Num2Str1 = "четыре"
            Case 5
                Num2Str1 = "пять"
            Case 6
                Num2Str1 = "шесть"
            Case 7
                Num2Str1 = "семь"
            Case 8
                Num2Str1 = "восемь"
            Case 9
                Num2Str1 = "девять"
            Case 10
                Num2Str1 = "десять"
        End Select
    End Function

    Private Shared Function AddStr(ByVal S1 As String, ByVal S2 As String)
        If S1 = "" Then
            AddStr = S2
        ElseIf S2 = "" Then
            AddStr = S1
        Else
            AddStr = S1 + " " + S2
        End If
    End Function

    Private Shared Function JS_Num2Str(ByVal MySumma As Object)
        'Дополнение к Сумме прописью
        Dim MyValue As Decimal

        If IsNumeric(MySumma) Then
            MyValue = CDec(MySumma)
            JS_Num2Str = Num2Str(MyValue, True)
        Else
            JS_Num2Str = "Сумма не указана !"
        End If
    End Function

End Class
