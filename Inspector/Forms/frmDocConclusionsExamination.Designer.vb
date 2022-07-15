<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocConclusionsExamination
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
        Dim Transport_numberLabel As System.Windows.Forms.Label
        Dim Bill_numberLabel As System.Windows.Forms.Label
        Dim Bill_dateLabel As System.Windows.Forms.Label
        Dim Sert_numberLabel As System.Windows.Forms.Label
        Dim Sert_fromLabel As System.Windows.Forms.Label
        Dim DisinfectionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocConclusionsExamination))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Transport_typeLabel = New System.Windows.Forms.Label()
        Me.Bill_typeLabel = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Doc_numberLabel = New System.Windows.Forms.Label()
        Me.Client_innLabel = New System.Windows.Forms.Label()
        Me.Doc_dateLabel = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.cbTargetOrSourceDir = New System.Windows.Forms.ComboBox()
        Me.bsDocs_Conclusions_Examination = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsConclusions = New Inspector.Docs_Conclusions()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbDocUser = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtMaterialFrom = New System.Windows.Forms.TextBox()
        Me.txtToDocument = New System.Windows.Forms.TextBox()
        Me.txtKarantinSertDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKarantinSertNumber = New System.Windows.Forms.TextBox()
        Me.Bill_date = New System.Windows.Forms.TextBox()
        Me.Bill_typeComboBox = New System.Windows.Forms.ComboBox()
        Me.Transport_typeComboBox = New System.Windows.Forms.ComboBox()
        Me.Transport_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Bill_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Sert_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Sert_fromTextBox = New System.Windows.Forms.TextBox()
        Me.txtTargetOrSource = New System.Windows.Forms.TextBox()
        Me.lblCountryFrom = New System.Windows.Forms.Label()
        Me.cbCountryFrom = New System.Windows.Forms.ComboBox()
        Me.lblKarantin = New System.Windows.Forms.Label()
        Me.cbKarantin = New System.Windows.Forms.ComboBox()
        Me.lblCountryProduction = New System.Windows.Forms.Label()
        Me.cbCountryProduction = New System.Windows.Forms.ComboBox()
        Me.lblProduction = New System.Windows.Forms.Label()
        Me.cbProduction = New System.Windows.Forms.ComboBox()
        Me.lblHighDate = New System.Windows.Forms.Label()
        Me.Doc_date_highDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtClient_address = New System.Windows.Forms.TextBox()
        Me.bsR_clients = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtClient_name = New System.Windows.Forms.TextBox()
        Me.Client_innMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Doc_numberMaskTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Doc_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.bnDocs_Conclusions_Examination = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnCopyTo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnCopyToExamination = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopyToImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopyToExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrints = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnPrintAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPreviews = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnPreviewAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlDiseases = New System.Windows.Forms.Panel()
        Me.dgvDocs_Conclusions_NotKarantin = New Inspector.dgvWithoutEnter()
        Me.Column_notkarantin_object_title = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column_state_notkar = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DocidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductioncountryDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GoodtitleDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDocs_Conclusions_NotKarantin = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsDocs_Acts_Goods = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDocs_Conclusions_Karantin = New Inspector.dgvWithoutEnter()
        Me.Column_karantin_object_title = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_karantin_count_unit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column_state = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DocidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductioncountryDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GoodtitleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDocs_Conclusions_Karantin = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDocs_Acts_Goods = New Inspector.dgvWithoutEnter()
        Me.Column_good_title = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column_production_country = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.places = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_places_unit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_weight_unit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.samples_count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GoodtitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductioncountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacesunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SamplescountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblFactAddress = New System.Windows.Forms.Label()
        Me.txtFactAddress = New System.Windows.Forms.TextBox()
        Me.DocidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taDocs_Acts_Goods = New Inspector.Docs_ConclusionsTableAdapters.Docs_Acts_GoodsTableAdapter()
        Me.taDocs_Conclusions_Karantin = New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_KarantinTableAdapter()
        Me.taDocs_Conclusions_NotKarantin = New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_NotKarantinTableAdapter()
        Me.taR_clients = New Inspector.Docs_ConclusionsTableAdapters.R_clientsTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.splitDiseasesAndMain = New System.Windows.Forms.SplitContainer()
        Me.splitAll = New System.Windows.Forms.SplitContainer()
        Me.taDocs_Conclusions_Examination = New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_ExaminationTableAdapter()
        Transport_numberLabel = New System.Windows.Forms.Label()
        Bill_numberLabel = New System.Windows.Forms.Label()
        Bill_dateLabel = New System.Windows.Forms.Label()
        Sert_numberLabel = New System.Windows.Forms.Label()
        Sert_fromLabel = New System.Windows.Forms.Label()
        DisinfectionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout
        CType(Me.bsDocs_Conclusions_Examination,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dsConclusions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bsR_clients,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bnDocs_Conclusions_Examination,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnDocs_Conclusions_Examination.SuspendLayout
        Me.pnlDiseases.SuspendLayout
        CType(Me.dgvDocs_Conclusions_NotKarantin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bsDocs_Conclusions_NotKarantin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bsDocs_Acts_Goods,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvDocs_Conclusions_Karantin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bsDocs_Conclusions_Karantin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvDocs_Acts_Goods,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlTitle.SuspendLayout
        Me.pnlSearch.SuspendLayout
        Me.splitDiseasesAndMain.Panel1.SuspendLayout
        Me.splitDiseasesAndMain.Panel2.SuspendLayout
        Me.splitDiseasesAndMain.SuspendLayout
        Me.splitAll.Panel1.SuspendLayout
        Me.splitAll.Panel2.SuspendLayout
        Me.splitAll.SuspendLayout
        Me.SuspendLayout
        '
        'Transport_numberLabel
        '
        Transport_numberLabel.AutoSize = true
        Transport_numberLabel.CausesValidation = false
        Transport_numberLabel.Location = New System.Drawing.Point(426, 31)
        Transport_numberLabel.Name = "Transport_numberLabel"
        Transport_numberLabel.Size = New System.Drawing.Size(18, 13)
        Transport_numberLabel.TabIndex = 12
        Transport_numberLabel.Text = "№"
        '
        'Bill_numberLabel
        '
        Bill_numberLabel.AutoSize = true
        Bill_numberLabel.CausesValidation = false
        Bill_numberLabel.Location = New System.Drawing.Point(426, 56)
        Bill_numberLabel.Name = "Bill_numberLabel"
        Bill_numberLabel.Size = New System.Drawing.Size(18, 13)
        Bill_numberLabel.TabIndex = 16
        Bill_numberLabel.Text = "№"
        '
        'Bill_dateLabel
        '
        Bill_dateLabel.AutoSize = true
        Bill_dateLabel.CausesValidation = false
        Bill_dateLabel.Location = New System.Drawing.Point(730, 56)
        Bill_dateLabel.Name = "Bill_dateLabel"
        Bill_dateLabel.Size = New System.Drawing.Size(18, 13)
        Bill_dateLabel.TabIndex = 18
        Bill_dateLabel.Text = "от"
        '
        'Sert_numberLabel
        '
        Sert_numberLabel.AutoSize = true
        Sert_numberLabel.CausesValidation = false
        Sert_numberLabel.Location = New System.Drawing.Point(4, 78)
        Sert_numberLabel.Name = "Sert_numberLabel"
        Sert_numberLabel.Size = New System.Drawing.Size(45, 13)
        Sert_numberLabel.TabIndex = 34
        Sert_numberLabel.Text = "Серт №"
        '
        'Sert_fromLabel
        '
        Sert_fromLabel.AutoSize = true
        Sert_fromLabel.CausesValidation = false
        Sert_fromLabel.Location = New System.Drawing.Point(241, 78)
        Sert_fromLabel.Name = "Sert_fromLabel"
        Sert_fromLabel.Size = New System.Drawing.Size(40, 13)
        Sert_fromLabel.TabIndex = 36
        Sert_fromLabel.Text = "Выдан"
        '
        'DisinfectionLabel
        '
        DisinfectionLabel.CausesValidation = false
        DisinfectionLabel.Location = New System.Drawing.Point(4, 98)
        DisinfectionLabel.Name = "DisinfectionLabel"
        DisinfectionLabel.Size = New System.Drawing.Size(61, 26)
        DisinfectionLabel.TabIndex = 40
        DisinfectionLabel.Text = "Откуда / Куда"
        '
        'Label2
        '
        Label2.AutoSize = true
        Label2.CausesValidation = false
        Label2.Location = New System.Drawing.Point(769, 29)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(18, 13)
        Label2.TabIndex = 44
        Label2.Text = "от"
        '
        'Label3
        '
        Label3.CausesValidation = false
        Label3.Location = New System.Drawing.Point(4, 158)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 40)
        Label3.TabIndex = 47
        Label3.Text = "На сопровод. док."
        '
        'Label4
        '
        Label4.CausesValidation = false
        Label4.Location = New System.Drawing.Point(3, 201)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(61, 40)
        Label4.TabIndex = 48
        Label4.Text = "От кого поступил материал"
        '
        'Label7
        '
        Label7.CausesValidation = false
        Label7.Location = New System.Drawing.Point(4, 130)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(61, 26)
        Label7.TabIndex = 75
        Label7.Text = "Откуда / Куда (выбор из справочника)"
        '
        'Transport_typeLabel
        '
        Me.Transport_typeLabel.AutoSize = true
        Me.Transport_typeLabel.CausesValidation = false
        Me.Transport_typeLabel.Location = New System.Drawing.Point(4, 29)
        Me.Transport_typeLabel.Name = "Transport_typeLabel"
        Me.Transport_typeLabel.Size = New System.Drawing.Size(61, 13)
        Me.Transport_typeLabel.TabIndex = 10
        Me.Transport_typeLabel.Text = "Транспорт"
        '
        'Bill_typeLabel
        '
        Me.Bill_typeLabel.AutoSize = true
        Me.Bill_typeLabel.CausesValidation = false
        Me.Bill_typeLabel.Location = New System.Drawing.Point(4, 54)
        Me.Bill_typeLabel.Name = "Bill_typeLabel"
        Me.Bill_typeLabel.Size = New System.Drawing.Size(63, 13)
        Me.Bill_typeLabel.TabIndex = 14
        Me.Bill_typeLabel.Text = "Накладная"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = true
        Me.lblAddress.CausesValidation = false
        Me.lblAddress.Location = New System.Drawing.Point(6, 58)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(38, 13)
        Me.lblAddress.TabIndex = 74
        Me.lblAddress.Text = "Адрес"
        '
        'Doc_numberLabel
        '
        Me.Doc_numberLabel.AutoSize = true
        Me.Doc_numberLabel.CausesValidation = false
        Me.Doc_numberLabel.Location = New System.Drawing.Point(5, 35)
        Me.Doc_numberLabel.Name = "Doc_numberLabel"
        Me.Doc_numberLabel.Size = New System.Drawing.Size(18, 13)
        Me.Doc_numberLabel.TabIndex = 2
        Me.Doc_numberLabel.Text = "№"
        '
        'Client_innLabel
        '
        Me.Client_innLabel.AutoSize = true
        Me.Client_innLabel.CausesValidation = false
        Me.Client_innLabel.Location = New System.Drawing.Point(263, 35)
        Me.Client_innLabel.Name = "Client_innLabel"
        Me.Client_innLabel.Size = New System.Drawing.Size(31, 13)
        Me.Client_innLabel.TabIndex = 4
        Me.Client_innLabel.Text = "ИНН"
        '
        'Doc_dateLabel
        '
        Me.Doc_dateLabel.AutoSize = true
        Me.Doc_dateLabel.CausesValidation = false
        Me.Doc_dateLabel.Location = New System.Drawing.Point(82, 35)
        Me.Doc_dateLabel.Name = "Doc_dateLabel"
        Me.Doc_dateLabel.Size = New System.Drawing.Size(18, 13)
        Me.Doc_dateLabel.TabIndex = 6
        Me.Doc_dateLabel.Text = "от"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMain.CausesValidation = false
        Me.pnlMain.Controls.Add(Label7)
        Me.pnlMain.Controls.Add(Me.cbTargetOrSourceDir)
        Me.pnlMain.Controls.Add(Me.Label6)
        Me.pnlMain.Controls.Add(Me.cbDocUser)
        Me.pnlMain.Controls.Add(Me.Label5)
        Me.pnlMain.Controls.Add(Me.txtRemark)
        Me.pnlMain.Controls.Add(Label4)
        Me.pnlMain.Controls.Add(Label3)
        Me.pnlMain.Controls.Add(Me.txtMaterialFrom)
        Me.pnlMain.Controls.Add(Me.txtToDocument)
        Me.pnlMain.Controls.Add(Me.txtKarantinSertDate)
        Me.pnlMain.Controls.Add(Label2)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Controls.Add(Me.txtKarantinSertNumber)
        Me.pnlMain.Controls.Add(Me.Bill_date)
        Me.pnlMain.Controls.Add(Me.Bill_typeComboBox)
        Me.pnlMain.Controls.Add(Me.Transport_typeComboBox)
        Me.pnlMain.Controls.Add(Me.Transport_typeLabel)
        Me.pnlMain.Controls.Add(Transport_numberLabel)
        Me.pnlMain.Controls.Add(Me.Transport_numberTextBox)
        Me.pnlMain.Controls.Add(Me.Bill_typeLabel)
        Me.pnlMain.Controls.Add(Bill_numberLabel)
        Me.pnlMain.Controls.Add(Me.Bill_numberTextBox)
        Me.pnlMain.Controls.Add(Bill_dateLabel)
        Me.pnlMain.Controls.Add(Sert_numberLabel)
        Me.pnlMain.Controls.Add(Me.Sert_numberTextBox)
        Me.pnlMain.Controls.Add(Sert_fromLabel)
        Me.pnlMain.Controls.Add(Me.Sert_fromTextBox)
        Me.pnlMain.Controls.Add(DisinfectionLabel)
        Me.pnlMain.Controls.Add(Me.txtTargetOrSource)
        Me.pnlMain.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(894, 212)
        Me.pnlMain.TabIndex = 0
        '
        'cbTargetOrSourceDir
        '
        Me.cbTargetOrSourceDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbTargetOrSourceDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTargetOrSourceDir.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbTargetOrSourceDir.CausesValidation = false
        Me.cbTargetOrSourceDir.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbTargetOrSourceDir.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsDocs_Conclusions_Examination, "target_or_source_dir", true))
        Me.cbTargetOrSourceDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTargetOrSourceDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cbTargetOrSourceDir.FormattingEnabled = true
        Me.cbTargetOrSourceDir.Location = New System.Drawing.Point(70, 132)
        Me.cbTargetOrSourceDir.Name = "cbTargetOrSourceDir"
        Me.cbTargetOrSourceDir.Size = New System.Drawing.Size(353, 24)
        Me.cbTargetOrSourceDir.TabIndex = 74
        '
        'bsDocs_Conclusions_Examination
        '
        Me.bsDocs_Conclusions_Examination.DataMember = "Docs_Conclusions_Examination"
        Me.bsDocs_Conclusions_Examination.DataSource = Me.dsConclusions
        '
        'dsConclusions
        '
        Me.dsConclusions.DataSetName = "Docs_Conclusions_Import"
        Me.dsConclusions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.CausesValidation = false
        Me.Label6.Location = New System.Drawing.Point(426, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Исполнитель"
        '
        'cbDocUser
        '
        Me.cbDocUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbDocUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDocUser.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbDocUser.CausesValidation = false
        Me.cbDocUser.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbDocUser.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsDocs_Conclusions_Examination, "doc_user", true))
        Me.cbDocUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cbDocUser.FormattingEnabled = true
        Me.cbDocUser.ItemHeight = 13
        Me.cbDocUser.Location = New System.Drawing.Point(509, 1)
        Me.cbDocUser.Name = "cbDocUser"
        Me.cbDocUser.Size = New System.Drawing.Size(380, 21)
        Me.cbDocUser.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.CausesValidation = false
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Заметки"
        '
        'txtRemark
        '
        Me.txtRemark.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtRemark.CausesValidation = false
        Me.txtRemark.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtRemark.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "mark", true))
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtRemark.Location = New System.Drawing.Point(70, 1)
        Me.txtRemark.MaxLength = 500
        Me.txtRemark.Multiline = true
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(353, 22)
        Me.txtRemark.TabIndex = 70
        '
        'txtMaterialFrom
        '
        Me.txtMaterialFrom.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtMaterialFrom.CausesValidation = false
        Me.txtMaterialFrom.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtMaterialFrom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "material_from", true))
        Me.txtMaterialFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtMaterialFrom.Location = New System.Drawing.Point(70, 201)
        Me.txtMaterialFrom.MaxLength = 500
        Me.txtMaterialFrom.Multiline = true
        Me.txtMaterialFrom.Name = "txtMaterialFrom"
        Me.txtMaterialFrom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMaterialFrom.Size = New System.Drawing.Size(819, 40)
        Me.txtMaterialFrom.TabIndex = 11
        '
        'txtToDocument
        '
        Me.txtToDocument.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtToDocument.CausesValidation = false
        Me.txtToDocument.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtToDocument.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "to_document", true))
        Me.txtToDocument.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtToDocument.Location = New System.Drawing.Point(70, 158)
        Me.txtToDocument.MaxLength = 500
        Me.txtToDocument.Multiline = true
        Me.txtToDocument.Name = "txtToDocument"
        Me.txtToDocument.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToDocument.Size = New System.Drawing.Size(819, 40)
        Me.txtToDocument.TabIndex = 10
        '
        'txtKarantinSertDate
        '
        Me.txtKarantinSertDate.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtKarantinSertDate.CausesValidation = false
        Me.txtKarantinSertDate.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtKarantinSertDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "karantin_sert_date", true))
        Me.txtKarantinSertDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtKarantinSertDate.Location = New System.Drawing.Point(793, 24)
        Me.txtKarantinSertDate.MaxLength = 20
        Me.txtKarantinSertDate.Name = "txtKarantinSertDate"
        Me.txtKarantinSertDate.Size = New System.Drawing.Size(96, 22)
        Me.txtKarantinSertDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(539, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Карантинный сертификат"
        '
        'txtKarantinSertNumber
        '
        Me.txtKarantinSertNumber.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtKarantinSertNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "karantin_sert_number", true))
        Me.txtKarantinSertNumber.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtKarantinSertNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtKarantinSertNumber.Location = New System.Drawing.Point(685, 24)
        Me.txtKarantinSertNumber.MaxLength = 50
        Me.txtKarantinSertNumber.Name = "txtKarantinSertNumber"
        Me.txtKarantinSertNumber.Size = New System.Drawing.Size(84, 22)
        Me.txtKarantinSertNumber.TabIndex = 2
        '
        'Bill_date
        '
        Me.Bill_date.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Bill_date.CausesValidation = false
        Me.Bill_date.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "bill_date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Bill_date.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Bill_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Bill_date.Location = New System.Drawing.Point(754, 51)
        Me.Bill_date.MaxLength = 20
        Me.Bill_date.Name = "Bill_date"
        Me.Bill_date.Size = New System.Drawing.Size(135, 22)
        Me.Bill_date.TabIndex = 6
        '
        'Bill_typeComboBox
        '
        Me.Bill_typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Bill_typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Bill_typeComboBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Bill_typeComboBox.CausesValidation = false
        Me.Bill_typeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsDocs_Conclusions_Examination, "bill_type", true))
        Me.Bill_typeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Bill_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bill_typeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Bill_typeComboBox.FormattingEnabled = true
        Me.Bill_typeComboBox.Location = New System.Drawing.Point(70, 49)
        Me.Bill_typeComboBox.Name = "Bill_typeComboBox"
        Me.Bill_typeComboBox.Size = New System.Drawing.Size(353, 24)
        Me.Bill_typeComboBox.TabIndex = 4
        '
        'Transport_typeComboBox
        '
        Me.Transport_typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Transport_typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Transport_typeComboBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Transport_typeComboBox.CausesValidation = false
        Me.Transport_typeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsDocs_Conclusions_Examination, "transport_type", true))
        Me.Transport_typeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Transport_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Transport_typeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Transport_typeComboBox.FormattingEnabled = true
        Me.Transport_typeComboBox.Location = New System.Drawing.Point(70, 24)
        Me.Transport_typeComboBox.Name = "Transport_typeComboBox"
        Me.Transport_typeComboBox.Size = New System.Drawing.Size(353, 24)
        Me.Transport_typeComboBox.TabIndex = 0
        '
        'Transport_numberTextBox
        '
        Me.Transport_numberTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Transport_numberTextBox.CausesValidation = false
        Me.Transport_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "transport_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Transport_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Transport_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Transport_numberTextBox.Location = New System.Drawing.Point(453, 24)
        Me.Transport_numberTextBox.MaxLength = 50
        Me.Transport_numberTextBox.Name = "Transport_numberTextBox"
        Me.Transport_numberTextBox.Size = New System.Drawing.Size(80, 22)
        Me.Transport_numberTextBox.TabIndex = 1
        '
        'Bill_numberTextBox
        '
        Me.Bill_numberTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Bill_numberTextBox.CausesValidation = false
        Me.Bill_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "bill_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Bill_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Bill_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Bill_numberTextBox.Location = New System.Drawing.Point(453, 51)
        Me.Bill_numberTextBox.MaxLength = 150
        Me.Bill_numberTextBox.Name = "Bill_numberTextBox"
        Me.Bill_numberTextBox.Size = New System.Drawing.Size(271, 22)
        Me.Bill_numberTextBox.TabIndex = 5
        '
        'Sert_numberTextBox
        '
        Me.Sert_numberTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Sert_numberTextBox.CausesValidation = false
        Me.Sert_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "sert_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Sert_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Sert_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Sert_numberTextBox.Location = New System.Drawing.Point(70, 73)
        Me.Sert_numberTextBox.MaxLength = 50
        Me.Sert_numberTextBox.Name = "Sert_numberTextBox"
        Me.Sert_numberTextBox.Size = New System.Drawing.Size(165, 22)
        Me.Sert_numberTextBox.TabIndex = 7
        '
        'Sert_fromTextBox
        '
        Me.Sert_fromTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Sert_fromTextBox.CausesValidation = false
        Me.Sert_fromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "sert_from", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Sert_fromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Sert_fromTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Sert_fromTextBox.Location = New System.Drawing.Point(287, 73)
        Me.Sert_fromTextBox.MaxLength = 200
        Me.Sert_fromTextBox.Name = "Sert_fromTextBox"
        Me.Sert_fromTextBox.Size = New System.Drawing.Size(602, 22)
        Me.Sert_fromTextBox.TabIndex = 8
        Me.Sert_fromTextBox.WordWrap = false
        '
        'txtTargetOrSource
        '
        Me.txtTargetOrSource.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtTargetOrSource.CausesValidation = false
        Me.txtTargetOrSource.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "target_or_source", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTargetOrSource.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTargetOrSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTargetOrSource.Location = New System.Drawing.Point(70, 96)
        Me.txtTargetOrSource.MaxLength = 1000
        Me.txtTargetOrSource.Multiline = true
        Me.txtTargetOrSource.Name = "txtTargetOrSource"
        Me.txtTargetOrSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTargetOrSource.Size = New System.Drawing.Size(819, 35)
        Me.txtTargetOrSource.TabIndex = 9
        '
        'lblCountryFrom
        '
        Me.lblCountryFrom.AutoSize = true
        Me.lblCountryFrom.CausesValidation = false
        Me.lblCountryFrom.Location = New System.Drawing.Point(361, 49)
        Me.lblCountryFrom.Name = "lblCountryFrom"
        Me.lblCountryFrom.Size = New System.Drawing.Size(47, 13)
        Me.lblCountryFrom.TabIndex = 86
        Me.lblCountryFrom.Text = "Прибыл"
        '
        'cbCountryFrom
        '
        Me.cbCountryFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCountryFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCountryFrom.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbCountryFrom.CausesValidation = false
        Me.cbCountryFrom.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCountryFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCountryFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cbCountryFrom.FormattingEnabled = true
        Me.cbCountryFrom.Location = New System.Drawing.Point(455, 49)
        Me.cbCountryFrom.Name = "cbCountryFrom"
        Me.cbCountryFrom.Size = New System.Drawing.Size(307, 24)
        Me.cbCountryFrom.TabIndex = 85
        '
        'lblKarantin
        '
        Me.lblKarantin.AutoSize = true
        Me.lblKarantin.CausesValidation = false
        Me.lblKarantin.Location = New System.Drawing.Point(32, 49)
        Me.lblKarantin.Name = "lblKarantin"
        Me.lblKarantin.Size = New System.Drawing.Size(55, 13)
        Me.lblKarantin.TabIndex = 84
        Me.lblKarantin.Text = "Карантин"
        '
        'cbKarantin
        '
        Me.cbKarantin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbKarantin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbKarantin.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbKarantin.CausesValidation = false
        Me.cbKarantin.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbKarantin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKarantin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cbKarantin.FormattingEnabled = true
        Me.cbKarantin.Location = New System.Drawing.Point(100, 49)
        Me.cbKarantin.Name = "cbKarantin"
        Me.cbKarantin.Size = New System.Drawing.Size(258, 24)
        Me.cbKarantin.TabIndex = 83
        '
        'lblCountryProduction
        '
        Me.lblCountryProduction.AutoSize = true
        Me.lblCountryProduction.CausesValidation = false
        Me.lblCountryProduction.Location = New System.Drawing.Point(361, 27)
        Me.lblCountryProduction.Name = "lblCountryProduction"
        Me.lblCountryProduction.Size = New System.Drawing.Size(88, 13)
        Me.lblCountryProduction.TabIndex = 82
        Me.lblCountryProduction.Text = "Происхождение"
        '
        'cbCountryProduction
        '
        Me.cbCountryProduction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCountryProduction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCountryProduction.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbCountryProduction.CausesValidation = false
        Me.cbCountryProduction.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCountryProduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCountryProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cbCountryProduction.FormattingEnabled = true
        Me.cbCountryProduction.Location = New System.Drawing.Point(455, 25)
        Me.cbCountryProduction.Name = "cbCountryProduction"
        Me.cbCountryProduction.Size = New System.Drawing.Size(307, 24)
        Me.cbCountryProduction.TabIndex = 81
        '
        'lblProduction
        '
        Me.lblProduction.AutoSize = true
        Me.lblProduction.CausesValidation = false
        Me.lblProduction.Location = New System.Drawing.Point(32, 28)
        Me.lblProduction.Name = "lblProduction"
        Me.lblProduction.Size = New System.Drawing.Size(62, 13)
        Me.lblProduction.TabIndex = 80
        Me.lblProduction.Text = "Продукция"
        '
        'cbProduction
        '
        Me.cbProduction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbProduction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProduction.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbProduction.CausesValidation = false
        Me.cbProduction.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbProduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cbProduction.FormattingEnabled = true
        Me.cbProduction.Location = New System.Drawing.Point(100, 25)
        Me.cbProduction.Name = "cbProduction"
        Me.cbProduction.Size = New System.Drawing.Size(258, 24)
        Me.cbProduction.TabIndex = 79
        '
        'lblHighDate
        '
        Me.lblHighDate.AutoSize = true
        Me.lblHighDate.CausesValidation = false
        Me.lblHighDate.Location = New System.Drawing.Point(76, 3)
        Me.lblHighDate.Name = "lblHighDate"
        Me.lblHighDate.Size = New System.Drawing.Size(19, 13)
        Me.lblHighDate.TabIndex = 78
        Me.lblHighDate.Text = "до"
        '
        'Doc_date_highDateTimePicker
        '
        Me.Doc_date_highDateTimePicker.CausesValidation = false
        Me.Doc_date_highDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Doc_date_highDateTimePicker.Location = New System.Drawing.Point(100, -1)
        Me.Doc_date_highDateTimePicker.Name = "Doc_date_highDateTimePicker"
        Me.Doc_date_highDateTimePicker.Size = New System.Drawing.Size(164, 22)
        Me.Doc_date_highDateTimePicker.TabIndex = 77
        '
        'txtClient_address
        '
        Me.txtClient_address.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.txtClient_address.CausesValidation = false
        Me.txtClient_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_adress", true))
        Me.txtClient_address.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtClient_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtClient_address.Location = New System.Drawing.Point(82, 55)
        Me.txtClient_address.Name = "txtClient_address"
        Me.txtClient_address.ReadOnly = true
        Me.txtClient_address.Size = New System.Drawing.Size(809, 22)
        Me.txtClient_address.TabIndex = 73
        Me.txtClient_address.TabStop = false
        '
        'bsR_clients
        '
        Me.bsR_clients.DataMember = "R_clients"
        Me.bsR_clients.DataSource = Me.dsConclusions
        '
        'txtClient_name
        '
        Me.txtClient_name.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.txtClient_name.CausesValidation = false
        Me.txtClient_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_name", true))
        Me.txtClient_name.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtClient_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtClient_name.Location = New System.Drawing.Point(431, 33)
        Me.txtClient_name.Name = "txtClient_name"
        Me.txtClient_name.ReadOnly = true
        Me.txtClient_name.Size = New System.Drawing.Size(460, 22)
        Me.txtClient_name.TabIndex = 72
        Me.txtClient_name.TabStop = false
        '
        'Client_innMaskedTextBox
        '
        Me.Client_innMaskedTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Client_innMaskedTextBox.CausesValidation = false
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_inn", true))
        Me.Client_innMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Client_innMaskedTextBox.Location = New System.Drawing.Point(300, 33)
        Me.Client_innMaskedTextBox.Mask = "00000000000000"
        Me.Client_innMaskedTextBox.Name = "Client_innMaskedTextBox"
        Me.Client_innMaskedTextBox.Size = New System.Drawing.Size(125, 22)
        Me.Client_innMaskedTextBox.TabIndex = 3
        '
        'Doc_numberMaskTextBox
        '
        Me.Doc_numberMaskTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Doc_numberMaskTextBox.CausesValidation = false
        Me.Doc_numberMaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "doc_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Doc_numberMaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Doc_numberMaskTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Doc_numberMaskTextBox.Location = New System.Drawing.Point(27, 32)
        Me.Doc_numberMaskTextBox.Mask = "00000"
        Me.Doc_numberMaskTextBox.Name = "Doc_numberMaskTextBox"
        Me.Doc_numberMaskTextBox.Size = New System.Drawing.Size(52, 22)
        Me.Doc_numberMaskTextBox.TabIndex = 1
        '
        'Doc_dateDateTimePicker
        '
        Me.Doc_dateDateTimePicker.CausesValidation = false
        Me.Doc_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsDocs_Conclusions_Examination, "doc_date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Doc_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Doc_dateDateTimePicker.Location = New System.Drawing.Point(100, 32)
        Me.Doc_dateDateTimePicker.Name = "Doc_dateDateTimePicker"
        Me.Doc_dateDateTimePicker.Size = New System.Drawing.Size(164, 22)
        Me.Doc_dateDateTimePicker.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.btnSearch.CausesValidation = false
        Me.btnSearch.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSearch.Location = New System.Drawing.Point(8, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(138, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Найти"
        Me.btnSearch.UseVisualStyleBackColor = false
        '
        'bnDocs_Conclusions_Examination
        '
        Me.bnDocs_Conclusions_Examination.AddNewItem = Nothing
        Me.bnDocs_Conclusions_Examination.BindingSource = Me.bsDocs_Conclusions_Examination
        Me.bnDocs_Conclusions_Examination.CountItem = Me.BindingNavigatorCountItem
        Me.bnDocs_Conclusions_Examination.DeleteItem = Nothing
        Me.bnDocs_Conclusions_Examination.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Docs_Conclusions_ImportBindingNavigatorSaveItem, Me.btnCopyTo, Me.btnPrints, Me.btnPreviews})
        Me.bnDocs_Conclusions_Examination.Location = New System.Drawing.Point(0, 191)
        Me.bnDocs_Conclusions_Examination.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnDocs_Conclusions_Examination.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnDocs_Conclusions_Examination.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnDocs_Conclusions_Examination.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnDocs_Conclusions_Examination.Name = "bnDocs_Conclusions_Examination"
        Me.bnDocs_Conclusions_Examination.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnDocs_Conclusions_Examination.Size = New System.Drawing.Size(894, 25)
        Me.bnDocs_Conclusions_Examination.TabIndex = 1
        Me.bnDocs_Conclusions_Examination.Text = "BindingNavigator1"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel1.Text = "Заключения"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true
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
        Me.BindingNavigatorPositionItem.AutoSize = false
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.Window
        Me.BindingNavigatorPositionItem.CausesValidation = false
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
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true
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
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Новое заключение на ВВОЗ"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить заключение"
        '
        'Docs_Conclusions_ImportBindingNavigatorSaveItem
        '
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Image = CType(resources.GetObject("Docs_Conclusions_ImportBindingNavigatorSaveItem.Image"),System.Drawing.Image)
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Name = "Docs_Conclusions_ImportBindingNavigatorSaveItem"
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Docs_Conclusions_ImportBindingNavigatorSaveItem.Text = "Сохранить"
        '
        'btnCopyTo
        '
        Me.btnCopyTo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopyTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopyTo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopyToExamination, Me.btnCopyToImport, Me.btnCopyToExport})
        Me.btnCopyTo.Image = CType(resources.GetObject("btnCopyTo.Image"),System.Drawing.Image)
        Me.btnCopyTo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopyTo.Name = "btnCopyTo"
        Me.btnCopyTo.Size = New System.Drawing.Size(29, 22)
        Me.btnCopyTo.Text = " "
        '
        'btnCopyToExamination
        '
        Me.btnCopyToExamination.Name = "btnCopyToExamination"
        Me.btnCopyToExamination.Size = New System.Drawing.Size(268, 22)
        Me.btnCopyToExamination.Text = "Копировать в свидетельство"
        '
        'btnCopyToImport
        '
        Me.btnCopyToImport.Name = "btnCopyToImport"
        Me.btnCopyToImport.Size = New System.Drawing.Size(268, 22)
        Me.btnCopyToImport.Text = "Копировать в заключение (ВВОЗ)"
        '
        'btnCopyToExport
        '
        Me.btnCopyToExport.Name = "btnCopyToExport"
        Me.btnCopyToExport.Size = New System.Drawing.Size(268, 22)
        Me.btnCopyToExport.Text = "Копировать в заключение (ВЫВОЗ)"
        '
        'btnPrints
        '
        Me.btnPrints.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrints.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrintAdd})
        Me.btnPrints.Image = CType(resources.GetObject("btnPrints.Image"),System.Drawing.Image)
        Me.btnPrints.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrints.Name = "btnPrints"
        Me.btnPrints.Size = New System.Drawing.Size(29, 22)
        Me.btnPrints.Text = "Печать"
        '
        'btnPrintAdd
        '
        Me.btnPrintAdd.Name = "btnPrintAdd"
        Me.btnPrintAdd.Size = New System.Drawing.Size(222, 22)
        Me.btnPrintAdd.Text = "Свидетельство экспертизы"
        '
        'btnPreviews
        '
        Me.btnPreviews.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPreviews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreviews.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPreviewAdd})
        Me.btnPreviews.Image = CType(resources.GetObject("btnPreviews.Image"),System.Drawing.Image)
        Me.btnPreviews.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreviews.Name = "btnPreviews"
        Me.btnPreviews.Size = New System.Drawing.Size(29, 22)
        Me.btnPreviews.Text = "Предпросмотр"
        '
        'btnPreviewAdd
        '
        Me.btnPreviewAdd.Name = "btnPreviewAdd"
        Me.btnPreviewAdd.Size = New System.Drawing.Size(222, 22)
        Me.btnPreviewAdd.Text = "Свидетельство экспертизы"
        '
        'pnlDiseases
        '
        Me.pnlDiseases.CausesValidation = false
        Me.pnlDiseases.Controls.Add(Me.dgvDocs_Conclusions_NotKarantin)
        Me.pnlDiseases.Controls.Add(Me.dgvDocs_Conclusions_Karantin)
        Me.pnlDiseases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDiseases.Location = New System.Drawing.Point(0, 0)
        Me.pnlDiseases.Name = "pnlDiseases"
        Me.pnlDiseases.Size = New System.Drawing.Size(894, 136)
        Me.pnlDiseases.TabIndex = 2
        '
        'dgvDocs_Conclusions_NotKarantin
        '
        Me.dgvDocs_Conclusions_NotKarantin.AutoGenerateColumns = false
        Me.dgvDocs_Conclusions_NotKarantin.BackgroundColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Conclusions_NotKarantin.CausesValidation = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocs_Conclusions_NotKarantin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDocs_Conclusions_NotKarantin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_notkarantin_object_title, Me.Column_state_notkar, Me.DocidDataGridViewTextBoxColumn3, Me.ProductioncountryDataGridViewTextBoxColumn2, Me.GoodtitleDataGridViewTextBoxColumn2})
        Me.dgvDocs_Conclusions_NotKarantin.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Global.Inspector.My.MySettings.Default, "backgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Conclusions_NotKarantin.DataSource = Me.bsDocs_Conclusions_NotKarantin
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocs_Conclusions_NotKarantin.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDocs_Conclusions_NotKarantin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocs_Conclusions_NotKarantin.Location = New System.Drawing.Point(0, 0)
        Me.dgvDocs_Conclusions_NotKarantin.Name = "dgvDocs_Conclusions_NotKarantin"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocs_Conclusions_NotKarantin.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDocs_Conclusions_NotKarantin.RowHeadersWidth = 20
        Me.dgvDocs_Conclusions_NotKarantin.Size = New System.Drawing.Size(394, 136)
        Me.dgvDocs_Conclusions_NotKarantin.TabIndex = 41
        '
        'Column_notkarantin_object_title
        '
        Me.Column_notkarantin_object_title.DataPropertyName = "object_title"
        Me.Column_notkarantin_object_title.DisplayStyleForCurrentCellOnly = true
        Me.Column_notkarantin_object_title.HeaderText = "Некарантинные"
        Me.Column_notkarantin_object_title.Name = "Column_notkarantin_object_title"
        Me.Column_notkarantin_object_title.Width = 210
        '
        'Column_state_notkar
        '
        Me.Column_state_notkar.DataPropertyName = "state"
        Me.Column_state_notkar.DisplayStyleForCurrentCellOnly = true
        Me.Column_state_notkar.HeaderText = "Состояние"
        Me.Column_state_notkar.Name = "Column_state_notkar"
        Me.Column_state_notkar.Width = 145
        '
        'DocidDataGridViewTextBoxColumn3
        '
        Me.DocidDataGridViewTextBoxColumn3.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn3.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn3.Name = "DocidDataGridViewTextBoxColumn3"
        Me.DocidDataGridViewTextBoxColumn3.Visible = false
        '
        'ProductioncountryDataGridViewTextBoxColumn2
        '
        Me.ProductioncountryDataGridViewTextBoxColumn2.DataPropertyName = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn2.HeaderText = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn2.Name = "ProductioncountryDataGridViewTextBoxColumn2"
        Me.ProductioncountryDataGridViewTextBoxColumn2.Visible = false
        '
        'GoodtitleDataGridViewTextBoxColumn2
        '
        Me.GoodtitleDataGridViewTextBoxColumn2.DataPropertyName = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn2.HeaderText = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn2.Name = "GoodtitleDataGridViewTextBoxColumn2"
        Me.GoodtitleDataGridViewTextBoxColumn2.Visible = false
        '
        'bsDocs_Conclusions_NotKarantin
        '
        Me.bsDocs_Conclusions_NotKarantin.DataMember = "FK_Docs_Conclusions_NotKarantin_Docs_Acts_Goods"
        Me.bsDocs_Conclusions_NotKarantin.DataSource = Me.bsDocs_Acts_Goods
        '
        'bsDocs_Acts_Goods
        '
        Me.bsDocs_Acts_Goods.DataMember = "FK_Docs_Acts_Goods_Docs_Conclusions_Examination"
        Me.bsDocs_Acts_Goods.DataSource = Me.bsDocs_Conclusions_Examination
        '
        'dgvDocs_Conclusions_Karantin
        '
        Me.dgvDocs_Conclusions_Karantin.AutoGenerateColumns = false
        Me.dgvDocs_Conclusions_Karantin.BackgroundColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Conclusions_Karantin.CausesValidation = false
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocs_Conclusions_Karantin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDocs_Conclusions_Karantin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_karantin_object_title, Me.count, Me.Column_karantin_count_unit, Me.Column_state, Me.DocidDataGridViewTextBoxColumn2, Me.ProductioncountryDataGridViewTextBoxColumn1, Me.GoodtitleDataGridViewTextBoxColumn1})
        Me.dgvDocs_Conclusions_Karantin.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Global.Inspector.My.MySettings.Default, "backgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Conclusions_Karantin.DataSource = Me.bsDocs_Conclusions_Karantin
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocs_Conclusions_Karantin.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDocs_Conclusions_Karantin.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvDocs_Conclusions_Karantin.Location = New System.Drawing.Point(394, 0)
        Me.dgvDocs_Conclusions_Karantin.Name = "dgvDocs_Conclusions_Karantin"
        Me.dgvDocs_Conclusions_Karantin.RowHeadersWidth = 20
        Me.dgvDocs_Conclusions_Karantin.Size = New System.Drawing.Size(500, 136)
        Me.dgvDocs_Conclusions_Karantin.TabIndex = 42
        '
        'Column_karantin_object_title
        '
        Me.Column_karantin_object_title.DataPropertyName = "object_title"
        Me.Column_karantin_object_title.DisplayStyleForCurrentCellOnly = true
        Me.Column_karantin_object_title.HeaderText = "Карантинные"
        Me.Column_karantin_object_title.Name = "Column_karantin_object_title"
        Me.Column_karantin_object_title.Width = 210
        '
        'count
        '
        Me.count.DataPropertyName = "count"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.count.DefaultCellStyle = DataGridViewCellStyle5
        Me.count.HeaderText = "Кол"
        Me.count.Name = "count"
        Me.count.Width = 60
        '
        'Column_karantin_count_unit
        '
        Me.Column_karantin_count_unit.DataPropertyName = "count_unit"
        Me.Column_karantin_count_unit.DisplayStyleForCurrentCellOnly = true
        Me.Column_karantin_count_unit.HeaderText = "Ед"
        Me.Column_karantin_count_unit.Items.AddRange(New Object() {"шт", "шт/кг", "шт/100 г"})
        Me.Column_karantin_count_unit.Name = "Column_karantin_count_unit"
        Me.Column_karantin_count_unit.Width = 50
        '
        'Column_state
        '
        Me.Column_state.DataPropertyName = "state"
        Me.Column_state.DisplayStyleForCurrentCellOnly = true
        Me.Column_state.HeaderText = "Состояние"
        Me.Column_state.Name = "Column_state"
        Me.Column_state.Width = 140
        '
        'DocidDataGridViewTextBoxColumn2
        '
        Me.DocidDataGridViewTextBoxColumn2.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.Name = "DocidDataGridViewTextBoxColumn2"
        Me.DocidDataGridViewTextBoxColumn2.Visible = false
        '
        'ProductioncountryDataGridViewTextBoxColumn1
        '
        Me.ProductioncountryDataGridViewTextBoxColumn1.DataPropertyName = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn1.HeaderText = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn1.Name = "ProductioncountryDataGridViewTextBoxColumn1"
        Me.ProductioncountryDataGridViewTextBoxColumn1.Visible = false
        '
        'GoodtitleDataGridViewTextBoxColumn1
        '
        Me.GoodtitleDataGridViewTextBoxColumn1.DataPropertyName = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn1.HeaderText = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn1.Name = "GoodtitleDataGridViewTextBoxColumn1"
        Me.GoodtitleDataGridViewTextBoxColumn1.Visible = false
        '
        'bsDocs_Conclusions_Karantin
        '
        Me.bsDocs_Conclusions_Karantin.DataMember = "FK_Docs_Conclusions_Karantin_Docs_Acts_Goods"
        Me.bsDocs_Conclusions_Karantin.DataSource = Me.bsDocs_Acts_Goods
        '
        'dgvDocs_Acts_Goods
        '
        Me.dgvDocs_Acts_Goods.AllowUserToResizeRows = false
        Me.dgvDocs_Acts_Goods.AutoGenerateColumns = false
        Me.dgvDocs_Acts_Goods.BackgroundColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Acts_Goods.CausesValidation = false
        Me.dgvDocs_Acts_Goods.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_good_title, Me.Column_production_country, Me.places, Me.Column_places_unit, Me.weight, Me.Column_weight_unit, Me.samples_count, Me.DocidDataGridViewTextBoxColumn1, Me.GoodtitleDataGridViewTextBoxColumn, Me.ProductioncountryDataGridViewTextBoxColumn, Me.PlacesDataGridViewTextBoxColumn, Me.PlacesunitDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.WeightunitDataGridViewTextBoxColumn, Me.SamplescountDataGridViewTextBoxColumn})
        Me.dgvDocs_Acts_Goods.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Global.Inspector.My.MySettings.Default, "backgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Acts_Goods.DataSource = Me.bsDocs_Acts_Goods
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocs_Acts_Goods.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDocs_Acts_Goods.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocs_Acts_Goods.Location = New System.Drawing.Point(0, 0)
        Me.dgvDocs_Acts_Goods.Name = "dgvDocs_Acts_Goods"
        Me.dgvDocs_Acts_Goods.Size = New System.Drawing.Size(894, 203)
        Me.dgvDocs_Acts_Goods.TabIndex = 40
        '
        'Column_good_title
        '
        Me.Column_good_title.DataPropertyName = "good_title"
        Me.Column_good_title.DisplayStyleForCurrentCellOnly = true
        Me.Column_good_title.HeaderText = "Наименование"
        Me.Column_good_title.Name = "Column_good_title"
        Me.Column_good_title.Width = 200
        '
        'Column_production_country
        '
        Me.Column_production_country.DataPropertyName = "production_country"
        Me.Column_production_country.DisplayStyleForCurrentCellOnly = true
        Me.Column_production_country.HeaderText = "Происхождение"
        Me.Column_production_country.Name = "Column_production_country"
        Me.Column_production_country.Width = 200
        '
        'places
        '
        Me.places.DataPropertyName = "places"
        DataGridViewCellStyle7.Format = "N0"
        Me.places.DefaultCellStyle = DataGridViewCellStyle7
        Me.places.HeaderText = "Мест"
        Me.places.Name = "places"
        Me.places.Width = 50
        '
        'Column_places_unit
        '
        Me.Column_places_unit.DataPropertyName = "places_unit"
        Me.Column_places_unit.DisplayStyleForCurrentCellOnly = true
        Me.Column_places_unit.HeaderText = "Ед мест"
        Me.Column_places_unit.Name = "Column_places_unit"
        Me.Column_places_unit.Width = 120
        '
        'weight
        '
        Me.weight.DataPropertyName = "weight"
        DataGridViewCellStyle8.Format = "N4"
        Me.weight.DefaultCellStyle = DataGridViewCellStyle8
        Me.weight.HeaderText = "Вес"
        Me.weight.Name = "weight"
        Me.weight.Width = 80
        '
        'Column_weight_unit
        '
        Me.Column_weight_unit.DataPropertyName = "weight_unit"
        Me.Column_weight_unit.DisplayStyleForCurrentCellOnly = true
        Me.Column_weight_unit.HeaderText = "Ед веса"
        Me.Column_weight_unit.Name = "Column_weight_unit"
        Me.Column_weight_unit.Width = 120
        '
        'samples_count
        '
        Me.samples_count.DataPropertyName = "samples_count"
        DataGridViewCellStyle9.Format = "N0"
        Me.samples_count.DefaultCellStyle = DataGridViewCellStyle9
        Me.samples_count.HeaderText = "Образцы"
        Me.samples_count.Name = "samples_count"
        Me.samples_count.Width = 60
        '
        'DocidDataGridViewTextBoxColumn1
        '
        Me.DocidDataGridViewTextBoxColumn1.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.Name = "DocidDataGridViewTextBoxColumn1"
        Me.DocidDataGridViewTextBoxColumn1.Visible = false
        '
        'GoodtitleDataGridViewTextBoxColumn
        '
        Me.GoodtitleDataGridViewTextBoxColumn.DataPropertyName = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn.HeaderText = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn.Name = "GoodtitleDataGridViewTextBoxColumn"
        Me.GoodtitleDataGridViewTextBoxColumn.Visible = false
        '
        'ProductioncountryDataGridViewTextBoxColumn
        '
        Me.ProductioncountryDataGridViewTextBoxColumn.DataPropertyName = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn.HeaderText = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn.Name = "ProductioncountryDataGridViewTextBoxColumn"
        Me.ProductioncountryDataGridViewTextBoxColumn.Visible = false
        '
        'PlacesDataGridViewTextBoxColumn
        '
        Me.PlacesDataGridViewTextBoxColumn.DataPropertyName = "places"
        Me.PlacesDataGridViewTextBoxColumn.HeaderText = "places"
        Me.PlacesDataGridViewTextBoxColumn.Name = "PlacesDataGridViewTextBoxColumn"
        Me.PlacesDataGridViewTextBoxColumn.Visible = false
        '
        'PlacesunitDataGridViewTextBoxColumn
        '
        Me.PlacesunitDataGridViewTextBoxColumn.DataPropertyName = "places_unit"
        Me.PlacesunitDataGridViewTextBoxColumn.HeaderText = "places_unit"
        Me.PlacesunitDataGridViewTextBoxColumn.Name = "PlacesunitDataGridViewTextBoxColumn"
        Me.PlacesunitDataGridViewTextBoxColumn.Visible = false
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.Visible = false
        '
        'WeightunitDataGridViewTextBoxColumn
        '
        Me.WeightunitDataGridViewTextBoxColumn.DataPropertyName = "weight_unit"
        Me.WeightunitDataGridViewTextBoxColumn.HeaderText = "weight_unit"
        Me.WeightunitDataGridViewTextBoxColumn.Name = "WeightunitDataGridViewTextBoxColumn"
        Me.WeightunitDataGridViewTextBoxColumn.Visible = false
        '
        'SamplescountDataGridViewTextBoxColumn
        '
        Me.SamplescountDataGridViewTextBoxColumn.DataPropertyName = "samples_count"
        Me.SamplescountDataGridViewTextBoxColumn.HeaderText = "samples_count"
        Me.SamplescountDataGridViewTextBoxColumn.Name = "SamplescountDataGridViewTextBoxColumn"
        Me.SamplescountDataGridViewTextBoxColumn.Visible = false
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlTitle.CausesValidation = false
        Me.pnlTitle.Controls.Add(Me.lblFactAddress)
        Me.pnlTitle.Controls.Add(Me.txtFactAddress)
        Me.pnlTitle.Controls.Add(Me.btnSearch)
        Me.pnlTitle.Controls.Add(Me.txtClient_name)
        Me.pnlTitle.Controls.Add(Me.Doc_dateDateTimePicker)
        Me.pnlTitle.Controls.Add(Me.Doc_dateLabel)
        Me.pnlTitle.Controls.Add(Me.Client_innLabel)
        Me.pnlTitle.Controls.Add(Me.Doc_numberLabel)
        Me.pnlTitle.Controls.Add(Me.Doc_numberMaskTextBox)
        Me.pnlTitle.Controls.Add(Me.Client_innMaskedTextBox)
        Me.pnlTitle.Controls.Add(Me.txtClient_address)
        Me.pnlTitle.Controls.Add(Me.lblAddress)
        Me.pnlTitle.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(894, 106)
        Me.pnlTitle.TabIndex = 6
        '
        'lblFactAddress
        '
        Me.lblFactAddress.AutoSize = true
        Me.lblFactAddress.CausesValidation = false
        Me.lblFactAddress.Location = New System.Drawing.Point(5, 83)
        Me.lblFactAddress.Name = "lblFactAddress"
        Me.lblFactAddress.Size = New System.Drawing.Size(71, 13)
        Me.lblFactAddress.TabIndex = 76
        Me.lblFactAddress.Text = "Факт. адрес"
        '
        'txtFactAddress
        '
        Me.txtFactAddress.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtFactAddress.CausesValidation = false
        Me.txtFactAddress.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFactAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Examination, "fact_address", true))
        Me.txtFactAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFactAddress.Location = New System.Drawing.Point(82, 78)
        Me.txtFactAddress.MaxLength = 100
        Me.txtFactAddress.Multiline = true
        Me.txtFactAddress.Name = "txtFactAddress"
        Me.txtFactAddress.Size = New System.Drawing.Size(809, 22)
        Me.txtFactAddress.TabIndex = 75
        '
        'DocidDataGridViewTextBoxColumn
        '
        Me.DocidDataGridViewTextBoxColumn.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.Name = "DocidDataGridViewTextBoxColumn"
        Me.DocidDataGridViewTextBoxColumn.ReadOnly = true
        Me.DocidDataGridViewTextBoxColumn.Visible = false
        '
        'taDocs_Acts_Goods
        '
        Me.taDocs_Acts_Goods.ClearBeforeFill = true
        '
        'taDocs_Conclusions_Karantin
        '
        Me.taDocs_Conclusions_Karantin.ClearBeforeFill = true
        '
        'taDocs_Conclusions_NotKarantin
        '
        Me.taDocs_Conclusions_NotKarantin.ClearBeforeFill = true
        '
        'taR_clients
        '
        Me.taR_clients.ClearBeforeFill = true
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlSearch.CausesValidation = false
        Me.pnlSearch.Controls.Add(Me.lblHighDate)
        Me.pnlSearch.Controls.Add(Me.Doc_date_highDateTimePicker)
        Me.pnlSearch.Controls.Add(Me.lblCountryProduction)
        Me.pnlSearch.Controls.Add(Me.cbProduction)
        Me.pnlSearch.Controls.Add(Me.lblCountryFrom)
        Me.pnlSearch.Controls.Add(Me.lblProduction)
        Me.pnlSearch.Controls.Add(Me.cbCountryProduction)
        Me.pnlSearch.Controls.Add(Me.cbCountryFrom)
        Me.pnlSearch.Controls.Add(Me.cbKarantin)
        Me.pnlSearch.Controls.Add(Me.lblKarantin)
        Me.pnlSearch.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 106)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(894, 85)
        Me.pnlSearch.TabIndex = 87
        Me.pnlSearch.Visible = false
        '
        'splitDiseasesAndMain
        '
        Me.splitDiseasesAndMain.CausesValidation = false
        Me.splitDiseasesAndMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitDiseasesAndMain.Location = New System.Drawing.Point(0, 0)
        Me.splitDiseasesAndMain.Name = "splitDiseasesAndMain"
        Me.splitDiseasesAndMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitDiseasesAndMain.Panel1
        '
        Me.splitDiseasesAndMain.Panel1.CausesValidation = false
        Me.splitDiseasesAndMain.Panel1.Controls.Add(Me.pnlDiseases)
        Me.splitDiseasesAndMain.Panel1MinSize = 20
        '
        'splitDiseasesAndMain.Panel2
        '
        Me.splitDiseasesAndMain.Panel2.CausesValidation = false
        Me.splitDiseasesAndMain.Panel2.Controls.Add(Me.pnlMain)
        Me.splitDiseasesAndMain.Panel2MinSize = 115
        Me.splitDiseasesAndMain.Size = New System.Drawing.Size(894, 352)
        Me.splitDiseasesAndMain.SplitterDistance = 136
        Me.splitDiseasesAndMain.TabIndex = 88
        '
        'splitAll
        '
        Me.splitAll.CausesValidation = false
        Me.splitAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitAll.Location = New System.Drawing.Point(0, 216)
        Me.splitAll.Name = "splitAll"
        Me.splitAll.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitAll.Panel1
        '
        Me.splitAll.Panel1.CausesValidation = false
        Me.splitAll.Panel1.Controls.Add(Me.dgvDocs_Acts_Goods)
        '
        'splitAll.Panel2
        '
        Me.splitAll.Panel2.CausesValidation = false
        Me.splitAll.Panel2.Controls.Add(Me.splitDiseasesAndMain)
        Me.splitAll.Size = New System.Drawing.Size(894, 559)
        Me.splitAll.SplitterDistance = 203
        Me.splitAll.TabIndex = 89
        '
        'taDocs_Conclusions_Examination
        '
        Me.taDocs_Conclusions_Examination.ClearBeforeFill = true
        '
        'frmDocConclusionsExamination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.CausesValidation = false
        Me.ClientSize = New System.Drawing.Size(894, 775)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.splitAll)
        Me.Controls.Add(Me.bnDocs_Conclusions_Examination)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlTitle)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = true
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.Name = "frmDocConclusionsExamination"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "СВИДЕТЕЛЬСТВО карантинной экспертизы"
        Me.pnlMain.ResumeLayout(false)
        Me.pnlMain.PerformLayout
        CType(Me.bsDocs_Conclusions_Examination,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dsConclusions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bsR_clients,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bnDocs_Conclusions_Examination,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnDocs_Conclusions_Examination.ResumeLayout(false)
        Me.bnDocs_Conclusions_Examination.PerformLayout
        Me.pnlDiseases.ResumeLayout(false)
        CType(Me.dgvDocs_Conclusions_NotKarantin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bsDocs_Conclusions_NotKarantin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bsDocs_Acts_Goods,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvDocs_Conclusions_Karantin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bsDocs_Conclusions_Karantin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvDocs_Acts_Goods,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlTitle.ResumeLayout(false)
        Me.pnlTitle.PerformLayout
        Me.pnlSearch.ResumeLayout(false)
        Me.pnlSearch.PerformLayout
        Me.splitDiseasesAndMain.Panel1.ResumeLayout(false)
        Me.splitDiseasesAndMain.Panel2.ResumeLayout(false)
        Me.splitDiseasesAndMain.ResumeLayout(false)
        Me.splitAll.Panel1.ResumeLayout(false)
        Me.splitAll.Panel2.ResumeLayout(false)
        Me.splitAll.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents dsConclusions As Inspector.Docs_Conclusions
    Friend WithEvents bnDocs_Conclusions_Examination As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Docs_Conclusions_ImportBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doc_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Transport_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bill_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sert_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sert_fromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtTargetOrSource As System.Windows.Forms.TextBox
    Friend WithEvents pnlDiseases As System.Windows.Forms.Panel
    Friend WithEvents bsDocs_Acts_Goods As System.Windows.Forms.BindingSource
    Friend WithEvents taDocs_Acts_Goods As Inspector.Docs_ConclusionsTableAdapters.Docs_Acts_GoodsTableAdapter
    Friend WithEvents bsDocs_Conclusions_Karantin As System.Windows.Forms.BindingSource
    Friend WithEvents taDocs_Conclusions_Karantin As Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_KarantinTableAdapter
    Friend WithEvents bsDocs_Conclusions_NotKarantin As System.Windows.Forms.BindingSource
    Friend WithEvents taDocs_Conclusions_NotKarantin As Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_NotKarantinTableAdapter
    Friend WithEvents Doc_numberMaskTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dgvDocs_Acts_Goods As Inspector.dgvWithoutEnter
    'Inspector.dgvWithoutEnter
    'Inspector.dgvWithoutEnter
    Friend WithEvents Client_innMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Transport_typeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bill_typeComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents bsR_clients As System.Windows.Forms.BindingSource
    Friend WithEvents taR_clients As Inspector.Docs_ConclusionsTableAdapters.R_clientsTableAdapter
    Friend WithEvents txtClient_address As System.Windows.Forms.TextBox
    Friend WithEvents txtClient_name As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DocidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbCountryProduction As System.Windows.Forms.ComboBox
    Friend WithEvents lblProduction As System.Windows.Forms.Label
    Friend WithEvents cbProduction As System.Windows.Forms.ComboBox
    Friend WithEvents lblHighDate As System.Windows.Forms.Label
    Friend WithEvents Doc_date_highDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCountryProduction As System.Windows.Forms.Label
    Friend WithEvents lblKarantin As System.Windows.Forms.Label
    Friend WithEvents cbKarantin As System.Windows.Forms.ComboBox
    Friend WithEvents lblCountryFrom As System.Windows.Forms.Label
    Friend WithEvents cbCountryFrom As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents Doc_numberLabel As System.Windows.Forms.Label
    Friend WithEvents Client_innLabel As System.Windows.Forms.Label
    Friend WithEvents Doc_dateLabel As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Transport_typeLabel As System.Windows.Forms.Label
    Friend WithEvents Bill_typeLabel As System.Windows.Forms.Label
    Friend WithEvents dgvDocs_Conclusions_Karantin As Inspector.dgvWithoutEnter
    Friend WithEvents dgvDocs_Conclusions_NotKarantin As Inspector.dgvWithoutEnter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnCopyTo As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnCopyToExamination As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPreviews As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPrints As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPreviewAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bill_date As System.Windows.Forms.TextBox
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents splitDiseasesAndMain As System.Windows.Forms.SplitContainer
    Friend WithEvents splitAll As System.Windows.Forms.SplitContainer
    Friend WithEvents lblFactAddress As System.Windows.Forms.Label
    Friend WithEvents txtFactAddress As System.Windows.Forms.TextBox
    Friend WithEvents taDocs_Conclusions_Examination As Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_ExaminationTableAdapter
    Friend WithEvents bsDocs_Conclusions_Examination As System.Windows.Forms.BindingSource
    Friend WithEvents Column_good_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column_production_country As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents places As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_places_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents weight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_weight_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents samples_count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GoodtitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductioncountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacesunitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightunitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SamplescountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtKarantinSertNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKarantinSertDate As System.Windows.Forms.TextBox
    Friend WithEvents btnCopyToImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopyToExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMaterialFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtToDocument As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Column_notkarantin_object_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column_state_notkar As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductioncountryDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GoodtitleDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_karantin_object_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_karantin_count_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column_state As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductioncountryDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GoodtitleDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbDocUser As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbTargetOrSourceDir As ComboBox
End Class
