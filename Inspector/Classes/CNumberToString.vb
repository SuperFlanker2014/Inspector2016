Public Class CNumberToString
    ' ������������� ����� �������� �� ������� �����.
    ' ��������� ����� ���� Currency �� ���� ��������� (�.� �� ~922 ���������� ������)
    ' ��� ������ ��������� ������� ������ 0, ����� ������ ����� ��������,
    ' ��� ������ ��������� ������� ������ 1, ������������� ����� ������ � ������

    Private Shared Skl As Byte

    Public Shared Function Num2Str(ByVal n As Decimal, Optional ByVal rub As Boolean = False, Optional ByVal m As Boolean = True) As String

        Dim s As String, R As String, K As String
        Dim t, u, v, w As Integer

        s = ""

        If n < 0 Then
            n = Math.Abs(n)
            s = "�����"
        End If
        '-----------------------------------------------------------------------------
        v = (n - Fix(n)) * 100 ' ����� ������
        w = Val(Right(Format(v), 1)) ' �������� ����� ������ ������

        n = Fix(n) ' ����� ����� ������
        t = Val(Right(Format(n), 2)) ' �������� ��� ��������� ����� ������
        u = Val(Right(t, 1)) ' �������� ����� ������ ������

        If t > 10 And t < 15 Then
            R = " ������" ' �������� ������� ��� ������
        ElseIf u = 1 Then
            R = " �����"
        ElseIf u > 1 And u < 5 Then
            R = " �����"
        Else
            R = " ������"
        End If

        If v > 10 And v < 15 Then
            K = " ������." ' �������� ������� ��� ������
        ElseIf w = 1 Then
            K = " �������"
        ElseIf w > 1 And w < 5 Then
            K = " �������"
        Else
            K = " ������"
        End If

        '-----------------------------------------------------------------------------
        If n > 1000000000000.0# Then
            s = AddStr(s, Num2Str2(Int(n / 1000000000000.0#), True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "��������")
                Case 1
                    s = AddStr(s, "���������")
                Case 2
                    s = AddStr(s, "����������")
            End Select
            n = n - Int(n / 1000000000000.0#) * 1000000000000.0#
        End If

        If n > 1000000000 Then
            s = AddStr(s, Num2Str2(Int(n / 1000000000), True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "��������")
                Case 1
                    s = AddStr(s, "���������")
                Case 2
                    s = AddStr(s, "����������")
            End Select
            n = n - Int(n / 1000000000) * 1000000000
        End If

        If n > 1000000 Then
            s = AddStr(s, Num2Str2(n \ 1000000, True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "�������")
                Case 1
                    s = AddStr(s, "��������")
                Case 2
                    s = AddStr(s, "���������")
            End Select
            n = n Mod 1000000
        End If

        If n > 1000 Then
            s = AddStr(s, Num2Str2(n \ 1000, True))
            Select Case Skl
                Case 0
                    s = AddStr(s, "������")
                Case 1
                    s = AddStr(s, "������")
                Case 2
                    s = AddStr(s, "�����")
            End Select
            n = n Mod 1000
        End If

        If n > 0 Then
            s = AddStr(s, Num2Str2(n, m))
        End If

        If s = "" Then
            s = "����"
        ElseIf s = "�����" Then
            s = s + " ����"
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
                Num2Str1 = "���"
            Case 200
                Num2Str1 = "������"
            Case 300
                Num2Str1 = "������"
            Case 400
                Num2Str1 = "���������"
            Case 500
                Num2Str1 = "�������"
            Case 600
                Num2Str1 = "��������"
            Case 700
                Num2Str1 = "�������"
            Case 800
                Num2Str1 = "���������"
            Case 900
                Num2Str1 = "���������"
            Case 11
                Num2Str1 = "�����������"
            Case 12
                Num2Str1 = "����������"
            Case 13
                Num2Str1 = "����������"
            Case 14
                Num2Str1 = "������������"
            Case 15
                Num2Str1 = "����������"
            Case 16
                Num2Str1 = "�����������"
            Case 17
                Num2Str1 = "����������"
            Case 18
                Num2Str1 = "������������"
            Case 19
                Num2Str1 = "������������"
            Case 20
                Num2Str1 = "��������"
            Case 30
                Num2Str1 = "��������"
            Case 40
                Num2Str1 = "�����"
            Case 50
                Num2Str1 = "���������"
            Case 60
                Num2Str1 = "����������"
            Case 70
                Num2Str1 = "���������"
            Case 80
                Num2Str1 = "�����������"
            Case 90
                Num2Str1 = "���������"
            Case 1
                Skl = 0
                If male Then
                    Num2Str1 = "����"
                Else
                    Num2Str1 = "����"
                End If
            Case 2
                Skl = 1
                If male Then
                    Num2Str1 = "���"
                Else
                    Num2Str1 = "���"
                End If
            Case 3
                Skl = 1
                Num2Str1 = "���"
            Case 4
                Skl = 1
                Num2Str1 = "������"
            Case 5
                Num2Str1 = "����"
            Case 6
                Num2Str1 = "�����"
            Case 7
                Num2Str1 = "����"
            Case 8
                Num2Str1 = "������"
            Case 9
                Num2Str1 = "������"
            Case 10
                Num2Str1 = "������"
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
        '���������� � ����� ��������
        Dim MyValue As Decimal

        If IsNumeric(MySumma) Then
            MyValue = CDec(MySumma)
            JS_Num2Str = Num2Str(MyValue, True)
        Else
            JS_Num2Str = "����� �� ������� !"
        End If
    End Function

End Class
