<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocActs
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
        Dim Doc_numberLabel As System.Windows.Forms.Label
        Dim Doc_laboratoryLabel As System.Windows.Forms.Label
        Dim Client_innLabel As System.Windows.Forms.Label
        Dim Doc_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocActs))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Client_adress_warehouseLabel = New System.Windows.Forms.Label
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.bsDocs_Acts = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsDocuments = New Inspector.Documents
        Me.pnlActs = New System.Windows.Forms.Panel
        Me.Client_innMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.bsR_clients = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doc_numberMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Doc_laboratoryComboBox = New System.Windows.Forms.ComboBox
        Me.Doc_dateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbCountry = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbProduction = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Doc_date_highDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Client_adress_warehouseTextBox = New System.Windows.Forms.TextBox
        Me.bnDocs_Acts = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Docs_ActsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.btnCopy = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnCopyToAct = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCopyToConclusionImport = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCopyToConclusionExport = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrintMenu = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.dgvDocs_Acts_Goods = New Inspector.dgvWithoutEnter
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column_good_title = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column_production_country = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PlacesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column_places_unit = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column_weight_unit = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SamplescountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsDocs_Acts_Goods = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.taDocs_Acts = New Inspector.DocumentsTableAdapters.Docs_ActsTableAdapter
        Me.taDocs_Acts_Goods = New Inspector.DocumentsTableAdapters.Docs_Acts_GoodsTableAdapter
        Me.taR_clients = New Inspector.DocumentsTableAdapters.R_clientsTableAdapter
        Me.pnlSearchItems = New System.Windows.Forms.Panel
        Me.pnlActsAdd = New System.Windows.Forms.Panel
        Me.txtRepresentative = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Doc_numberLabel = New System.Windows.Forms.Label
        Doc_laboratoryLabel = New System.Windows.Forms.Label
        Client_innLabel = New System.Windows.Forms.Label
        Doc_dateLabel = New System.Windows.Forms.Label
        Me.pnlSearch.SuspendLayout()
        CType(Me.bsDocs_Acts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActs.SuspendLayout()
        CType(Me.bsR_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnDocs_Acts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnDocs_Acts.SuspendLayout()
        CType(Me.dgvDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchItems.SuspendLayout()
        Me.pnlActsAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Doc_numberLabel
        '
        Doc_numberLabel.AutoSize = True
        Doc_numberLabel.CausesValidation = False
        Doc_numberLabel.Location = New System.Drawing.Point(12, 12)
        Doc_numberLabel.Name = "Doc_numberLabel"
        Doc_numberLabel.Size = New System.Drawing.Size(45, 13)
        Doc_numberLabel.TabIndex = 2
        Doc_numberLabel.Text = "№ Акта"
        '
        'Doc_laboratoryLabel
        '
        Doc_laboratoryLabel.AutoSize = True
        Doc_laboratoryLabel.CausesValidation = False
        Doc_laboratoryLabel.Location = New System.Drawing.Point(720, 11)
        Doc_laboratoryLabel.Name = "Doc_laboratoryLabel"
        Doc_laboratoryLabel.Size = New System.Drawing.Size(74, 13)
        Doc_laboratoryLabel.TabIndex = 4
        Doc_laboratoryLabel.Text = "Лаборатория"
        '
        'Client_innLabel
        '
        Client_innLabel.AutoSize = True
        Client_innLabel.CausesValidation = False
        Client_innLabel.Location = New System.Drawing.Point(386, 11)
        Client_innLabel.Name = "Client_innLabel"
        Client_innLabel.Size = New System.Drawing.Size(76, 13)
        Client_innLabel.TabIndex = 6
        Client_innLabel.Text = "ИНН Клиента"
        '
        'Doc_dateLabel
        '
        Doc_dateLabel.AutoSize = True
        Doc_dateLabel.CausesValidation = False
        Doc_dateLabel.Location = New System.Drawing.Point(137, 12)
        Doc_dateLabel.Name = "Doc_dateLabel"
        Doc_dateLabel.Size = New System.Drawing.Size(60, 13)
        Doc_dateLabel.TabIndex = 8
        Doc_dateLabel.Text = "Дата Акта"
        '
        'Client_adress_warehouseLabel
        '
        Me.Client_adress_warehouseLabel.AutoSize = True
        Me.Client_adress_warehouseLabel.CausesValidation = False
        Me.Client_adress_warehouseLabel.Location = New System.Drawing.Point(12, 63)
        Me.Client_adress_warehouseLabel.Name = "Client_adress_warehouseLabel"
        Me.Client_adress_warehouseLabel.Size = New System.Drawing.Size(77, 13)
        Me.Client_adress_warehouseLabel.TabIndex = 10
        Me.Client_adress_warehouseLabel.Text = "Адрес склада"
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.CausesValidation = False
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(894, 35)
        Me.pnlSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.CausesValidation = False
        Me.btnSearch.Location = New System.Drawing.Point(3, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "В режим поиска"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'bsDocs_Acts
        '
        Me.bsDocs_Acts.DataMember = "Docs_Acts"
        Me.bsDocs_Acts.DataSource = Me.dsDocuments
        '
        'dsDocuments
        '
        Me.dsDocuments.DataSetName = "Documents"
        Me.dsDocuments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlActs
        '
        Me.pnlActs.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlActs.CausesValidation = False
        Me.pnlActs.Controls.Add(Me.Client_innMaskedTextBox)
        Me.pnlActs.Controls.Add(Doc_numberLabel)
        Me.pnlActs.Controls.Add(Me.Doc_numberMaskedTextBox)
        Me.pnlActs.Controls.Add(Doc_laboratoryLabel)
        Me.pnlActs.Controls.Add(Me.Doc_laboratoryComboBox)
        Me.pnlActs.Controls.Add(Client_innLabel)
        Me.pnlActs.Controls.Add(Doc_dateLabel)
        Me.pnlActs.Controls.Add(Me.Doc_dateDateTimePicker)
        Me.pnlActs.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlActs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActs.Location = New System.Drawing.Point(0, 35)
        Me.pnlActs.Name = "pnlActs"
        Me.pnlActs.Size = New System.Drawing.Size(894, 36)
        Me.pnlActs.TabIndex = 1
        '
        'Client_innMaskedTextBox
        '
        Me.Client_innMaskedTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Client_innMaskedTextBox.CausesValidation = False
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_inn", True))
        Me.Client_innMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Client_innMaskedTextBox.Location = New System.Drawing.Point(468, 7)
        Me.Client_innMaskedTextBox.Mask = "00000000000000"
        Me.Client_innMaskedTextBox.Name = "Client_innMaskedTextBox"
        Me.Client_innMaskedTextBox.Size = New System.Drawing.Size(110, 22)
        Me.Client_innMaskedTextBox.TabIndex = 3
        '
        'bsR_clients
        '
        Me.bsR_clients.DataMember = "R_clients"
        Me.bsR_clients.DataSource = Me.dsDocuments
        '
        'Doc_numberMaskedTextBox
        '
        Me.Doc_numberMaskedTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Doc_numberMaskedTextBox.CausesValidation = False
        Me.Doc_numberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Acts, "doc_number", True))
        Me.Doc_numberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Doc_numberMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Doc_numberMaskedTextBox.Location = New System.Drawing.Point(63, 9)
        Me.Doc_numberMaskedTextBox.Mask = "00000"
        Me.Doc_numberMaskedTextBox.Name = "Doc_numberMaskedTextBox"
        Me.Doc_numberMaskedTextBox.Size = New System.Drawing.Size(58, 22)
        Me.Doc_numberMaskedTextBox.TabIndex = 1
        '
        'Doc_laboratoryComboBox
        '
        Me.Doc_laboratoryComboBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Doc_laboratoryComboBox.CausesValidation = False
        Me.Doc_laboratoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Acts, "doc_laboratory", True))
        Me.Doc_laboratoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Doc_laboratoryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Doc_laboratoryComboBox.FormattingEnabled = True
        Me.Doc_laboratoryComboBox.Items.AddRange(New Object() {"л1", "л2"})
        Me.Doc_laboratoryComboBox.Location = New System.Drawing.Point(810, 7)
        Me.Doc_laboratoryComboBox.Name = "Doc_laboratoryComboBox"
        Me.Doc_laboratoryComboBox.Size = New System.Drawing.Size(72, 24)
        Me.Doc_laboratoryComboBox.TabIndex = 4
        '
        'Doc_dateDateTimePicker
        '
        Me.Doc_dateDateTimePicker.BackColor = System.Drawing.SystemColors.Window
        Me.Doc_dateDateTimePicker.CausesValidation = False
        Me.Doc_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsDocs_Acts, "doc_date", True))
        Me.Doc_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Doc_dateDateTimePicker.Location = New System.Drawing.Point(203, 8)
        Me.Doc_dateDateTimePicker.Name = "Doc_dateDateTimePicker"
        Me.Doc_dateDateTimePicker.Size = New System.Drawing.Size(168, 22)
        Me.Doc_dateDateTimePicker.TabIndex = 2
        Me.Doc_dateDateTimePicker.Value = New Date(2007, 4, 8, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.CausesValidation = False
        Me.Label5.Location = New System.Drawing.Point(518, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Происхождение"
        '
        'cbCountry
        '
        Me.cbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCountry.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.cbCountry.CausesValidation = False
        Me.cbCountry.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbCountry.FormattingEnabled = True
        Me.cbCountry.Location = New System.Drawing.Point(610, 33)
        Me.cbCountry.Name = "cbCountry"
        Me.cbCountry.Size = New System.Drawing.Size(272, 24)
        Me.cbCountry.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(137, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Продукция"
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
        Me.cbProduction.Location = New System.Drawing.Point(203, 33)
        Me.cbProduction.Name = "cbProduction"
        Me.cbProduction.Size = New System.Drawing.Size(307, 24)
        Me.cbProduction.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(137, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "До"
        '
        'Doc_date_highDateTimePicker
        '
        Me.Doc_date_highDateTimePicker.BackColor = System.Drawing.SystemColors.WindowText
        Me.Doc_date_highDateTimePicker.CausesValidation = False
        Me.Doc_date_highDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Doc_date_highDateTimePicker.Location = New System.Drawing.Point(203, 3)
        Me.Doc_date_highDateTimePicker.Name = "Doc_date_highDateTimePicker"
        Me.Doc_date_highDateTimePicker.Size = New System.Drawing.Size(168, 22)
        Me.Doc_date_highDateTimePicker.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(14, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Адрес"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.TextBox2.CausesValidation = False
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_adress", True))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(95, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(787, 22)
        Me.TextBox2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Клиент"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_name", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(95, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(787, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Client_adress_warehouseTextBox
        '
        Me.Client_adress_warehouseTextBox.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.Client_adress_warehouseTextBox.CausesValidation = False
        Me.Client_adress_warehouseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Acts, "client_adress_warehouse", True))
        Me.Client_adress_warehouseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_adress_warehouseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Client_adress_warehouseTextBox.Location = New System.Drawing.Point(95, 60)
        Me.Client_adress_warehouseTextBox.MaxLength = 200
        Me.Client_adress_warehouseTextBox.Name = "Client_adress_warehouseTextBox"
        Me.Client_adress_warehouseTextBox.Size = New System.Drawing.Size(415, 22)
        Me.Client_adress_warehouseTextBox.TabIndex = 7
        '
        'bnDocs_Acts
        '
        Me.bnDocs_Acts.AddNewItem = Nothing
        Me.bnDocs_Acts.BindingSource = Me.bsDocs_Acts
        Me.bnDocs_Acts.CountItem = Me.BindingNavigatorCountItem
        Me.bnDocs_Acts.DeleteItem = Nothing
        Me.bnDocs_Acts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Docs_ActsBindingNavigatorSaveItem, Me.btnCopy, Me.btnPrintMenu, Me.btnPrintPreview})
        Me.bnDocs_Acts.Location = New System.Drawing.Point(0, 219)
        Me.bnDocs_Acts.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnDocs_Acts.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnDocs_Acts.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnDocs_Acts.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnDocs_Acts.Name = "bnDocs_Acts"
        Me.bnDocs_Acts.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnDocs_Acts.Size = New System.Drawing.Size(894, 25)
        Me.bnDocs_Acts.TabIndex = 2
        Me.bnDocs_Acts.Text = "BindingNavigator1"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel1.Text = "Акты"
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
        Me.BindingNavigatorAddNewItem.Text = "Новый Акт"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить Акт"
        '
        'Docs_ActsBindingNavigatorSaveItem
        '
        Me.Docs_ActsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Docs_ActsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Docs_ActsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Docs_ActsBindingNavigatorSaveItem.Name = "Docs_ActsBindingNavigatorSaveItem"
        Me.Docs_ActsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Docs_ActsBindingNavigatorSaveItem.Text = "Сохранить"
        '
        'btnCopy
        '
        Me.btnCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopyToAct, Me.btnCopyToConclusionImport, Me.btnCopyToConclusionExport})
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(29, 22)
        Me.btnCopy.Text = "Копировать в"
        Me.btnCopy.ToolTipText = "Копировать в"
        '
        'btnCopyToAct
        '
        Me.btnCopyToAct.Name = "btnCopyToAct"
        Me.btnCopyToAct.Size = New System.Drawing.Size(262, 22)
        Me.btnCopyToAct.Text = "Копировать в акт"
        '
        'btnCopyToConclusionImport
        '
        Me.btnCopyToConclusionImport.Name = "btnCopyToConclusionImport"
        Me.btnCopyToConclusionImport.Size = New System.Drawing.Size(262, 22)
        Me.btnCopyToConclusionImport.Text = "Копировать в заключение (ввоз)"
        '
        'btnCopyToConclusionExport
        '
        Me.btnCopyToConclusionExport.Name = "btnCopyToConclusionExport"
        Me.btnCopyToConclusionExport.Size = New System.Drawing.Size(262, 22)
        Me.btnCopyToConclusionExport.Text = "Копировать в заключение (вывоз)"
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
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
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
        'dgvDocs_Acts_Goods
        '
        Me.dgvDocs_Acts_Goods.AllowUserToResizeRows = False
        Me.dgvDocs_Acts_Goods.AutoGenerateColumns = False
        Me.dgvDocs_Acts_Goods.BackgroundColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Acts_Goods.CausesValidation = False
        Me.dgvDocs_Acts_Goods.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column_good_title, Me.Column_production_country, Me.PlacesDataGridViewTextBoxColumn, Me.Column_places_unit, Me.WeightDataGridViewTextBoxColumn, Me.Column_weight_unit, Me.SamplescountDataGridViewTextBoxColumn})
        Me.dgvDocs_Acts_Goods.DataBindings.Add(New System.Windows.Forms.Binding("GridColor", Global.Inspector.My.MySettings.Default, "backgroundColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Acts_Goods.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Global.Inspector.My.MySettings.Default, "backgroundColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dgvDocs_Acts_Goods.DataSource = Me.bsDocs_Acts_Goods
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocs_Acts_Goods.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDocs_Acts_Goods.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocs_Acts_Goods.GridColor = Global.Inspector.My.MySettings.Default.backgroundColor
        Me.dgvDocs_Acts_Goods.Location = New System.Drawing.Point(0, 244)
        Me.dgvDocs_Acts_Goods.MultiSelect = False
        Me.dgvDocs_Acts_Goods.Name = "dgvDocs_Acts_Goods"
        Me.dgvDocs_Acts_Goods.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDocs_Acts_Goods.Size = New System.Drawing.Size(894, 238)
        Me.dgvDocs_Acts_Goods.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "doc_id"
        Me.Column1.HeaderText = "doc_id"
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Visible = False
        '
        'Column_good_title
        '
        Me.Column_good_title.DataPropertyName = "good_title"
        Me.Column_good_title.DisplayStyleForCurrentCellOnly = True
        Me.Column_good_title.HeaderText = "Продукция"
        Me.Column_good_title.Name = "Column_good_title"
        Me.Column_good_title.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_good_title.Width = 200
        '
        'Column_production_country
        '
        Me.Column_production_country.DataPropertyName = "production_country"
        Me.Column_production_country.DisplayStyleForCurrentCellOnly = True
        Me.Column_production_country.HeaderText = "Происхождение"
        Me.Column_production_country.Name = "Column_production_country"
        Me.Column_production_country.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_production_country.Width = 200
        '
        'PlacesDataGridViewTextBoxColumn
        '
        Me.PlacesDataGridViewTextBoxColumn.DataPropertyName = "places"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PlacesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PlacesDataGridViewTextBoxColumn.HeaderText = "Число мест"
        Me.PlacesDataGridViewTextBoxColumn.Name = "PlacesDataGridViewTextBoxColumn"
        Me.PlacesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PlacesDataGridViewTextBoxColumn.Width = 75
        '
        'Column_places_unit
        '
        Me.Column_places_unit.DataPropertyName = "places_unit"
        Me.Column_places_unit.DisplayStyleForCurrentCellOnly = True
        Me.Column_places_unit.HeaderText = "Единицы мест"
        Me.Column_places_unit.Name = "Column_places_unit"
        Me.Column_places_unit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_places_unit.Width = 110
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.WeightDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Вес"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.WeightDataGridViewTextBoxColumn.Width = 80
        '
        'Column_weight_unit
        '
        Me.Column_weight_unit.DataPropertyName = "weight_unit"
        Me.Column_weight_unit.DisplayStyleForCurrentCellOnly = True
        Me.Column_weight_unit.HeaderText = "Единицы веса"
        Me.Column_weight_unit.Name = "Column_weight_unit"
        Me.Column_weight_unit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'SamplescountDataGridViewTextBoxColumn
        '
        Me.SamplescountDataGridViewTextBoxColumn.DataPropertyName = "samples_count"
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SamplescountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SamplescountDataGridViewTextBoxColumn.HeaderText = "Образцы"
        Me.SamplescountDataGridViewTextBoxColumn.Name = "SamplescountDataGridViewTextBoxColumn"
        Me.SamplescountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SamplescountDataGridViewTextBoxColumn.Width = 60
        '
        'bsDocs_Acts_Goods
        '
        Me.bsDocs_Acts_Goods.AllowNew = True
        Me.bsDocs_Acts_Goods.DataMember = "FK_Docs_Acts_Goods_Docs_Acts"
        Me.bsDocs_Acts_Goods.DataSource = Me.bsDocs_Acts
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'taDocs_Acts
        '
        Me.taDocs_Acts.ClearBeforeFill = True
        '
        'taDocs_Acts_Goods
        '
        Me.taDocs_Acts_Goods.ClearBeforeFill = True
        '
        'taR_clients
        '
        Me.taR_clients.ClearBeforeFill = True
        '
        'pnlSearchItems
        '
        Me.pnlSearchItems.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlSearchItems.CausesValidation = False
        Me.pnlSearchItems.Controls.Add(Me.Label5)
        Me.pnlSearchItems.Controls.Add(Me.Doc_date_highDateTimePicker)
        Me.pnlSearchItems.Controls.Add(Me.cbCountry)
        Me.pnlSearchItems.Controls.Add(Me.Label3)
        Me.pnlSearchItems.Controls.Add(Me.Label4)
        Me.pnlSearchItems.Controls.Add(Me.cbProduction)
        Me.pnlSearchItems.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlSearchItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchItems.Location = New System.Drawing.Point(0, 71)
        Me.pnlSearchItems.Name = "pnlSearchItems"
        Me.pnlSearchItems.Size = New System.Drawing.Size(894, 60)
        Me.pnlSearchItems.TabIndex = 9
        Me.pnlSearchItems.Visible = False
        '
        'pnlActsAdd
        '
        Me.pnlActsAdd.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.pnlActsAdd.CausesValidation = False
        Me.pnlActsAdd.Controls.Add(Me.txtRepresentative)
        Me.pnlActsAdd.Controls.Add(Me.Label6)
        Me.pnlActsAdd.Controls.Add(Me.Label2)
        Me.pnlActsAdd.Controls.Add(Me.TextBox1)
        Me.pnlActsAdd.Controls.Add(Me.TextBox2)
        Me.pnlActsAdd.Controls.Add(Me.Client_adress_warehouseTextBox)
        Me.pnlActsAdd.Controls.Add(Me.Label1)
        Me.pnlActsAdd.Controls.Add(Me.Client_adress_warehouseLabel)
        Me.pnlActsAdd.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlActsAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActsAdd.Location = New System.Drawing.Point(0, 131)
        Me.pnlActsAdd.Name = "pnlActsAdd"
        Me.pnlActsAdd.Size = New System.Drawing.Size(894, 88)
        Me.pnlActsAdd.TabIndex = 10
        '
        'txtRepresentative
        '
        Me.txtRepresentative.BackColor = Global.Inspector.My.MySettings.Default.backColorText
        Me.txtRepresentative.CausesValidation = False
        Me.txtRepresentative.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtRepresentative.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDocs_Acts, "representative", True))
        Me.txtRepresentative.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtRepresentative.Location = New System.Drawing.Point(610, 60)
        Me.txtRepresentative.MaxLength = 200
        Me.txtRepresentative.Name = "txtRepresentative"
        Me.txtRepresentative.Size = New System.Drawing.Size(272, 22)
        Me.txtRepresentative.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.CausesValidation = False
        Me.Label6.Location = New System.Drawing.Point(521, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Представитель"
        '
        'frmDocActs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Inspector.My.MySettings.Default.backColorControl
        Me.ClientSize = New System.Drawing.Size(894, 482)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.dgvDocs_Acts_Goods)
        Me.Controls.Add(Me.bnDocs_Acts)
        Me.Controls.Add(Me.pnlActsAdd)
        Me.Controls.Add(Me.pnlSearchItems)
        Me.Controls.Add(Me.pnlActs)
        Me.Controls.Add(Me.pnlSearch)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Inspector.My.MySettings.Default, "backColorControl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDocActs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Акты отбора образцов"
        Me.pnlSearch.ResumeLayout(False)
        CType(Me.bsDocs_Acts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActs.ResumeLayout(False)
        Me.pnlActs.PerformLayout()
        CType(Me.bsR_clients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnDocs_Acts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnDocs_Acts.ResumeLayout(False)
        Me.bnDocs_Acts.PerformLayout()
        CType(Me.dgvDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDocs_Acts_Goods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchItems.ResumeLayout(False)
        Me.pnlSearchItems.PerformLayout()
        Me.pnlActsAdd.ResumeLayout(False)
        Me.pnlActsAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlActs As System.Windows.Forms.Panel
    Friend WithEvents dsDocuments As Inspector.Documents
    Friend WithEvents bsDocs_Acts As System.Windows.Forms.BindingSource
    Friend WithEvents taDocs_Acts As Inspector.DocumentsTableAdapters.Docs_ActsTableAdapter
    Friend WithEvents bnDocs_Acts As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Docs_ActsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doc_numberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Doc_laboratoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Doc_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Client_adress_warehouseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_innMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents taDocs_Acts_Goods As Inspector.DocumentsTableAdapters.Docs_Acts_GoodsTableAdapter
    Friend WithEvents bsR_clients As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bsDocs_Acts_Goods As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Client_adress_warehouseLabel As System.Windows.Forms.Label
    Friend WithEvents Doc_date_highDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbProduction As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents dgvDocs_Acts_Goods As Inspector.dgvWithoutEnter
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnCopyToAct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopyToConclusionImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopyToConclusionExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents taR_clients As Inspector.DocumentsTableAdapters.R_clientsTableAdapter
    Friend WithEvents pnlSearchItems As System.Windows.Forms.Panel
    Friend WithEvents pnlActsAdd As System.Windows.Forms.Panel
    Friend WithEvents btnPrintMenu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRepresentative As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_good_title As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column_production_country As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PlacesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_places_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_weight_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SamplescountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
