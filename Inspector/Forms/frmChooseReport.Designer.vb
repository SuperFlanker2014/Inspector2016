<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseReport
    Inherits CAppForm 'System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lbReports = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlParameters = New System.Windows.Forms.Panel
        Me.lblProduction = New System.Windows.Forms.Label
        Me.cbProduction = New System.Windows.Forms.ComboBox
        Me.lblClientInn = New System.Windows.Forms.Label
        Me.txtClientInn = New System.Windows.Forms.MaskedTextBox
        Me.btnBackParameters = New System.Windows.Forms.Button
        Me.lblDateReportPeriod = New System.Windows.Forms.Label
        Me.lblDatehigh = New System.Windows.Forms.Label
        Me.lblDateLow = New System.Windows.Forms.Label
        Me.dtpDateReportPeriod = New System.Windows.Forms.DateTimePicker
        Me.dtpDateHigh = New System.Windows.Forms.DateTimePicker
        Me.dtpDateLow = New System.Windows.Forms.DateTimePicker
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.pnlList = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnNextList = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.cbAggregate = New System.Windows.Forms.CheckBox
        Me.pnltAggregate = New System.Windows.Forms.Panel
        Me.dgvReportsDivisions = New System.Windows.Forms.DataGridView
        Me.useReport = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.rowid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.H_ReportsDivisionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reports = New Inspector.Reports
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnBackAggregate = New System.Windows.Forms.Button
        Me.btnNextAggregate = New System.Windows.Forms.Button
        Me.pnlExport = New System.Windows.Forms.Panel
        Me.btnBackExport = New System.Windows.Forms.Button
        Me.txtDevisionTitle = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDevisionNumber = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpReportHigh = New System.Windows.Forms.DateTimePicker
        Me.dtpReportLow = New System.Windows.Forms.DateTimePicker
        Me.btnSave = New System.Windows.Forms.Button
        Me.H_ReportsDivisionsTableAdapter = New Inspector.ReportsTableAdapters.H_ReportsDivisionsTableAdapter
        Me.GetXMLTableAdapter = New Inspector.ReportsTableAdapters.GetXMLTableAdapter
        Me.QueriesTableAdapter = New Inspector.ReportsTableAdapters.QueriesTableAdapter
        Me.pnlParameters.SuspendLayout()
        Me.pnlList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnltAggregate.SuspendLayout()
        CType(Me.dgvReportsDivisions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.H_ReportsDivisionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbReports
        '
        Me.lbReports.CausesValidation = False
        Me.lbReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbReports.FormattingEnabled = True
        Me.lbReports.HorizontalScrollbar = True
        Me.lbReports.Location = New System.Drawing.Point(0, 0)
        Me.lbReports.Name = "lbReports"
        Me.lbReports.Size = New System.Drawing.Size(544, 290)
        Me.lbReports.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pnlParameters
        '
        Me.pnlParameters.CausesValidation = False
        Me.pnlParameters.Controls.Add(Me.lblProduction)
        Me.pnlParameters.Controls.Add(Me.cbProduction)
        Me.pnlParameters.Controls.Add(Me.lblClientInn)
        Me.pnlParameters.Controls.Add(Me.txtClientInn)
        Me.pnlParameters.Controls.Add(Me.btnBackParameters)
        Me.pnlParameters.Controls.Add(Me.lblDateReportPeriod)
        Me.pnlParameters.Controls.Add(Me.lblDatehigh)
        Me.pnlParameters.Controls.Add(Me.lblDateLow)
        Me.pnlParameters.Controls.Add(Me.dtpDateReportPeriod)
        Me.pnlParameters.Controls.Add(Me.dtpDateHigh)
        Me.pnlParameters.Controls.Add(Me.dtpDateLow)
        Me.pnlParameters.Controls.Add(Me.btnGenerate)
        Me.pnlParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlParameters.Location = New System.Drawing.Point(0, 0)
        Me.pnlParameters.Name = "pnlParameters"
        Me.pnlParameters.Size = New System.Drawing.Size(544, 325)
        Me.pnlParameters.TabIndex = 4
        Me.pnlParameters.Visible = False
        '
        'lblProduction
        '
        Me.lblProduction.AutoSize = True
        Me.lblProduction.CausesValidation = False
        Me.lblProduction.Location = New System.Drawing.Point(11, 134)
        Me.lblProduction.Name = "lblProduction"
        Me.lblProduction.Size = New System.Drawing.Size(88, 13)
        Me.lblProduction.TabIndex = 11
        Me.lblProduction.Tag = "production"
        Me.lblProduction.Text = "Происхождение"
        '
        'cbProduction
        '
        Me.cbProduction.CausesValidation = False
        Me.cbProduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduction.FormattingEnabled = True
        Me.cbProduction.Items.AddRange(New Object() {"Все", "Импортные", "Отечественные"})
        Me.cbProduction.Location = New System.Drawing.Point(404, 126)
        Me.cbProduction.Name = "cbProduction"
        Me.cbProduction.Size = New System.Drawing.Size(134, 21)
        Me.cbProduction.TabIndex = 10
        Me.cbProduction.Tag = "production"
        '
        'lblClientInn
        '
        Me.lblClientInn.AutoSize = True
        Me.lblClientInn.CausesValidation = False
        Me.lblClientInn.Location = New System.Drawing.Point(11, 107)
        Me.lblClientInn.Name = "lblClientInn"
        Me.lblClientInn.Size = New System.Drawing.Size(75, 13)
        Me.lblClientInn.TabIndex = 9
        Me.lblClientInn.Tag = "client_inn"
        Me.lblClientInn.Text = "ИНН клиента"
        Me.lblClientInn.Visible = False
        '
        'txtClientInn
        '
        Me.txtClientInn.CausesValidation = False
        Me.txtClientInn.Location = New System.Drawing.Point(404, 100)
        Me.txtClientInn.Mask = "00000000000000"
        Me.txtClientInn.Name = "txtClientInn"
        Me.txtClientInn.Size = New System.Drawing.Size(134, 20)
        Me.txtClientInn.TabIndex = 8
        Me.txtClientInn.Tag = "client_guid"
        Me.txtClientInn.Visible = False
        '
        'btnBackParameters
        '
        Me.btnBackParameters.CausesValidation = False
        Me.btnBackParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackParameters.Location = New System.Drawing.Point(6, 297)
        Me.btnBackParameters.Name = "btnBackParameters"
        Me.btnBackParameters.Size = New System.Drawing.Size(150, 23)
        Me.btnBackParameters.TabIndex = 7
        Me.btnBackParameters.Text = "<< Назад"
        Me.btnBackParameters.UseVisualStyleBackColor = True
        '
        'lblDateReportPeriod
        '
        Me.lblDateReportPeriod.AutoSize = True
        Me.lblDateReportPeriod.CausesValidation = False
        Me.lblDateReportPeriod.Location = New System.Drawing.Point(11, 81)
        Me.lblDateReportPeriod.Name = "lblDateReportPeriod"
        Me.lblDateReportPeriod.Size = New System.Drawing.Size(142, 13)
        Me.lblDateReportPeriod.TabIndex = 6
        Me.lblDateReportPeriod.Tag = "date_report_period"
        Me.lblDateReportPeriod.Text = "Начало отчётного периода"
        Me.lblDateReportPeriod.Visible = False
        '
        'lblDatehigh
        '
        Me.lblDatehigh.AutoSize = True
        Me.lblDatehigh.CausesValidation = False
        Me.lblDatehigh.Location = New System.Drawing.Point(11, 41)
        Me.lblDatehigh.Name = "lblDatehigh"
        Me.lblDatehigh.Size = New System.Drawing.Size(81, 13)
        Me.lblDatehigh.TabIndex = 5
        Me.lblDatehigh.Tag = "date_high"
        Me.lblDatehigh.Text = "Дата до     (<=)"
        Me.lblDatehigh.Visible = False
        '
        'lblDateLow
        '
        Me.lblDateLow.AutoSize = True
        Me.lblDateLow.CausesValidation = False
        Me.lblDateLow.Location = New System.Drawing.Point(11, 15)
        Me.lblDateLow.Name = "lblDateLow"
        Me.lblDateLow.Size = New System.Drawing.Size(80, 13)
        Me.lblDateLow.TabIndex = 4
        Me.lblDateLow.Tag = "date_low"
        Me.lblDateLow.Text = "Дата от     (>=)"
        Me.lblDateLow.Visible = False
        '
        'dtpDateReportPeriod
        '
        Me.dtpDateReportPeriod.CausesValidation = False
        Me.dtpDateReportPeriod.Location = New System.Drawing.Point(405, 74)
        Me.dtpDateReportPeriod.Name = "dtpDateReportPeriod"
        Me.dtpDateReportPeriod.Size = New System.Drawing.Size(134, 20)
        Me.dtpDateReportPeriod.TabIndex = 3
        Me.dtpDateReportPeriod.Tag = "date_report_period"
        Me.dtpDateReportPeriod.Visible = False
        '
        'dtpDateHigh
        '
        Me.dtpDateHigh.CausesValidation = False
        Me.dtpDateHigh.Location = New System.Drawing.Point(404, 34)
        Me.dtpDateHigh.Name = "dtpDateHigh"
        Me.dtpDateHigh.Size = New System.Drawing.Size(134, 20)
        Me.dtpDateHigh.TabIndex = 2
        Me.dtpDateHigh.Tag = "date_high"
        Me.dtpDateHigh.Visible = False
        '
        'dtpDateLow
        '
        Me.dtpDateLow.CausesValidation = False
        Me.dtpDateLow.Location = New System.Drawing.Point(404, 10)
        Me.dtpDateLow.Name = "dtpDateLow"
        Me.dtpDateLow.Size = New System.Drawing.Size(134, 20)
        Me.dtpDateLow.TabIndex = 1
        Me.dtpDateLow.Tag = "date_low"
        Me.dtpDateLow.Visible = False
        '
        'btnGenerate
        '
        Me.btnGenerate.CausesValidation = False
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Location = New System.Drawing.Point(388, 297)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(150, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Сформировать"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'pnlList
        '
        Me.pnlList.CausesValidation = False
        Me.pnlList.Controls.Add(Me.lbReports)
        Me.pnlList.Controls.Add(Me.Panel1)
        Me.pnlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlList.Location = New System.Drawing.Point(0, 0)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(544, 325)
        Me.pnlList.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.CausesValidation = False
        Me.Panel1.Controls.Add(Me.btnNextList)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.cbAggregate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 32)
        Me.Panel1.TabIndex = 3
        '
        'btnNextList
        '
        Me.btnNextList.CausesValidation = False
        Me.btnNextList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextList.Location = New System.Drawing.Point(389, 5)
        Me.btnNextList.Name = "btnNextList"
        Me.btnNextList.Size = New System.Drawing.Size(150, 23)
        Me.btnNextList.TabIndex = 12
        Me.btnNextList.Text = "Сформировать отчёт >>"
        Me.btnNextList.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.CausesValidation = False
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Location = New System.Drawing.Point(233, 5)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(150, 23)
        Me.btnExport.TabIndex = 11
        Me.btnExport.Text = "Экспорт данных >>"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'cbAggregate
        '
        Me.cbAggregate.AutoSize = True
        Me.cbAggregate.CausesValidation = False
        Me.cbAggregate.Location = New System.Drawing.Point(6, 6)
        Me.cbAggregate.Name = "cbAggregate"
        Me.cbAggregate.Size = New System.Drawing.Size(103, 17)
        Me.cbAggregate.TabIndex = 0
        Me.cbAggregate.Text = "Объединённый"
        Me.cbAggregate.UseVisualStyleBackColor = True
        '
        'pnltAggregate
        '
        Me.pnltAggregate.CausesValidation = False
        Me.pnltAggregate.Controls.Add(Me.dgvReportsDivisions)
        Me.pnltAggregate.Controls.Add(Me.Panel2)
        Me.pnltAggregate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnltAggregate.Location = New System.Drawing.Point(0, 0)
        Me.pnltAggregate.Name = "pnltAggregate"
        Me.pnltAggregate.Size = New System.Drawing.Size(544, 325)
        Me.pnltAggregate.TabIndex = 6
        '
        'dgvReportsDivisions
        '
        Me.dgvReportsDivisions.AllowUserToAddRows = False
        Me.dgvReportsDivisions.AllowUserToDeleteRows = False
        Me.dgvReportsDivisions.AutoGenerateColumns = False
        Me.dgvReportsDivisions.CausesValidation = False
        Me.dgvReportsDivisions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.useReport, Me.rowid, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvReportsDivisions.DataSource = Me.H_ReportsDivisionsBindingSource
        Me.dgvReportsDivisions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReportsDivisions.Location = New System.Drawing.Point(0, 0)
        Me.dgvReportsDivisions.Name = "dgvReportsDivisions"
        Me.dgvReportsDivisions.RowHeadersVisible = False
        Me.dgvReportsDivisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReportsDivisions.Size = New System.Drawing.Size(544, 293)
        Me.dgvReportsDivisions.TabIndex = 1
        '
        'useReport
        '
        Me.useReport.HeaderText = "Выбрать"
        Me.useReport.Name = "useReport"
        Me.useReport.Width = 55
        '
        'rowid
        '
        Me.rowid.DataPropertyName = "id"
        Me.rowid.HeaderText = "id"
        Me.rowid.Name = "rowid"
        Me.rowid.ReadOnly = True
        Me.rowid.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "creation_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Добавлен"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "division"
        Me.DataGridViewTextBoxColumn3.HeaderText = "№"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 25
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "division_title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Филиала"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date_from"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "От"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date_to"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "До"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'H_ReportsDivisionsBindingSource
        '
        Me.H_ReportsDivisionsBindingSource.DataMember = "H_ReportsDivisions"
        Me.H_ReportsDivisionsBindingSource.DataSource = Me.Reports
        '
        'Reports
        '
        Me.Reports.DataSetName = "Reports"
        Me.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.CausesValidation = False
        Me.Panel2.Controls.Add(Me.btnLoad)
        Me.Panel2.Controls.Add(Me.btnBackAggregate)
        Me.Panel2.Controls.Add(Me.btnNextAggregate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 293)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 32)
        Me.Panel2.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.CausesValidation = False
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Location = New System.Drawing.Point(232, 5)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(150, 23)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "Загрузить..."
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnBackAggregate
        '
        Me.btnBackAggregate.CausesValidation = False
        Me.btnBackAggregate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackAggregate.Location = New System.Drawing.Point(4, 5)
        Me.btnBackAggregate.Name = "btnBackAggregate"
        Me.btnBackAggregate.Size = New System.Drawing.Size(150, 23)
        Me.btnBackAggregate.TabIndex = 9
        Me.btnBackAggregate.Text = "<< Назад"
        Me.btnBackAggregate.UseVisualStyleBackColor = True
        '
        'btnNextAggregate
        '
        Me.btnNextAggregate.CausesValidation = False
        Me.btnNextAggregate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextAggregate.Location = New System.Drawing.Point(388, 5)
        Me.btnNextAggregate.Name = "btnNextAggregate"
        Me.btnNextAggregate.Size = New System.Drawing.Size(150, 23)
        Me.btnNextAggregate.TabIndex = 8
        Me.btnNextAggregate.Text = "Далее >>"
        Me.btnNextAggregate.UseVisualStyleBackColor = True
        '
        'pnlExport
        '
        Me.pnlExport.CausesValidation = False
        Me.pnlExport.Controls.Add(Me.btnBackExport)
        Me.pnlExport.Controls.Add(Me.txtDevisionTitle)
        Me.pnlExport.Controls.Add(Me.Label4)
        Me.pnlExport.Controls.Add(Me.Label1)
        Me.pnlExport.Controls.Add(Me.txtDevisionNumber)
        Me.pnlExport.Controls.Add(Me.Label2)
        Me.pnlExport.Controls.Add(Me.Label3)
        Me.pnlExport.Controls.Add(Me.dtpReportHigh)
        Me.pnlExport.Controls.Add(Me.dtpReportLow)
        Me.pnlExport.Controls.Add(Me.btnSave)
        Me.pnlExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlExport.Location = New System.Drawing.Point(0, 0)
        Me.pnlExport.Name = "pnlExport"
        Me.pnlExport.Size = New System.Drawing.Size(544, 325)
        Me.pnlExport.TabIndex = 7
        '
        'btnBackExport
        '
        Me.btnBackExport.CausesValidation = False
        Me.btnBackExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackExport.Location = New System.Drawing.Point(6, 297)
        Me.btnBackExport.Name = "btnBackExport"
        Me.btnBackExport.Size = New System.Drawing.Size(150, 23)
        Me.btnBackExport.TabIndex = 22
        Me.btnBackExport.Text = "<< Назад"
        Me.btnBackExport.UseVisualStyleBackColor = True
        '
        'txtDevisionTitle
        '
        Me.txtDevisionTitle.CausesValidation = False
        Me.txtDevisionTitle.Location = New System.Drawing.Point(122, 63)
        Me.txtDevisionTitle.MaxLength = 50
        Me.txtDevisionTitle.Name = "txtDevisionTitle"
        Me.txtDevisionTitle.Size = New System.Drawing.Size(416, 20)
        Me.txtDevisionTitle.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(11, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Tag = ""
        Me.Label4.Text = "Название филиала"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(11, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Tag = ""
        Me.Label1.Text = "Номер филиала"
        '
        'txtDevisionNumber
        '
        Me.txtDevisionNumber.CausesValidation = False
        Me.txtDevisionNumber.Location = New System.Drawing.Point(122, 89)
        Me.txtDevisionNumber.Mask = "00"
        Me.txtDevisionNumber.Name = "txtDevisionNumber"
        Me.txtDevisionNumber.Size = New System.Drawing.Size(26, 20)
        Me.txtDevisionNumber.TabIndex = 17
        Me.txtDevisionNumber.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Tag = ""
        Me.Label2.Text = "Дата до     (<=)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(11, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Tag = ""
        Me.Label3.Text = "Дата от     (>=)"
        '
        'dtpReportHigh
        '
        Me.dtpReportHigh.CausesValidation = False
        Me.dtpReportHigh.Location = New System.Drawing.Point(404, 39)
        Me.dtpReportHigh.Name = "dtpReportHigh"
        Me.dtpReportHigh.Size = New System.Drawing.Size(134, 20)
        Me.dtpReportHigh.TabIndex = 14
        Me.dtpReportHigh.Tag = ""
        '
        'dtpReportLow
        '
        Me.dtpReportLow.CausesValidation = False
        Me.dtpReportLow.Location = New System.Drawing.Point(404, 13)
        Me.dtpReportLow.Name = "dtpReportLow"
        Me.dtpReportLow.Size = New System.Drawing.Size(134, 20)
        Me.dtpReportLow.TabIndex = 13
        Me.dtpReportLow.Tag = ""
        '
        'btnSave
        '
        Me.btnSave.CausesValidation = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(388, 297)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Сохранить..."
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'H_ReportsDivisionsTableAdapter
        '
        Me.H_ReportsDivisionsTableAdapter.ClearBeforeFill = True
        '
        'GetXMLTableAdapter
        '
        Me.GetXMLTableAdapter.ClearBeforeFill = True
        '
        'frmChooseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 325)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.pnlParameters)
        Me.Controls.Add(Me.pnlExport)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.pnltAggregate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChooseReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Отчёты"
        Me.pnlParameters.ResumeLayout(False)
        Me.pnlParameters.PerformLayout()
        Me.pnlList.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnltAggregate.ResumeLayout(False)
        CType(Me.dgvReportsDivisions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.H_ReportsDivisionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlExport.ResumeLayout(False)
        Me.pnlExport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbReports As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pnlParameters As System.Windows.Forms.Panel
    Friend WithEvents dtpDateLow As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents dtpDateHigh As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateReportPeriod As System.Windows.Forms.Label
    Friend WithEvents lblDatehigh As System.Windows.Forms.Label
    Friend WithEvents lblDateLow As System.Windows.Forms.Label
    Friend WithEvents dtpDateReportPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBackParameters As System.Windows.Forms.Button
    Friend WithEvents lblClientInn As System.Windows.Forms.Label
    Friend WithEvents txtClientInn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblProduction As System.Windows.Forms.Label
    Friend WithEvents cbProduction As System.Windows.Forms.ComboBox
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbAggregate As System.Windows.Forms.CheckBox
    Friend WithEvents pnltAggregate As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBackAggregate As System.Windows.Forms.Button
    Friend WithEvents btnNextAggregate As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Reports As Inspector.Reports
    Friend WithEvents H_ReportsDivisionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents H_ReportsDivisionsTableAdapter As Inspector.ReportsTableAdapters.H_ReportsDivisionsTableAdapter
    Friend WithEvents dgvReportsDivisions As System.Windows.Forms.DataGridView
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents pnlExport As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDevisionNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpReportHigh As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReportLow As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDevisionTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GetXMLTableAdapter As Inspector.ReportsTableAdapters.GetXMLTableAdapter
    Friend WithEvents QueriesTableAdapter As Inspector.ReportsTableAdapters.QueriesTableAdapter
    Friend WithEvents btnBackExport As System.Windows.Forms.Button
    Friend WithEvents btnNextList As System.Windows.Forms.Button
    Friend WithEvents useReport As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents rowid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
