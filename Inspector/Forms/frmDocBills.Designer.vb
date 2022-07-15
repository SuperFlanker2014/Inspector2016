<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocBills
    Inherits CAppForm

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocBills))
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Doc_numberLabel = New System.Windows.Forms.Label()
        Me.Client_innLabel = New System.Windows.Forms.Label()
        Me.Doc_dateLabel = New System.Windows.Forms.Label()
        Me.lblObject = New System.Windows.Forms.Label()
        Me.dtpDate_low = New System.Windows.Forms.DateTimePicker()
        Me.txtClient_address = New System.Windows.Forms.TextBox()
        Me.bsClients = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPayments = New Inspector.Docs_Payments()
        Me.txtClient_name = New System.Windows.Forms.TextBox()
        Me.Client_innMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.bsAgreements = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doc_numberMaskTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.bsBills = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doc_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.pnlDoc = New System.Windows.Forms.Panel()
        Me.txtVans = New System.Windows.Forms.TextBox()
        Me.lblVans = New System.Windows.Forms.Label()
        Me.txtFactAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlTransaction = New System.Windows.Forms.Panel()
        Me.btnTransact = New System.Windows.Forms.Button()
        Me.dtpPaydoc_date = New System.Windows.Forms.DateTimePicker()
        Me.txtPaydoc_num = New System.Windows.Forms.TextBox()
        Me.cbCash = New System.Windows.Forms.CheckBox()
        Me.txtTaxRate = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtAgreementNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.DocidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtbDoc_number = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbClient_inn = New System.Windows.Forms.MaskedTextBox()
        Me.cbTransacted = New System.Windows.Forms.CheckBox()
        Me.dtpDate_high = New System.Windows.Forms.DateTimePicker()
        Me.lblHighDate = New System.Windows.Forms.Label()
        Me.dgvServices = New Inspector.dgvWithoutEnter()
        Me.DocidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.line_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilltypeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column_service_title = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sum_factorColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.sum_factor_titleColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.bnBills = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExportTo1C = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ЭкспортВ1СToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВосстановлениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopy = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnCopyPrePre = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopyPrePost = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopyPostPost = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrint = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnBillPrePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBillPreAddPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBillPostPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBillPostAddPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrintPreview = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnBillPrePreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBillPreAddPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBillPostPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBillPostAddPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbBillPatterns = New System.Windows.Forms.ToolStripComboBox()
        Me.btnFill = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlSearchButton = New System.Windows.Forms.Panel()
        Me.txtDoc_id = New System.Windows.Forms.TextBox()
        Me.taBills = New Inspector.Docs_PaymentsTableAdapters.Docs_BillsTableAdapter()
        Me.taAgreements = New Inspector.Docs_PaymentsTableAdapters.Docs_AgreementsTableAdapter()
        Me.taClients = New Inspector.Docs_PaymentsTableAdapters.R_clientsTableAdapter()
        Me.taServices = New Inspector.Docs_PaymentsTableAdapters.Docs_Bills_ServicesTableAdapter()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAgreements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDoc.SuspendLayout()
        Me.pnlTransaction.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnBills.SuspendLayout()
        Me.pnlSearchButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.CausesValidation = False
        Me.lblAddress.Location = New System.Drawing.Point(5, 54)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(38, 13)
        Me.lblAddress.TabIndex = 74
        Me.lblAddress.Text = "Адрес"
        '
        'Doc_numberLabel
        '
        Me.Doc_numberLabel.AutoSize = True
        Me.Doc_numberLabel.CausesValidation = False
        Me.Doc_numberLabel.Location = New System.Drawing.Point(161, 9)
        Me.Doc_numberLabel.Name = "Doc_numberLabel"
        Me.Doc_numberLabel.Size = New System.Drawing.Size(50, 13)
        Me.Doc_numberLabel.TabIndex = 2
        Me.Doc_numberLabel.Text = "№ Счёта"
        '
        'Client_innLabel
        '
        Me.Client_innLabel.AutoSize = True
        Me.Client_innLabel.CausesValidation = False
        Me.Client_innLabel.Location = New System.Drawing.Point(5, 32)
        Me.Client_innLabel.Name = "Client_innLabel"
        Me.Client_innLabel.Size = New System.Drawing.Size(31, 13)
        Me.Client_innLabel.TabIndex = 4
        Me.Client_innLabel.Text = "ИНН"
        '
        'Doc_dateLabel
        '
        Me.Doc_dateLabel.AutoSize = True
        Me.Doc_dateLabel.CausesValidation = False
        Me.Doc_dateLabel.Location = New System.Drawing.Point(299, 9)
        Me.Doc_dateLabel.Name = "Doc_dateLabel"
        Me.Doc_dateLabel.Size = New System.Drawing.Size(18, 13)
        Me.Doc_dateLabel.TabIndex = 6
        Me.Doc_dateLabel.Text = "от"
        '
        'lblObject
        '
        Me.lblObject.AutoSize = True
        Me.lblObject.CausesValidation = False
        Me.lblObject.Location = New System.Drawing.Point(48, 8)
        Me.lblObject.Name = "lblObject"
        Me.lblObject.Size = New System.Drawing.Size(47, 13)
        Me.lblObject.TabIndex = 80
        Me.lblObject.Text = "Дата от"
        '
        'dtpDate_low
        '
        Me.dtpDate_low.CausesValidation = False
        Me.dtpDate_low.Location = New System.Drawing.Point(100, 4)
        Me.dtpDate_low.Name = "dtpDate_low"
        Me.dtpDate_low.Size = New System.Drawing.Size(135, 20)
        Me.dtpDate_low.TabIndex = 77
        '
        'txtClient_address
        '
        Me.txtClient_address.CausesValidation = False
        Me.txtClient_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_adress", True))
        Me.txtClient_address.Location = New System.Drawing.Point(52, 51)
        Me.txtClient_address.Name = "txtClient_address"
        Me.txtClient_address.ReadOnly = True
        Me.txtClient_address.Size = New System.Drawing.Size(644, 20)
        Me.txtClient_address.TabIndex = 73
        '
        'bsClients
        '
        Me.bsClients.DataMember = "R_clients"
        Me.bsClients.DataSource = Me.dsPayments
        '
        'dsPayments
        '
        Me.dsPayments.DataSetName = "Docs_Payments"
        Me.dsPayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtClient_name
        '
        Me.txtClient_name.CausesValidation = False
        Me.txtClient_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_name", True))
        Me.txtClient_name.Location = New System.Drawing.Point(157, 29)
        Me.txtClient_name.Name = "txtClient_name"
        Me.txtClient_name.ReadOnly = True
        Me.txtClient_name.Size = New System.Drawing.Size(470, 20)
        Me.txtClient_name.TabIndex = 72
        '
        'Client_innMaskedTextBox
        '
        Me.Client_innMaskedTextBox.CausesValidation = False
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_inn", True))
        Me.Client_innMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Client_innMaskedTextBox.Location = New System.Drawing.Point(52, 29)
        Me.Client_innMaskedTextBox.Mask = "00000000000000"
        Me.Client_innMaskedTextBox.Name = "Client_innMaskedTextBox"
        Me.Client_innMaskedTextBox.ReadOnly = True
        Me.Client_innMaskedTextBox.Size = New System.Drawing.Size(103, 20)
        Me.Client_innMaskedTextBox.TabIndex = 3
        '
        'bsAgreements
        '
        Me.bsAgreements.DataMember = "Docs_Agreements"
        Me.bsAgreements.DataSource = Me.dsPayments
        '
        'Doc_numberMaskTextBox
        '
        Me.Doc_numberMaskTextBox.CausesValidation = False
        Me.Doc_numberMaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "doc_number", True))
        Me.Doc_numberMaskTextBox.Location = New System.Drawing.Point(217, 6)
        Me.Doc_numberMaskTextBox.Mask = "00000000"
        Me.Doc_numberMaskTextBox.Name = "Doc_numberMaskTextBox"
        Me.Doc_numberMaskTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Doc_numberMaskTextBox.TabIndex = 1
        '
        'bsBills
        '
        Me.bsBills.DataMember = "Docs_Bills"
        Me.bsBills.DataSource = Me.dsPayments
        '
        'Doc_dateDateTimePicker
        '
        Me.Doc_dateDateTimePicker.CausesValidation = False
        Me.Doc_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "doc_date", True))
        Me.Doc_dateDateTimePicker.Location = New System.Drawing.Point(323, 6)
        Me.Doc_dateDateTimePicker.Name = "Doc_dateDateTimePicker"
        Me.Doc_dateDateTimePicker.Size = New System.Drawing.Size(135, 20)
        Me.Doc_dateDateTimePicker.TabIndex = 2
        '
        'pnlDoc
        '
        Me.pnlDoc.CausesValidation = False
        Me.pnlDoc.Controls.Add(Me.txtVans)
        Me.pnlDoc.Controls.Add(Me.lblVans)
        Me.pnlDoc.Controls.Add(Me.txtFactAddress)
        Me.pnlDoc.Controls.Add(Me.Label6)
        Me.pnlDoc.Controls.Add(Me.pnlTransaction)
        Me.pnlDoc.Controls.Add(Me.txtTaxRate)
        Me.pnlDoc.Controls.Add(Me.CheckBox1)
        Me.pnlDoc.Controls.Add(Me.txtAgreementNumber)
        Me.pnlDoc.Controls.Add(Me.Label3)
        Me.pnlDoc.Controls.Add(Me.Label2)
        Me.pnlDoc.Controls.Add(Me.Label1)
        Me.pnlDoc.Controls.Add(Me.txtSum)
        Me.pnlDoc.Controls.Add(Me.txtClient_name)
        Me.pnlDoc.Controls.Add(Me.Doc_dateDateTimePicker)
        Me.pnlDoc.Controls.Add(Me.Doc_dateLabel)
        Me.pnlDoc.Controls.Add(Me.Client_innLabel)
        Me.pnlDoc.Controls.Add(Me.Doc_numberLabel)
        Me.pnlDoc.Controls.Add(Me.Doc_numberMaskTextBox)
        Me.pnlDoc.Controls.Add(Me.Client_innMaskedTextBox)
        Me.pnlDoc.Controls.Add(Me.txtClient_address)
        Me.pnlDoc.Controls.Add(Me.lblAddress)
        Me.pnlDoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDoc.Location = New System.Drawing.Point(0, 32)
        Me.pnlDoc.Name = "pnlDoc"
        Me.pnlDoc.Size = New System.Drawing.Size(858, 122)
        Me.pnlDoc.TabIndex = 6
        '
        'txtVans
        '
        Me.txtVans.CausesValidation = False
        Me.txtVans.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "vans", True))
        Me.txtVans.Location = New System.Drawing.Point(79, 95)
        Me.txtVans.MaxLength = 500
        Me.txtVans.Name = "txtVans"
        Me.txtVans.Size = New System.Drawing.Size(617, 20)
        Me.txtVans.TabIndex = 87
        '
        'lblVans
        '
        Me.lblVans.AutoSize = True
        Me.lblVans.CausesValidation = False
        Me.lblVans.Location = New System.Drawing.Point(5, 98)
        Me.lblVans.Name = "lblVans"
        Me.lblVans.Size = New System.Drawing.Size(45, 13)
        Me.lblVans.TabIndex = 88
        Me.lblVans.Text = "Вагоны"
        '
        'txtFactAddress
        '
        Me.txtFactAddress.CausesValidation = False
        Me.txtFactAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "fact_address", True))
        Me.txtFactAddress.Location = New System.Drawing.Point(79, 73)
        Me.txtFactAddress.Name = "txtFactAddress"
        Me.txtFactAddress.Size = New System.Drawing.Size(617, 20)
        Me.txtFactAddress.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.CausesValidation = False
        Me.Label6.Location = New System.Drawing.Point(5, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Факт. адрес"
        '
        'pnlTransaction
        '
        Me.pnlTransaction.CausesValidation = False
        Me.pnlTransaction.Controls.Add(Me.btnTransact)
        Me.pnlTransaction.Controls.Add(Me.dtpPaydoc_date)
        Me.pnlTransaction.Controls.Add(Me.txtPaydoc_num)
        Me.pnlTransaction.Controls.Add(Me.cbCash)
        Me.pnlTransaction.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTransaction.Location = New System.Drawing.Point(702, 0)
        Me.pnlTransaction.Name = "pnlTransaction"
        Me.pnlTransaction.Size = New System.Drawing.Size(156, 122)
        Me.pnlTransaction.TabIndex = 84
        '
        'btnTransact
        '
        Me.btnTransact.CausesValidation = False
        Me.btnTransact.Location = New System.Drawing.Point(13, 7)
        Me.btnTransact.Name = "btnTransact"
        Me.btnTransact.Size = New System.Drawing.Size(131, 23)
        Me.btnTransact.TabIndex = 2
        Me.btnTransact.Text = "Провести"
        Me.btnTransact.UseVisualStyleBackColor = True
        '
        'dtpPaydoc_date
        '
        Me.dtpPaydoc_date.CalendarTrailingForeColor = System.Drawing.SystemColors.Window
        Me.dtpPaydoc_date.CausesValidation = False
        Me.dtpPaydoc_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsBills, "paydoc_date", True))
        Me.dtpPaydoc_date.Location = New System.Drawing.Point(13, 50)
        Me.dtpPaydoc_date.Name = "dtpPaydoc_date"
        Me.dtpPaydoc_date.Size = New System.Drawing.Size(131, 20)
        Me.dtpPaydoc_date.TabIndex = 1
        '
        'txtPaydoc_num
        '
        Me.txtPaydoc_num.CausesValidation = False
        Me.txtPaydoc_num.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "paydoc_num", True))
        Me.txtPaydoc_num.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPaydoc_num.Location = New System.Drawing.Point(55, 30)
        Me.txtPaydoc_num.Name = "txtPaydoc_num"
        Me.txtPaydoc_num.Size = New System.Drawing.Size(89, 20)
        Me.txtPaydoc_num.TabIndex = 0
        '
        'cbCash
        '
        Me.cbCash.AutoSize = True
        Me.cbCash.CausesValidation = False
        Me.cbCash.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsBills, "is_cash", True))
        Me.cbCash.Location = New System.Drawing.Point(14, 32)
        Me.cbCash.Name = "cbCash"
        Me.cbCash.Size = New System.Drawing.Size(44, 17)
        Me.cbCash.TabIndex = 3
        Me.cbCash.Text = "нал"
        Me.cbCash.UseVisualStyleBackColor = True
        '
        'txtTaxRate
        '
        Me.txtTaxRate.CausesValidation = False
        Me.txtTaxRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "tax_nds", True))
        Me.txtTaxRate.Location = New System.Drawing.Point(502, 6)
        Me.txtTaxRate.MaxLength = 5
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(34, 20)
        Me.txtTaxRate.TabIndex = 83
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CausesValidation = False
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsBills, "is_russia", True))
        Me.CheckBox1.Location = New System.Drawing.Point(633, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox1.TabIndex = 82
        Me.CheckBox1.Text = "Россия"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtAgreementNumber
        '
        Me.txtAgreementNumber.CausesValidation = False
        Me.txtAgreementNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgreements, "doc_number", True))
        Me.txtAgreementNumber.Location = New System.Drawing.Point(79, 6)
        Me.txtAgreementNumber.Name = "txtAgreementNumber"
        Me.txtAgreementNumber.ReadOnly = True
        Me.txtAgreementNumber.Size = New System.Drawing.Size(76, 20)
        Me.txtAgreementNumber.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "№ Договора"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(536, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Сумма"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(464, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "НДС"
        '
        'txtSum
        '
        Me.txtSum.CausesValidation = False
        Me.txtSum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "doc_sum", True))
        Me.txtSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtSum.Location = New System.Drawing.Point(583, 7)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.txtSum.Size = New System.Drawing.Size(113, 20)
        Me.txtSum.TabIndex = 76
        '
        'DocidDataGridViewTextBoxColumn
        '
        Me.DocidDataGridViewTextBoxColumn.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.Name = "DocidDataGridViewTextBoxColumn"
        Me.DocidDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn.Visible = False
        '
        'pnlSearch
        '
        Me.pnlSearch.CausesValidation = False
        Me.pnlSearch.Controls.Add(Me.Label5)
        Me.pnlSearch.Controls.Add(Me.mtbDoc_number)
        Me.pnlSearch.Controls.Add(Me.Label4)
        Me.pnlSearch.Controls.Add(Me.mtbClient_inn)
        Me.pnlSearch.Controls.Add(Me.cbTransacted)
        Me.pnlSearch.Controls.Add(Me.dtpDate_high)
        Me.pnlSearch.Controls.Add(Me.dtpDate_low)
        Me.pnlSearch.Controls.Add(Me.lblHighDate)
        Me.pnlSearch.Controls.Add(Me.lblObject)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 154)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(858, 80)
        Me.pnlSearch.TabIndex = 87
        Me.pnlSearch.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.CausesValidation = False
        Me.Label5.Location = New System.Drawing.Point(241, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "№ Счёта"
        '
        'mtbDoc_number
        '
        Me.mtbDoc_number.CausesValidation = False
        Me.mtbDoc_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "doc_number", True))
        Me.mtbDoc_number.Location = New System.Drawing.Point(302, 30)
        Me.mtbDoc_number.Mask = "00000000"
        Me.mtbDoc_number.Name = "mtbDoc_number"
        Me.mtbDoc_number.Size = New System.Drawing.Size(114, 20)
        Me.mtbDoc_number.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(241, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "ИНН"
        '
        'mtbClient_inn
        '
        Me.mtbClient_inn.CausesValidation = False
        Me.mtbClient_inn.Location = New System.Drawing.Point(302, 4)
        Me.mtbClient_inn.Mask = "00000000000000"
        Me.mtbClient_inn.Name = "mtbClient_inn"
        Me.mtbClient_inn.Size = New System.Drawing.Size(114, 20)
        Me.mtbClient_inn.TabIndex = 90
        '
        'cbTransacted
        '
        Me.cbTransacted.AutoSize = True
        Me.cbTransacted.CausesValidation = False
        Me.cbTransacted.Checked = True
        Me.cbTransacted.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.cbTransacted.Location = New System.Drawing.Point(100, 56)
        Me.cbTransacted.Name = "cbTransacted"
        Me.cbTransacted.Size = New System.Drawing.Size(73, 17)
        Me.cbTransacted.TabIndex = 89
        Me.cbTransacted.Text = "оплачено"
        Me.cbTransacted.ThreeState = True
        Me.cbTransacted.UseVisualStyleBackColor = True
        '
        'dtpDate_high
        '
        Me.dtpDate_high.CausesValidation = False
        Me.dtpDate_high.Location = New System.Drawing.Point(100, 30)
        Me.dtpDate_high.Name = "dtpDate_high"
        Me.dtpDate_high.Size = New System.Drawing.Size(135, 20)
        Me.dtpDate_high.TabIndex = 88
        '
        'lblHighDate
        '
        Me.lblHighDate.AutoSize = True
        Me.lblHighDate.CausesValidation = False
        Me.lblHighDate.Location = New System.Drawing.Point(76, 34)
        Me.lblHighDate.Name = "lblHighDate"
        Me.lblHighDate.Size = New System.Drawing.Size(19, 13)
        Me.lblHighDate.TabIndex = 87
        Me.lblHighDate.Text = "до"
        '
        'dgvServices
        '
        Me.dgvServices.AllowUserToResizeRows = False
        Me.dgvServices.AutoGenerateColumns = False
        Me.dgvServices.CausesValidation = False
        Me.dgvServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocidDataGridViewTextBoxColumn1, Me.line_number, Me.BilltypeDataGridViewCheckBoxColumn, Me.Column_service_title, Me.unit, Me.RateDataGridViewTextBoxColumn, Me.CountDataGridViewTextBoxColumn, Me.sum_factorColumn, Me.sum_factor_titleColumn, Me.SumDataGridViewTextBoxColumn})
        Me.dgvServices.DataSource = Me.bsServices
        Me.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvServices.Location = New System.Drawing.Point(0, 259)
        Me.dgvServices.MultiSelect = False
        Me.dgvServices.Name = "dgvServices"
        Me.dgvServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvServices.Size = New System.Drawing.Size(858, 233)
        Me.dgvServices.TabIndex = 3
        '
        'DocidDataGridViewTextBoxColumn1
        '
        Me.DocidDataGridViewTextBoxColumn1.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.Name = "DocidDataGridViewTextBoxColumn1"
        Me.DocidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DocidDataGridViewTextBoxColumn1.Visible = False
        '
        'line_number
        '
        Me.line_number.DataPropertyName = "line_number"
        Me.line_number.HeaderText = "line_number"
        Me.line_number.Name = "line_number"
        Me.line_number.ReadOnly = True
        Me.line_number.Visible = False
        '
        'BilltypeDataGridViewCheckBoxColumn
        '
        Me.BilltypeDataGridViewCheckBoxColumn.DataPropertyName = "bill_type"
        Me.BilltypeDataGridViewCheckBoxColumn.HeaderText = "bill_type"
        Me.BilltypeDataGridViewCheckBoxColumn.Name = "BilltypeDataGridViewCheckBoxColumn"
        Me.BilltypeDataGridViewCheckBoxColumn.Visible = False
        '
        'Column_service_title
        '
        Me.Column_service_title.DataPropertyName = "service_title"
        Me.Column_service_title.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Column_service_title.DisplayStyleForCurrentCellOnly = True
        Me.Column_service_title.HeaderText = "Наименование услуги"
        Me.Column_service_title.Name = "Column_service_title"
        Me.Column_service_title.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_service_title.Width = 380
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "Единица"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 80
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Цена"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        Me.RateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RateDataGridViewTextBoxColumn.Width = 70
        '
        'CountDataGridViewTextBoxColumn
        '
        Me.CountDataGridViewTextBoxColumn.DataPropertyName = "count"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CountDataGridViewTextBoxColumn.HeaderText = "Количество"
        Me.CountDataGridViewTextBoxColumn.Name = "CountDataGridViewTextBoxColumn"
        Me.CountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'sum_factorColumn
        '
        Me.sum_factorColumn.DataPropertyName = "sum_factor"
        Me.sum_factorColumn.DisplayStyleForCurrentCellOnly = True
        Me.sum_factorColumn.HeaderText = "Коэффициент"
        Me.sum_factorColumn.Name = "sum_factorColumn"
        Me.sum_factorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sum_factorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sum_factorColumn.Visible = False
        Me.sum_factorColumn.Width = 80
        '
        'sum_factor_titleColumn
        '
        Me.sum_factor_titleColumn.DataPropertyName = "sum_factor_title"
        Me.sum_factor_titleColumn.DisplayStyleForCurrentCellOnly = True
        Me.sum_factor_titleColumn.HeaderText = "Коэффициент"
        Me.sum_factor_titleColumn.Name = "sum_factor_titleColumn"
        Me.sum_factor_titleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sum_factor_titleColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SumDataGridViewTextBoxColumn
        '
        Me.SumDataGridViewTextBoxColumn.DataPropertyName = "sum"
        Me.SumDataGridViewTextBoxColumn.HeaderText = "Сумма"
        Me.SumDataGridViewTextBoxColumn.Name = "SumDataGridViewTextBoxColumn"
        Me.SumDataGridViewTextBoxColumn.ReadOnly = True
        Me.SumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SumDataGridViewTextBoxColumn.Width = 65
        '
        'bsServices
        '
        Me.bsServices.AllowNew = True
        Me.bsServices.DataMember = "FK_Docs_Bills_Services_Docs_Bills"
        Me.bsServices.DataSource = Me.bsBills
        '
        'bnBills
        '
        Me.bnBills.AddNewItem = Nothing
        Me.bnBills.BindingSource = Me.bsBills
        Me.bnBills.CountItem = Me.BindingNavigatorCountItem
        Me.bnBills.DeleteItem = Nothing
        Me.bnBills.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.btnSave, Me.btnExportTo1C, Me.btnCopy, Me.btnPrint, Me.btnPrintPreview, Me.cbBillPatterns, Me.btnFill})
        Me.bnBills.Location = New System.Drawing.Point(0, 234)
        Me.bnBills.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnBills.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnBills.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnBills.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnBills.Name = "bnBills"
        Me.bnBills.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnBills.Size = New System.Drawing.Size(858, 25)
        Me.bnBills.TabIndex = 2
        Me.bnBills.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel1.Text = "Счета"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.CausesValidation = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Новый СЧЁТ"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить счёт"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Сохранить"
        '
        'btnExportTo1C
        '
        Me.btnExportTo1C.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportTo1C.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExportTo1C.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВ1СToolStripMenuItem, Me.ВосстановлениеToolStripMenuItem})
        Me.btnExportTo1C.Image = CType(resources.GetObject("btnExportTo1C.Image"), System.Drawing.Image)
        Me.btnExportTo1C.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportTo1C.Name = "btnExportTo1C"
        Me.btnExportTo1C.Size = New System.Drawing.Size(29, 22)
        Me.btnExportTo1C.Text = "Экспорт в 1С"
        '
        'ЭкспортВ1СToolStripMenuItem
        '
        Me.ЭкспортВ1СToolStripMenuItem.Name = "ЭкспортВ1СToolStripMenuItem"
        Me.ЭкспортВ1СToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ЭкспортВ1СToolStripMenuItem.Text = "Экспорт в 1С"
        '
        'ВосстановлениеToolStripMenuItem
        '
        Me.ВосстановлениеToolStripMenuItem.Name = "ВосстановлениеToolStripMenuItem"
        Me.ВосстановлениеToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ВосстановлениеToolStripMenuItem.Text = "Восстановление"
        Me.ВосстановлениеToolStripMenuItem.Visible = False
        '
        'btnCopy
        '
        Me.btnCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopyPrePre, Me.btnCopyPrePost, Me.btnCopyPostPost})
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(29, 22)
        Me.btnCopy.Text = "Копировать в"
        '
        'btnCopyPrePre
        '
        Me.btnCopyPrePre.Name = "btnCopyPrePre"
        Me.btnCopyPrePre.Size = New System.Drawing.Size(204, 22)
        Me.btnCopyPrePre.Text = "В счёт на ПРЕДОПЛАТУ"
        '
        'btnCopyPrePost
        '
        Me.btnCopyPrePost.Name = "btnCopyPrePost"
        Me.btnCopyPrePost.Size = New System.Drawing.Size(204, 22)
        Me.btnCopyPrePost.Text = "В счёт-ФАКТУРУ"
        '
        'btnCopyPostPost
        '
        Me.btnCopyPostPost.Name = "btnCopyPostPost"
        Me.btnCopyPostPost.Size = New System.Drawing.Size(204, 22)
        Me.btnCopyPostPost.Text = "В счёт-ФАКТУРУ"
        '
        'btnPrint
        '
        Me.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBillPrePrint, Me.btnBillPreAddPrint, Me.btnBillPostPrint, Me.btnBillPostAddPrint})
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(29, 22)
        Me.btnPrint.Text = "Печать"
        '
        'btnBillPrePrint
        '
        Me.btnBillPrePrint.Name = "btnBillPrePrint"
        Me.btnBillPrePrint.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPrePrint.Text = "Счёт на предоплату"
        '
        'btnBillPreAddPrint
        '
        Me.btnBillPreAddPrint.Name = "btnBillPreAddPrint"
        Me.btnBillPreAddPrint.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPreAddPrint.Text = "Протокол согласования цены"
        '
        'btnBillPostPrint
        '
        Me.btnBillPostPrint.Name = "btnBillPostPrint"
        Me.btnBillPostPrint.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPostPrint.Text = "Счёт-фактура"
        '
        'btnBillPostAddPrint
        '
        Me.btnBillPostAddPrint.Name = "btnBillPostAddPrint"
        Me.btnBillPostAddPrint.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPostAddPrint.Text = "Акт приёма-передачи работ"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrintPreview.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBillPrePreview, Me.btnBillPreAddPreview, Me.btnBillPostPreview, Me.btnBillPostAddPreview})
        Me.btnPrintPreview.Image = CType(resources.GetObject("btnPrintPreview.Image"), System.Drawing.Image)
        Me.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(29, 22)
        Me.btnPrintPreview.Text = "Предпросмотр"
        '
        'btnBillPrePreview
        '
        Me.btnBillPrePreview.Name = "btnBillPrePreview"
        Me.btnBillPrePreview.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPrePreview.Text = "Счёт на предоплату"
        '
        'btnBillPreAddPreview
        '
        Me.btnBillPreAddPreview.Name = "btnBillPreAddPreview"
        Me.btnBillPreAddPreview.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPreAddPreview.Text = "Протокол согласования цены"
        '
        'btnBillPostPreview
        '
        Me.btnBillPostPreview.Name = "btnBillPostPreview"
        Me.btnBillPostPreview.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPostPreview.Text = "Счёт-фактура"
        '
        'btnBillPostAddPreview
        '
        Me.btnBillPostAddPreview.Name = "btnBillPostAddPreview"
        Me.btnBillPostAddPreview.Size = New System.Drawing.Size(240, 22)
        Me.btnBillPostAddPreview.Text = "Акт приёма-передачи работ"
        '
        'cbBillPatterns
        '
        Me.cbBillPatterns.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbBillPatterns.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBillPatterns.CausesValidation = False
        Me.cbBillPatterns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillPatterns.DropDownWidth = 350
        Me.cbBillPatterns.Name = "cbBillPatterns"
        Me.cbBillPatterns.Size = New System.Drawing.Size(350, 25)
        '
        'btnFill
        '
        Me.btnFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFill.Image = CType(resources.GetObject("btnFill.Image"), System.Drawing.Image)
        Me.btnFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(70, 22)
        Me.btnFill.Text = "Заполнить"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnSearch
        '
        Me.btnSearch.CausesValidation = False
        Me.btnSearch.Location = New System.Drawing.Point(8, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(138, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Найти"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlSearchButton
        '
        Me.pnlSearchButton.CausesValidation = False
        Me.pnlSearchButton.Controls.Add(Me.txtDoc_id)
        Me.pnlSearchButton.Controls.Add(Me.btnSearch)
        Me.pnlSearchButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchButton.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearchButton.Name = "pnlSearchButton"
        Me.pnlSearchButton.Size = New System.Drawing.Size(858, 32)
        Me.pnlSearchButton.TabIndex = 89
        '
        'txtDoc_id
        '
        Me.txtDoc_id.CausesValidation = False
        Me.txtDoc_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBills, "doc_id", True))
        Me.txtDoc_id.Location = New System.Drawing.Point(900, 5)
        Me.txtDoc_id.Name = "txtDoc_id"
        Me.txtDoc_id.Size = New System.Drawing.Size(100, 20)
        Me.txtDoc_id.TabIndex = 1
        '
        'taBills
        '
        Me.taBills.ClearBeforeFill = True
        '
        'taAgreements
        '
        Me.taAgreements.ClearBeforeFill = True
        '
        'taClients
        '
        Me.taClients.ClearBeforeFill = True
        '
        'taServices
        '
        Me.taServices.ClearBeforeFill = True
        '
        'frmDocBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 492)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.dgvServices)
        Me.Controls.Add(Me.bnBills)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlDoc)
        Me.Controls.Add(Me.pnlSearchButton)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("isTransacted", Me.bsBills, "is_transacted", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDocBills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAgreements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDoc.ResumeLayout(False)
        Me.pnlDoc.PerformLayout()
        Me.pnlTransaction.ResumeLayout(False)
        Me.pnlTransaction.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnBills.ResumeLayout(False)
        Me.bnBills.PerformLayout()
        Me.pnlSearchButton.ResumeLayout(False)
        Me.pnlSearchButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Doc_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Doc_numberMaskTextBox As System.Windows.Forms.MaskedTextBox
    'Inspector.dgvWithoutEnter
    'Inspector.dgvWithoutEnter
    Friend WithEvents Client_innMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtClient_address As System.Windows.Forms.TextBox
    Friend WithEvents txtClient_name As System.Windows.Forms.TextBox
    Friend WithEvents DocidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblObject As System.Windows.Forms.Label
    Friend WithEvents dtpDate_low As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlDoc As System.Windows.Forms.Panel
    Friend WithEvents Doc_numberLabel As System.Windows.Forms.Label
    Friend WithEvents Client_innLabel As System.Windows.Forms.Label
    Friend WithEvents Doc_dateLabel As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents bnBills As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblHighDate As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents dsPayments As Inspector.Docs_Payments
    Friend WithEvents taBills As Inspector.Docs_PaymentsTableAdapters.Docs_BillsTableAdapter
    Friend WithEvents taAgreements As Inspector.Docs_PaymentsTableAdapters.Docs_AgreementsTableAdapter
    Friend WithEvents taClients As Inspector.Docs_PaymentsTableAdapters.R_clientsTableAdapter
    Friend WithEvents taServices As Inspector.Docs_PaymentsTableAdapters.Docs_Bills_ServicesTableAdapter
    Friend WithEvents bsBills As System.Windows.Forms.BindingSource
    Friend WithEvents bsServices As System.Windows.Forms.BindingSource
    Friend WithEvents bsAgreements As System.Windows.Forms.BindingSource
    Friend WithEvents bsClients As System.Windows.Forms.BindingSource
    Friend WithEvents dgvServices As dgvWithoutEnter 'System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlSearchButton As System.Windows.Forms.Panel
    Friend WithEvents txtAgreementNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents txtDoc_id As System.Windows.Forms.TextBox
    Friend WithEvents pnlTransaction As System.Windows.Forms.Panel
    Friend WithEvents txtPaydoc_num As System.Windows.Forms.TextBox
    Friend WithEvents dtpPaydoc_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTransact As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnBillPrePreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillPreAddPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnBillPrePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillPreAddPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbTransacted As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDate_high As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtbClient_inn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mtbDoc_number As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DoccreationdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnCopyPrePre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopyPrePost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbCash As System.Windows.Forms.CheckBox
    Friend WithEvents btnCopyPostPost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillPostPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillPostAddPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillPostPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillPostAddPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbBillPatterns As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnFill As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtFactAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DocidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents line_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilltypeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column_service_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sum_factorColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents sum_factor_titleColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtVans As System.Windows.Forms.TextBox
    Friend WithEvents lblVans As System.Windows.Forms.Label
    Friend WithEvents btnExportTo1C As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ЭкспортВ1СToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВосстановлениеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
