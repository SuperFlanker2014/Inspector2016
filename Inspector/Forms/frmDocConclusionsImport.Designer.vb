<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocConclusionsImport
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
        Dim SenderLabel As System.Windows.Forms.Label
        Dim Starting_pointLabel As System.Windows.Forms.Label
        Dim Destination_pointLabel As System.Windows.Forms.Label
        Dim Grounds_documentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocConclusionsImport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MarkLabel = New System.Windows.Forms.Label
        Me.ArrivedLabel = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.Doc_numberLabel = New System.Windows.Forms.Label
        Me.Client_innLabel = New System.Windows.Forms.Label
        Me.Doc_dateLabel = New System.Windows.Forms.Label
        Me.Arrived_rayonLabel = New System.Windows.Forms.Label
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.cbFoundation = New System.Windows.Forms.ComboBox
        Me.bsDocs_Conclusions_Import = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsConclusions = New Inspector.Docs_Conclusions
        Me.Destination_pointTextBox = New System.Windows.Forms.TextBox
        Me.Starting_pointTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.cbVerdict = New System.Windows.Forms.ComboBox
        Me.Arrived_rayonComboBox = New System.Windows.Forms.ComboBox
        Me.ArrivedComboBox = New System.Windows.Forms.ComboBox
        Me.MarkComboBox = New System.Windows.Forms.ComboBox
        Me.SenderTextBox = New System.Windows.Forms.TextBox
        Me.lblCountryFrom = New System.Windows.Forms.Label
        Me.cbCountryFrom = New System.Windows.Forms.ComboBox
        Me.lblKarantin = New System.Windows.Forms.Label
        Me.cbKarantin = New System.Windows.Forms.ComboBox
        Me.lblCountryProduction = New System.Windows.Forms.Label
        Me.cbCountryProduction = New System.Windows.Forms.ComboBox
        Me.lblProduction = New System.Windows.Forms.Label
        Me.cbProduction = New System.Windows.Forms.ComboBox
        Me.lblHighDate = New System.Windows.Forms.Label
        Me.Doc_date_highDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.txtClient_address = New System.Windows.Forms.TextBox
        Me.bsR_clients = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtClient_name = New System.Windows.Forms.TextBox
        Me.Client_innMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Doc_numberMaskTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Doc_dateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New System.Windows.Forms.Button
        Me.bnDocs_Conclusions_Import = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.btnCopyTo = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnCopytoImport = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCopyToExport = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCopyToExamination = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCopyAndPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrints = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrintAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPreviews = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnPreview = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPreviewAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlDiseases = New System.Windows.Forms.Panel
        Me.dgvDocs_Conclusions_NotKarantin = New Inspector.dgvWithoutEnter
        Me.Column_notkarantin_object_title = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column_state_notkar = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DocidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GoodtitleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductioncountryDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsDocs_Conclusions_NotKarantin = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsDocs_Acts_Goods = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDocs_Conclusions_Karantin = New Inspector.dgvWithoutEnter
        Me.Column_karantin_object_title = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.count = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column_karantin_count_unit = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column_state = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DocidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GoodtitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductioncountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsDocs_Conclusions_Karantin = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDocs_Acts_Goods = New Inspector.dgvWithoutEnter
        Me.Column_good_title = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column_production_country = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.places = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column_places_unit = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.weight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column_weight_unit = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.samples_count = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblFactAddress = New System.Windows.Forms.Label
        Me.txtFactAddress = New System.Windows.Forms.TextBox
        Me.DocidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.taDocs_Conclusions_Import = New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_ImportTableAdapter
        Me.taDocs_Acts_Goods = New Inspector.Docs_ConclusionsTableAdapters.Docs_Acts_GoodsTableAdapter
        Me.taDocs_Conclusions_Karantin = New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_KarantinTableAdapter
        Me.taDocs_Conclusions_NotKarantin = New Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_NotKarantinTableAdapter
        Me.taR_clients = New Inspector.Docs_ConclusionsTableAdapters.R_clientsTableAdapter
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.splitDiseasesAndMain = New System.Windows.Forms.SplitContainer
        Me.splitAll = New System.Windows.Forms.SplitContainer
        Me.tipInspection = New System.Windows.Forms.ToolTip(Me.components)
        SenderLabel = New System.Windows.Forms.Label
        Starting_pointLabel = New System.Windows.Forms.Label
        Destination_pointLabel = New System.Windows.Forms.Label
        Grounds_documentLabel = New System.Windows.Forms.Label
        Me.pnlMain.SuspendLayout()
        CType(Me.bsDocs_Conclusions_Import, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsConclusions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsR_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnDocs_Conclusions_Import, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnDocs_Conclusions_Import.SuspendLayout()
        Me.pnlDiseases.SuspendLayout()
        CType(Me.dgvDocs_Conclusions_NotKarantin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDocs_Conclusions_NotKarantin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDocs_Conclusions_Karantin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDocs_Conclusions_Karantin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.splitDiseasesAndMain.Panel1.SuspendLayout()
        Me.splitDiseasesAndMain.Panel2.SuspendLayout()
        Me.splitDiseasesAndMain.SuspendLayout()
        Me.splitAll.Panel1.SuspendLayout()
        Me.splitAll.Panel2.SuspendLayout()
        Me.splitAll.SuspendLayout()
        Me.SuspendLayout()
        '
        'SenderLabel
        '
        SenderLabel.AutoSize = True
        SenderLabel.CausesValidation = False
        SenderLabel.Location = New System.Drawing.Point(4, 62)
        SenderLabel.Name = "SenderLabel"
        SenderLabel.Size = New System.Drawing.Size(73, 13)
        SenderLabel.TabIndex = 38
        SenderLabel.Text = "Отправитель"
        '
        'Starting_pointLabel
        '
        Starting_pointLabel.AutoSize = True
        Starting_pointLabel.Location = New System.Drawing.Point(4, 118)
        Starting_pointLabel.Name = "Starting_pointLabel"
        Starting_pointLabel.Size = New System.Drawing.Size(105, 13)
        Starting_pointLabel.TabIndex = 71
        Starting_pointLabel.Text = "Пункт отправления"
        '
        'Destination_pointLabel
        '
        Destination_pointLabel.AutoSize = True
        Destination_pointLabel.Location = New System.Drawing.Point(4, 140)
        Destination_pointLabel.Name = "Destination_pointLabel"
        Destination_pointLabel.Size = New System.Drawing.Size(99, 13)
        Destination_pointLabel.TabIndex = 72
        Destination_pointLabel.Text = "Пункт назначения"
        '
        'Grounds_documentLabel
        '
        Grounds_documentLabel.AutoSize = True
        Grounds_documentLabel.Location = New System.Drawing.Point(4, 167)
        Grounds_documentLabel.Name = "Grounds_documentLabel"
        Grounds_documentLabel.Size = New System.Drawing.Size(118, 13)
        Grounds_documentLabel.TabIndex = 73
        Grounds_documentLabel.Text = "Выдано на основании"
        '
        'MarkLabel
        '
        Me.MarkLabel.AutoSize = True
        Me.MarkLabel.CausesValidation = False
        Me.MarkLabel.Location = New System.Drawing.Point(700, 32)
        Me.MarkLabel.Name = "MarkLabel"
        Me.MarkLabel.Size = New System.Drawing.Size(34, 13)
        Me.MarkLabel.TabIndex = 8
        Me.MarkLabel.Text = "Марк"
        '
        'ArrivedLabel
        '
        Me.ArrivedLabel.AutoSize = True
        Me.ArrivedLabel.CausesValidation = False
        Me.ArrivedLabel.Location = New System.Drawing.Point(4, 32)
        Me.ArrivedLabel.Name = "ArrivedLabel"
        Me.ArrivedLabel.Size = New System.Drawing.Size(47, 13)
        Me.ArrivedLabel.TabIndex = 28
        Me.ArrivedLabel.Text = "Прибыл"
        Me.ArrivedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Client_innLabel.Location = New System.Drawing.Point(263, 35)
        Me.Client_innLabel.Name = "Client_innLabel"
        Me.Client_innLabel.Size = New System.Drawing.Size(31, 13)
        Me.Client_innLabel.TabIndex = 4
        Me.Client_innLabel.Text = "ИНН"
        '
        'Doc_dateLabel
        '
        Me.Doc_dateLabel.AutoSize = True
        Me.Doc_dateLabel.CausesValidation = False
        Me.Doc_dateLabel.Location = New System.Drawing.Point(82, 35)
        Me.Doc_dateLabel.Name = "Doc_dateLabel"
        Me.Doc_dateLabel.Size = New System.Drawing.Size(18, 13)
        Me.Doc_dateLabel.TabIndex = 6
        Me.Doc_dateLabel.Text = "от"
        '
        'Arrived_rayonLabel
        '
        Me.Arrived_rayonLabel.AutoSize = True
        Me.Arrived_rayonLabel.CausesValidation = False
        Me.Arrived_rayonLabel.Location = New System.Drawing.Point(362, 32)
        Me.Arrived_rayonLabel.Name = "Arrived_rayonLabel"
        Me.Arrived_rayonLabel.Size = New System.Drawing.Size(38, 13)
        Me.Arrived_rayonLabel.TabIndex = 30
        Me.Arrived_rayonLabel.Text = "Район"
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMain.CausesValidation = False
        Me.pnlMain.Controls.Add(Me.cbFoundation)
        Me.pnlMain.Controls.Add(Grounds_documentLabel)
        Me.pnlMain.Controls.Add(Destination_pointLabel)
        Me.pnlMain.Controls.Add(Me.Destination_pointTextBox)
        Me.pnlMain.Controls.Add(Starting_pointLabel)
        Me.pnlMain.Controls.Add(Me.Starting_pointTextBox)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Controls.Add(Me.txtRemark)
        Me.pnlMain.Controls.Add(Me.cbVerdict)
        Me.pnlMain.Controls.Add(Me.Arrived_rayonComboBox)
        Me.pnlMain.Controls.Add(Me.ArrivedComboBox)
        Me.pnlMain.Controls.Add(Me.MarkComboBox)
        Me.pnlMain.Controls.Add(Me.MarkLabel)
        Me.pnlMain.Controls.Add(Me.ArrivedLabel)
        Me.pnlMain.Controls.Add(Me.Arrived_rayonLabel)
        Me.pnlMain.Controls.Add(SenderLabel)
        Me.pnlMain.Controls.Add(Me.SenderTextBox)
        Me.pnlMain.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(894, 206)
        Me.pnlMain.TabIndex = 0
        '
        'cbFoundation
        '
        Me.cbFoundation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbFoundation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFoundation.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbFoundation.CausesValidation = False
        Me.cbFoundation.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbFoundation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "grounds_document", True))
        Me.cbFoundation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbFoundation.FormattingEnabled = True
        Me.cbFoundation.Items.AddRange(New Object() {"протокола визуального исследования", "свидетельства карантинной экспертизы"})
        Me.cbFoundation.Location = New System.Drawing.Point(128, 162)
        Me.cbFoundation.Name = "cbFoundation"
        Me.cbFoundation.Size = New System.Drawing.Size(761, 24)
        Me.cbFoundation.TabIndex = 74
        '
        'bsDocs_Conclusions_Import
        '
        Me.bsDocs_Conclusions_Import.DataMember = "Docs_Conclusions_Import"
        Me.bsDocs_Conclusions_Import.DataSource = Me.dsConclusions
        '
        'dsConclusions
        '
        Me.dsConclusions.DataSetName = "Docs_Conclusions_Import"
        Me.dsConclusions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Destination_pointTextBox
        '
        Me.Destination_pointTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Destination_pointTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "destination_point", True))
        Me.Destination_pointTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Destination_pointTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Destination_pointTextBox.Location = New System.Drawing.Point(128, 137)
        Me.Destination_pointTextBox.Name = "Destination_pointTextBox"
        Me.Destination_pointTextBox.Size = New System.Drawing.Size(761, 22)
        Me.Destination_pointTextBox.TabIndex = 73
        '
        'Starting_pointTextBox
        '
        Me.Starting_pointTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Starting_pointTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "starting_point", True))
        Me.Starting_pointTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Starting_pointTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Starting_pointTextBox.Location = New System.Drawing.Point(128, 115)
        Me.Starting_pointTextBox.Name = "Starting_pointTextBox"
        Me.Starting_pointTextBox.Size = New System.Drawing.Size(761, 22)
        Me.Starting_pointTextBox.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Заметки"
        '
        'txtRemark
        '
        Me.txtRemark.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtRemark.CausesValidation = False
        Me.txtRemark.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "remark", True))
        Me.txtRemark.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(70, 4)
        Me.txtRemark.MaxLength = 500
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(819, 22)
        Me.txtRemark.TabIndex = 0
        '
        'cbVerdict
        '
        Me.cbVerdict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbVerdict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVerdict.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbVerdict.CausesValidation = False
        Me.cbVerdict.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "verdict", True))
        Me.cbVerdict.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbVerdict.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbVerdict.FormattingEnabled = True
        Me.cbVerdict.Location = New System.Drawing.Point(6, 85)
        Me.cbVerdict.Name = "cbVerdict"
        Me.cbVerdict.Size = New System.Drawing.Size(883, 24)
        Me.cbVerdict.TabIndex = 24
        '
        'Arrived_rayonComboBox
        '
        Me.Arrived_rayonComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Arrived_rayonComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Arrived_rayonComboBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Arrived_rayonComboBox.CausesValidation = False
        Me.Arrived_rayonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsDocs_Conclusions_Import, "arrived_rayon", True))
        Me.Arrived_rayonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Arrived_rayonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Arrived_rayonComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Arrived_rayonComboBox.FormattingEnabled = True
        Me.Arrived_rayonComboBox.Location = New System.Drawing.Point(406, 27)
        Me.Arrived_rayonComboBox.Name = "Arrived_rayonComboBox"
        Me.Arrived_rayonComboBox.Size = New System.Drawing.Size(288, 24)
        Me.Arrived_rayonComboBox.TabIndex = 12
        '
        'ArrivedComboBox
        '
        Me.ArrivedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ArrivedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArrivedComboBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.ArrivedComboBox.CausesValidation = False
        Me.ArrivedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsDocs_Conclusions_Import, "arrived", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ArrivedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ArrivedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ArrivedComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ArrivedComboBox.FormattingEnabled = True
        Me.ArrivedComboBox.Location = New System.Drawing.Point(70, 27)
        Me.ArrivedComboBox.Name = "ArrivedComboBox"
        Me.ArrivedComboBox.Size = New System.Drawing.Size(286, 24)
        Me.ArrivedComboBox.TabIndex = 11
        '
        'MarkComboBox
        '
        Me.MarkComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.MarkComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MarkComboBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.MarkComboBox.CausesValidation = False
        Me.MarkComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsDocs_Conclusions_Import, "mark", True))
        Me.MarkComboBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MarkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MarkComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MarkComboBox.FormattingEnabled = True
        Me.MarkComboBox.Location = New System.Drawing.Point(740, 27)
        Me.MarkComboBox.Name = "MarkComboBox"
        Me.MarkComboBox.Size = New System.Drawing.Size(149, 24)
        Me.MarkComboBox.TabIndex = 3
        '
        'SenderTextBox
        '
        Me.SenderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SenderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SenderTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.SenderTextBox.CausesValidation = False
        Me.SenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "sender", True))
        Me.SenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SenderTextBox.Location = New System.Drawing.Point(83, 57)
        Me.SenderTextBox.MaxLength = 200
        Me.SenderTextBox.Name = "SenderTextBox"
        Me.SenderTextBox.Size = New System.Drawing.Size(806, 22)
        Me.SenderTextBox.TabIndex = 16
        '
        'lblCountryFrom
        '
        Me.lblCountryFrom.AutoSize = True
        Me.lblCountryFrom.CausesValidation = False
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
        Me.cbCountryFrom.CausesValidation = False
        Me.cbCountryFrom.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCountryFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCountryFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbCountryFrom.FormattingEnabled = True
        Me.cbCountryFrom.Location = New System.Drawing.Point(455, 49)
        Me.cbCountryFrom.Name = "cbCountryFrom"
        Me.cbCountryFrom.Size = New System.Drawing.Size(307, 24)
        Me.cbCountryFrom.TabIndex = 85
        '
        'lblKarantin
        '
        Me.lblKarantin.AutoSize = True
        Me.lblKarantin.CausesValidation = False
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
        Me.cbKarantin.CausesValidation = False
        Me.cbKarantin.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbKarantin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKarantin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbKarantin.FormattingEnabled = True
        Me.cbKarantin.Location = New System.Drawing.Point(100, 49)
        Me.cbKarantin.Name = "cbKarantin"
        Me.cbKarantin.Size = New System.Drawing.Size(258, 24)
        Me.cbKarantin.TabIndex = 83
        '
        'lblCountryProduction
        '
        Me.lblCountryProduction.AutoSize = True
        Me.lblCountryProduction.CausesValidation = False
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
        Me.cbCountryProduction.CausesValidation = False
        Me.cbCountryProduction.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCountryProduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCountryProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbCountryProduction.FormattingEnabled = True
        Me.cbCountryProduction.Location = New System.Drawing.Point(455, 25)
        Me.cbCountryProduction.Name = "cbCountryProduction"
        Me.cbCountryProduction.Size = New System.Drawing.Size(307, 24)
        Me.cbCountryProduction.TabIndex = 81
        '
        'lblProduction
        '
        Me.lblProduction.AutoSize = True
        Me.lblProduction.CausesValidation = False
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
        Me.cbProduction.CausesValidation = False
        Me.cbProduction.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbProduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbProduction.FormattingEnabled = True
        Me.cbProduction.Location = New System.Drawing.Point(100, 25)
        Me.cbProduction.Name = "cbProduction"
        Me.cbProduction.Size = New System.Drawing.Size(258, 24)
        Me.cbProduction.TabIndex = 79
        '
        'lblHighDate
        '
        Me.lblHighDate.AutoSize = True
        Me.lblHighDate.CausesValidation = False
        Me.lblHighDate.Location = New System.Drawing.Point(76, 3)
        Me.lblHighDate.Name = "lblHighDate"
        Me.lblHighDate.Size = New System.Drawing.Size(19, 13)
        Me.lblHighDate.TabIndex = 78
        Me.lblHighDate.Text = "до"
        '
        'Doc_date_highDateTimePicker
        '
        Me.Doc_date_highDateTimePicker.CausesValidation = False
        Me.Doc_date_highDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Doc_date_highDateTimePicker.Location = New System.Drawing.Point(100, -1)
        Me.Doc_date_highDateTimePicker.Name = "Doc_date_highDateTimePicker"
        Me.Doc_date_highDateTimePicker.Size = New System.Drawing.Size(164, 22)
        Me.Doc_date_highDateTimePicker.TabIndex = 77
        '
        'txtClient_address
        '
        Me.txtClient_address.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.txtClient_address.CausesValidation = False
        Me.txtClient_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_adress", True))
        Me.txtClient_address.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtClient_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtClient_address.Location = New System.Drawing.Point(82, 55)
        Me.txtClient_address.Name = "txtClient_address"
        Me.txtClient_address.ReadOnly = True
        Me.txtClient_address.Size = New System.Drawing.Size(809, 22)
        Me.txtClient_address.TabIndex = 73
        Me.txtClient_address.TabStop = False
        '
        'bsR_clients
        '
        Me.bsR_clients.DataMember = "R_clients"
        Me.bsR_clients.DataSource = Me.dsConclusions
        '
        'txtClient_name
        '
        Me.txtClient_name.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.txtClient_name.CausesValidation = False
        Me.txtClient_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_name", True))
        Me.txtClient_name.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtClient_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtClient_name.Location = New System.Drawing.Point(431, 33)
        Me.txtClient_name.Name = "txtClient_name"
        Me.txtClient_name.ReadOnly = True
        Me.txtClient_name.Size = New System.Drawing.Size(460, 22)
        Me.txtClient_name.TabIndex = 72
        Me.txtClient_name.TabStop = False
        '
        'Client_innMaskedTextBox
        '
        Me.Client_innMaskedTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Client_innMaskedTextBox.CausesValidation = False
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_inn", True))
        Me.Client_innMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Client_innMaskedTextBox.Location = New System.Drawing.Point(300, 33)
        Me.Client_innMaskedTextBox.Mask = "00000000000000"
        Me.Client_innMaskedTextBox.Name = "Client_innMaskedTextBox"
        Me.Client_innMaskedTextBox.Size = New System.Drawing.Size(125, 22)
        Me.Client_innMaskedTextBox.TabIndex = 3
        '
        'Doc_numberMaskTextBox
        '
        Me.Doc_numberMaskTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Doc_numberMaskTextBox.CausesValidation = False
        Me.Doc_numberMaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "doc_number", True))
        Me.Doc_numberMaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Doc_numberMaskTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Doc_numberMaskTextBox.Location = New System.Drawing.Point(27, 32)
        Me.Doc_numberMaskTextBox.Mask = "00000"
        Me.Doc_numberMaskTextBox.Name = "Doc_numberMaskTextBox"
        Me.Doc_numberMaskTextBox.Size = New System.Drawing.Size(52, 22)
        Me.Doc_numberMaskTextBox.TabIndex = 1
        '
        'Doc_dateDateTimePicker
        '
        Me.Doc_dateDateTimePicker.CausesValidation = False
        Me.Doc_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsDocs_Conclusions_Import, "doc_date", True))
        Me.Doc_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Doc_dateDateTimePicker.Location = New System.Drawing.Point(100, 32)
        Me.Doc_dateDateTimePicker.Name = "Doc_dateDateTimePicker"
        Me.Doc_dateDateTimePicker.Size = New System.Drawing.Size(164, 22)
        Me.Doc_dateDateTimePicker.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.btnSearch.CausesValidation = False
        Me.btnSearch.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSearch.Location = New System.Drawing.Point(8, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(138, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Найти"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'bnDocs_Conclusions_Import
        '
        Me.bnDocs_Conclusions_Import.AddNewItem = Nothing
        Me.bnDocs_Conclusions_Import.BindingSource = Me.bsDocs_Conclusions_Import
        Me.bnDocs_Conclusions_Import.CountItem = Me.BindingNavigatorCountItem
        Me.bnDocs_Conclusions_Import.DeleteItem = Nothing
        Me.bnDocs_Conclusions_Import.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Docs_Conclusions_ImportBindingNavigatorSaveItem, Me.btnCopyTo, Me.btnPrints, Me.btnPreviews})
        Me.bnDocs_Conclusions_Import.Location = New System.Drawing.Point(0, 181)
        Me.bnDocs_Conclusions_Import.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnDocs_Conclusions_Import.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnDocs_Conclusions_Import.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnDocs_Conclusions_Import.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnDocs_Conclusions_Import.Name = "bnDocs_Conclusions_Import"
        Me.bnDocs_Conclusions_Import.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnDocs_Conclusions_Import.Size = New System.Drawing.Size(894, 25)
        Me.bnDocs_Conclusions_Import.TabIndex = 1
        Me.bnDocs_Conclusions_Import.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 22)
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
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.Window
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
        Me.BindingNavigatorAddNewItem.Text = "Новое заключение на ВВОЗ"
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
        'btnCopyTo
        '
        Me.btnCopyTo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopyTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopyTo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopytoImport, Me.btnCopyToExport, Me.btnCopyToExamination, Me.btnCopyAndPrint})
        Me.btnCopyTo.Image = CType(resources.GetObject("btnCopyTo.Image"), System.Drawing.Image)
        Me.btnCopyTo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopyTo.Name = "btnCopyTo"
        Me.btnCopyTo.Size = New System.Drawing.Size(29, 22)
        Me.btnCopyTo.Text = "Копировать в"
        '
        'btnCopytoImport
        '
        Me.btnCopytoImport.Name = "btnCopytoImport"
        Me.btnCopytoImport.Size = New System.Drawing.Size(251, 22)
        Me.btnCopytoImport.Text = "Копировать в заключение (ввоз)"
        '
        'btnCopyToExport
        '
        Me.btnCopyToExport.Name = "btnCopyToExport"
        Me.btnCopyToExport.Size = New System.Drawing.Size(251, 22)
        Me.btnCopyToExport.Text = "Копировать в заключение (вывоз)"
        '
        'btnCopyToExamination
        '
        Me.btnCopyToExamination.Name = "btnCopyToExamination"
        Me.btnCopyToExamination.Size = New System.Drawing.Size(251, 22)
        Me.btnCopyToExamination.Text = "Копировать в СВИДЕТЕЛЬСТВО"
        '
        'btnCopyAndPrint
        '
        Me.btnCopyAndPrint.Name = "btnCopyAndPrint"
        Me.btnCopyAndPrint.Size = New System.Drawing.Size(251, 22)
        Me.btnCopyAndPrint.Text = "Копировать и печатать..."
        '
        'btnPrints
        '
        Me.btnPrints.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrints.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnPrintAdd})
        Me.btnPrints.Image = CType(resources.GetObject("btnPrints.Image"), System.Drawing.Image)
        Me.btnPrints.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrints.Name = "btnPrints"
        Me.btnPrints.Size = New System.Drawing.Size(29, 22)
        Me.btnPrints.Text = "Печать"
        '
        'btnPrint
        '
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(215, 22)
        Me.btnPrint.Text = "Заключение на ВВОЗ"
        '
        'btnPrintAdd
        '
        Me.btnPrintAdd.Name = "btnPrintAdd"
        Me.btnPrintAdd.Size = New System.Drawing.Size(215, 22)
        Me.btnPrintAdd.Text = "Свидетельство экспертизы"
        Me.btnPrintAdd.Visible = False
        '
        'btnPreviews
        '
        Me.btnPreviews.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPreviews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreviews.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPreview, Me.btnPreviewAdd})
        Me.btnPreviews.Image = CType(resources.GetObject("btnPreviews.Image"), System.Drawing.Image)
        Me.btnPreviews.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreviews.Name = "btnPreviews"
        Me.btnPreviews.Size = New System.Drawing.Size(29, 22)
        Me.btnPreviews.Text = "Предпросмотр"
        '
        'btnPreview
        '
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(215, 22)
        Me.btnPreview.Text = "Заключение на ВВОЗ"
        '
        'btnPreviewAdd
        '
        Me.btnPreviewAdd.Name = "btnPreviewAdd"
        Me.btnPreviewAdd.Size = New System.Drawing.Size(215, 22)
        Me.btnPreviewAdd.Text = "Свидетельство экспертизы"
        Me.btnPreviewAdd.Visible = False
        '
        'pnlDiseases
        '
        Me.pnlDiseases.CausesValidation = False
        Me.pnlDiseases.Controls.Add(Me.dgvDocs_Conclusions_NotKarantin)
        Me.pnlDiseases.Controls.Add(Me.dgvDocs_Conclusions_Karantin)
        Me.pnlDiseases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDiseases.Location = New System.Drawing.Point(0, 0)
        Me.pnlDiseases.Name = "pnlDiseases"
        Me.pnlDiseases.Size = New System.Drawing.Size(894, 61)
        Me.pnlDiseases.TabIndex = 2
        '
        'dgvDocs_Conclusions_NotKarantin
        '
        Me.dgvDocs_Conclusions_NotKarantin.AutoGenerateColumns = False
        Me.dgvDocs_Conclusions_NotKarantin.BackgroundColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Conclusions_NotKarantin.CausesValidation = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocs_Conclusions_NotKarantin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDocs_Conclusions_NotKarantin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_notkarantin_object_title, Me.Column_state_notkar, Me.DocidDataGridViewTextBoxColumn2, Me.GoodtitleDataGridViewTextBoxColumn1, Me.ProductioncountryDataGridViewTextBoxColumn1})
        Me.dgvDocs_Conclusions_NotKarantin.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Global.Inspector.My.MySettings.Default, "backgroundColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Conclusions_NotKarantin.DataSource = Me.bsDocs_Conclusions_NotKarantin
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocs_Conclusions_NotKarantin.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDocs_Conclusions_NotKarantin.RowHeadersWidth = 20
        Me.dgvDocs_Conclusions_NotKarantin.Size = New System.Drawing.Size(394, 61)
        Me.dgvDocs_Conclusions_NotKarantin.TabIndex = 41
        '
        'Column_notkarantin_object_title
        '
        Me.Column_notkarantin_object_title.DataPropertyName = "object_title"
        Me.Column_notkarantin_object_title.DisplayStyleForCurrentCellOnly = True
        Me.Column_notkarantin_object_title.HeaderText = "Некарантинные"
        Me.Column_notkarantin_object_title.Name = "Column_notkarantin_object_title"
        Me.Column_notkarantin_object_title.Width = 210
        '
        'Column_state_notkar
        '
        Me.Column_state_notkar.DataPropertyName = "state"
        Me.Column_state_notkar.DisplayStyleForCurrentCellOnly = True
        Me.Column_state_notkar.HeaderText = "Состояние"
        Me.Column_state_notkar.Name = "Column_state_notkar"
        Me.Column_state_notkar.Width = 145
        '
        'DocidDataGridViewTextBoxColumn2
        '
        Me.DocidDataGridViewTextBoxColumn2.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn2.Name = "DocidDataGridViewTextBoxColumn2"
        Me.DocidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn2.Visible = False
        '
        'GoodtitleDataGridViewTextBoxColumn1
        '
        Me.GoodtitleDataGridViewTextBoxColumn1.DataPropertyName = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn1.HeaderText = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn1.Name = "GoodtitleDataGridViewTextBoxColumn1"
        Me.GoodtitleDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GoodtitleDataGridViewTextBoxColumn1.Visible = False
        '
        'ProductioncountryDataGridViewTextBoxColumn1
        '
        Me.ProductioncountryDataGridViewTextBoxColumn1.DataPropertyName = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn1.HeaderText = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn1.Name = "ProductioncountryDataGridViewTextBoxColumn1"
        Me.ProductioncountryDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProductioncountryDataGridViewTextBoxColumn1.Visible = False
        '
        'bsDocs_Conclusions_NotKarantin
        '
        Me.bsDocs_Conclusions_NotKarantin.DataMember = "FK_Docs_Conclusions_NotKarantin_Docs_Acts_Goods"
        Me.bsDocs_Conclusions_NotKarantin.DataSource = Me.bsDocs_Acts_Goods
        '
        'bsDocs_Acts_Goods
        '
        Me.bsDocs_Acts_Goods.DataMember = "FK_Docs_Acts_Goods_Docs_Conclusions_Import"
        Me.bsDocs_Acts_Goods.DataSource = Me.bsDocs_Conclusions_Import
        '
        'dgvDocs_Conclusions_Karantin
        '
        Me.dgvDocs_Conclusions_Karantin.AutoGenerateColumns = False
        Me.dgvDocs_Conclusions_Karantin.BackgroundColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Conclusions_Karantin.CausesValidation = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocs_Conclusions_Karantin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDocs_Conclusions_Karantin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_karantin_object_title, Me.count, Me.Column_karantin_count_unit, Me.Column_state, Me.DocidDataGridViewTextBoxColumn1, Me.GoodtitleDataGridViewTextBoxColumn, Me.ProductioncountryDataGridViewTextBoxColumn})
        Me.dgvDocs_Conclusions_Karantin.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Global.Inspector.My.MySettings.Default, "backgroundColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Conclusions_Karantin.DataSource = Me.bsDocs_Conclusions_Karantin
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocs_Conclusions_Karantin.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDocs_Conclusions_Karantin.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvDocs_Conclusions_Karantin.Location = New System.Drawing.Point(394, 0)
        Me.dgvDocs_Conclusions_Karantin.Name = "dgvDocs_Conclusions_Karantin"
        Me.dgvDocs_Conclusions_Karantin.RowHeadersWidth = 20
        Me.dgvDocs_Conclusions_Karantin.Size = New System.Drawing.Size(500, 61)
        Me.dgvDocs_Conclusions_Karantin.TabIndex = 42
        '
        'Column_karantin_object_title
        '
        Me.Column_karantin_object_title.DataPropertyName = "object_title"
        Me.Column_karantin_object_title.DisplayStyleForCurrentCellOnly = True
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
        Me.Column_karantin_count_unit.DisplayStyleForCurrentCellOnly = True
        Me.Column_karantin_count_unit.HeaderText = "Ед"
        Me.Column_karantin_count_unit.Items.AddRange(New Object() {"шт", "шт/кг", "шт/100 г"})
        Me.Column_karantin_count_unit.Name = "Column_karantin_count_unit"
        Me.Column_karantin_count_unit.Width = 50
        '
        'Column_state
        '
        Me.Column_state.DataPropertyName = "state"
        Me.Column_state.DisplayStyleForCurrentCellOnly = True
        Me.Column_state.HeaderText = "Состояние"
        Me.Column_state.Name = "Column_state"
        Me.Column_state.Width = 140
        '
        'DocidDataGridViewTextBoxColumn1
        '
        Me.DocidDataGridViewTextBoxColumn1.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn1.Name = "DocidDataGridViewTextBoxColumn1"
        Me.DocidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn1.Visible = False
        '
        'GoodtitleDataGridViewTextBoxColumn
        '
        Me.GoodtitleDataGridViewTextBoxColumn.DataPropertyName = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn.HeaderText = "good_title"
        Me.GoodtitleDataGridViewTextBoxColumn.Name = "GoodtitleDataGridViewTextBoxColumn"
        Me.GoodtitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.GoodtitleDataGridViewTextBoxColumn.Visible = False
        '
        'ProductioncountryDataGridViewTextBoxColumn
        '
        Me.ProductioncountryDataGridViewTextBoxColumn.DataPropertyName = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn.HeaderText = "production_country"
        Me.ProductioncountryDataGridViewTextBoxColumn.Name = "ProductioncountryDataGridViewTextBoxColumn"
        Me.ProductioncountryDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductioncountryDataGridViewTextBoxColumn.Visible = False
        '
        'bsDocs_Conclusions_Karantin
        '
        Me.bsDocs_Conclusions_Karantin.DataMember = "FK_Docs_Conclusions_Karantin_Docs_Acts_Goods"
        Me.bsDocs_Conclusions_Karantin.DataSource = Me.bsDocs_Acts_Goods
        '
        'dgvDocs_Acts_Goods
        '
        Me.dgvDocs_Acts_Goods.AllowUserToResizeRows = False
        Me.dgvDocs_Acts_Goods.AutoGenerateColumns = False
        Me.dgvDocs_Acts_Goods.BackgroundColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Acts_Goods.CausesValidation = False
        Me.dgvDocs_Acts_Goods.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_good_title, Me.Column_production_country, Me.places, Me.Column_places_unit, Me.weight, Me.Column_weight_unit, Me.samples_count})
        Me.dgvDocs_Acts_Goods.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Global.Inspector.My.MySettings.Default, "backgroundColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Acts_Goods.DataSource = Me.bsDocs_Acts_Goods
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocs_Acts_Goods.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDocs_Acts_Goods.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocs_Acts_Goods.Location = New System.Drawing.Point(0, 0)
        Me.dgvDocs_Acts_Goods.Name = "dgvDocs_Acts_Goods"
        Me.dgvDocs_Acts_Goods.Size = New System.Drawing.Size(894, 74)
        Me.dgvDocs_Acts_Goods.TabIndex = 40
        '
        'Column_good_title
        '
        Me.Column_good_title.DataPropertyName = "good_title"
        Me.Column_good_title.DisplayStyleForCurrentCellOnly = True
        Me.Column_good_title.HeaderText = "Наименование"
        Me.Column_good_title.Name = "Column_good_title"
        Me.Column_good_title.Width = 200
        '
        'Column_production_country
        '
        Me.Column_production_country.DataPropertyName = "production_country"
        Me.Column_production_country.DisplayStyleForCurrentCellOnly = True
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
        Me.Column_places_unit.DisplayStyleForCurrentCellOnly = True
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
        Me.Column_weight_unit.DisplayStyleForCurrentCellOnly = True
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
        'pnlTitle
        '
        Me.pnlTitle.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlTitle.CausesValidation = False
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
        Me.pnlTitle.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(894, 106)
        Me.pnlTitle.TabIndex = 6
        '
        'lblFactAddress
        '
        Me.lblFactAddress.AutoSize = True
        Me.lblFactAddress.CausesValidation = False
        Me.lblFactAddress.Location = New System.Drawing.Point(5, 83)
        Me.lblFactAddress.Name = "lblFactAddress"
        Me.lblFactAddress.Size = New System.Drawing.Size(71, 13)
        Me.lblFactAddress.TabIndex = 76
        Me.lblFactAddress.Text = "Факт. адрес"
        '
        'txtFactAddress
        '
        Me.txtFactAddress.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtFactAddress.CausesValidation = False
        Me.txtFactAddress.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFactAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Conclusions_Import, "fact_address", True))
        Me.txtFactAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFactAddress.Location = New System.Drawing.Point(82, 78)
        Me.txtFactAddress.MaxLength = 100
        Me.txtFactAddress.Multiline = True
        Me.txtFactAddress.Name = "txtFactAddress"
        Me.txtFactAddress.Size = New System.Drawing.Size(809, 22)
        Me.txtFactAddress.TabIndex = 75
        '
        'DocidDataGridViewTextBoxColumn
        '
        Me.DocidDataGridViewTextBoxColumn.DataPropertyName = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.HeaderText = "doc_id"
        Me.DocidDataGridViewTextBoxColumn.Name = "DocidDataGridViewTextBoxColumn"
        Me.DocidDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocidDataGridViewTextBoxColumn.Visible = False
        '
        'taDocs_Conclusions_Import
        '
        Me.taDocs_Conclusions_Import.ClearBeforeFill = True
        '
        'taDocs_Acts_Goods
        '
        Me.taDocs_Acts_Goods.ClearBeforeFill = True
        '
        'taDocs_Conclusions_Karantin
        '
        Me.taDocs_Conclusions_Karantin.ClearBeforeFill = True
        '
        'taDocs_Conclusions_NotKarantin
        '
        Me.taDocs_Conclusions_NotKarantin.ClearBeforeFill = True
        '
        'taR_clients
        '
        Me.taR_clients.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlSearch.CausesValidation = False
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
        Me.pnlSearch.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 106)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(894, 75)
        Me.pnlSearch.TabIndex = 87
        Me.pnlSearch.Visible = False
        '
        'splitDiseasesAndMain
        '
        Me.splitDiseasesAndMain.CausesValidation = False
        Me.splitDiseasesAndMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitDiseasesAndMain.Location = New System.Drawing.Point(0, 0)
        Me.splitDiseasesAndMain.Name = "splitDiseasesAndMain"
        Me.splitDiseasesAndMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitDiseasesAndMain.Panel1
        '
        Me.splitDiseasesAndMain.Panel1.CausesValidation = False
        Me.splitDiseasesAndMain.Panel1.Controls.Add(Me.pnlDiseases)
        '
        'splitDiseasesAndMain.Panel2
        '
        Me.splitDiseasesAndMain.Panel2.CausesValidation = False
        Me.splitDiseasesAndMain.Panel2.Controls.Add(Me.pnlMain)
        Me.splitDiseasesAndMain.Size = New System.Drawing.Size(894, 271)
        Me.splitDiseasesAndMain.SplitterDistance = 61
        Me.splitDiseasesAndMain.TabIndex = 88
        '
        'splitAll
        '
        Me.splitAll.CausesValidation = False
        Me.splitAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitAll.Location = New System.Drawing.Point(0, 206)
        Me.splitAll.Name = "splitAll"
        Me.splitAll.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitAll.Panel1
        '
        Me.splitAll.Panel1.CausesValidation = False
        Me.splitAll.Panel1.Controls.Add(Me.dgvDocs_Acts_Goods)
        '
        'splitAll.Panel2
        '
        Me.splitAll.Panel2.CausesValidation = False
        Me.splitAll.Panel2.Controls.Add(Me.splitDiseasesAndMain)
        Me.splitAll.Size = New System.Drawing.Size(894, 349)
        Me.splitAll.SplitterDistance = 74
        Me.splitAll.TabIndex = 89
        '
        'tipInspection
        '
        Me.tipInspection.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tipInspection.ToolTipTitle = "Обследование"
        '
        'frmDocConclusionsImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(894, 555)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.splitAll)
        Me.Controls.Add(Me.bnDocs_Conclusions_Import)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlTitle)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDocConclusionsImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Заключения на ВВОЗ"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.bsDocs_Conclusions_Import, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsConclusions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsR_clients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnDocs_Conclusions_Import, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnDocs_Conclusions_Import.ResumeLayout(False)
        Me.bnDocs_Conclusions_Import.PerformLayout()
        Me.pnlDiseases.ResumeLayout(False)
        CType(Me.dgvDocs_Conclusions_NotKarantin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDocs_Conclusions_NotKarantin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDocs_Conclusions_Karantin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDocs_Conclusions_Karantin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.splitDiseasesAndMain.Panel1.ResumeLayout(False)
        Me.splitDiseasesAndMain.Panel2.ResumeLayout(False)
        Me.splitDiseasesAndMain.ResumeLayout(False)
        Me.splitAll.Panel1.ResumeLayout(False)
        Me.splitAll.Panel2.ResumeLayout(False)
        Me.splitAll.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents dsConclusions As Inspector.Docs_Conclusions
    Friend WithEvents bsDocs_Conclusions_Import As System.Windows.Forms.BindingSource
    Friend WithEvents taDocs_Conclusions_Import As Inspector.Docs_ConclusionsTableAdapters.Docs_Conclusions_ImportTableAdapter
    Friend WithEvents bnDocs_Conclusions_Import As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SenderTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents MarkComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ArrivedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Arrived_rayonComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents Arrived_rayonLabel As System.Windows.Forms.Label
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
    Friend WithEvents ArrivedLabel As System.Windows.Forms.Label
    Friend WithEvents dgvDocs_Conclusions_Karantin As Inspector.dgvWithoutEnter
    Friend WithEvents dgvDocs_Conclusions_NotKarantin As Inspector.dgvWithoutEnter
    Friend WithEvents MarkLabel As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnCopyTo As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnCopytoImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopyToExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPreviews As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrints As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPreviewAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbVerdict As System.Windows.Forms.ComboBox
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents btnCopyAndPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Column_notkarantin_object_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column_state_notkar As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GoodtitleDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductioncountryDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents splitDiseasesAndMain As System.Windows.Forms.SplitContainer
    Friend WithEvents splitAll As System.Windows.Forms.SplitContainer
    Friend WithEvents tipInspection As System.Windows.Forms.ToolTip
    Friend WithEvents lblFactAddress As System.Windows.Forms.Label
    Friend WithEvents txtFactAddress As System.Windows.Forms.TextBox
    Friend WithEvents Column_good_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column_production_country As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents places As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_places_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents weight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_weight_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents samples_count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCopyToExamination As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column_karantin_object_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_karantin_count_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column_state As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DocidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GoodtitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductioncountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Starting_pointTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Destination_pointTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cbFoundation As System.Windows.Forms.ComboBox
End Class
