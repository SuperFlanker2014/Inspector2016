<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocConclusionsObjects
    Inherits CAppForm 'Windows.Forms.Form 'frmWithoutEnter

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocConclusionsObjects))
        Me.lblAddress = New System.Windows.Forms.Label
        Me.Doc_numberLabel = New System.Windows.Forms.Label
        Me.Client_innLabel = New System.Windows.Forms.Label
        Me.Doc_dateLabel = New System.Windows.Forms.Label
        Me.txtVerdict = New System.Windows.Forms.TextBox
        Me.bsConclusions = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsConclusions = New Inspector.Docs_Conclusions_Objects
        Me.btnFill = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRepresentative = New System.Windows.Forms.TextBox
        Me.txtConclusion = New System.Windows.Forms.TextBox
        Me.lblKarantin = New System.Windows.Forms.Label
        Me.cbKarantin = New System.Windows.Forms.ComboBox
        Me.lblRayon = New System.Windows.Forms.Label
        Me.cbRayon = New System.Windows.Forms.ComboBox
        Me.lblObject = New System.Windows.Forms.Label
        Me.cbObject = New System.Windows.Forms.ComboBox
        Me.Doc_date_highDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.txtClient_address = New System.Windows.Forms.TextBox
        Me.bsClients = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtClient_name = New System.Windows.Forms.TextBox
        Me.Client_innMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Doc_numberMaskTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Doc_dateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New System.Windows.Forms.Button
        Me.pnlDoc = New System.Windows.Forms.Panel
        Me.lblDocType = New System.Windows.Forms.Label
        Me.cbCategory = New System.Windows.Forms.ComboBox
        Me.DocidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.lblHighDate = New System.Windows.Forms.Label
        Me.pnlGrids = New System.Windows.Forms.Panel
        Me.tabChildViewes = New System.Windows.Forms.TabControl
        Me.tpExaminations = New System.Windows.Forms.TabPage
        Me.dgvExaminations = New Inspector.dgvWithoutEnter
        Me.DocidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cExamsTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cExamsObjectTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VolumeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsExaminations = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsObjects = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddExaminations = New System.Windows.Forms.Button
        Me.tpNotKarantin = New System.Windows.Forms.TabPage
        Me.dgvNotKarantin = New Inspector.dgvWithoutEnter
        Me.cNotKarantinObjectTitle = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ExammethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ExamcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TitleDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsNotKarantin = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpKarantin = New System.Windows.Forms.TabPage
        Me.dgvKarantin = New Inspector.dgvWithoutEnter
        Me.cKarantinObjectTitle = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ExammethodDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ExamcountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocidDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TitleDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsKarantin = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvObjects = New Inspector.dgvWithoutEnter
        Me.DocidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cTitle = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cVolumeUnit = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cRayon = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ExamtrapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExambaitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExamdustDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bnConclusions = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.btnCopy = New System.Windows.Forms.ToolStripButton
        Me.btnPrint = New System.Windows.Forms.ToolStripButton
        Me.btnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlMain = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSamples = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTarget = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.taConclusions = New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_Conclusions_ObjectsTableAdapter
        Me.taCO_Objects = New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_CO_ObjectsTableAdapter
        Me.taCOO_Examinations = New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_ExaminationsTableAdapter
        Me.taCOO_Karantin = New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_KarantinTableAdapter
        Me.taCOO_NotKarantin = New Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_NotKarantinTableAdapter
        Me.taClients = New Inspector.Docs_Conclusions_ObjectsTableAdapters.R_clientsTableAdapter
        CType(Me.bsConclusions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsConclusions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDoc.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlGrids.SuspendLayout()
        Me.tabChildViewes.SuspendLayout()
        Me.tpExaminations.SuspendLayout()
        CType(Me.dgvExaminations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsExaminations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpNotKarantin.SuspendLayout()
        CType(Me.dgvNotKarantin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNotKarantin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpKarantin.SuspendLayout()
        CType(Me.dgvKarantin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKarantin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnConclusions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnConclusions.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.CausesValidation = False
        Me.lblAddress.Location = New System.Drawing.Point(6, 58)
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
        Me.Client_innLabel.Location = New System.Drawing.Point(241, 36)
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
        'txtVerdict
        '
        Me.txtVerdict.CausesValidation = False
        Me.pnlMain.SetColumnSpan(Me.txtVerdict, 3)
        Me.txtVerdict.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsConclusions, "verdict", True))
        Me.txtVerdict.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtVerdict.Location = New System.Drawing.Point(95, 20)
        Me.txtVerdict.Margin = New System.Windows.Forms.Padding(0)
        Me.txtVerdict.Multiline = True
        Me.txtVerdict.Name = "txtVerdict"
        Me.txtVerdict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVerdict.Size = New System.Drawing.Size(763, 81)
        Me.txtVerdict.TabIndex = 8
        '
        'bsConclusions
        '
        Me.bsConclusions.DataMember = "Docs_Conclusions_Objects"
        Me.bsConclusions.DataSource = Me.dsConclusions
        '
        'dsConclusions
        '
        Me.dsConclusions.DataSetName = "Docs_Conclusions_Objects"
        Me.dsConclusions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnFill
        '
        Me.btnFill.CausesValidation = False
        Me.btnFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFill.Location = New System.Drawing.Point(2, 22)
        Me.btnFill.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(91, 77)
        Me.btnFill.TabIndex = 50
        Me.btnFill.Text = "Заполнить >>"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Представитель"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRepresentative
        '
        Me.txtRepresentative.CausesValidation = False
        Me.txtRepresentative.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsConclusions, "representative", True))
        Me.txtRepresentative.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRepresentative.Location = New System.Drawing.Point(95, 0)
        Me.txtRepresentative.Margin = New System.Windows.Forms.Padding(0)
        Me.txtRepresentative.MaxLength = 50
        Me.txtRepresentative.Name = "txtRepresentative"
        Me.txtRepresentative.Size = New System.Drawing.Size(336, 20)
        Me.txtRepresentative.TabIndex = 7
        '
        'txtConclusion
        '
        Me.txtConclusion.CausesValidation = False
        Me.txtConclusion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsConclusions, "conclusion", True))
        Me.txtConclusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConclusion.Location = New System.Drawing.Point(95, 101)
        Me.txtConclusion.Margin = New System.Windows.Forms.Padding(0)
        Me.txtConclusion.Multiline = True
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConclusion.Size = New System.Drawing.Size(336, 70)
        Me.txtConclusion.TabIndex = 9
        '
        'lblKarantin
        '
        Me.lblKarantin.AutoSize = True
        Me.lblKarantin.CausesValidation = False
        Me.lblKarantin.Location = New System.Drawing.Point(241, 29)
        Me.lblKarantin.Name = "lblKarantin"
        Me.lblKarantin.Size = New System.Drawing.Size(55, 13)
        Me.lblKarantin.TabIndex = 84
        Me.lblKarantin.Text = "Карантин"
        '
        'cbKarantin
        '
        Me.cbKarantin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbKarantin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbKarantin.CausesValidation = False
        Me.cbKarantin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKarantin.FormattingEnabled = True
        Me.cbKarantin.Location = New System.Drawing.Point(309, 27)
        Me.cbKarantin.Name = "cbKarantin"
        Me.cbKarantin.Size = New System.Drawing.Size(258, 21)
        Me.cbKarantin.TabIndex = 6
        '
        'lblRayon
        '
        Me.lblRayon.AutoSize = True
        Me.lblRayon.CausesValidation = False
        Me.lblRayon.Location = New System.Drawing.Point(241, 52)
        Me.lblRayon.Name = "lblRayon"
        Me.lblRayon.Size = New System.Drawing.Size(38, 13)
        Me.lblRayon.TabIndex = 82
        Me.lblRayon.Text = "Район"
        '
        'cbRayon
        '
        Me.cbRayon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbRayon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRayon.CausesValidation = False
        Me.cbRayon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRayon.FormattingEnabled = True
        Me.cbRayon.Location = New System.Drawing.Point(309, 49)
        Me.cbRayon.Name = "cbRayon"
        Me.cbRayon.Size = New System.Drawing.Size(258, 21)
        Me.cbRayon.TabIndex = 7
        '
        'lblObject
        '
        Me.lblObject.AutoSize = True
        Me.lblObject.CausesValidation = False
        Me.lblObject.Location = New System.Drawing.Point(241, 8)
        Me.lblObject.Name = "lblObject"
        Me.lblObject.Size = New System.Drawing.Size(45, 13)
        Me.lblObject.TabIndex = 80
        Me.lblObject.Text = "Объект"
        '
        'cbObject
        '
        Me.cbObject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbObject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbObject.CausesValidation = False
        Me.cbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbObject.FormattingEnabled = True
        Me.cbObject.Location = New System.Drawing.Point(309, 5)
        Me.cbObject.Name = "cbObject"
        Me.cbObject.Size = New System.Drawing.Size(258, 21)
        Me.cbObject.TabIndex = 5
        '
        'Doc_date_highDateTimePicker
        '
        Me.Doc_date_highDateTimePicker.CausesValidation = False
        Me.Doc_date_highDateTimePicker.Location = New System.Drawing.Point(100, 4)
        Me.Doc_date_highDateTimePicker.Name = "Doc_date_highDateTimePicker"
        Me.Doc_date_highDateTimePicker.Size = New System.Drawing.Size(135, 20)
        Me.Doc_date_highDateTimePicker.TabIndex = 4
        '
        'txtClient_address
        '
        Me.txtClient_address.CausesValidation = False
        Me.txtClient_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_adress", True))
        Me.txtClient_address.Location = New System.Drawing.Point(50, 55)
        Me.txtClient_address.Name = "txtClient_address"
        Me.txtClient_address.ReadOnly = True
        Me.txtClient_address.Size = New System.Drawing.Size(803, 20)
        Me.txtClient_address.TabIndex = 5
        Me.txtClient_address.TabStop = False
        '
        'bsClients
        '
        Me.bsClients.DataMember = "R_clients"
        Me.bsClients.DataSource = Me.dsConclusions
        '
        'txtClient_name
        '
        Me.txtClient_name.CausesValidation = False
        Me.txtClient_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_name", True))
        Me.txtClient_name.Location = New System.Drawing.Point(397, 33)
        Me.txtClient_name.Name = "txtClient_name"
        Me.txtClient_name.ReadOnly = True
        Me.txtClient_name.Size = New System.Drawing.Size(456, 20)
        Me.txtClient_name.TabIndex = 4
        Me.txtClient_name.TabStop = False
        '
        'Client_innMaskedTextBox
        '
        Me.Client_innMaskedTextBox.CausesValidation = False
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "client_inn", True))
        Me.Client_innMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Client_innMaskedTextBox.Location = New System.Drawing.Point(278, 33)
        Me.Client_innMaskedTextBox.Mask = "00000000000000"
        Me.Client_innMaskedTextBox.Name = "Client_innMaskedTextBox"
        Me.Client_innMaskedTextBox.Size = New System.Drawing.Size(113, 20)
        Me.Client_innMaskedTextBox.TabIndex = 3
        '
        'Doc_numberMaskTextBox
        '
        Me.Doc_numberMaskTextBox.CausesValidation = False
        Me.Doc_numberMaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsConclusions, "doc_number", True))
        Me.Doc_numberMaskTextBox.Location = New System.Drawing.Point(27, 32)
        Me.Doc_numberMaskTextBox.Mask = "000000"
        Me.Doc_numberMaskTextBox.Name = "Doc_numberMaskTextBox"
        Me.Doc_numberMaskTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Doc_numberMaskTextBox.TabIndex = 1
        '
        'Doc_dateDateTimePicker
        '
        Me.Doc_dateDateTimePicker.CausesValidation = False
        Me.Doc_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsConclusions, "doc_date", True))
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
        Me.btnSearch.TabIndex = 100
        Me.btnSearch.Text = "Найти"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlDoc
        '
        Me.pnlDoc.CausesValidation = False
        Me.pnlDoc.Controls.Add(Me.lblDocType)
        Me.pnlDoc.Controls.Add(Me.cbCategory)
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
        Me.pnlDoc.Size = New System.Drawing.Size(858, 81)
        Me.pnlDoc.TabIndex = 6
        '
        'lblDocType
        '
        Me.lblDocType.AutoSize = True
        Me.lblDocType.CausesValidation = False
        Me.lblDocType.Location = New System.Drawing.Point(570, 9)
        Me.lblDocType.Name = "lblDocType"
        Me.lblDocType.Size = New System.Drawing.Size(83, 13)
        Me.lblDocType.TabIndex = 102
        Me.lblDocType.Text = "Тип документа"
        '
        'cbCategory
        '
        Me.cbCategory.CausesValidation = False
        Me.cbCategory.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsConclusions, "category", True))
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(659, 5)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(192, 21)
        Me.cbCategory.TabIndex = 4
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
        Me.pnlSearch.Controls.Add(Me.Doc_date_highDateTimePicker)
        Me.pnlSearch.Controls.Add(Me.lblHighDate)
        Me.pnlSearch.Controls.Add(Me.cbObject)
        Me.pnlSearch.Controls.Add(Me.lblObject)
        Me.pnlSearch.Controls.Add(Me.cbRayon)
        Me.pnlSearch.Controls.Add(Me.lblKarantin)
        Me.pnlSearch.Controls.Add(Me.lblRayon)
        Me.pnlSearch.Controls.Add(Me.cbKarantin)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 81)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(858, 76)
        Me.pnlSearch.TabIndex = 87
        Me.pnlSearch.Visible = False
        '
        'lblHighDate
        '
        Me.lblHighDate.AutoSize = True
        Me.lblHighDate.CausesValidation = False
        Me.lblHighDate.Location = New System.Drawing.Point(76, 8)
        Me.lblHighDate.Name = "lblHighDate"
        Me.lblHighDate.Size = New System.Drawing.Size(19, 13)
        Me.lblHighDate.TabIndex = 87
        Me.lblHighDate.Text = "до"
        '
        'pnlGrids
        '
        Me.pnlGrids.CausesValidation = False
        Me.pnlGrids.Controls.Add(Me.tabChildViewes)
        Me.pnlGrids.Controls.Add(Me.dgvObjects)
        Me.pnlGrids.Controls.Add(Me.bnConclusions)
        Me.pnlGrids.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGrids.Location = New System.Drawing.Point(0, 157)
        Me.pnlGrids.Name = "pnlGrids"
        Me.pnlGrids.Size = New System.Drawing.Size(858, 287)
        Me.pnlGrids.TabIndex = 88
        '
        'tabChildViewes
        '
        Me.tabChildViewes.CausesValidation = False
        Me.tabChildViewes.Controls.Add(Me.tpExaminations)
        Me.tabChildViewes.Controls.Add(Me.tpNotKarantin)
        Me.tabChildViewes.Controls.Add(Me.tpKarantin)
        Me.tabChildViewes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabChildViewes.Location = New System.Drawing.Point(0, 151)
        Me.tabChildViewes.Name = "tabChildViewes"
        Me.tabChildViewes.SelectedIndex = 0
        Me.tabChildViewes.Size = New System.Drawing.Size(858, 136)
        Me.tabChildViewes.TabIndex = 10
        '
        'tpExaminations
        '
        Me.tpExaminations.CausesValidation = False
        Me.tpExaminations.Controls.Add(Me.dgvExaminations)
        Me.tpExaminations.Controls.Add(Me.btnAddExaminations)
        Me.tpExaminations.Location = New System.Drawing.Point(4, 22)
        Me.tpExaminations.Name = "tpExaminations"
        Me.tpExaminations.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExaminations.Size = New System.Drawing.Size(850, 110)
        Me.tpExaminations.TabIndex = 1
        Me.tpExaminations.Text = "Обследования"
        Me.tpExaminations.UseVisualStyleBackColor = True
        '
        'dgvExaminations
        '
        Me.dgvExaminations.AllowUserToAddRows = False
        Me.dgvExaminations.AutoGenerateColumns = False
        Me.dgvExaminations.CausesValidation = False
        Me.dgvExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExaminations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocidDataGridViewTextBoxColumn2, Me.cExamsTitle, Me.cExamsObjectTitle, Me.VolumeDataGridViewTextBoxColumn1})
        Me.dgvExaminations.DataSource = Me.bsExaminations
        Me.dgvExaminations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExaminations.Location = New System.Drawing.Point(79, 3)
        Me.dgvExaminations.Name = "dgvExaminations"
        Me.dgvExaminations.Size = New System.Drawing.Size(768, 104)
        Me.dgvExaminations.TabIndex = 0
        '
        'DocidDataGridViewTextBoxColumn2
        '
        Me.DocidDataGridViewTextBoxColumn2.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.Name = "DocidDataGridViewTextBoxColumn2"
        Me.DocidDataGridViewTextBoxColumn2.Visible = False
        '
        'cExamsTitle
        '
        Me.cExamsTitle.DataPropertyName = "title"
        Me.cExamsTitle.HeaderText = "title"
        Me.cExamsTitle.Name = "cExamsTitle"
        Me.cExamsTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cExamsTitle.Visible = False
        Me.cExamsTitle.Width = 200
        '
        'cExamsObjectTitle
        '
        Me.cExamsObjectTitle.DataPropertyName = "object_title"
        Me.cExamsObjectTitle.HeaderText = "Наименование"
        Me.cExamsObjectTitle.Name = "cExamsObjectTitle"
        Me.cExamsObjectTitle.ReadOnly = True
        Me.cExamsObjectTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cExamsObjectTitle.Width = 200
        '
        'VolumeDataGridViewTextBoxColumn1
        '
        Me.VolumeDataGridViewTextBoxColumn1.DataPropertyName = "volume"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.VolumeDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.VolumeDataGridViewTextBoxColumn1.HeaderText = "Объём"
        Me.VolumeDataGridViewTextBoxColumn1.Name = "VolumeDataGridViewTextBoxColumn1"
        '
        'bsExaminations
        '
        Me.bsExaminations.DataMember = "FK_Docs_COO_Examinations_Docs_CO_Objects"
        Me.bsExaminations.DataSource = Me.bsObjects
        '
        'bsObjects
        '
        Me.bsObjects.DataMember = "FK_Docs_CO_Objects_Docs_Conclusions_Objects"
        Me.bsObjects.DataSource = Me.bsConclusions
        '
        'btnAddExaminations
        '
        Me.btnAddExaminations.CausesValidation = False
        Me.btnAddExaminations.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddExaminations.Location = New System.Drawing.Point(3, 3)
        Me.btnAddExaminations.Name = "btnAddExaminations"
        Me.btnAddExaminations.Size = New System.Drawing.Size(76, 104)
        Me.btnAddExaminations.TabIndex = 1
        Me.btnAddExaminations.Text = "Заполнить"
        Me.btnAddExaminations.UseVisualStyleBackColor = True
        '
        'tpNotKarantin
        '
        Me.tpNotKarantin.CausesValidation = False
        Me.tpNotKarantin.Controls.Add(Me.dgvNotKarantin)
        Me.tpNotKarantin.Location = New System.Drawing.Point(4, 22)
        Me.tpNotKarantin.Name = "tpNotKarantin"
        Me.tpNotKarantin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNotKarantin.Size = New System.Drawing.Size(850, 110)
        Me.tpNotKarantin.TabIndex = 2
        Me.tpNotKarantin.Text = "Некарантинные"
        Me.tpNotKarantin.UseVisualStyleBackColor = True
        '
        'dgvNotKarantin
        '
        Me.dgvNotKarantin.AutoGenerateColumns = False
        Me.dgvNotKarantin.CausesValidation = False
        Me.dgvNotKarantin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotKarantin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNotKarantinObjectTitle, Me.ExammethodDataGridViewTextBoxColumn, Me.ExamcountDataGridViewTextBoxColumn, Me.DocidDataGridViewTextBoxColumn3, Me.TitleDataGridViewTextBoxColumn2})
        Me.dgvNotKarantin.DataSource = Me.bsNotKarantin
        Me.dgvNotKarantin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotKarantin.Location = New System.Drawing.Point(3, 3)
        Me.dgvNotKarantin.Name = "dgvNotKarantin"
        Me.dgvNotKarantin.Size = New System.Drawing.Size(844, 104)
        Me.dgvNotKarantin.TabIndex = 0
        '
        'cNotKarantinObjectTitle
        '
        Me.cNotKarantinObjectTitle.DataPropertyName = "object_title"
        Me.cNotKarantinObjectTitle.DisplayStyleForCurrentCellOnly = True
        Me.cNotKarantinObjectTitle.HeaderText = "Наименование"
        Me.cNotKarantinObjectTitle.Name = "cNotKarantinObjectTitle"
        Me.cNotKarantinObjectTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cNotKarantinObjectTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cNotKarantinObjectTitle.Width = 200
        '
        'ExammethodDataGridViewTextBoxColumn
        '
        Me.ExammethodDataGridViewTextBoxColumn.DataPropertyName = "exam_method"
        Me.ExammethodDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.ExammethodDataGridViewTextBoxColumn.HeaderText = "Способ обнаружения"
        Me.ExammethodDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Визуально", "Ловушками", "Приманками", "Смётками"})
        Me.ExammethodDataGridViewTextBoxColumn.Name = "ExammethodDataGridViewTextBoxColumn"
        Me.ExammethodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExammethodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ExammethodDataGridViewTextBoxColumn.Width = 150
        '
        'ExamcountDataGridViewTextBoxColumn
        '
        Me.ExamcountDataGridViewTextBoxColumn.DataPropertyName = "exam_count"
        DataGridViewCellStyle2.Format = "N0"
        Me.ExamcountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ExamcountDataGridViewTextBoxColumn.HeaderText = "Штук найдено"
        Me.ExamcountDataGridViewTextBoxColumn.Name = "ExamcountDataGridViewTextBoxColumn"
        Me.ExamcountDataGridViewTextBoxColumn.Width = 150
        '
        'DocidDataGridViewTextBoxColumn3
        '
        Me.DocidDataGridViewTextBoxColumn3.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn3.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn3.Name = "DocidDataGridViewTextBoxColumn3"
        Me.DocidDataGridViewTextBoxColumn3.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn3.Visible = False
        '
        'TitleDataGridViewTextBoxColumn2
        '
        Me.TitleDataGridViewTextBoxColumn2.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn2.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn2.Name = "TitleDataGridViewTextBoxColumn2"
        Me.TitleDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn2.Visible = False
        '
        'bsNotKarantin
        '
        Me.bsNotKarantin.DataMember = "FK_Docs_COO_NotKarantin_Docs_CO_Objects"
        Me.bsNotKarantin.DataSource = Me.bsObjects
        '
        'tpKarantin
        '
        Me.tpKarantin.CausesValidation = False
        Me.tpKarantin.Controls.Add(Me.dgvKarantin)
        Me.tpKarantin.ImageKey = "Copy.bmp"
        Me.tpKarantin.Location = New System.Drawing.Point(4, 22)
        Me.tpKarantin.Name = "tpKarantin"
        Me.tpKarantin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpKarantin.Size = New System.Drawing.Size(850, 110)
        Me.tpKarantin.TabIndex = 0
        Me.tpKarantin.Text = "Карантинные"
        Me.tpKarantin.UseVisualStyleBackColor = True
        '
        'dgvKarantin
        '
        Me.dgvKarantin.AutoGenerateColumns = False
        Me.dgvKarantin.CausesValidation = False
        Me.dgvKarantin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKarantin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cKarantinObjectTitle, Me.ExammethodDataGridViewTextBoxColumn1, Me.ExamcountDataGridViewTextBoxColumn1, Me.DocidDataGridViewTextBoxColumn4, Me.TitleDataGridViewTextBoxColumn3})
        Me.dgvKarantin.DataSource = Me.bsKarantin
        Me.dgvKarantin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKarantin.Location = New System.Drawing.Point(3, 3)
        Me.dgvKarantin.Name = "dgvKarantin"
        Me.dgvKarantin.Size = New System.Drawing.Size(844, 104)
        Me.dgvKarantin.TabIndex = 0
        '
        'cKarantinObjectTitle
        '
        Me.cKarantinObjectTitle.DataPropertyName = "object_title"
        Me.cKarantinObjectTitle.DisplayStyleForCurrentCellOnly = True
        Me.cKarantinObjectTitle.HeaderText = "Наименование"
        Me.cKarantinObjectTitle.Name = "cKarantinObjectTitle"
        Me.cKarantinObjectTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cKarantinObjectTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cKarantinObjectTitle.Width = 200
        '
        'ExammethodDataGridViewTextBoxColumn1
        '
        Me.ExammethodDataGridViewTextBoxColumn1.DataPropertyName = "exam_method"
        Me.ExammethodDataGridViewTextBoxColumn1.DisplayStyleForCurrentCellOnly = True
        Me.ExammethodDataGridViewTextBoxColumn1.HeaderText = "Способ обнаружения"
        Me.ExammethodDataGridViewTextBoxColumn1.Items.AddRange(New Object() {"Визуально", "Ловушками", "Приманками", "Смётками"})
        Me.ExammethodDataGridViewTextBoxColumn1.Name = "ExammethodDataGridViewTextBoxColumn1"
        Me.ExammethodDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExammethodDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ExammethodDataGridViewTextBoxColumn1.Width = 150
        '
        'ExamcountDataGridViewTextBoxColumn1
        '
        Me.ExamcountDataGridViewTextBoxColumn1.DataPropertyName = "exam_count"
        DataGridViewCellStyle3.Format = "N0"
        Me.ExamcountDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.ExamcountDataGridViewTextBoxColumn1.HeaderText = "Штук найдено"
        Me.ExamcountDataGridViewTextBoxColumn1.Name = "ExamcountDataGridViewTextBoxColumn1"
        Me.ExamcountDataGridViewTextBoxColumn1.Width = 150
        '
        'DocidDataGridViewTextBoxColumn4
        '
        Me.DocidDataGridViewTextBoxColumn4.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn4.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn4.Name = "DocidDataGridViewTextBoxColumn4"
        Me.DocidDataGridViewTextBoxColumn4.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn4.Visible = False
        '
        'TitleDataGridViewTextBoxColumn3
        '
        Me.TitleDataGridViewTextBoxColumn3.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn3.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn3.Name = "TitleDataGridViewTextBoxColumn3"
        Me.TitleDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn3.Visible = False
        '
        'bsKarantin
        '
        Me.bsKarantin.DataMember = "FK_Docs_COO_Karantin_Docs_CO_Objects"
        Me.bsKarantin.DataSource = Me.bsObjects
        '
        'dgvObjects
        '
        Me.dgvObjects.AllowUserToResizeRows = False
        Me.dgvObjects.AutoGenerateColumns = False
        Me.dgvObjects.CausesValidation = False
        Me.dgvObjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocidDataGridViewTextBoxColumn1, Me.cTitle, Me.CountDataGridViewTextBoxColumn, Me.VolumeDataGridViewTextBoxColumn, Me.cVolumeUnit, Me.cRayon, Me.ExamtrapDataGridViewTextBoxColumn, Me.ExambaitDataGridViewTextBoxColumn, Me.ExamdustDataGridViewTextBoxColumn})
        Me.dgvObjects.DataSource = Me.bsObjects
        Me.dgvObjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvObjects.Location = New System.Drawing.Point(0, 25)
        Me.dgvObjects.Name = "dgvObjects"
        Me.dgvObjects.Size = New System.Drawing.Size(858, 126)
        Me.dgvObjects.TabIndex = 6
        '
        'DocidDataGridViewTextBoxColumn1
        '
        Me.DocidDataGridViewTextBoxColumn1.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.Name = "DocidDataGridViewTextBoxColumn1"
        Me.DocidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DocidDataGridViewTextBoxColumn1.Visible = False
        '
        'cTitle
        '
        Me.cTitle.DataPropertyName = "title"
        Me.cTitle.DisplayStyleForCurrentCellOnly = True
        Me.cTitle.HeaderText = "Наименование"
        Me.cTitle.Name = "cTitle"
        Me.cTitle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cTitle.Width = 200
        '
        'CountDataGridViewTextBoxColumn
        '
        Me.CountDataGridViewTextBoxColumn.DataPropertyName = "count"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CountDataGridViewTextBoxColumn.HeaderText = "Кол-во"
        Me.CountDataGridViewTextBoxColumn.Name = "CountDataGridViewTextBoxColumn"
        Me.CountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CountDataGridViewTextBoxColumn.Width = 50
        '
        'VolumeDataGridViewTextBoxColumn
        '
        Me.VolumeDataGridViewTextBoxColumn.DataPropertyName = "volume"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.VolumeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.VolumeDataGridViewTextBoxColumn.HeaderText = "Объём"
        Me.VolumeDataGridViewTextBoxColumn.Name = "VolumeDataGridViewTextBoxColumn"
        Me.VolumeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.VolumeDataGridViewTextBoxColumn.Width = 50
        '
        'cVolumeUnit
        '
        Me.cVolumeUnit.DataPropertyName = "volume_unit"
        Me.cVolumeUnit.DisplayStyleForCurrentCellOnly = True
        Me.cVolumeUnit.HeaderText = "Ед. объёма"
        Me.cVolumeUnit.Name = "cVolumeUnit"
        Me.cVolumeUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cVolumeUnit.Width = 90
        '
        'cRayon
        '
        Me.cRayon.DataPropertyName = "rayon"
        Me.cRayon.DisplayStyleForCurrentCellOnly = True
        Me.cRayon.HeaderText = "Район"
        Me.cRayon.Name = "cRayon"
        Me.cRayon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cRayon.Width = 150
        '
        'ExamtrapDataGridViewTextBoxColumn
        '
        Me.ExamtrapDataGridViewTextBoxColumn.DataPropertyName = "exam_trap"
        DataGridViewCellStyle6.Format = "N0"
        Me.ExamtrapDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ExamtrapDataGridViewTextBoxColumn.HeaderText = "Ловушек"
        Me.ExamtrapDataGridViewTextBoxColumn.Name = "ExamtrapDataGridViewTextBoxColumn"
        Me.ExamtrapDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExamtrapDataGridViewTextBoxColumn.Width = 80
        '
        'ExambaitDataGridViewTextBoxColumn
        '
        Me.ExambaitDataGridViewTextBoxColumn.DataPropertyName = "exam_bait"
        DataGridViewCellStyle7.Format = "N0"
        Me.ExambaitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ExambaitDataGridViewTextBoxColumn.HeaderText = "Приманок"
        Me.ExambaitDataGridViewTextBoxColumn.Name = "ExambaitDataGridViewTextBoxColumn"
        Me.ExambaitDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExambaitDataGridViewTextBoxColumn.Width = 80
        '
        'ExamdustDataGridViewTextBoxColumn
        '
        Me.ExamdustDataGridViewTextBoxColumn.DataPropertyName = "exam_dust"
        DataGridViewCellStyle8.Format = "N0"
        Me.ExamdustDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ExamdustDataGridViewTextBoxColumn.HeaderText = "Смёток"
        Me.ExamdustDataGridViewTextBoxColumn.Name = "ExamdustDataGridViewTextBoxColumn"
        Me.ExamdustDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExamdustDataGridViewTextBoxColumn.Width = 80
        '
        'bnConclusions
        '
        Me.bnConclusions.AddNewItem = Nothing
        Me.bnConclusions.BindingSource = Me.bsConclusions
        Me.bnConclusions.CountItem = Me.BindingNavigatorCountItem
        Me.bnConclusions.DeleteItem = Nothing
        Me.bnConclusions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Docs_Conclusions_ImportBindingNavigatorSaveItem, Me.btnCopy, Me.btnPrint, Me.btnPrintPreview})
        Me.bnConclusions.Location = New System.Drawing.Point(0, 0)
        Me.bnConclusions.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnConclusions.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnConclusions.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnConclusions.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnConclusions.Name = "bnConclusions"
        Me.bnConclusions.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnConclusions.Size = New System.Drawing.Size(858, 25)
        Me.bnConclusions.TabIndex = 2
        Me.bnConclusions.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel1.Text = "Заключения"
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
        Me.BindingNavigatorAddNewItem.Text = "Новое заключение на ОБЪЕКТЫ"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить заключение"
        '
        'Docs_Conclusions_ImportBindingNavigatorSaveItem
        '
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Image = CType(resources.GetObject("Docs_Conclusions_ImportBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Name = "Docs_Conclusions_ImportBindingNavigatorSaveItem"
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Text = "Сохранить"
        '
        'btnCopy
        '
        Me.btnCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "Копировать в заключение на ОБЪЕКТЫ"
        '
        'btnPrint
        '
        Me.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Печать"
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pnlMain
        '
        Me.pnlMain.CausesValidation = False
        Me.pnlMain.ColumnCount = 4
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlMain.Controls.Add(Me.Label3, 0, 2)
        Me.pnlMain.Controls.Add(Me.txtSamples, 3, 2)
        Me.pnlMain.Controls.Add(Me.txtRepresentative, 1, 0)
        Me.pnlMain.Controls.Add(Me.txtConclusion, 1, 2)
        Me.pnlMain.Controls.Add(Me.Label1, 0, 0)
        Me.pnlMain.Controls.Add(Me.btnFill, 0, 1)
        Me.pnlMain.Controls.Add(Me.txtVerdict, 1, 1)
        Me.pnlMain.Controls.Add(Me.Label2, 2, 0)
        Me.pnlMain.Controls.Add(Me.cbTarget, 3, 0)
        Me.pnlMain.Controls.Add(Me.Label4, 2, 2)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 444)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.RowCount = 3
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.pnlMain.Size = New System.Drawing.Size(858, 171)
        Me.pnlMain.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(3, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 70)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Заключение"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSamples
        '
        Me.txtSamples.CausesValidation = False
        Me.txtSamples.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsConclusions, "samples", True))
        Me.txtSamples.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSamples.Location = New System.Drawing.Point(521, 101)
        Me.txtSamples.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSamples.Multiline = True
        Me.txtSamples.Name = "txtSamples"
        Me.txtSamples.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSamples.Size = New System.Drawing.Size(337, 70)
        Me.txtSamples.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(434, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Обследование"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbTarget
        '
        Me.cbTarget.CausesValidation = False
        Me.cbTarget.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsConclusions, "target", True))
        Me.cbTarget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTarget.FormattingEnabled = True
        Me.cbTarget.Location = New System.Drawing.Point(521, 0)
        Me.cbTarget.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTarget.Name = "cbTarget"
        Me.cbTarget.Size = New System.Drawing.Size(337, 21)
        Me.cbTarget.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(434, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 70)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Образцы"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'taConclusions
        '
        Me.taConclusions.ClearBeforeFill = True
        '
        'taCO_Objects
        '
        Me.taCO_Objects.ClearBeforeFill = True
        '
        'taCOO_Examinations
        '
        Me.taCOO_Examinations.ClearBeforeFill = True
        '
        'taCOO_Karantin
        '
        Me.taCOO_Karantin.ClearBeforeFill = True
        '
        'taCOO_NotKarantin
        '
        Me.taCOO_NotKarantin.ClearBeforeFill = True
        '
        'taClients
        '
        Me.taClients.ClearBeforeFill = True
        '
        'frmDocConclusionsObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(858, 615)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlGrids)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlDoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDocConclusionsObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Заключения на ОБЪЕКТЫ"
        CType(Me.bsConclusions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsConclusions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDoc.ResumeLayout(False)
        Me.pnlDoc.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlGrids.ResumeLayout(False)
        Me.pnlGrids.PerformLayout()
        Me.tabChildViewes.ResumeLayout(False)
        Me.tpExaminations.ResumeLayout(False)
        CType(Me.dgvExaminations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsExaminations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsObjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpNotKarantin.ResumeLayout(False)
        CType(Me.dgvNotKarantin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNotKarantin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpKarantin.ResumeLayout(False)
        CType(Me.dgvKarantin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKarantin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvObjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnConclusions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnConclusions.ResumeLayout(False)
        Me.bnConclusions.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents cbRayon As System.Windows.Forms.ComboBox
    Friend WithEvents lblObject As System.Windows.Forms.Label
    Friend WithEvents cbObject As System.Windows.Forms.ComboBox
    Friend WithEvents Doc_date_highDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRayon As System.Windows.Forms.Label
    Friend WithEvents lblKarantin As System.Windows.Forms.Label
    Friend WithEvents cbKarantin As System.Windows.Forms.ComboBox
    Friend WithEvents pnlDoc As System.Windows.Forms.Panel
    Friend WithEvents Doc_numberLabel As System.Windows.Forms.Label
    Friend WithEvents Client_innLabel As System.Windows.Forms.Label
    Friend WithEvents Doc_dateLabel As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents pnlGrids As System.Windows.Forms.Panel
    Friend WithEvents tabChildViewes As System.Windows.Forms.TabControl
    Friend WithEvents tpKarantin As System.Windows.Forms.TabPage
    Friend WithEvents tpExaminations As System.Windows.Forms.TabPage
    Friend WithEvents tpNotKarantin As System.Windows.Forms.TabPage
    Friend WithEvents bnConclusions As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Docs_Conclusions_ImportBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents dsConclusions As Inspector.Docs_Conclusions_Objects
    Friend WithEvents taConclusions As Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_Conclusions_ObjectsTableAdapter
    Friend WithEvents taCO_Objects As Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_CO_ObjectsTableAdapter
    Friend WithEvents taCOO_Examinations As Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_ExaminationsTableAdapter
    Friend WithEvents taCOO_Karantin As Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_KarantinTableAdapter
    Friend WithEvents taCOO_NotKarantin As Inspector.Docs_Conclusions_ObjectsTableAdapters.Docs_COO_NotKarantinTableAdapter
    Friend WithEvents bsConclusions As System.Windows.Forms.BindingSource
    Friend WithEvents lblHighDate As System.Windows.Forms.Label
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents txtVerdict As System.Windows.Forms.TextBox
    Friend WithEvents txtRepresentative As System.Windows.Forms.TextBox
    Friend WithEvents bsObjects As System.Windows.Forms.BindingSource
    Friend WithEvents bsExaminations As System.Windows.Forms.BindingSource
    Friend WithEvents bsKarantin As System.Windows.Forms.BindingSource
    Friend WithEvents bsNotKarantin As System.Windows.Forms.BindingSource
    Friend WithEvents bsClients As System.Windows.Forms.BindingSource
    Friend WithEvents taClients As Inspector.Docs_Conclusions_ObjectsTableAdapters.R_clientsTableAdapter
    Friend WithEvents btnAddExaminations As System.Windows.Forms.Button
    Friend WithEvents dgvObjects As Inspector.dgvWithoutEnter
    Friend WithEvents dgvExaminations As Inspector.dgvWithoutEnter
    Friend WithEvents dgvNotKarantin As Inspector.dgvWithoutEnter
    Friend WithEvents dgvKarantin As Inspector.dgvWithoutEnter
    Friend WithEvents cNotKarantinObjectTitle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ExammethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ExamcountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKarantinObjectTitle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ExammethodDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ExamcountDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DocidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cExamsTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cExamsObjectTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTitle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cVolumeUnit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cRayon As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ExamtrapDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExambaitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExamdustDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblDocType As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTarget As System.Windows.Forms.ComboBox
    Friend WithEvents txtSamples As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
