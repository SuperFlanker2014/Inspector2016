Imports System.Collections
Imports System.Collections.Specialized
Imports System.Collections.Generic

Public Enum PrintingType
    PrintDocument
    PreviewDocument
End Enum

Public Enum DocumentType
    Agreement
    ConclusionExamination
    ConclusionImport
    ConclusionExport
    ConclusionObjects
    BillsPre
    BillsPreAdd
    BillsPost
    BillsPostAdd
    Act
End Enum

Public Class Printing

    Private Shared LastError As String = ""
    Private Shared ReadOnly Property org() As References.R_inspectionRow
        Get
            Return Main.dsReferenses.R_inspection.Rows(0)
        End Get
    End Property

    Public Shared Sub print(ByVal DocType As DocumentType, _
                            ByVal PrintOrPreview As PrintingType, _
                            ByVal AskParameters As Boolean, _
                            ByVal Count As Integer, _
                            ByRef Row As DataRow)

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim report As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing

        'копирование записи
        Dim ds As DataSet = Row.Table.DataSet.Clone()
        For Each dr As DataRelation In Row.Table.ParentRelations
            Dim parentRow As DataRow = Row.GetParentRow(dr.RelationName)
            ds.Tables(dr.ParentTable.TableName).Rows.Add(parentRow.ItemArray)
            For Each dr1 As DataRelation In dr.ParentTable.ParentRelations
                Dim parentRow1 As DataRow = parentRow.GetParentRow(dr1.RelationName)
                ds.Tables(dr1.ParentTable.TableName).Rows.Add(parentRow1.ItemArray)
            Next dr1
        Next dr

        Dim NewRow As DataRow = ds.Tables(Row.Table.TableName).Rows.Add(Row.ItemArray)

        For Each dr As DataRelation In Row.Table.ChildRelations
            Dim childRows As DataRow() = Row.GetChildRows(dr.RelationName)
            For Each cr As DataRow In childRows
                ds.Tables(dr.ChildTable.TableName).Rows.Add(cr.ItemArray)
                For Each dr1 As DataRelation In dr.ChildTable.ChildRelations
                    Dim childRows1 As DataRow() = cr.GetChildRows(dr1.RelationName)
                    For Each cr1 As DataRow In childRows1
                        ds.Tables(dr1.ChildTable.TableName).Rows.Add(cr1.ItemArray)
                    Next cr1
                Next dr1
            Next cr
        Next dr

        Try
            Select Case DocType
                Case DocumentType.Agreement
                    report = GetAgreementReport(NewRow)
                Case DocumentType.BillsPre
                    report = GetBillsPreReport(NewRow)
                Case DocumentType.BillsPreAdd
                    report = GetBillsPreAddReport(NewRow)
                Case DocumentType.BillsPost
                    report = GetBillsPostReport(NewRow)
                Case DocumentType.BillsPostAdd
                    report = GetBillsPostAddReport(NewRow)
                Case DocumentType.Act
                    report = GetActReport(NewRow)
                Case DocumentType.ConclusionObjects
                    report = GetConclutionObjectsReport(NewRow)
                Case DocumentType.ConclusionExport
                    report = GetConclutionExportReport(NewRow)
                Case DocumentType.ConclusionImport
                    report = GetConclutionImportReport(NewRow)
                Case DocumentType.ConclusionExamination
                    report = GetConclutionExamination(NewRow)
            End Select
        Catch ex As Exception
            LastError = "Ошибка: " + DocType.ToString() + "; " + Microsoft.VisualBasic.Constants.vbCrLf + _
                        "Текст ошибки: " + ex.ToString() + "; " + ex.Message
        End Try

        Windows.Forms.Cursor.Current = Cursors.Arrow
        If (report Is Nothing) Or (LastError <> "") Then
            MessageBox.Show(LastError, "Ошибка при формировании документа", MessageBoxButtons.OK, _
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            LastError = ""
            Exit Sub
        Else
            _print(report, PrintOrPreview, AskParameters, Count)
        End If

    End Sub

    Private Shared Sub _print(ByRef source As CrystalDecisions.CrystalReports.Engine.ReportDocument, _
                              ByVal PrintOrPreview As PrintingType, _
                              ByVal AskParameters As Boolean, _
                              ByVal Count As Integer)
        My.Forms.frmPrinting.reportViewer.ReportSource = source
        If PrintOrPreview = PrintingType.PrintDocument Then
            My.Forms.frmPrinting.print(Count, Not AskParameters)
        Else
            My.Forms.frmPrinting.ShowDialog()
        End If
        source.Close()
        source.Dispose()
    End Sub

    Private Shared Function GetAgreementReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Agreements

        rd.SetDataSource(Row.Table.DataSet)

        Dim client As DataRow = Row.Table.DataSet.Tables("R_clients").Rows(0)
        Dim client_bank As References.R_banksRow

        If (client.Item("client_bank_bik") Is DBNull.Value) OrElse (CType(client.Item("client_bank_bik"), Double) = 100000000) Then
            client_bank = Nothing

            rd.SetParameterValue("client_bank_corr_account", "")
            rd.SetParameterValue("client_bank_account", "")
            rd.SetParameterValue("client_bank_bik", "")
            rd.SetParameterValue("client_bank", "")
        Else
            client_bank = Main.dsReferenses.R_banks.FindBybank_bik(client.Item("client_bank_bik"))

            rd.SetParameterValue("client_bank_corr_account", client_bank.bank_corr_acc)
            rd.SetParameterValue("client_bank_account", client.Item("client_bank_account"))
            rd.SetParameterValue("client_bank_bik", client("client_bank_bik"))
            rd.SetParameterValue("client_bank", client_bank.bank_title)
        End If

        rd.SetParameterValue("doc_id", Int(Row.Item("doc_id")))
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())
        rd.SetParameterValue("org_title", org.title)
        rd.SetParameterValue("org_title_short", org.title_short)
        rd.SetParameterValue("org_telephone", org.telephone)
        rd.SetParameterValue("org_email", org.email)
        rd.SetParameterValue("org_ogrn", org.ogrn)
        rd.SetParameterValue("org_oktmo", org.oktmo)
        rd.SetParameterValue("org_adress", org.adress)
        rd.SetParameterValue("org_region_number", org.region_number)
        rd.SetParameterValue("user_division", Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division)
        rd.SetParameterValue("org_inn", org.inn)
        rd.SetParameterValue("org_kpp", org.kpp)
        rd.SetParameterValue("org_bank", org.bank_title)
        rd.SetParameterValue("org_payment_adressee", org.payment_adressee)
        rd.SetParameterValue("doc_year", Year(Row.Item("doc_date")))
        rd.SetParameterValue("org_bank_saccount", org.bank_saccount)
        rd.SetParameterValue("org_bank_caccount", org.bank_caccount)
        rd.SetParameterValue("org_director_short", Main.getShortForFIO(org.director))
        rd.SetParameterValue("org_bank_bik", org.bank_bik)
        rd.SetParameterValue("org_okato", org.okato)
        rd.SetParameterValue("org_kbk", org.bank_kbk)
        rd.SetParameterValue("org_payment_type", org.payment_type)

        rd.SetParameterValue("org_agreement", org.agreement)

        Return rd
    End Function

    Private Shared Function GetBillsPreReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Bills_Pre

        Dim taBills As New Docs_PaymentsTableAdapters.Docs_BillsTableAdapter()

        Dim client As DataRow = Row.Table.DataSet.Tables("R_clients").Rows(0)
        Dim bank As String = ""
        Dim client_bank As References.R_banksRow
        If (client.Item("client_bank_bik") Is DBNull.Value) OrElse _
           (CType(client.Item("client_bank_bik"), Double) = 100000000) Then
            client_bank = Nothing
            bank = ""
        Else
            client_bank = Main.dsReferenses.R_banks.FindBybank_bik(client.Item("client_bank_bik"))
            bank = String.Format("счёт {0} в {1} г. {2} БИК {3} к/с {4}", _
                client("client_bank_account"), _
                client_bank.bank_title, _
                client_bank.bank_city, _
                client_bank.bank_bik, _
                client_bank.bank_corr_acc)
        End If

        rd.SetDataSource(Row.Table.DataSet)

        rd.SetParameterValue("bank", bank)

        rd.SetParameterValue("line_number", Row.Item("line_number"))
        rd.SetParameterValue("sum_without_nds", _
            Math.Round(taBills.GetSumByLineWithoutNDS(Row.Item("line_number")), 2))
        rd.SetParameterValue("bill_number", org.region_number.ToString + "/" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "/" + _
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())

        rd.SetParameterValue("org_director", Main.getShortforFIO(org.director))
        rd.SetParameterValue("org_buch", Main.getShortforFIO(org.accountant))

        rd.SetParameterValue("org_title", org.title)
        rd.SetParameterValue("org_adress", org.adress)
        rd.SetParameterValue("org_telephone", org.telephone)

        rd.SetParameterValue("org_account", org.bank_saccount)
        rd.SetParameterValue("org_bank_bik", org.bank_bik)
        Try
            rd.SetParameterValue("org_bank_account", org.bank_caccount)
        Catch ex As StrongTypingException
            rd.SetParameterValue("org_bank_account", "")
        End Try
        rd.SetParameterValue("org_payment_target", org.payment_target)
        rd.SetParameterValue("org_bank", org.bank_title)
        rd.SetParameterValue("org_inn", org.inn)
        rd.SetParameterValue("org_kpp", org.kpp)
        rd.SetParameterValue("org_adressee", org.payment_adressee)
        rd.SetParameterValue("org_kbk", org.kbk)
        rd.SetParameterValue("org_okato", org.okato)

        rd.SetParameterValue("string_sum", CNumberToString.Num2Str(Row.Item("doc_sum"), True))

        Return rd
    End Function

    Private Shared Function GetBillsPreAddReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Bills_Pre_add

        rd.SetDataSource(Row.Table.DataSet)

        rd.SetParameterValue("line_number", Row.Item("line_number"))
        rd.SetParameterValue("org_title", org.title)
        rd.SetParameterValue("org_director", Main.getGenetiveForFIO(org.director))
        rd.SetParameterValue("doc_number", org.region_number.ToString + "/" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "/" + _
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("agreement_note", org.agreement_note)
        rd.SetParameterValue("string_sum", CNumberToString.Num2Str(Row.Item("doc_sum"), True))

        Return rd
    End Function

    Private Shared Function GetBillsPostReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Bills_Post

        Dim tblUnits As Docs_Payments.R_services_unitsDataTable = Row.Table.DataSet.Tables("R_services_units")
        Dim taUnits As Object = tblUnits.GetAdapter(Main.dbConnection)
        taUnits.Fill(tblUnits)

        Dim taBills As New Docs_PaymentsTableAdapters.Docs_BillsTableAdapter()
        rd.SetDataSource(Row.Table.DataSet)

        rd.SetParameterValue("line_number", Row.Item("line_number"))
        rd.SetParameterValue("sum_without_nds", Math.Round(taBills.GetSumByLineWithoutNDS(Row.Item("line_number")), 2))
        rd.SetParameterValue("bill_number",
            org.region_number.ToString + "/" +
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "/" +
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())

        rd.SetParameterValue("org_director", Main.getShortforFIO(org.director))
        rd.SetParameterValue("org_buch", Main.getShortforFIO(org.accountant))

        rd.SetParameterValue("org_title", org.title)
        rd.SetParameterValue("org_title_short", org.title_short)
        rd.SetParameterValue("org_adress", org.adress)
        rd.SetParameterValue("org_inn", org.inn)
        rd.SetParameterValue("org_kpp", org.kpp)
        rd.SetParameterValue("org_adressee", org.addressee + ", " + org.adress)
        rd.SetParameterValue("org_region_number", org.region_number)
        rd.SetParameterValue("user_division", Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division)

        'rd.SetParameterValue("string_sum", CNumberToString.Num2Str(Row.Item("doc_sum"), True))

        Return rd
    End Function

    Private Shared Function GetBillsPostAddReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Bills_Post_add

        Dim taBills As New Docs_PaymentsTableAdapters.Docs_BillsTableAdapter()
        rd.SetDataSource(Row.Table.DataSet)

        rd.SetParameterValue("line_number", Row.Item("line_number"))
        rd.SetParameterValue("sum_without_nds", _
            Math.Round(taBills.GetSumByLineWithoutNDS(Row.Item("line_number")), 2))
        rd.SetParameterValue("bill_number", org.region_number.ToString + "/" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "/" + _
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())

        rd.SetParameterValue("org_director", Main.getShortforFIO(org.director))
        rd.SetParameterValue("org_buch", Main.getShortforFIO(org.accountant))

        rd.SetParameterValue("org_title", org.title)
        rd.SetParameterValue("org_adress", org.adress)

        rd.SetParameterValue("string_sum", CNumberToString.Num2Str(Row.Item("doc_sum"), True))
        rd.SetParameterValue("string_sum_nds", CNumberToString.Num2Str(Convert.ToDouble(Row.Item("doc_sum")) - _
            Math.Round(taBills.GetSumByLineWithoutNDS(Row.Item("line_number")), 2), True))

        Return rd
    End Function

    Private Shared Function GetActReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Act

        rd.SetDataSource(Row.Table.DataSet)
        AddOrgData(rd)

        rd.SetParameterValue("doc_num", org.region_number.ToString + "-" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "-" + _
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("doc_id", Int(Row.Item("doc_id")))
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())
        rd.SetParameterValue("specialist", Row.Item("doc_user"))

        Return rd
    End Function

    Private Shared Function GetConclutionObjectsReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Conclusion_Objects

        rd.SetDataSource(Row.Table.DataSet)
        AddOrgData(rd)

        rd.SetParameterValue("doc_id", Int(Row.Item("doc_id")))
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())
        rd.SetParameterValue("specialist", Main.getAblativeForFIO(Row.Item("doc_user")))
        rd.SetParameterValue("specialist1", Main.getShortforFIO(Row.Item("doc_user")))
        rd.SetParameterValue("doc_num", org.region_number.ToString + "-" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "-" + _
            Row.Item("doc_number").ToString)

        Return rd
    End Function

    Private Shared Function GetConclutionImportReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Conclusion_Import_New

        'считаем строки обнаруженных карантинных
        Dim strKarantin As String = _
            pestDetected(Row.Table.DataSet.Tables("Docs_Conclusions_Karantin").Rows, Row.Item("doc_id"))

        'считаем строки обнаруженных некарантинных
        Dim strNotKarantin As String = _
            pestDetected(Row.Table.DataSet.Tables("Docs_Conclusions_NotKarantin").Rows, Row.Item("doc_id"))

        rd.SetDataSource(Row.Table.DataSet)
        AddOrgData(rd)

        rd.SetParameterValue("doc_num", org.region_number.ToString + "-" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "-" + _
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("doc_id", Int(Row.Item("doc_id")))
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())
        'в новом формате не нужны
        rd.SetParameterValue("specialist", Main.getShortForFIO(Row.Item("doc_user")))
        'rd.SetParameterValue("arrived_from", Main.dsReferenses.R_countries_and_regions.FindBycountry_title(Row.Item("arrived")).country_in)
        rd.SetParameterValue("karantin_detected", strKarantin)
        rd.SetParameterValue("notkarantin_detected", strNotKarantin)

        'для нового формата
        Dim titles As String = getFieldList(Row.Table.DataSet.Tables("Docs_Acts_Goods").Rows, Row.Item("doc_id"), "{0}", "good_title")
        Dim countries As String = getFieldList(Row.Table.DataSet.Tables("Docs_Acts_Goods").Rows, Row.Item("doc_id"), "{0}", "production_country")
        Dim weights As String = getFieldList(Row.Table.DataSet.Tables("Docs_Acts_Goods").Rows, Row.Item("doc_id"), "{0} {1} - {2} {3}", "places", "places_unit", "weight", "weight_unit")

        rd.SetParameterValue("good_titles", titles)
        rd.SetParameterValue("production_countries", countries)
        rd.SetParameterValue("places_weights", weights)

        Return rd
    End Function

    Private Shared Function GetConclutionExportReport(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Conclusion_Export_New

        'считаем строки обнаруженных карантинных
        Dim strKarantin As String = _
            pestDetected(Row.Table.DataSet.Tables("Docs_Conclusions_Karantin").Rows, Row.Item("doc_id"))

        'считаем строки обнаруженных некарантинных
        Dim strNotKarantin As String = _
            pestDetected(Row.Table.DataSet.Tables("Docs_Conclusions_NotKarantin").Rows, Row.Item("doc_id"))

        rd.SetDataSource(Row.Table.DataSet)
        AddOrgData(rd)

        rd.SetParameterValue("doc_num", org.region_number.ToString + "-" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "-" + _
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("doc_id", Int(Row.Item("doc_id")))
        rd.SetParameterValue("doc_date", CDate(Row.Item("doc_date")).ToString("«d» MMMM yyyy г.")) 'Row.Item("doc_date").ToLongDateString())
        rd.SetParameterValue("specialist", Main.getShortForFIO(Row.Item("doc_user")))
        rd.SetParameterValue("karantin_detected", strKarantin)
        rd.SetParameterValue("notkarantin_detected", strNotKarantin)

        'для нового формата
        Dim titles As String = getFieldList(Row.Table.DataSet.Tables("Docs_Acts_Goods").Rows, Row.Item("doc_id"), "{0}", "good_title")
        Dim countries As String = getFieldList(Row.Table.DataSet.Tables("Docs_Acts_Goods").Rows, Row.Item("doc_id"), "{0}", "production_country")
        Dim weights As String = getFieldList(Row.Table.DataSet.Tables("Docs_Acts_Goods").Rows, Row.Item("doc_id"), "{0} {1} - {2} {3}", "places", "places_unit", "weight", "weight_unit")

        'good_title, production_country, places, places_unit, weight, weight_unit

        rd.SetParameterValue("good_titles", titles)
        rd.SetParameterValue("production_countries", countries)
        rd.SetParameterValue("places_weights", weights)

        Return rd
    End Function

    Private Shared Function GetConclutionExamination(ByRef Row As DataRow) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rd As New Docs_Conclusion_Examination

        rd.SetDataSource(Row.Table.DataSet)
        AddOrgData(rd)

        Dim e As String = Exams( _
        Row.Table.DataSet.Tables("Docs_Conclusions_Karantin").Rows, _
        Row.Table.DataSet.Tables("Docs_Conclusions_NotKarantin").Rows, _
        Convert.ToInt32(Row.Item("doc_id")))

        rd.SetParameterValue("doc_num", org.region_number.ToString + "-" + _
            Main.dsReferenses.R_users.FindByuser_name(Row.Item("doc_user")).user_division + "-" + _
            Row.Item("doc_number").ToString)
        rd.SetParameterValue("doc_id", Int(Row.Item("doc_id")))
        rd.SetParameterValue("doc_date", Row.Item("doc_date").ToLongDateString())
        rd.SetParameterValue("specialist1", Main.getShortForFIO(Row.Item("doc_user")))
        rd.SetParameterValue("exams", e)
        rd.SetParameterValue("director_div_karantin", Main.getShortForFIO(org.director_div_karantin))

        Return rd
    End Function

    'вставка реквизитов организации
    Private Shared Sub AddOrgData(ByVal report As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim fields() As String = New String() {"title", "adress", "telephone", "fax", "delegation_order"}

        For Each str As String In fields
            Try
                report.SetParameterValue("org_" + str, org(str))
            Catch ex As Exception

            End Try
        Next str
    End Sub

    'компаратор для pest в заключениях
    Private Class pestComparer
        Implements IComparer(Of pest)
        Public Function Compare(ByVal x As pest, ByVal y As pest) As Integer Implements System.Collections.Generic.IComparer(Of pest).Compare
            If (x.good > y.good) Or _
               (x.good = y.good And x.group > y.group) Or _
               (x.good = y.good And x.group = y.group And x.title > y.title) Then
                Return 1
            ElseIf (x.good = y.good And x.group = y.group And x.title = y.title) Then
                Return 0
            Else
                Return -1
            End If
        End Function
    End Class
    'компаратор для pest в свидетельствах
    Private Class pestComparerExams
        Implements IComparer(Of pest)
        Public Function Compare(ByVal x As pest, ByVal y As pest) As Integer Implements System.Collections.Generic.IComparer(Of pest).Compare
            If (x.examination > y.examination) Or _
               (x.examination = y.examination And x.good > y.good) Or _
               (x.examination = y.examination And x.good = y.good And x.group > y.group) Or _
               (x.examination = y.examination And x.good = y.good And x.group = y.group And x.title > y.title) Then
                Return 1
            ElseIf (x.examination = y.examination And x.good = y.good And x.group = y.group And x.title = y.title) Then
                Return 0
            Else
                Return -1
            End If
        End Function
    End Class
    'строковые функции для печати
    Private Structure pest
        Dim group As String
        Dim good As String
        Dim title As String
        Dim title_latin As String
        Dim state As String
        Dim count As String
        Dim examination As String
    End Structure

    Private Shared Function pestDetected(ByRef rows As System.Data.DataRowCollection, ByVal doc_id As Integer) As String

        Dim list As List(Of pest) = New List(Of pest)
        For Each row As DataRow In rows
            If row("doc_id") = doc_id Then
                Dim s As New pest()

                Dim r As DataRow
                If row.GetType().Name = "Docs_Conclusions_NotKarantinRow" Then
                    r = Main.dsReferenses.R_notkarantin.FindByobject_title(row("object_title"))
                    s.count = ""
                    s.title_latin = r("object_title_latin").ToString()
                Else 'Docs_Conclusions_KarantinRow
                    r = Main.dsReferenses.R_karantin.FindByobject_title(row("object_title"))
                    s.count = row("count").ToString() + " " + row("count_unit")
                    s.title_latin = r("object_title_latin").ToString()
                End If

                s.group = r("group_title")
                s.good = row("good_title")
                s.title = row("object_title")
                s.state = row.Item("state").ToString()

                list.Add(s)
            End If
        Next row

        Dim strPests As String = ""

        If list.Count > 0 Then
            list.Sort(New pestComparer())

            Dim last_state As New pest()
            last_state.good = list(0).good
            For Each p As pest In list
                Dim block As String = ""

                Dim dot As String = "; "
                If p.good <> last_state.good Then
                    block += " - " + last_state.good.ToUpper() + dot
                    dot = ""
                End If
                If p.group <> last_state.group Then
                    block += dot + p.group + ": " + p.title
                Else
                    block += ", " + p.title
                End If

                If (p.title_latin <> "") Then
                    block += " " + p.title_latin
                End If
                If (p.count <> "") And (p.state = "") Then
                    block += " (" + p.count + ")"
                ElseIf (p.count <> "") And (p.state <> "") Then
                    block += " (" + p.state + " " + p.count + ")"
                ElseIf (p.count = "") And (p.state <> "") Then
                    block += " (" + p.state + ")"
                End If

                strPests += block
                last_state = p
            Next p
            strPests += " - " + last_state.good.ToUpper() + "; "
            strPests = strPests.Substring(2)
        End If

        Return strPests
    End Function

    Private Shared Function Exams(ByRef karatnin_rows As System.Data.DataRowCollection, _
                                  ByRef notkarantin_rows As System.Data.DataRowCollection, _
                                  ByVal doc_id As Integer) As String

        Dim list As List(Of pest) = New List(Of pest)

        For Each row As DataRow In karatnin_rows
            If row("doc_id") = doc_id Then
                Dim s As New pest()

                Dim r As DataRow = Main.dsReferenses.R_karantin.FindByobject_title(row("object_title"))
                s.count = row("count").ToString() + " " + row("count_unit")
                s.title_latin = r("object_title_latin").ToString()
                s.group = r("group_title")
                s.good = row("good_title")
                s.title = row("object_title")
                s.state = row("state").ToString()
                s.examination = r("examination").ToString()

                list.Add(s)
            End If
        Next row

        For Each row As DataRow In notkarantin_rows
            If row("doc_id") = doc_id Then
                Dim s As New pest()

                Dim r As DataRow = Main.dsReferenses.R_notkarantin.FindByobject_title(row("object_title"))
                s.count = ""
                s.title_latin = r("object_title_latin").ToString()
                s.group = r("group_title")
                s.good = row("good_title")
                s.title = row("object_title")
                s.state = row("state").ToString()
                s.examination = r("examination").ToString()

                list.Add(s)
            End If
        Next row

        Dim strPests As String = ""
        Dim first_exam As String = ""
        'если есть вредители
        If list.Count > 0 Then
            list.Sort(New pestComparerExams())

            'Инициализация
            Dim last_state As New pest()
            last_state = list(0)
            strPests += last_state.examination + ": " + last_state.group + ": " + last_state.title + " " + last_state.title_latin
            If (last_state.count <> "") And (last_state.state = "") Then
                strPests += " (" + last_state.count + ")"
            ElseIf (last_state.count <> "") And (last_state.state <> "") Then
                strPests += " (" + last_state.state + " " + last_state.count + ")"
            ElseIf (last_state.count = "") And (last_state.state <> "") Then
                strPests += " (" + last_state.state + ")"
            End If
            first_exam = last_state.examination
            list.RemoveAt(0)

            'цикл по остальным
            For Each p As pest In list
                Dim block As String = ""

                If p.examination <> last_state.examination Then
                    block += " - " + last_state.good.ToUpper() + "; " + vbCrLf + p.examination + ": "
                Else
                    If p.good <> last_state.good Then
                        block += " - " + last_state.good.ToUpper() + "; "
                    End If
                End If

                If p.group <> last_state.group Then
                    If (p.good = last_state.good) And (p.examination = last_state.examination) Then
                        block += "; "
                    End If
                    block += p.group + ": " + p.title
                Else
                    block += ", " + p.title
                End If

                If (p.title_latin <> "") Then
                    block += " " + p.title_latin
                End If
                If (p.count <> "") And (p.state = "") Then
                    block += " (" + p.count + ")"
                ElseIf (p.count <> "") And (p.state <> "") Then
                    block += " (" + p.state + " " + p.count + ")"
                ElseIf (p.count = "") And (p.state <> "") Then
                    block += " (" + p.state + ")"
                End If

                strPests += block
                last_state = p
            Next p
            strPests += " - " + last_state.good.ToUpper() + "; "
            'strPests = strPests.Substring(2)
        End If

        'теперь добавляем к тексту те экспертизы, которые проводились, но не было ничего ими обнаружено
        Dim taDocExaminations As New Docs_ConclusionsTableAdapters.DocExaminationsTableAdapter()
        Dim table As Docs_Conclusions.DocExaminationsDataTable = taDocExaminations.GetExams(doc_id)

        For Each row As Docs_Conclusions.DocExaminationsRow In table.Rows
            Dim containsExam As Boolean = False

            If row.examination.ToLower() = first_exam.ToLower() Then
                containsExam = True
            End If
            For Each element As pest In list
                If row.examination.ToLower() = element.examination.ToLower() Then
                    containsExam = True
                    Exit For
                End If
            Next element
            If Not containsExam Then
                strPests += vbCrLf + row.examination + ": не обнаружено"
            End If
        Next row

        Return strPests
    End Function

    Private Shared Function isExam(ByVal p As pest, ByVal exam As String) As Boolean
        If p.examination.ToLower() = exam.ToLower() Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Shared Function getFieldList( _
        ByRef rows As System.Data.DataRowCollection, _
        ByVal doc_id As Integer, ByVal format As String, _
        ByVal ParamArray field_names() As String) As String

        Dim list As List(Of String) = New List(Of String)

        For Each row As DataRow In rows
            If row("doc_id") = doc_id Then
                Dim list_fields As List(Of String) = New List(Of String)

                For Each field As String In field_names
                    list_fields.Add(row(field).ToString())
                Next field

                list.Add(String.Format(format, list_fields.ToArray()))
            End If
        Next row

        Return String.Join(", ", list.ToArray())

    End Function

End Class

