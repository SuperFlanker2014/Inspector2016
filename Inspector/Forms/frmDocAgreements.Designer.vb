<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocAgreements
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocAgreements))
        Me.lblAddress = New System.Windows.Forms.Label
        Me.Doc_numberLabel = New System.Windows.Forms.Label
        Me.Client_innLabel = New System.Windows.Forms.Label
        Me.Doc_dateLabel = New System.Windows.Forms.Label
        Me.bsAgreements = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPayments = New Inspector.Docs_Payments
        Me.txtClient_address = New System.Windows.Forms.TextBox
        Me.bsClients = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtClient_name = New System.Windows.Forms.TextBox
        Me.Client_innMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Doc_numberMaskTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Doc_dateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New System.Windows.Forms.Button
        Me.pnlDoc = New System.Windows.Forms.Panel
        Me.lblMoney = New System.Windows.Forms.Label
        Me.txtSum = New System.Windows.Forms.TextBox
        Me.Doc_date_highDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.lblName = New System.Windows.Forms.Label
        Me.lblHighDate = New System.Windows.Forms.Label
        Me.DocidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlMain = New System.Windows.Forms.TableLayoutPanel
        Me.tsPost = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.btnAddPost = New System.Windows.Forms.ToolStripButton
        Me.btnHideTransactedPost = New System.Windows.Forms.ToolStripButton
        Me.dgvBillsPre = New System.Windows.Forms.DataGridView
        Me.DocidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocsumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxndsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsrussiaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column_is_transacted = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column_is_transacted_visible = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaydocnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaydocdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BilltypeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.bsBillsPre = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvBillsPost = New System.Windows.Forms.DataGridView
        Me.DocidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocnumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocsumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxndsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsrussiaDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IstransactedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column_is_transacted_vidible1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaydocnumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaydocdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BilltypeDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.line_number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsBillsPost = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsPre = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnAddPre = New System.Windows.Forms.ToolStripButton
        Me.btnHideTransactedPre = New System.Windows.Forms.ToolStripButton
        Me.taAgreements = New Inspector.Docs_PaymentsTableAdapters.Docs_AgreementsTableAdapter
        Me.taClients = New Inspector.Docs_PaymentsTableAdapters.R_clientsTableAdapter
        Me.taBills = New Inspector.Docs_PaymentsTableAdapters.Docs_BillsTableAdapter
        Me.bnAgreements = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnNew = New System.Windows.Forms.ToolStripButton
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        Me.btnSave = New System.Windows.Forms.ToolStripButton
        Me.btnCopyAll = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.btnMakeAct = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrintMenu = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton
        CType(Me.bsAgreements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDoc.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.tsPost.SuspendLayout()
        CType(Me.dgvBillsPre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBillsPre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBillsPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBillsPost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsPre.SuspendLayout()
        CType(Me.bnAgreements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnAgreements.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.CausesValidation = False
        Me.lblAddress.Location = New System.Drawing.Point(5, 90)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(38, 13)
        Me.lblAddress.TabIndex = 74
        Me.lblAddress.Text = "Адрес"
        '
        'Doc_numberLabel
        '
        Me.Doc_numberLabel.AutoSize = True
        Me.Doc_numberLabel.CausesValidation = False
        Me.Doc_numberLabel.Location = New System.Drawing.Point(5, 35)
        Me.Doc_numberLabel.Name = "Doc_numberLabel"
        Me.Doc_numberLabel.Size = New System.Drawing.Size(18, 13)
        Me.Doc_numberLabel.TabIndex = 2
        Me.Doc_numberLabel.Text = "№"
        '
        'Client_innLabel
        '
        Me.Client_innLabel.AutoSize = True
        Me.Client_innLabel.CausesValidation = False
        Me.Client_innLabel.Location = New System.Drawing.Point(5, 64)
        Me.Client_innLabel.Name = "Client_innLabel"
        Me.Client_innLabel.Size = New System.Drawing.Size(31, 13)
        Me.Client_innLabel.TabIndex = 4
        Me.Client_innLabel.Text = "ИНН"
        '
        'Doc_dateLabel
        '
        Me.Doc_dateLabel.AutoSize = True
        Me.Doc_dateLabel.CausesValidation = False
        Me.Doc_dateLabel.Location = New System.Drawing.Point(76, 35)
        Me.Doc_dateLabel.Name = "Doc_dateLabel"
        Me.Doc_dateLabel.Size = New System.Drawing.Size(18, 13)
        Me.Doc_dateLabel.TabIndex = 6
        Me.Doc_dateLabel.Text = "от"
        '
        'bsAgreements
        '
        Me.bsAgreements.DataMember = "Docs_Agreements"
        Me.bsAgreements.DataSource = Me.dsPayments
        '
        'dsPayments
        '
        Me.dsPayments.DataSetName = "Docs_Payments"
        Me.dsPayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtClient_address
        '
        Me.txtClient_address.CausesValidation = False
        Me.txtClient_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_adress", True))
        Me.txtClient_address.Location = New System.Drawing.Point(52, 87)
        Me.txtClient_address.Name = "txtClient_address"
        Me.txtClient_address.ReadOnly = True
        Me.txtClient_address.Size = New System.Drawing.Size(803, 20)
        Me.txtClient_address.TabIndex = 73
        '
        'bsClients
        '
        Me.bsClients.DataMember = "R_clients"
        Me.bsClients.DataSource = Me.dsPayments
        '
        'txtClient_name
        '
        Me.txtClient_name.CausesValidation = False
        Me.txtClient_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_name", True))
        Me.txtClient_name.Location = New System.Drawing.Point(225, 61)
        Me.txtClient_name.Name = "txtClient_name"
        Me.txtClient_name.ReadOnly = True
        Me.txtClient_name.Size = New System.Drawing.Size(630, 20)
        Me.txtClient_name.TabIndex = 72
        '
        'Client_innMaskedTextBox
        '
        Me.Client_innMaskedTextBox.CausesValidation = False
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_inn", True))
        Me.Client_innMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Client_innMaskedTextBox.Location = New System.Drawing.Point(52, 61)
        Me.Client_innMaskedTextBox.Mask = "00000000000000"
        Me.Client_innMaskedTextBox.Name = "Client_innMaskedTextBox"
        Me.Client_innMaskedTextBox.Size = New System.Drawing.Size(103, 20)
        Me.Client_innMaskedTextBox.TabIndex = 4
        '
        'Doc_numberMaskTextBox
        '
        Me.Doc_numberMaskTextBox.CausesValidation = False
        Me.Doc_numberMaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgreements, "doc_number", True))
        Me.Doc_numberMaskTextBox.Location = New System.Drawing.Point(27, 32)
        Me.Doc_numberMaskTextBox.Mask = "000000"
        Me.Doc_numberMaskTextBox.Name = "Doc_numberMaskTextBox"
        Me.Doc_numberMaskTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Doc_numberMaskTextBox.TabIndex = 1
        '
        'Doc_dateDateTimePicker
        '
        Me.Doc_dateDateTimePicker.CausesValidation = False
        Me.Doc_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgreements, "doc_date", True))
        Me.Doc_dateDateTimePicker.Location = New System.Drawing.Point(100, 32)
        Me.Doc_dateDateTimePicker.Name = "Doc_dateDateTimePicker"
        Me.Doc_dateDateTimePicker.Size = New System.Drawing.Size(135, 20)
        Me.Doc_dateDateTimePicker.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.CausesValidation = False
        Me.btnSearch.Location = New System.Drawing.Point(8, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(138, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Найти"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlDoc
        '
        Me.pnlDoc.CausesValidation = False
        Me.pnlDoc.Controls.Add(Me.lblMoney)
        Me.pnlDoc.Controls.Add(Me.txtSum)
        Me.pnlDoc.Controls.Add(Me.Doc_date_highDateTimePicker)
        Me.pnlDoc.Controls.Add(Me.lblName)
        Me.pnlDoc.Controls.Add(Me.lblHighDate)
        Me.pnlDoc.Controls.Add(Me.btnSearch)
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
        Me.pnlDoc.Location = New System.Drawing.Point(0, 0)
        Me.pnlDoc.Name = "pnlDoc"
        Me.pnlDoc.Size = New System.Drawing.Size(858, 114)
        Me.pnlDoc.TabIndex = 6
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.CausesValidation = False
        Me.lblMoney.Location = New System.Drawing.Point(623, 36)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(85, 13)
        Me.lblMoney.TabIndex = 92
        Me.lblMoney.Text = "Денег на счёте"
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.SystemColors.Window
        Me.txtSum.CausesValidation = False
        Me.txtSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtSum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSum.Location = New System.Drawing.Point(714, 32)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.txtSum.Size = New System.Drawing.Size(141, 20)
        Me.txtSum.TabIndex = 91
        Me.txtSum.TabStop = False
        '
        'Doc_date_highDateTimePicker
        '
        Me.Doc_date_highDateTimePicker.CausesValidation = False
        Me.Doc_date_highDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgreements, "doc_date_limit", True))
        Me.Doc_date_highDateTimePicker.Enabled = False
        Me.Doc_date_highDateTimePicker.Location = New System.Drawing.Point(266, 32)
        Me.Doc_date_highDateTimePicker.Name = "Doc_date_highDateTimePicker"
        Me.Doc_date_highDateTimePicker.Size = New System.Drawing.Size(135, 20)
        Me.Doc_date_highDateTimePicker.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.CausesValidation = False
        Me.lblName.Location = New System.Drawing.Point(162, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 13)
        Me.lblName.TabIndex = 88
        Me.lblName.Text = "Название"
        '
        'lblHighDate
        '
        Me.lblHighDate.AutoSize = True
        Me.lblHighDate.CausesValidation = False
        Me.lblHighDate.Location = New System.Drawing.Point(241, 36)
        Me.lblHighDate.Name = "lblHighDate"
        Me.lblHighDate.Size = New System.Drawing.Size(19, 13)
        Me.lblHighDate.TabIndex = 87
        Me.lblHighDate.Text = "до"
        '
        'DocidDataGridViewTextBoxColumn
        '
        Me.DocidDataGridViewTextBoxColumn.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.Name = "DocidDataGridViewTextBoxColumn"
        Me.DocidDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pnlMain
        '
        Me.pnlMain.CausesValidation = False
        Me.pnlMain.ColumnCount = 2
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlMain.Controls.Add(Me.tsPost, 1, 0)
        Me.pnlMain.Controls.Add(Me.dgvBillsPre, 0, 1)
        Me.pnlMain.Controls.Add(Me.dgvBillsPost, 1, 1)
        Me.pnlMain.Controls.Add(Me.tsPre, 0, 0)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 139)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.RowCount = 2
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlMain.Size = New System.Drawing.Size(858, 281)
        Me.pnlMain.TabIndex = 88
        '
        'tsPost
        '
        Me.tsPost.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.btnAddPost, Me.btnHideTransactedPost})
        Me.tsPost.Location = New System.Drawing.Point(429, 0)
        Me.tsPost.Name = "tsPost"
        Me.tsPost.Size = New System.Drawing.Size(429, 25)
        Me.tsPost.TabIndex = 3
        Me.tsPost.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel2.Text = "Счета-фактуры"
        '
        'btnAddPost
        '
        Me.btnAddPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddPost.Image = CType(resources.GetObject("btnAddPost.Image"), System.Drawing.Image)
        Me.btnAddPost.Name = "btnAddPost"
        Me.btnAddPost.RightToLeftAutoMirrorImage = True
        Me.btnAddPost.Size = New System.Drawing.Size(23, 22)
        Me.btnAddPost.Text = "Новый СЧЁТ-ФАКТУРА"
        '
        'btnHideTransactedPost
        '
        Me.btnHideTransactedPost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnHideTransactedPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnHideTransactedPost.Image = CType(resources.GetObject("btnHideTransactedPost.Image"), System.Drawing.Image)
        Me.btnHideTransactedPost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHideTransactedPost.Name = "btnHideTransactedPost"
        Me.btnHideTransactedPost.Size = New System.Drawing.Size(122, 22)
        Me.btnHideTransactedPost.Text = "Скрыть проведённые"
        '
        'dgvBillsPre
        '
        Me.dgvBillsPre.AllowUserToAddRows = False
        Me.dgvBillsPre.AllowUserToDeleteRows = False
        Me.dgvBillsPre.AutoGenerateColumns = False
        Me.dgvBillsPre.CausesValidation = False
        Me.dgvBillsPre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillsPre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocidDataGridViewTextBoxColumn1, Me.DocnumberDataGridViewTextBoxColumn, Me.DocsumDataGridViewTextBoxColumn, Me.DocdateDataGridViewTextBoxColumn, Me.TaxndsDataGridViewTextBoxColumn, Me.IsrussiaDataGridViewCheckBoxColumn, Me.Column_is_transacted, Me.Column_is_transacted_visible, Me.PaydocnumDataGridViewTextBoxColumn, Me.PaydocdateDataGridViewTextBoxColumn, Me.BilltypeDataGridViewCheckBoxColumn})
        Me.dgvBillsPre.DataSource = Me.bsBillsPre
        Me.dgvBillsPre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBillsPre.Location = New System.Drawing.Point(3, 30)
        Me.dgvBillsPre.Name = "dgvBillsPre"
        Me.dgvBillsPre.ReadOnly = True
        Me.dgvBillsPre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillsPre.Size = New System.Drawing.Size(423, 248)
        Me.dgvBillsPre.TabIndex = 0
        '
        'DocidDataGridViewTextBoxColumn1
        '
        Me.DocidDataGridViewTextBoxColumn1.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.Name = "DocidDataGridViewTextBoxColumn1"
        Me.DocidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn1.Visible = False
        '
        'DocnumberDataGridViewTextBoxColumn
        '
        Me.DocnumberDataGridViewTextBoxColumn.DataPropertyName = "doc_number"
        Me.DocnumberDataGridViewTextBoxColumn.HeaderText = "Номер"
        Me.DocnumberDataGridViewTextBoxColumn.Name = "DocnumberDataGridViewTextBoxColumn"
        Me.DocnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocsumDataGridViewTextBoxColumn
        '
        Me.DocsumDataGridViewTextBoxColumn.DataPropertyName = "doc_sum"
        Me.DocsumDataGridViewTextBoxColumn.HeaderText = "Сумма"
        Me.DocsumDataGridViewTextBoxColumn.Name = "DocsumDataGridViewTextBoxColumn"
        Me.DocsumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocdateDataGridViewTextBoxColumn
        '
        Me.DocdateDataGridViewTextBoxColumn.DataPropertyName = "doc_date"
        Me.DocdateDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.DocdateDataGridViewTextBoxColumn.Name = "DocdateDataGridViewTextBoxColumn"
        Me.DocdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TaxndsDataGridViewTextBoxColumn
        '
        Me.TaxndsDataGridViewTextBoxColumn.DataPropertyName = "tax_nds"
        Me.TaxndsDataGridViewTextBoxColumn.HeaderText = "tax_nds"
        Me.TaxndsDataGridViewTextBoxColumn.Name = "TaxndsDataGridViewTextBoxColumn"
        Me.TaxndsDataGridViewTextBoxColumn.ReadOnly = True
        Me.TaxndsDataGridViewTextBoxColumn.Visible = False
        '
        'IsrussiaDataGridViewCheckBoxColumn
        '
        Me.IsrussiaDataGridViewCheckBoxColumn.DataPropertyName = "is_russia"
        Me.IsrussiaDataGridViewCheckBoxColumn.HeaderText = "is_russia"
        Me.IsrussiaDataGridViewCheckBoxColumn.Name = "IsrussiaDataGridViewCheckBoxColumn"
        Me.IsrussiaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsrussiaDataGridViewCheckBoxColumn.Visible = False
        '
        'Column_is_transacted
        '
        Me.Column_is_transacted.DataPropertyName = "is_transacted"
        Me.Column_is_transacted.HeaderText = "is_transacted"
        Me.Column_is_transacted.Name = "Column_is_transacted"
        Me.Column_is_transacted.ReadOnly = True
        Me.Column_is_transacted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_is_transacted.Visible = False
        Me.Column_is_transacted.Width = 50
        '
        'Column_is_transacted_visible
        '
        Me.Column_is_transacted_visible.HeaderText = "Проведено"
        Me.Column_is_transacted_visible.Name = "Column_is_transacted_visible"
        Me.Column_is_transacted_visible.ReadOnly = True
        Me.Column_is_transacted_visible.Width = 80
        '
        'PaydocnumDataGridViewTextBoxColumn
        '
        Me.PaydocnumDataGridViewTextBoxColumn.DataPropertyName = "paydoc_num"
        Me.PaydocnumDataGridViewTextBoxColumn.HeaderText = "paydoc_num"
        Me.PaydocnumDataGridViewTextBoxColumn.Name = "PaydocnumDataGridViewTextBoxColumn"
        Me.PaydocnumDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaydocnumDataGridViewTextBoxColumn.Visible = False
        '
        'PaydocdateDataGridViewTextBoxColumn
        '
        Me.PaydocdateDataGridViewTextBoxColumn.DataPropertyName = "paydoc_date"
        Me.PaydocdateDataGridViewTextBoxColumn.HeaderText = "paydoc_date"
        Me.PaydocdateDataGridViewTextBoxColumn.Name = "PaydocdateDataGridViewTextBoxColumn"
        Me.PaydocdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaydocdateDataGridViewTextBoxColumn.Visible = False
        '
        'BilltypeDataGridViewCheckBoxColumn
        '
        Me.BilltypeDataGridViewCheckBoxColumn.DataPropertyName = "bill_type"
        Me.BilltypeDataGridViewCheckBoxColumn.HeaderText = "bill_type"
        Me.BilltypeDataGridViewCheckBoxColumn.Name = "BilltypeDataGridViewCheckBoxColumn"
        Me.BilltypeDataGridViewCheckBoxColumn.ReadOnly = True
        Me.BilltypeDataGridViewCheckBoxColumn.Visible = False
        '
        'bsBillsPre
        '
        Me.bsBillsPre.DataMember = "FK_Docs_Bills_Docs_Agreements"
        Me.bsBillsPre.DataSource = Me.bsAgreements
        Me.bsBillsPre.Filter = "bill_type = 0"
        '
        'dgvBillsPost
        '
        Me.dgvBillsPost.AllowUserToAddRows = False
        Me.dgvBillsPost.AllowUserToDeleteRows = False
        Me.dgvBillsPost.AutoGenerateColumns = False
        Me.dgvBillsPost.CausesValidation = False
        Me.dgvBillsPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillsPost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocidDataGridViewTextBoxColumn2, Me.DocnumberDataGridViewTextBoxColumn1, Me.DocsumDataGridViewTextBoxColumn1, Me.DocdateDataGridViewTextBoxColumn1, Me.TaxndsDataGridViewTextBoxColumn1, Me.IsrussiaDataGridViewCheckBoxColumn1, Me.IstransactedDataGridViewCheckBoxColumn1, Me.Column_is_transacted_vidible1, Me.PaydocnumDataGridViewTextBoxColumn1, Me.PaydocdateDataGridViewTextBoxColumn1, Me.BilltypeDataGridViewCheckBoxColumn1, Me.line_number})
        Me.dgvBillsPost.DataSource = Me.bsBillsPost
        Me.dgvBillsPost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBillsPost.Location = New System.Drawing.Point(432, 30)
        Me.dgvBillsPost.Name = "dgvBillsPost"
        Me.dgvBillsPost.ReadOnly = True
        Me.dgvBillsPost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillsPost.Size = New System.Drawing.Size(423, 248)
        Me.dgvBillsPost.TabIndex = 1
        '
        'DocidDataGridViewTextBoxColumn2
        '
        Me.DocidDataGridViewTextBoxColumn2.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.Name = "DocidDataGridViewTextBoxColumn2"
        Me.DocidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn2.Visible = False
        '
        'DocnumberDataGridViewTextBoxColumn1
        '
        Me.DocnumberDataGridViewTextBoxColumn1.DataPropertyName = "doc_number"
        Me.DocnumberDataGridViewTextBoxColumn1.HeaderText = "Номер"
        Me.DocnumberDataGridViewTextBoxColumn1.Name = "DocnumberDataGridViewTextBoxColumn1"
        Me.DocnumberDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DocsumDataGridViewTextBoxColumn1
        '
        Me.DocsumDataGridViewTextBoxColumn1.DataPropertyName = "doc_sum"
        Me.DocsumDataGridViewTextBoxColumn1.HeaderText = "Сумма"
        Me.DocsumDataGridViewTextBoxColumn1.Name = "DocsumDataGridViewTextBoxColumn1"
        Me.DocsumDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DocdateDataGridViewTextBoxColumn1
        '
        Me.DocdateDataGridViewTextBoxColumn1.DataPropertyName = "doc_date"
        Me.DocdateDataGridViewTextBoxColumn1.HeaderText = "Дата"
        Me.DocdateDataGridViewTextBoxColumn1.Name = "DocdateDataGridViewTextBoxColumn1"
        Me.DocdateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TaxndsDataGridViewTextBoxColumn1
        '
        Me.TaxndsDataGridViewTextBoxColumn1.DataPropertyName = "tax_nds"
        Me.TaxndsDataGridViewTextBoxColumn1.HeaderText = "tax_nds"
        Me.TaxndsDataGridViewTextBoxColumn1.Name = "TaxndsDataGridViewTextBoxColumn1"
        Me.TaxndsDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TaxndsDataGridViewTextBoxColumn1.Visible = False
        '
        'IsrussiaDataGridViewCheckBoxColumn1
        '
        Me.IsrussiaDataGridViewCheckBoxColumn1.DataPropertyName = "is_russia"
        Me.IsrussiaDataGridViewCheckBoxColumn1.HeaderText = "is_russia"
        Me.IsrussiaDataGridViewCheckBoxColumn1.Name = "IsrussiaDataGridViewCheckBoxColumn1"
        Me.IsrussiaDataGridViewCheckBoxColumn1.ReadOnly = True
        Me.IsrussiaDataGridViewCheckBoxColumn1.Visible = False
        '
        'IstransactedDataGridViewCheckBoxColumn1
        '
        Me.IstransactedDataGridViewCheckBoxColumn1.DataPropertyName = "is_transacted"
        Me.IstransactedDataGridViewCheckBoxColumn1.HeaderText = "is_transacted"
        Me.IstransactedDataGridViewCheckBoxColumn1.Name = "IstransactedDataGridViewCheckBoxColumn1"
        Me.IstransactedDataGridViewCheckBoxColumn1.ReadOnly = True
        Me.IstransactedDataGridViewCheckBoxColumn1.Visible = False
        Me.IstransactedDataGridViewCheckBoxColumn1.Width = 50
        '
        'Column_is_transacted_vidible1
        '
        Me.Column_is_transacted_vidible1.HeaderText = "Проведено"
        Me.Column_is_transacted_vidible1.Name = "Column_is_transacted_vidible1"
        Me.Column_is_transacted_vidible1.ReadOnly = True
        Me.Column_is_transacted_vidible1.Width = 80
        '
        'PaydocnumDataGridViewTextBoxColumn1
        '
        Me.PaydocnumDataGridViewTextBoxColumn1.DataPropertyName = "paydoc_num"
        Me.PaydocnumDataGridViewTextBoxColumn1.HeaderText = "paydoc_num"
        Me.PaydocnumDataGridViewTextBoxColumn1.Name = "PaydocnumDataGridViewTextBoxColumn1"
        Me.PaydocnumDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PaydocnumDataGridViewTextBoxColumn1.Visible = False
        '
        'PaydocdateDataGridViewTextBoxColumn1
        '
        Me.PaydocdateDataGridViewTextBoxColumn1.DataPropertyName = "paydoc_date"
        Me.PaydocdateDataGridViewTextBoxColumn1.HeaderText = "paydoc_date"
        Me.PaydocdateDataGridViewTextBoxColumn1.Name = "PaydocdateDataGridViewTextBoxColumn1"
        Me.PaydocdateDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PaydocdateDataGridViewTextBoxColumn1.Visible = False
        '
        'BilltypeDataGridViewCheckBoxColumn1
        '
        Me.BilltypeDataGridViewCheckBoxColumn1.DataPropertyName = "bill_type"
        Me.BilltypeDataGridViewCheckBoxColumn1.HeaderText = "bill_type"
        Me.BilltypeDataGridViewCheckBoxColumn1.Name = "BilltypeDataGridViewCheckBoxColumn1"
        Me.BilltypeDataGridViewCheckBoxColumn1.ReadOnly = True
        Me.BilltypeDataGridViewCheckBoxColumn1.Visible = False
        '
        'line_number
        '
        Me.line_number.DataPropertyName = "line_number"
        Me.line_number.HeaderText = "line_number"
        Me.line_number.Name = "line_number"
        Me.line_number.ReadOnly = True
        Me.line_number.Visible = False
        '
        'bsBillsPost
        '
        Me.bsBillsPost.DataMember = "FK_Docs_Bills_Docs_Agreements"
        Me.bsBillsPost.DataSource = Me.bsAgreements
        Me.bsBillsPost.Filter = "bill_type = 1"
        '
        'tsPre
        '
        Me.tsPre.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnAddPre, Me.btnHideTransactedPre})
        Me.tsPre.Location = New System.Drawing.Point(0, 0)
        Me.tsPre.Name = "tsPre"
        Me.tsPre.Size = New System.Drawing.Size(429, 25)
        Me.tsPre.TabIndex = 2
        Me.tsPre.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripLabel1.Text = "Счета на предоплату"
        '
        'btnAddPre
        '
        Me.btnAddPre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddPre.Image = CType(resources.GetObject("btnAddPre.Image"), System.Drawing.Image)
        Me.btnAddPre.Name = "btnAddPre"
        Me.btnAddPre.RightToLeftAutoMirrorImage = True
        Me.btnAddPre.Size = New System.Drawing.Size(23, 22)
        Me.btnAddPre.Text = "Новый СЧЁТ НА ПРЕДОПЛАТУ"
        '
        'btnHideTransactedPre
        '
        Me.btnHideTransactedPre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnHideTransactedPre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnHideTransactedPre.Image = CType(resources.GetObject("btnHideTransactedPre.Image"), System.Drawing.Image)
        Me.btnHideTransactedPre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHideTransactedPre.Name = "btnHideTransactedPre"
        Me.btnHideTransactedPre.Size = New System.Drawing.Size(122, 22)
        Me.btnHideTransactedPre.Text = "Скрыть проведённые"
        '
        'taAgreements
        '
        Me.taAgreements.ClearBeforeFill = True
        '
        'taClients
        '
        Me.taClients.ClearBeforeFill = True
        '
        'taBills
        '
        Me.taBills.ClearBeforeFill = True
        '
        'bnAgreements
        '
        Me.bnAgreements.AddNewItem = Nothing
        Me.bnAgreements.BindingSource = Me.bsAgreements
        Me.bnAgreements.CountItem = Me.BindingNavigatorCountItem
        Me.bnAgreements.DeleteItem = Nothing
        Me.bnAgreements.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnNew, Me.btnDelete, Me.btnSave, Me.btnCopyAll, Me.btnPrintMenu, Me.btnPrintPreview, Me.btnUpdate})
        Me.bnAgreements.Location = New System.Drawing.Point(0, 114)
        Me.bnAgreements.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnAgreements.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnAgreements.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnAgreements.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnAgreements.Name = "bnAgreements"
        Me.bnAgreements.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnAgreements.Size = New System.Drawing.Size(858, 25)
        Me.bnAgreements.TabIndex = 2
        Me.bnAgreements.Text = "bnAgreements"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.RightToLeftAutoMirrorImage = True
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "Новый договор"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeftAutoMirrorImage = True
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Удалить договор"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Сохранить"
        '
        'btnCopyAll
        '
        Me.btnCopyAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopyAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopyAll.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopy, Me.btnMakeAct})
        Me.btnCopyAll.Image = CType(resources.GetObject("btnCopyAll.Image"), System.Drawing.Image)
        Me.btnCopyAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopyAll.Name = "btnCopyAll"
        Me.btnCopyAll.Size = New System.Drawing.Size(29, 22)
        Me.btnCopyAll.Text = "ToolStripDropDownButton1"
        '
        'btnCopy
        '
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(220, 22)
        Me.btnCopy.Text = "Копировать с остатками"
        '
        'btnMakeAct
        '
        Me.btnMakeAct.Name = "btnMakeAct"
        Me.btnMakeAct.Size = New System.Drawing.Size(220, 22)
        Me.btnMakeAct.Text = "Сформировать Акт сверки"
        '
        'btnPrintMenu
        '
        Me.btnPrintMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrintMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrintMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint})
        Me.btnPrintMenu.Image = CType(resources.GetObject("btnPrintMenu.Image"), System.Drawing.Image)
        Me.btnPrintMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintMenu.Name = "btnPrintMenu"
        Me.btnPrintMenu.Size = New System.Drawing.Size(29, 22)
        '
        'btnPrint
        '
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(134, 22)
        Me.btnPrint.Text = "Печатать"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrintPreview.Image = CType(resources.GetObject("btnPrintPreview.Image"), System.Drawing.Image)
        Me.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(23, 22)
        Me.btnPrintPreview.Text = "Предпросмотр"
        '
        'btnUpdate
        '
        Me.btnUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 22)
        Me.btnUpdate.Text = "Обновить счета"
        '
        'frmDocAgreements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(858, 420)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.bnAgreements)
        Me.Controls.Add(Me.pnlDoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDocAgreements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Договоры"
        CType(Me.bsAgreements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDoc.ResumeLayout(False)
        Me.pnlDoc.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.tsPost.ResumeLayout(False)
        Me.tsPost.PerformLayout()
        CType(Me.dgvBillsPre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBillsPre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBillsPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBillsPost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsPre.ResumeLayout(False)
        Me.tsPre.PerformLayout()
        CType(Me.bnAgreements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnAgreements.ResumeLayout(False)
        Me.bnAgreements.PerformLayout()
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
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DocidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlDoc As System.Windows.Forms.Panel
    Friend WithEvents Doc_numberLabel As System.Windows.Forms.Label
    Friend WithEvents Client_innLabel As System.Windows.Forms.Label
    Friend WithEvents Doc_dateLabel As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblHighDate As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pnlMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dsPayments As Inspector.Docs_Payments
    Friend WithEvents taAgreements As Inspector.Docs_PaymentsTableAdapters.Docs_AgreementsTableAdapter
    Friend WithEvents taClients As Inspector.Docs_PaymentsTableAdapters.R_clientsTableAdapter
    Friend WithEvents bsAgreements As System.Windows.Forms.BindingSource
    Friend WithEvents bsClients As System.Windows.Forms.BindingSource
    Friend WithEvents dgvBillsPre As System.Windows.Forms.DataGridView
    Friend WithEvents bsBillsPre As System.Windows.Forms.BindingSource
    Friend WithEvents bsBillsPost As System.Windows.Forms.BindingSource
    Friend WithEvents taBills As Inspector.Docs_PaymentsTableAdapters.Docs_BillsTableAdapter
    Friend WithEvents dgvBillsPost As System.Windows.Forms.DataGridView
    Friend WithEvents bnAgreements As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsPost As System.Windows.Forms.ToolStrip
    Friend WithEvents tsPre As System.Windows.Forms.ToolStrip
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doc_date_highDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DocidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocsumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxndsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsrussiaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column_is_transacted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column_is_transacted_visible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaydocnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaydocdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilltypeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DoccreationdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoccreationdateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnAddPre As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents btnAddPost As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents DocidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocnumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocsumDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocdateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxndsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsrussiaDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IstransactedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column_is_transacted_vidible1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaydocnumDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaydocdateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilltypeDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents line_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintMenu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopyAll As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHideTransactedPost As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHideTransactedPre As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMakeAct As System.Windows.Forms.ToolStripMenuItem
End Class
