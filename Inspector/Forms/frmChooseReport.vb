Imports ICSharpCode.SharpZipLib.Zip
Imports System.IO

Public Class frmChooseReport
    Implements IForm

    Private Enum MasterStep
        ReportList
        ReportAggregate
        ReportParameters
        ReportExport
    End Enum

    Private doc_id As Integer
    Dim client_guid As Guid = Guid.Empty
    Dim reports_list As String = ""

    Private params() As Control

    Public Sub New()
        InitializeComponent()

        params = New Control() {Me.dtpDateLow, Me.dtpDateHigh, Me.dtpDateReportPeriod, Me.lblDateReportPeriod, _
        Me.txtClientInn, Me.lblClientInn, Me.lblDatehigh, Me.lblDateLow, Me.cbProduction, Me.lblProduction}

        For Each s As String In Reporting.ReportList
            Me.lbReports.Items.Add(s)
        Next s

        Me.lbReports.Sorted = True
        Me.cbProduction.SelectedIndex = 0

        dtpDateLow.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtpDateHigh.Value = DateTime.Today
        dtpReportLow.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtpReportHigh.Value = DateTime.Today
    End Sub


    Private Sub MoveToStep(ByVal s As MasterStep)
        pnlList.Visible = False
        pnlParameters.Visible = False
        pnltAggregate.Visible = False
        pnlExport.Visible = False
        Select Case s
            Case MasterStep.ReportList
                pnlList.Visible = True
                Me.Text = "Отчёты"
            Case MasterStep.ReportAggregate
                pnltAggregate.Visible = True
            Case MasterStep.ReportParameters
                pnlParameters.Visible = True
            Case MasterStep.ReportExport
                pnlExport.Visible = True
        End Select
    End Sub

    Private Sub frmChooseReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MoveToStep(MasterStep.ReportList)
    End Sub

    Private Sub btnBackExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackExport.Click
        MoveToStep(MasterStep.ReportList)
    End Sub
    Private Sub btnBackAggregate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAggregate.Click, pnlExport.Click
        MoveToStep(MasterStep.ReportList)
    End Sub
    Private Sub btnBackParameters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackParameters.Click
        If cbAggregate.Checked Then
            MoveToStep(MasterStep.ReportAggregate)
        Else
            MoveToStep(MasterStep.ReportList)
        End If
    End Sub

    Private Sub btnNextList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextList.Click
        If lbReports.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim s As List(Of String) = Reporting.ParameterList(lbReports.SelectedItem.ToString())
        For Each ctrl As Control In params
            ctrl.Visible = s.Contains(ctrl.Tag.ToString())
        Next ctrl

        Me.Text = "Отчёт: " + lbReports.SelectedItem.ToString()

        If cbAggregate.Checked Then
            Me.H_ReportsDivisionsTableAdapter.Fill(Me.Reports.H_ReportsDivisions)
            MoveToStep(MasterStep.ReportAggregate)
        Else
            MoveToStep(MasterStep.ReportParameters)
        End If
    End Sub
    Private Sub btnNextAggregate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextAggregate.Click
        dgvReportsDivisions.EndEdit()

        reports_list = ""
        For Each row As DataGridViewRow In dgvReportsDivisions.Rows
            If row.Cells("useReport").Value = True Then
                reports_list += row.Cells("rowid").Value.ToString() + ","
            End If
        Next row
        If reports_list.Length > 0 Then
            reports_list = reports_list.Substring(0, reports_list.Length - 1)
        End If

        pnlList.Visible = False
        pnltAggregate.Visible = False
        pnlParameters.Visible = True
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim s As List(Of String) = Reporting.ParameterList(lbReports.SelectedItem.ToString())

        Dim htSQLparams As New Hashtable
        For Each ctrl As Control In params
            Dim tag As String = ctrl.Tag.ToString()
            If s.Contains(tag) And ctrl.GetType().Name <> "Label" Then
                Select Case tag
                    Case "date_low"
                        Dim c As DateTimePicker = ctrl
                        htSQLparams.Add(tag, c.Value)
                    Case "date_high"
                        Dim c As DateTimePicker = ctrl
                        htSQLparams.Add(tag, c.Value)
                        'Case "client_guid"
                        '    Dim c As MaskedTextBox = ctrl
                        '    htSQLparams.Add(tag, c.Text)
                    Case "date_report_period"
                        Dim c As DateTimePicker = ctrl
                        htSQLparams.Add(tag, c.Value)
                    Case "production"
                        Dim c As ComboBox = ctrl
                        htSQLparams.Add(tag, c.SelectedIndex)
                End Select
            End If
        Next ctrl

        'если нужен акт сверки старого договора
        If s.Contains("doc_id") Then
            htSQLparams.Add("doc_id", doc_id)
            doc_id = 0
        End If

        'если нужен клиент
        If s.Contains("client_guid") Then
            'проверить ИНН на существование
            If txtClientInn.Text = "" Then
                MessageBox.Show("Введите ИНН!")
                Exit Sub
            End If

            Dim dt As Documents.R_clientsDataTable = New Documents.R_clientsDataTable
            Dim da As DocumentsTableAdapters.R_clientsTableAdapter = New DocumentsTableAdapters.R_clientsTableAdapter()

            If client_guid = Guid.Empty Then
                Dim g As Guid = da.IsInnExists(txtClientInn.Text.Trim())
                If g = Guid.Empty Then
                    MsgBox("Такого номера ИНН не существует!", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    da.FillOneByGUID(dt, g)
                End If
            Else
                da.FillOneByGUID(dt, client_guid)
            End If
            'залить все его реквизиты
            htSQLparams.Add("client_guid", dt.Rows(0).Item("client_guid").ToString())
            htSQLparams.Add("client_inn", dt.Rows(0).Item("client_inn").ToString())
            htSQLparams.Add("client_adress", dt.Rows(0).Item("client_adress").ToString())
            htSQLparams.Add("client_adress_fact", dt.Rows(0).Item("client_adress_fact").ToString())
            htSQLparams.Add("client_adress_warehouse", dt.Rows(0).Item("client_adress_warehouse").ToString())
            htSQLparams.Add("client_bank_account", dt.Rows(0).Item("client_bank_account").ToString())
            htSQLparams.Add("client_bank_bik", dt.Rows(0).Item("client_bank_bik").ToString())
            htSQLparams.Add("client_face_agreement", dt.Rows(0).Item("client_face_agreement").ToString())
            htSQLparams.Add("client_kpp", dt.Rows(0).Item("client_kpp").ToString())
            htSQLparams.Add("client_name", dt.Rows(0).Item("client_name").ToString())
            htSQLparams.Add("client_phone", dt.Rows(0).Item("client_phone").ToString())
            htSQLparams.Add("client_region", dt.Rows(0).Item("client_region").ToString())
            htSQLparams.Add("client_region_rayon", dt.Rows(0).Item("client_region_rayon").ToString())
            htSQLparams.Add("client_representative", dt.Rows(0).Item("client_representative").ToString())
            htSQLparams.Add("client_type", dt.Rows(0).Item("client_type").ToString())
        End If

        Reporting.GenerateReport(lbReports.SelectedItem.ToString(), htSQLparams, reports_list)
        reports_list = ""

        client_guid = Guid.Empty

        MoveToStep(MasterStep.ReportList)

        Me.Hide()
    End Sub
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        MoveToStep(MasterStep.ReportExport)
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtDevisionTitle.Text = "" Then
            MessageBox.Show("Введите название подразделения!")
            Exit Sub
        End If
        If txtDevisionNumber.Text.Trim() = "" Then
            MessageBox.Show("Введите номер подразделения!")
            Exit Sub
        End If
        If DateAndTime.DateDiff(DateInterval.Day, dtpReportLow.Value, dtpReportHigh.Value, _
                    FirstDayOfWeek.System, FirstWeekOfYear.System) > 93 Then
            MessageBox.Show("Интервал между датами не может превышать три месяца.")
            Exit Sub
        End If

        Dim title As String = txtDevisionTitle.Text
        Dim num As Integer
        If Not Integer.TryParse(txtDevisionNumber.Text.Trim(), num) Then
            num = 0
        End If

        Dim zipFileName As String
        Dim fbd As New FolderBrowserDialog()
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.ShowNewFolderButton = True
        If fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            zipFileName = fbd.SelectedPath + "\" + num.ToString() + "_" + title.Replace(" ", "") + _
            "_" + dtpReportLow.Value.ToString("ddMMyyyy") + _
            "_" + dtpReportHigh.Value.ToString("ddMMyyyy") + ".zip"
        Else
            Exit Sub
        End If

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            GetXMLTableAdapter.FillNew(Reports.GetXML, dtpReportLow.Value, dtpReportHigh.Value, num, title)
        Catch ex As Exception
            MessageBox.Show("Ошибка при выборке данных" + ex.Message)
            Exit Sub
        End Try

        Dim tempXMLFileName As String = fbd.SelectedPath + "\" + Date.Now.Ticks.ToString() + ".xml"
        File.WriteAllText(tempXMLFileName, Reports.GetXML.Rows.Item(0)(0).ToString())

        Try
            Dim zip As New FastZip()
            zip.CreateZip(zipFileName, fbd.SelectedPath + "\", False, Path.GetFileName(tempXMLFileName))
        Catch ex As Exception
            MessageBox.Show("Ошибка при архивировании данных" + ex.Message)
        End Try

        File.Delete(tempXMLFileName)
        Windows.Forms.Cursor.Current = Cursors.Arrow

        MoveToStep(MasterStep.ReportList)
    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim zipFileName As String
        Dim ofd As New OpenFileDialog()
        ofd.InitialDirectory = Environment.SpecialFolder.Desktop
        ofd.RestoreDirectory = True
        ofd.Filter = "ZIP files|*.zip"

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            zipFileName = ofd.FileName
        Else
            Exit Sub
        End If

        Dim fileName As String
        Try
            Dim file As New ZipFile(zipFileName)
            Dim enumer As IEnumerator = file.GetEnumerator()
            enumer.MoveNext()
            Dim entry As ZipEntry = enumer.Current
            Dim zip As New FastZip()
            zip.ExtractZip(zipFileName, Path.GetDirectoryName(zipFileName), "")
            fileName = Path.GetDirectoryName(zipFileName) + "\" + entry.Name
        Catch ex As Exception
            MessageBox.Show("Ошибка при разархивировании данных" + ex.Message)
            Exit Sub
        End Try

        Dim xml As String = File.ReadAllText(fileName, System.Text.Encoding.UTF8)
        File.Delete(fileName)
        QueriesTableAdapter.SaveXML(xml)
        H_ReportsDivisionsTableAdapter.Fill(Reports.H_ReportsDivisions)

    End Sub

    Private Sub client_inn_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtClientInn.MouseClick
        txtClientInn.SelectAll()
    End Sub
    Private Sub client_inn_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtClientInn.MouseDoubleClick

        Dim i As String = Me.txtClientInn.Text.Trim()
        'If i = "" Then
        '    i = "g"
        'End If

        Using row = Main.ShowClientsForm(i)
            If row Is Nothing Then
                MsgBox("Клиент не выбран!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                client_guid = row.Item("client_guid")
                Me.txtClientInn.Text = row.Item("client_inn").ToString()
            End If
        End Using

    End Sub

    Private Sub dgvReportsDivisions_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReportsDivisions.CellDoubleClick
        For Each row As DataGridViewRow In dgvReportsDivisions.Rows
            If row.Cells("useReport").Value = True Then
                reports_list += row.Cells("rowid").Value.ToString() + ","
            End If
        Next row
        If reports_list.Length > 0 Then
            reports_list = reports_list.Substring(0, reports_list.Length - 1)
        End If

        If MessageBox.Show("Удалить запись?", "Удаление записи", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) = _
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        H_ReportsDivisionsBindingSource.RemoveCurrent()
        H_ReportsDivisionsBindingSource.EndEdit()
        H_ReportsDivisionsTableAdapter.Update(Reports.H_ReportsDivisions)

    End Sub

#Region "Выполнение комманд"

    Public Overrides Sub ExecuteCommand(ByRef Command As CCustomCommand)
        If TypeOf Command Is CCommandReviseAct Then
            Dim cmd As CCommandReviseAct = CType(Command, CCommandReviseAct)

            Me.Show()

            doc_id = cmd.doc_id
            client_guid = cmd.client_guid
            txtClientInn.Text = cmd.client_inn
            cbAggregate.Checked = False
            lbReports.SelectedIndex = lbReports.FindString("[Бухгалтерия] Акт сверки")
            btnNextList_Click(Nothing, Nothing)
        End If
    End Sub

#End Region

End Class