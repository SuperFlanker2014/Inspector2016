Imports System.Collections
Imports CarlosAg.ExcelXmlWriter

Public Class Reporting

    Private Shared reports As New Dictionary(Of String, reportNew)
    Private Shared styles As New Dictionary(Of String, WorksheetStyle)
    Private Shared LastError As String = ""
    Private Shared ReadOnly org As References.R_inspectionRow = Main.dsReferenses.R_inspection.Rows(0)

    Shared Sub New()
        createStyles()
        createReports()
    End Sub

    Public Shared ReadOnly Property ReportList() As List(Of String)
        Get
            Dim lst As New List(Of String)()
            For Each str As String In reports.Keys
                lst.Add(str)
            Next str
            Return lst
        End Get
    End Property

    Public Shared ReadOnly Property ParameterList(ByVal ReportTitle As String) As List(Of String)
        Get
            Dim lst As New List(Of String)()
            Return reports(ReportTitle).getParemeters()
        End Get
    End Property

    Public Shared Sub GenerateReport(ByVal ReportTitle As String, ByVal params As Hashtable, ByVal reports_list As String)
        Dim path As String = ""

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            path = reports(ReportTitle).Generate(params, reports_list)
        Catch ex As Exception
            LastError = "Ошибка: " + ReportTitle + "; " + Microsoft.VisualBasic.Constants.vbCrLf + "Текст ошибки: " + ex.ToString() + "; " + ex.Message
        End Try
        Windows.Forms.Cursor.Current = Cursors.Arrow

        If (LastError <> "") Or (path = "") Then
            MessageBox.Show(LastError, "Ошибка при формировании документа", MessageBoxButtons.OK, _
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            LastError = ""
            Exit Sub
        Else
            System.Diagnostics.Process.Start(path)
        End If

    End Sub

    Private Shared Sub createStyles()
        styles.Add("default", New WorksheetStyle("default"))
        styles("default").Alignment.Horizontal = StyleHorizontalAlignment.Left
        styles("default").Alignment.Vertical = StyleVerticalAlignment.Top
        styles("default").Font.Size = 10
        styles("default").Font.FontName = "Arial"
        styles("default").Alignment.WrapText = True

        styles.Add("LTR", New WorksheetStyle("LTR"))
        styles("LTR").Alignment.Vertical = StyleVerticalAlignment.Top
        styles("LTR").Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1)
        styles("LTR").Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1)
        styles("LTR").Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1)
        styles("LTR").Alignment.WrapText = True

        styles.Add("LR", New WorksheetStyle("LR"))
        styles("LR").Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1)
        styles("LR").Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1)
        styles("LR").Alignment.WrapText = True

        styles.Add("T", New WorksheetStyle("T"))
        styles("T").Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1)
        styles("T").Alignment.WrapText = True
        styles("T").Alignment.Vertical = StyleVerticalAlignment.Top
        styles("T").Alignment.Horizontal = StyleHorizontalAlignment.Left

        styles.Add("table8", New WorksheetStyle("table8"))
        styles("table8").Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1)
        styles("table8").Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1)
        styles("table8").Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1)
        styles("table8").Borders.Add(StylePosition.Bottom, LineStyleOption.Continuous, 1)
        styles("table8").Font.Size = 8
        styles("table8").Alignment.WrapText = True

        styles.Add("table10", New WorksheetStyle("table10"))
        styles("table10").Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1)
        styles("table10").Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1)
        styles("table10").Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1)
        styles("table10").Borders.Add(StylePosition.Bottom, LineStyleOption.Continuous, 1)
        styles("table10").Font.Size = 10
        styles("table10").Alignment.WrapText = True

        styles.Add("LTRCB12", New WorksheetStyle("LTRCB12"))
        styles("LTRCB12").Alignment.Vertical = StyleVerticalAlignment.Top
        styles("LTRCB12").Alignment.Horizontal = StyleHorizontalAlignment.Center
        styles("LTRCB12").Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1)
        styles("LTRCB12").Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1)
        styles("LTRCB12").Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1)
        styles("LTRCB12").Alignment.WrapText = True
        styles("LTRCB12").Font.Bold = True

    End Sub

    Private Shared Sub createReports()

        'Сведения о результатах обследований. Ежемесечный отчёт
        Dim r1ReplaceTasks As New ArrayList
        r1ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r1ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r1ReplaceTasks.Add(New rptReplaceTask("#date_current", Date.Today.ToLongDateString))
        Dim r1InsertTasks As New ArrayList
        r1InsertTasks.Add(New rptInsertTask("с начала года", _
            "select * from report_region_month(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r1 As New reportNew(r1ReplaceTasks, r1InsertTasks, Application.StartupPath + _
            "\Templates\report_month_01.xml")
        reports.Add("[Ежемесечные отчёты] Сведения о результатах обследований", r1)

        'Информация об объёмах и происхождении подкарантинной продукции(1.1)
        Dim r3ReplaceTasks As New ArrayList
        r3ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r3ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r3InsertTasks As New ArrayList
        r3InsertTasks.Add(New rptInsertTask("импортная продукция", _
            "select * from report_moscow_11(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r3 As New reportNew(r3ReplaceTasks, r3InsertTasks, Application.StartupPath + _
            "\Templates\report_moscow_11.xml")
        reports.Add("[Квартальные отчёты] 1.1.Информация об объёмах и происхождении подкарантинной продукции", r3)

        'Сведения о проведённых экспертизах, выявленных карантинных организмах и выданных докуменатах (2.1)
        Dim r4ReplaceTasks As New ArrayList
        r4ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r4ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r4InsertTasks As New ArrayList
        r4InsertTasks.Add(New rptInsertTask("Экспертизы", _
            "select * from report_moscow_21(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r4 As New reportNew(r4ReplaceTasks, r4InsertTasks, Application.StartupPath + _
            "\Templates\report_moscow_21.xml")
        reports.Add("[Квартальные отчёты] 2.1.Сведения о проведённых экспертизах, выявленных карантинных организмах и выданных докуменатах", r4)

        'Сведения о проведённых экспертизах, выявленных карантинных организмах и выданных докуменатах (2.2)
        Dim r11ReplaceTasks As New ArrayList
        r11ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r11ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r11InsertTasks As New ArrayList
        r11InsertTasks.Add(New rptInsertTask("всего", _
            "select * from report_moscow_22(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r11 As New reportNew(r11ReplaceTasks, r11InsertTasks, Application.StartupPath + _
            "\Templates\report_moscow_22.xml")
        reports.Add("[Квартальные отчёты] 2.2.Сведения о проведённых экспертизах, выявленных карантинных организмах и выданных докуменатах", r11)

        'Сведения о проведённых экспертизах, выявленных карантинных организмах и выданных докуменатах (2.3)
        Dim r12ReplaceTasks As New ArrayList
        r12ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r12ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r12InsertTasks As New ArrayList
        r12InsertTasks.Add(New rptInsertTask("объём", _
            "select * from report_moscow_23(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r12 As New reportNew(r12ReplaceTasks, r12InsertTasks, Application.StartupPath + _
            "\Templates\report_moscow_23.xml")
        reports.Add("[Квартальные отчёты] 2.3.Сведения о проведённых экспертизах, выявленных карантинных организмах и выданных докуменатах", r12)

        'Сведения о проведённых обследовательских мероприятиях (3.1)
        Dim r13ReplaceTasks As New ArrayList
        r13ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r13ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r13InsertTasks As New ArrayList
        r13InsertTasks.Add(New rptInsertTask("Объём", _
            "select * from report_moscow_31(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r13 As New reportNew(r13ReplaceTasks, r13InsertTasks, Application.StartupPath + _
            "\Templates\report_moscow_31.xml")
        reports.Add("[Квартальные отчёты] 3.1.Сведения о проведённых обследовательских мероприятиях", r13)

        'Сведения о проведённых обследовательских мероприятиях (3.2)
        Dim r14ReplaceTasks As New ArrayList
        r14ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r14ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r14InsertTasks As New ArrayList
        r14InsertTasks.Add(New rptInsertTask("Карантинный", _
            "select * from report_moscow_32(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r14 As New reportNew(r14ReplaceTasks, r14InsertTasks, Application.StartupPath + _
            "\Templates\report_moscow_32.xml")
        reports.Add("[Квартальные отчёты] 3.2.Сведения о проведённых обследовательских мероприятиях", r14)

        'Журнал учёта выставленных счетов-фактур
        Dim r2ReplaceTasks As New ArrayList
        r2ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r2ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r2ReplaceTasks.Add(New rptReplaceTask("#gb", org.accountant))
        r2ReplaceTasks.Add(New rptReplaceTask("#date_current", Date.Today.ToLongDateString))
        Dim r2InsertTasks As New ArrayList
        r2InsertTasks.Add(New rptInsertTask("Покупатель", _
            "select * from report_fin_01(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r2 As New reportNew(r2ReplaceTasks, r2InsertTasks, Application.StartupPath + _
            "\Templates\JUSF.xml")
        reports.Add("[Бухгалтерия] Журнал учёта выставленных счетов-фактур", r2)

        'Акт сверки
        Dim r5ReplaceTasks As New ArrayList
        r5ReplaceTasks.Add(New rptReplaceTask("#org_title_short", org.title_short))
        r5ReplaceTasks.Add(New rptReplaceTask("#org_adress", org.adress))
        r5ReplaceTasks.Add(New rptReplaceTask("#org_inn", org.inn))
        r5ReplaceTasks.Add(New rptReplaceTask("#org_kpp", org.kpp))
        r5ReplaceTasks.Add(New rptReplaceTask("#client_name", ""))
        r5ReplaceTasks.Add(New rptReplaceTask("#client_adress", ""))
        r5ReplaceTasks.Add(New rptReplaceTask("#client_inn", ""))
        r5ReplaceTasks.Add(New rptReplaceTask("#client_kpp", ""))
        r5ReplaceTasks.Add(New rptReplaceTask("#current_date", Date.Today.ToLongDateString))
        r5ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r5ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r5ReplaceTasks.Add(New rptReplaceTask("#gb", org.accountant))
        Dim r5InsertTasks As New ArrayList
        r5InsertTasks.Add(New rptInsertTask("Номер ", _
            "select * from report_revise_act_1(@date_low,@date_high,@client_guid,@doc_id)", _
            New String() {"date_low", "date_high", "client_guid", "doc_id"}))
        r5InsertTasks.Add(New rptInsertTask("Дата ", _
            "select * from report_revise_act_2(@date_low,@date_high,@client_guid,@doc_id)", _
            New String() {"date_low", "date_high", "client_guid", "doc_id"}))
        Dim r5 As New reportNew(r5ReplaceTasks, r5InsertTasks, Application.StartupPath + _
            "\Templates\revise_act.xml")
        reports.Add("[Бухгалтерия] Акт сверки", r5)

        'Книга продаж
        Dim r6ReplaceTasks As New ArrayList
        r6ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r6ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r6ReplaceTasks.Add(New rptReplaceTask("#title_short", org.title_short))
        r6ReplaceTasks.Add(New rptReplaceTask("#inn", org.inn))
        r6ReplaceTasks.Add(New rptReplaceTask("#kpp", org.kpp))
        r6ReplaceTasks.Add(New rptReplaceTask("#gb", org.accountant))
        r6ReplaceTasks.Add(New rptReplaceTask("#date_current", Date.Today.ToLongDateString))
        Dim r6InsertTasks As New ArrayList
        r6InsertTasks.Add(New rptInsertTask("(1)", _
            "select * from report_sales_book_all(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r6 As New reportNew(r6ReplaceTasks, r6InsertTasks, Application.StartupPath + _
            "\Templates\Sales_Book.xml")
        reports.Add("[Бухгалтерия] Книга продаж", r6)

        'Книга продаж - итоги
        Dim r7ReplaceTasks As New ArrayList
        r7ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r7ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r7ReplaceTasks.Add(New rptReplaceTask("#title_short", org.title_short))
        r7ReplaceTasks.Add(New rptReplaceTask("#inn", org.inn))
        r7ReplaceTasks.Add(New rptReplaceTask("#kpp", org.kpp))
        r7ReplaceTasks.Add(New rptReplaceTask("#gb", org.accountant))
        r7ReplaceTasks.Add(New rptReplaceTask("#date_current", Date.Today.ToLongDateString))
        Dim r7InsertTasks As New ArrayList
        r7InsertTasks.Add(New rptInsertTask("(1)", _
            "select * from report_sales_book_total(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r7 As New reportNew(r7ReplaceTasks, r7InsertTasks, Application.StartupPath + _
            "\Templates\Sales_Book.xml")
        reports.Add("[Бухгалтерия] Книга продаж (итоги)", r7)

        'Реестр платежей
        Dim r8ReplaceTasks As New ArrayList
        r8ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r8ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r8ReplaceTasks.Add(New rptReplaceTask("#title", org.title))
        r8ReplaceTasks.Add(New rptReplaceTask("#gb", org.accountant))
        r8ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim r8InsertTasks As New ArrayList
        r8InsertTasks.Add(New rptInsertTask("Сумма", _
            "select * from report_list_paydocs(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r8 As New reportNew(r8ReplaceTasks, r8InsertTasks, Application.StartupPath + _
            "\Templates\List_Paydocs.xml")
        reports.Add("[Бухгалтерия] Реестр платежей", r8)

        'Реестр счетов-фактур
        Dim r9InsertTasks As New ArrayList
        r9InsertTasks.Add(New rptInsertTask("Сумма", _
            "select * from report_list_bills(@date_low,@date_high,1)", _
            New String() {"date_low", "date_high"}))
        Dim r9 As New reportNew(r8ReplaceTasks, r9InsertTasks, Application.StartupPath + _
            "\Templates\List_Bills_Post.xml")
        reports.Add("[Бухгалтерия] Реестр счетов-фактур", r9)

        'Реестр счетов
        Dim r10InsertTasks As New ArrayList
        r10InsertTasks.Add(New rptInsertTask("Сумма", _
            "select * from report_list_bills(@date_low,@date_high,0)", _
            New String() {"date_low", "date_high"}))
        Dim r10 As New reportNew(r8ReplaceTasks, r10InsertTasks, Application.StartupPath + _
            "\Templates\List_Bills_Pre.xml")
        reports.Add("[Бухгалтерия] Реестр счетов", r10)

        'Карантинные объекты
        Dim r15InsertTasks As New ArrayList
        r15InsertTasks.Add(New rptInsertTask("случаев", _
            "select * from report_karantin_objects_01(@date_low,@date_high,@production)", _
            New String() {"date_low", "date_high", "production"}))
        Dim r15ReplaceTasks As New ArrayList
        r15ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r15ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r15 As New reportNew(r15ReplaceTasks, r15InsertTasks, Application.StartupPath + _
            "\Templates\report_karantin_objects_01.xml")
        reports.Add("Карантинные объекты (ввоз и вывоз)", r15)

        'Реестр договоров
        Dim r16ReplaceTasks As New ArrayList
        r16ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r16ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r16ReplaceTasks.Add(New rptReplaceTask("#gb", org.accountant))
        r16ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim r16InsertTasks As New ArrayList
        r16InsertTasks.Add(New rptInsertTask("Дата", _
            "select * from report_agreements_01(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r16 As New reportNew(r16ReplaceTasks, r16InsertTasks, Application.StartupPath + _
            "\Templates\report_agreements_01.xml")
        reports.Add("[Бухгалтерия] Реестр договоров", r16)

        'Реестр дебиторов/кредиторов
        Dim r17ReplaceTasks As New ArrayList
        'r17ReplaceTasks.Add(New rptReplaceTask("#date_current", Date.Today.ToLongDateString))
        r17ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r17ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        r17ReplaceTasks.Add(New rptReplaceTask("#gb", org.accountant))
        r17ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim r17InsertTasks As New ArrayList
        r17InsertTasks.Add(New rptInsertTask("Кредит", _
            "select * from report_debtors_creditors_f(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r17 As New reportNew(r17ReplaceTasks, r17InsertTasks, Application.StartupPath + _
            "\Templates\report_debtors_creditors.xml")
        reports.Add("[Бухгалтерия] Реестр дебиторов/кредиторов", r17)

        '[Обследования] Склады
        Dim r18ReplaceTasks As New ArrayList
        r18ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r18ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r18InsertTasks As New ArrayList
        r18InsertTasks.Add(New rptInsertTask("Район", _
            "select * from report_examinations_warehouse(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r18 As New reportNew(r18ReplaceTasks, r18InsertTasks, Application.StartupPath + _
            "\Templates\report_examinations_warehouse.xml")
        reports.Add("[Обследования] Склады", r18)

        '[Обследования] Лес
        Dim r19ReplaceTasks As New ArrayList
        r19ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r19ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r19InsertTasks As New ArrayList
        r19InsertTasks.Add(New rptInsertTask("Район", _
            "select * from report_examinations_forest(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r19 As New reportNew(r19ReplaceTasks, r19InsertTasks, Application.StartupPath + _
            "\Templates\report_examinations_forest.xml")
        reports.Add("[Обследования] Лес", r19)

        '[Обследования] Теплицы
        Dim r20ReplaceTasks As New ArrayList
        r20ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r20ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r20InsertTasks As New ArrayList
        r20InsertTasks.Add(New rptInsertTask("Район", _
            "select * from report_examinations_hothouse(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r20 As New reportNew(r20ReplaceTasks, r20InsertTasks, Application.StartupPath + "\Templates\report_examinations_hothouse.xml")
        reports.Add("[Обследования] Теплицы", r20)

        '[Обследования] Питомники
        Dim r21ReplaceTasks As New ArrayList
        r21ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r21ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r21InsertTasks As New ArrayList
        r21InsertTasks.Add(New rptInsertTask("Район", _
            "select * from report_examinations_garden(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r21 As New reportNew(r21ReplaceTasks, r21InsertTasks, Application.StartupPath + "\Templates\report_examinations_garden.xml")
        reports.Add("[Обследования] Питомники", r21)

        'Журнал учёта заключений
        Dim r22ReplaceTasks As New ArrayList
        r22ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        r22ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        Dim r22InsertTasks As New ArrayList
        r22InsertTasks.Add(New rptInsertTask("Организация", _
            "select * from report_journal1(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim r22 As New reportNew(r22ReplaceTasks, r22InsertTasks, Application.StartupPath + "\Templates\List_Examinations.xml")
        reports.Add("Журнал учёта заключений", r22)

        'Форма 1
        Dim f1ReplaceTasks As New ArrayList
        f1ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        f1ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        f1ReplaceTasks.Add(New rptReplaceTask("#title", org.title))
        f1ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim f1InsertTasks As New ArrayList
        f1InsertTasks.Add(New rptInsertTask("10", _
            "select * from report_form1(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim f1 As New reportNew(f1ReplaceTasks, f1InsertTasks, Application.StartupPath + "\Templates\form_1.xml")
        reports.Add("Форма 1", f1)

        'Форма 21
        Dim f21ReplaceTasks As New ArrayList
        f21ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        f21ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        f21ReplaceTasks.Add(New rptReplaceTask("#title", org.title))
        f21ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim f21InsertTasks As New ArrayList
        f21InsertTasks.Add(New rptInsertTask("без НДС", _
            "select * from report_form21(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim f21 As New reportNew(f21ReplaceTasks, f21InsertTasks, Application.StartupPath + "\Templates\form_21.xml")
        reports.Add("Форма 21", f21)

        'Форма 22
        Dim f22ReplaceTasks As New ArrayList
        f22ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        f22ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        f22ReplaceTasks.Add(New rptReplaceTask("#title", org.title))
        f22ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim f22InsertTasks As New ArrayList
        f22InsertTasks.Add(New rptInsertTask("Всего", _
            "select * from report_form22(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim f22 As New reportNew(f22ReplaceTasks, f22InsertTasks, Application.StartupPath + "\Templates\form_22.xml")
        reports.Add("Форма 22", f22)

        'Форма 23
        Dim f23ReplaceTasks As New ArrayList
        f23ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        f23ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        f23ReplaceTasks.Add(New rptReplaceTask("#title", org.title))
        f23ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim f23InsertTasks As New ArrayList
        f23InsertTasks.Add(New rptInsertTask("При экспертизе образцов импортной подкарантинной продукции (при ввозе на территорию РФ)", _
            "select * from report_form23(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim f23 As New reportNew(f23ReplaceTasks, f23InsertTasks, Application.StartupPath + "\Templates\form_23.xml")
        reports.Add("Форма 23", f23)

        'Форма 24
        Dim f24ReplaceTasks As New ArrayList
        f24ReplaceTasks.Add(New rptReplaceTask("#date_low", ""))
        f24ReplaceTasks.Add(New rptReplaceTask("#date_high", ""))
        f24ReplaceTasks.Add(New rptReplaceTask("#title", org.title))
        f24ReplaceTasks.Add(New rptReplaceTask("#director", org.director))
        Dim f24InsertTasks As New ArrayList
        f24InsertTasks.Add(New rptInsertTask("При экспертизе образцов отечественной подкарантинной продукции (при внутрироссийских перевозках экспорте)", _
            "select * from report_form24(@date_low,@date_high)", _
            New String() {"date_low", "date_high"}))
        Dim f24 As New reportNew(f24ReplaceTasks, f24InsertTasks, Application.StartupPath + "\Templates\form_24.xml")
        reports.Add("Форма 24", f24)

    End Sub

#Region "Классы для отчётов"

    Private Class rptReplaceDBTask
        Private _target As String
        Private _source As String
        Private _conn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        Private _parameters As List(Of String)

        Public Sub New(ByVal target As String, ByVal source As String, ByVal parameters As String())
            _target = target
            _source = source
            _conn = Main.dbConnection
            _parameters = New List(Of String)(parameters)
        End Sub

        Public Function getTarget() As String
            Return _target
        End Function

        Public Function getSource(ByVal queryParameters As Hashtable) As String
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(_source, _conn)
            For Each key As String In queryParameters.Keys
                If _parameters.Contains(key.ToString()) Then
                    Dim t As System.Type = queryParameters.Item(key).GetType()
                    Select Case t.FullName
                        Case "System.DateTime"
                            cmd.Parameters.Add(key, SqlDbType.DateTime).Value = _
                            CDate(queryParameters.Item(key)).AddDays(-1)
                        Case Else
                            cmd.Parameters.Add(key, SqlDbType.VarChar).Value = _
                            queryParameters.Item(key).ToString()
                    End Select
                End If
            Next key

            Dim o As Object = cmd.ExecuteScalar()
            _conn.Close()
            Return o.ToString()

        End Function

        Public Function getParemeters() As List(Of String)
            Return _parameters
        End Function
    End Class

    Private Class rptReplaceTask
        Private _target As String
        Private _source As String
        Private _conn As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection()

        Public Sub New(ByVal target As String, ByVal source As String)
            _target = target
            _source = source
            _conn = Main.dbConnection
        End Sub

        Public Function getTarget() As String
            Return _target
        End Function

        Public Function getSource() As String
            Return _source
        End Function

        Public Function getParemeters() As List(Of String)
            Return New List(Of String)()
        End Function

    End Class

    Private Class rptInsertTask
        Private tbl As New DataTable

        Private _target As String
        Private _source As String
        Private _conn As SqlClient.SqlConnection
        Private _parameters As List(Of String)
        Private _styles As Dictionary(Of String, WorksheetStyle) = styles

        Public Sub New(ByVal target As String, ByVal source As String, ByVal parameters As String())
            _target = target
            _source = source
            _conn = Main.dbConnection
            _parameters = New List(Of String)(parameters)
            tbl.Columns.Add("style_name", System.Type.GetType("System.String"))
            tbl.Columns.Add("shifts", System.Type.GetType("System.String"))
        End Sub

        Public Function getTarget() As String
            Return _target
        End Function

        Public Function getSource(ByVal queryParameters As Hashtable, ByVal reports_list As String) As DataTable
            'заливаем
            Dim dt As DataTable = New DataTable()

            Dim strQuery As String = ""
            If reports_list <> "" Then
                strQuery = My.Settings.reportQueryPattern.Replace("{lst}", reports_list)
                strQuery = strQuery.Replace("{query}", _source)
            Else
                strQuery = _source
            End If

            Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(strQuery, _conn)
            For Each key As String In queryParameters.Keys
                If _parameters.Contains(key.ToString()) Then
                    Dim t As System.Type = queryParameters.Item(key).GetType()
                    Select Case t.FullName
                        Case "System.DateTime"
                            da.SelectCommand.Parameters.Add(key, SqlDbType.DateTime).Value = _
                            CDate(queryParameters.Item(key)).Date '.AddDays(-1)
                        Case Else
                            da.SelectCommand.Parameters.Add(key, SqlDbType.VarChar).Value = _
                            queryParameters.Item(key).ToString()
                    End Select
                End If
            Next key
            da.SelectCommand.CommandTimeout = 600
            da.Fill(dt)

            'сохраняем колонки в экземпляре задания
            For Each row As DataRow In dt.Rows
                tbl.Rows.Add(New Object() {"default", ""})
            Next row
            If dt.Columns.Contains("style_name") Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    tbl.Rows(i)("style_name") = dt.Rows(i)("style_name")
                Next i
                dt.Columns.Remove("style_name")
            End If
            If dt.Columns.Contains("shifts") Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    tbl.Rows(i)("shifts") = dt.Rows(i)("shifts")
                Next i
                dt.Columns.Remove("shifts")
            End If

            Return dt
        End Function

        Public Function getParemeters() As List(Of String)
            Return _parameters
        End Function

        Public Function getStyle(ByVal row_number As Integer) As WorksheetStyle
            If _styles.ContainsKey(tbl.Rows(row_number)("style_name")) Then
                Return _styles(tbl.Rows(row_number)("style_name"))
            Else
                Return _styles("default")
            End If
            'если у нас крайние ячейки - надо вернуть стиль с вертикальными границами
        End Function

        Public Function Merge(ByVal row_number As Integer, ByVal col_number As Integer, ByVal type As Integer) As Integer
            'col_number:across,down;
            Dim shift As String = tbl.Rows(row_number)("shifts").ToString()
            If shift = "" Then
                Return 0
            Else
                Dim i As Integer = shift.IndexOf(col_number.ToString() + ":")
                If i <> -1 Then
                    Dim str As String = _
                    shift.Substring(shift.Substring(i).IndexOf(":") + i + 1, _
                                    shift.Substring(i).IndexOf(";") - shift.Substring(i).IndexOf(":") - 1)
                    Return CInt(str.Split(",")(type))
                Else
                    Return 0
                End If
            End If
        End Function

    End Class

    Private Class reportNew
        Private replaceTasks As ArrayList
        Private insertTasks As ArrayList
        Private templateName As String

        Public Sub New(ByVal rTasks As ArrayList, ByVal iTasks As ArrayList, ByVal tempName As String)
            replaceTasks = rTasks
            insertTasks = iTasks
            templateName = tempName
        End Sub

        Public Function getParemeters() As List(Of String)
            Dim s As List(Of String) = New List(Of String)
            For Each task As rptInsertTask In insertTasks
                s.AddRange(task.getParemeters())
            Next task
            For Each task As Object In replaceTasks
                s.AddRange(task.getParemeters())
            Next task
            Return s
        End Function

        Public Function Generate(ByVal queryParameters As Hashtable, ByVal reports_list As String) As String

            'открываем шаблон
            Dim xls As New CarlosAg.ExcelXmlWriter.Workbook
            xls.Load(templateName)
            Dim tbl As CarlosAg.ExcelXmlWriter.WorksheetTable = xls.Worksheets(0).Table

            'обрабатываем задания вставки
            For Each task As rptInsertTask In insertTasks
                'выборка данных
                Dim dt As DataTable = task.getSource(queryParameters, reports_list)

                'определяем номер строки куда вставлять
                Dim rowNumber As Integer = 0
                Dim j As Integer = 0
                For Each r As CarlosAg.ExcelXmlWriter.WorksheetRow In tbl.Rows
                    For Each c As CarlosAg.ExcelXmlWriter.WorksheetCell In r.Cells
                        If (Not c.Data.Text Is Nothing) AndAlso (c.Data.Text.Contains(task.getTarget())) Then
                            rowNumber = j + 1
                        End If
                    Next c
                    j += 1
                Next r

                'добавляем данные выборки в файл
                Dim mergeDownDepth(dt.Rows.Count, 30) As Boolean
                For row_number As Integer = 0 To dt.Rows.Count - 1
                    For col_number As Integer = 0 To 30
                        mergeDownDepth.SetValue(True, row_number, col_number)
                    Next col_number
                Next row_number

                For row_number As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(row_number) 'выбираем строку из результата запроса
                    Dim r As New CarlosAg.ExcelXmlWriter.WorksheetRow 'новая строка для листа excel
                    Dim mergeAcross As Integer = 0 'храним величину сдвига ячеек для присвоения индексов

                    For col_number As Integer = 0 To dt.Columns.Count - 1
                        Dim cell As Object = row(col_number)
                        Dim c As New CarlosAg.ExcelXmlWriter.WorksheetCell(cell.ToString, DataType.String)
                        'в зависимости от содержимого cell создаём excel-ячейку
                        Select Case cell.GetType.Name
                            Case "Decimal", "Int32"
                                c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell, DataType.Number)
                                c.Formula = "=" + cell.ToString().Replace(",", ".")
                            Case "String"
                                'Try
                                '    cell = Convert.ToInt64(cell.ToString().Trim())
                                '    c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell, DataType.Number)
                                '    c.Formula = "=" + cell.ToString()
                                'Catch ex As InvalidCastException
                                '    Try
                                '        cell = CDec(cell.ToString().Trim().Replace(".", ","))
                                '        c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell, DataType.Number)
                                '        c.Formula = "=" + cell.ToString().Replace(",", ".")
                                '    Catch ex1 As InvalidCastException
                                '        c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell.ToString, DataType.String)
                                '    End Try
                                'Catch ex As FormatException
                                '    Try
                                '        cell = CDec(cell.ToString().Trim().Replace(".", ","))
                                '        c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell, DataType.Number)
                                '        c.Formula = "=" + cell.ToString().Replace(",", ".")
                                '    Catch ex1 As InvalidCastException
                                '        c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell.ToString, DataType.String)
                                '    End Try
                                'Catch ex As Exception
                                c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell.ToString, DataType.String)
                                'End Try
                            Case Else
                                c = New CarlosAg.ExcelXmlWriter.WorksheetCell(cell.ToString, DataType.String)
                        End Select
                        'присваиваем ячейке параметры отображения
                        Dim style As WorksheetStyle = task.getStyle(row_number)
                        c.StyleID = style.ID
                        If Not xls.Styles.Contains(style) Then
                            xls.Styles.Add(style)
                        End If
                        c.Index = col_number + 1 '+ mergeAcross
                        Dim ma As Integer = task.Merge(row_number, col_number, 0)
                        If ma <> 0 Then
                            c.MergeAcross = ma
                            mergeAcross += ma
                        End If
                        Dim md As Integer = task.Merge(row_number, col_number, 1)
                        If md <> 0 Then
                            c.MergeDown = md
                        End If
                        'добавляем ячейку
                        If mergeDownDepth(row_number, col_number + 1) Then
                            r.Cells.Add(c)
                            If md > 0 Then
                                For md_index As Integer = row_number + 1 To row_number + md
                                    For ma_ind As Integer = c.Index To c.Index + ma
                                        If md_index <= dt.Rows.Count - 1 Then
                                            mergeDownDepth(md_index, ma_ind) = False
                                        End If
                                    Next ma_ind
                                Next md_index
                            End If
                            If ma > 0 Then
                                For ma_ind As Integer = c.Index + 1 To c.Index + ma
                                    mergeDownDepth(row_number, ma_ind) = False
                                Next ma_ind
                            End If
                        End If
                    Next col_number
                    tbl.Rows.Insert(rowNumber + row_number, r)
                    tbl.ExpandedRowCount += 1

                    'корекция высоты ячеек с объединением
                    Dim q As Integer = 0
                    For Each addedCell As CarlosAg.ExcelXmlWriter.WorksheetCell In r.Cells
                        If (addedCell.MergeAcross > 0) Then
                            Dim height As Integer = Math.Truncate(addedCell.Data.Text.Length * 1.6 / r.Table.Columns(q).Width) + 1
                            r.Height = height * 14
                        End If
                        q += 1
                    Next addedCell
                Next row_number

                Dim u As Integer = 0
                For Each row As CarlosAg.ExcelXmlWriter.WorksheetRow In tbl.Rows
                    If row.Index <> 0 And u > rowNumber Then
                        row.Index += dt.Rows.Count
                    End If
                    u += 1
                Next row

            Next task

            'tbl.ExpandedColumnCount = 256
            'tbl.ExpandedRowCount = 100000

            'сохраняем изменённый файл
            Dim tmpFolder As String = IO.Path.GetTempPath()

            If tmpFolder.EndsWith("\") Then
                tmpFolder = tmpFolder.Substring(0, IO.Path.GetTempPath().Length - 1)
            End If

            Dim tmpFileName As String = String.Format("{0}\{1}{2}.xls", tmpFolder, IO.Path.GetFileName(templateName), Date.Now.Ticks)
            xls.Save(tmpFileName)

            'производим замену
            Dim xml_template As String = System.IO.File.ReadAllText(tmpFileName, System.Text.Encoding.UTF8)
            For Each task As Object In replaceTasks
                Dim source As String
                If task.GetType().Name = "rptReplaceDBTask" Then
                    source = task.getSource(queryParameters)
                Else
                    source = task.getSource()
                End If
                Dim target As String = task.getTarget()
                If source = "" Then 'значит значение надо подставить из параметров отчёта
                    For Each key As String In queryParameters.Keys
                        If target.Contains(key) Then
                            Try
                                source = queryParameters.Item(key).ToLongDateString()
                            Catch ex As Exception
                                source = queryParameters.Item(key).ToString()
                            End Try
                        End If
                    Next key
                End If

                xml_template = xml_template.Replace(target, source)
            Next task

            System.IO.File.WriteAllText(tmpFileName, xml_template, System.Text.Encoding.UTF8)

            Return tmpFileName

        End Function
    End Class

#End Region

End Class

