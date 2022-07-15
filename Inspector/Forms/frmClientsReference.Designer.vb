<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientsReference
    Inherits CAppForm 'System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Client_nameLabel As System.Windows.Forms.Label
        Dim Client_innLabel As System.Windows.Forms.Label
        Dim Client_adressLabel As System.Windows.Forms.Label
        Dim Client_adress_factLabel As System.Windows.Forms.Label
        Dim Client_adress_warehouseLabel As System.Windows.Forms.Label
        Dim Client_phoneLabel As System.Windows.Forms.Label
        Dim Client_bank_nameLabel As System.Windows.Forms.Label
        Dim Client_bank_accountLabel As System.Windows.Forms.Label
        Dim Client_regionLabel As System.Windows.Forms.Label
        Dim Client_region_rayonLabel As System.Windows.Forms.Label
        Dim Client_representativeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientsReference))
        Me.Client_kppLabel = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.bsR_clients = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsDocuments = New Inspector.Documents()
        Me.bnR_clients = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
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
        Me.R_clientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Client_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_innMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Client_kppMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Client_adressTextBox = New System.Windows.Forms.TextBox()
        Me.Client_adress_factTextBox = New System.Windows.Forms.TextBox()
        Me.Client_adress_warehouseTextBox = New System.Windows.Forms.TextBox()
        Me.Client_phoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Client_bank_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.Client_bank_accountMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Client_regionComboBox = New System.Windows.Forms.ComboBox()
        Me.Client_region_rayonComboBox = New System.Windows.Forms.ComboBox()
        Me.Client_representativeTextBox = New System.Windows.Forms.TextBox()
        Me.taR_clients = New Inspector.DocumentsTableAdapters.R_clientsTableAdapter()
        Me.pnlFields = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAgreement = New System.Windows.Forms.TextBox()
        Me.Client_typeLabel = New System.Windows.Forms.Label()
        Me.Client_typeComboBox = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlFieldsContainer = New System.Windows.Forms.Panel()
        Me.pnlFieldsType = New System.Windows.Forms.Panel()
        Me.pnlFieldsMain = New System.Windows.Forms.Panel()
        Me.btnNewINN = New System.Windows.Forms.Button()
        Client_nameLabel = New System.Windows.Forms.Label()
        Client_innLabel = New System.Windows.Forms.Label()
        Client_adressLabel = New System.Windows.Forms.Label()
        Client_adress_factLabel = New System.Windows.Forms.Label()
        Client_adress_warehouseLabel = New System.Windows.Forms.Label()
        Client_phoneLabel = New System.Windows.Forms.Label()
        Client_bank_nameLabel = New System.Windows.Forms.Label()
        Client_bank_accountLabel = New System.Windows.Forms.Label()
        Client_regionLabel = New System.Windows.Forms.Label()
        Client_region_rayonLabel = New System.Windows.Forms.Label()
        Client_representativeLabel = New System.Windows.Forms.Label()
        Me.pnlSearch.SuspendLayout()
        CType(Me.bsR_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnR_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnR_clients.SuspendLayout()
        Me.pnlFields.SuspendLayout()
        Me.pnlFieldsContainer.SuspendLayout()
        Me.pnlFieldsType.SuspendLayout()
        Me.pnlFieldsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Client_nameLabel
        '
        Client_nameLabel.AutoSize = True
        Client_nameLabel.CausesValidation = False
        Client_nameLabel.Location = New System.Drawing.Point(14, 9)
        Client_nameLabel.Name = "Client_nameLabel"
        Client_nameLabel.Size = New System.Drawing.Size(60, 13)
        Client_nameLabel.TabIndex = 26
        Client_nameLabel.Text = "Название:"
        '
        'Client_innLabel
        '
        Client_innLabel.AutoSize = True
        Client_innLabel.CausesValidation = False
        Client_innLabel.Location = New System.Drawing.Point(14, 31)
        Client_innLabel.Name = "Client_innLabel"
        Client_innLabel.Size = New System.Drawing.Size(34, 13)
        Client_innLabel.TabIndex = 28
        Client_innLabel.Text = "ИНН:"
        '
        'Client_adressLabel
        '
        Client_adressLabel.AutoSize = True
        Client_adressLabel.CausesValidation = False
        Client_adressLabel.Location = New System.Drawing.Point(16, 6)
        Client_adressLabel.Name = "Client_adressLabel"
        Client_adressLabel.Size = New System.Drawing.Size(41, 13)
        Client_adressLabel.TabIndex = 32
        Client_adressLabel.Text = "Адрес:"
        '
        'Client_adress_factLabel
        '
        Client_adress_factLabel.AutoSize = True
        Client_adress_factLabel.CausesValidation = False
        Client_adress_factLabel.Location = New System.Drawing.Point(16, 35)
        Client_adress_factLabel.Name = "Client_adress_factLabel"
        Client_adress_factLabel.Size = New System.Drawing.Size(112, 13)
        Client_adress_factLabel.TabIndex = 34
        Client_adress_factLabel.Text = "Фактический адрес:"
        '
        'Client_adress_warehouseLabel
        '
        Client_adress_warehouseLabel.AutoSize = True
        Client_adress_warehouseLabel.CausesValidation = False
        Client_adress_warehouseLabel.Location = New System.Drawing.Point(16, 61)
        Client_adress_warehouseLabel.Name = "Client_adress_warehouseLabel"
        Client_adress_warehouseLabel.Size = New System.Drawing.Size(80, 13)
        Client_adress_warehouseLabel.TabIndex = 36
        Client_adress_warehouseLabel.Text = "Адрес склада:"
        '
        'Client_phoneLabel
        '
        Client_phoneLabel.AutoSize = True
        Client_phoneLabel.CausesValidation = False
        Client_phoneLabel.Location = New System.Drawing.Point(270, 110)
        Client_phoneLabel.Name = "Client_phoneLabel"
        Client_phoneLabel.Size = New System.Drawing.Size(55, 13)
        Client_phoneLabel.TabIndex = 38
        Client_phoneLabel.Text = "Телефон:"
        '
        'Client_bank_nameLabel
        '
        Client_bank_nameLabel.AutoSize = True
        Client_bank_nameLabel.CausesValidation = False
        Client_bank_nameLabel.Location = New System.Drawing.Point(16, 87)
        Client_bank_nameLabel.Name = "Client_bank_nameLabel"
        Client_bank_nameLabel.Size = New System.Drawing.Size(35, 13)
        Client_bank_nameLabel.TabIndex = 40
        Client_bank_nameLabel.Text = "Банк:"
        '
        'Client_bank_accountLabel
        '
        Client_bank_accountLabel.AutoSize = True
        Client_bank_accountLabel.CausesValidation = False
        Client_bank_accountLabel.Location = New System.Drawing.Point(16, 110)
        Client_bank_accountLabel.Name = "Client_bank_accountLabel"
        Client_bank_accountLabel.Size = New System.Drawing.Size(96, 13)
        Client_bank_accountLabel.TabIndex = 42
        Client_bank_accountLabel.Text = "Банковский счёт:"
        '
        'Client_regionLabel
        '
        Client_regionLabel.AutoSize = True
        Client_regionLabel.CausesValidation = False
        Client_regionLabel.Location = New System.Drawing.Point(16, 133)
        Client_regionLabel.Name = "Client_regionLabel"
        Client_regionLabel.Size = New System.Drawing.Size(46, 13)
        Client_regionLabel.TabIndex = 44
        Client_regionLabel.Text = "Регион:"
        '
        'Client_region_rayonLabel
        '
        Client_region_rayonLabel.AutoSize = True
        Client_region_rayonLabel.CausesValidation = False
        Client_region_rayonLabel.Location = New System.Drawing.Point(316, 136)
        Client_region_rayonLabel.Name = "Client_region_rayonLabel"
        Client_region_rayonLabel.Size = New System.Drawing.Size(41, 13)
        Client_region_rayonLabel.TabIndex = 46
        Client_region_rayonLabel.Text = "Район:"
        '
        'Client_representativeLabel
        '
        Client_representativeLabel.AutoSize = True
        Client_representativeLabel.CausesValidation = False
        Client_representativeLabel.Location = New System.Drawing.Point(2, 32)
        Client_representativeLabel.Name = "Client_representativeLabel"
        Client_representativeLabel.Size = New System.Drawing.Size(88, 13)
        Client_representativeLabel.TabIndex = 48
        Client_representativeLabel.Text = "Представитель:"
        '
        'Client_kppLabel
        '
        Me.Client_kppLabel.AutoSize = True
        Me.Client_kppLabel.CausesValidation = False
        Me.Client_kppLabel.Location = New System.Drawing.Point(207, 32)
        Me.Client_kppLabel.Name = "Client_kppLabel"
        Me.Client_kppLabel.Size = New System.Drawing.Size(33, 13)
        Me.Client_kppLabel.TabIndex = 30
        Me.Client_kppLabel.Text = "КПП:"
        '
        'pnlSearch
        '
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.CausesValidation = False
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(683, 47)
        Me.pnlSearch.TabIndex = 25
        '
        'btnSearch
        '
        Me.btnSearch.CausesValidation = False
        Me.btnSearch.Location = New System.Drawing.Point(10, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(107, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "В режим поиска"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'bsR_clients
        '
        Me.bsR_clients.DataMember = "R_clients"
        Me.bsR_clients.DataSource = Me.dsDocuments
        '
        'dsDocuments
        '
        Me.dsDocuments.DataSetName = "Documents"
        Me.dsDocuments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bnR_clients
        '
        Me.bnR_clients.AddNewItem = Nothing
        Me.bnR_clients.BindingSource = Me.bsR_clients
        Me.bnR_clients.CountItem = Me.BindingNavigatorCountItem
        Me.bnR_clients.DeleteItem = Nothing
        Me.bnR_clients.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnR_clients.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.R_clientsBindingNavigatorSaveItem})
        Me.bnR_clients.Location = New System.Drawing.Point(0, 284)
        Me.bnR_clients.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnR_clients.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnR_clients.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnR_clients.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnR_clients.Name = "bnR_clients"
        Me.bnR_clients.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnR_clients.Size = New System.Drawing.Size(683, 25)
        Me.bnR_clients.TabIndex = 26
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Новый клиент"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить клиента"
        '
        'R_clientsBindingNavigatorSaveItem
        '
        Me.R_clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.R_clientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("R_clientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.R_clientsBindingNavigatorSaveItem.Name = "R_clientsBindingNavigatorSaveItem"
        Me.R_clientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.R_clientsBindingNavigatorSaveItem.Text = "Сохранить"
        '
        'Client_nameTextBox
        '
        Me.Client_nameTextBox.CausesValidation = False
        Me.Client_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_name", True))
        Me.Client_nameTextBox.Location = New System.Drawing.Point(80, 6)
        Me.Client_nameTextBox.MaxLength = 300
        Me.Client_nameTextBox.Name = "Client_nameTextBox"
        Me.Client_nameTextBox.Size = New System.Drawing.Size(287, 20)
        Me.Client_nameTextBox.TabIndex = 1
        '
        'Client_innMaskedTextBox
        '
        Me.Client_innMaskedTextBox.CausesValidation = False
        Me.Client_innMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_inn", True))
        Me.Client_innMaskedTextBox.Location = New System.Drawing.Point(80, 28)
        Me.Client_innMaskedTextBox.Mask = "000000000000"
        Me.Client_innMaskedTextBox.Name = "Client_innMaskedTextBox"
        Me.Client_innMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Client_innMaskedTextBox.TabIndex = 3
        '
        'Client_kppMaskedTextBox
        '
        Me.Client_kppMaskedTextBox.CausesValidation = False
        Me.Client_kppMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_kpp", True))
        Me.Client_kppMaskedTextBox.Location = New System.Drawing.Point(246, 29)
        Me.Client_kppMaskedTextBox.Mask = "0000000000"
        Me.Client_kppMaskedTextBox.Name = "Client_kppMaskedTextBox"
        Me.Client_kppMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Client_kppMaskedTextBox.TabIndex = 4
        '
        'Client_adressTextBox
        '
        Me.Client_adressTextBox.CausesValidation = False
        Me.Client_adressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_adress", True))
        Me.Client_adressTextBox.Location = New System.Drawing.Point(80, 6)
        Me.Client_adressTextBox.MaxLength = 500
        Me.Client_adressTextBox.Name = "Client_adressTextBox"
        Me.Client_adressTextBox.Size = New System.Drawing.Size(599, 20)
        Me.Client_adressTextBox.TabIndex = 6
        '
        'Client_adress_factTextBox
        '
        Me.Client_adress_factTextBox.CausesValidation = False
        Me.Client_adress_factTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_adress_fact", True))
        Me.Client_adress_factTextBox.Location = New System.Drawing.Point(134, 32)
        Me.Client_adress_factTextBox.MaxLength = 500
        Me.Client_adress_factTextBox.Name = "Client_adress_factTextBox"
        Me.Client_adress_factTextBox.Size = New System.Drawing.Size(545, 20)
        Me.Client_adress_factTextBox.TabIndex = 7
        '
        'Client_adress_warehouseTextBox
        '
        Me.Client_adress_warehouseTextBox.CausesValidation = False
        Me.Client_adress_warehouseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_adress_warehouse", True))
        Me.Client_adress_warehouseTextBox.Location = New System.Drawing.Point(134, 58)
        Me.Client_adress_warehouseTextBox.MaxLength = 500
        Me.Client_adress_warehouseTextBox.Name = "Client_adress_warehouseTextBox"
        Me.Client_adress_warehouseTextBox.Size = New System.Drawing.Size(545, 20)
        Me.Client_adress_warehouseTextBox.TabIndex = 8
        '
        'Client_phoneMaskedTextBox
        '
        Me.Client_phoneMaskedTextBox.CausesValidation = False
        Me.Client_phoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_phone", True))
        Me.Client_phoneMaskedTextBox.Location = New System.Drawing.Point(331, 107)
        Me.Client_phoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.Client_phoneMaskedTextBox.Name = "Client_phoneMaskedTextBox"
        Me.Client_phoneMaskedTextBox.Size = New System.Drawing.Size(139, 20)
        Me.Client_phoneMaskedTextBox.TabIndex = 11
        '
        'Client_bank_nameComboBox
        '
        Me.Client_bank_nameComboBox.AllowDrop = True
        Me.Client_bank_nameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Client_bank_nameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Client_bank_nameComboBox.CausesValidation = False
        Me.Client_bank_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsR_clients, "client_bank_bik", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_bank_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Client_bank_nameComboBox.FormattingEnabled = True
        Me.Client_bank_nameComboBox.Location = New System.Drawing.Point(134, 84)
        Me.Client_bank_nameComboBox.Name = "Client_bank_nameComboBox"
        Me.Client_bank_nameComboBox.Size = New System.Drawing.Size(545, 21)
        Me.Client_bank_nameComboBox.TabIndex = 9
        '
        'Client_bank_accountMaskedTextBox
        '
        Me.Client_bank_accountMaskedTextBox.CausesValidation = False
        Me.Client_bank_accountMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_bank_account", True))
        Me.Client_bank_accountMaskedTextBox.Location = New System.Drawing.Point(134, 107)
        Me.Client_bank_accountMaskedTextBox.Mask = "00000000000000000000"
        Me.Client_bank_accountMaskedTextBox.Name = "Client_bank_accountMaskedTextBox"
        Me.Client_bank_accountMaskedTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Client_bank_accountMaskedTextBox.TabIndex = 10
        '
        'Client_regionComboBox
        '
        Me.Client_regionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Client_regionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Client_regionComboBox.CausesValidation = False
        Me.Client_regionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsR_clients, "client_region", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Client_regionComboBox.FormattingEnabled = True
        Me.Client_regionComboBox.Location = New System.Drawing.Point(68, 130)
        Me.Client_regionComboBox.Name = "Client_regionComboBox"
        Me.Client_regionComboBox.Size = New System.Drawing.Size(238, 21)
        Me.Client_regionComboBox.TabIndex = 12
        '
        'Client_region_rayonComboBox
        '
        Me.Client_region_rayonComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Client_region_rayonComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Client_region_rayonComboBox.CausesValidation = False
        Me.Client_region_rayonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsR_clients, "client_region_rayon", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_region_rayonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Client_region_rayonComboBox.FormattingEnabled = True
        Me.Client_region_rayonComboBox.Location = New System.Drawing.Point(367, 130)
        Me.Client_region_rayonComboBox.Name = "Client_region_rayonComboBox"
        Me.Client_region_rayonComboBox.Size = New System.Drawing.Size(314, 21)
        Me.Client_region_rayonComboBox.TabIndex = 13
        '
        'Client_representativeTextBox
        '
        Me.Client_representativeTextBox.CausesValidation = False
        Me.Client_representativeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_representative", True))
        Me.Client_representativeTextBox.Location = New System.Drawing.Point(96, 29)
        Me.Client_representativeTextBox.Name = "Client_representativeTextBox"
        Me.Client_representativeTextBox.Size = New System.Drawing.Size(210, 20)
        Me.Client_representativeTextBox.TabIndex = 5
        '
        'taR_clients
        '
        Me.taR_clients.ClearBeforeFill = True
        '
        'pnlFields
        '
        Me.pnlFields.CausesValidation = False
        Me.pnlFields.Controls.Add(Me.Label2)
        Me.pnlFields.Controls.Add(Me.txtAgreement)
        Me.pnlFields.Controls.Add(Me.Client_region_rayonComboBox)
        Me.pnlFields.Controls.Add(Client_region_rayonLabel)
        Me.pnlFields.Controls.Add(Me.Client_regionComboBox)
        Me.pnlFields.Controls.Add(Client_regionLabel)
        Me.pnlFields.Controls.Add(Client_adressLabel)
        Me.pnlFields.Controls.Add(Me.Client_bank_accountMaskedTextBox)
        Me.pnlFields.Controls.Add(Me.Client_adressTextBox)
        Me.pnlFields.Controls.Add(Client_bank_accountLabel)
        Me.pnlFields.Controls.Add(Client_adress_factLabel)
        Me.pnlFields.Controls.Add(Me.Client_bank_nameComboBox)
        Me.pnlFields.Controls.Add(Me.Client_adress_factTextBox)
        Me.pnlFields.Controls.Add(Client_bank_nameLabel)
        Me.pnlFields.Controls.Add(Client_adress_warehouseLabel)
        Me.pnlFields.Controls.Add(Me.Client_phoneMaskedTextBox)
        Me.pnlFields.Controls.Add(Me.Client_adress_warehouseTextBox)
        Me.pnlFields.Controls.Add(Client_phoneLabel)
        Me.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFields.Location = New System.Drawing.Point(0, 104)
        Me.pnlFields.Name = "pnlFields"
        Me.pnlFields.Size = New System.Drawing.Size(683, 180)
        Me.pnlFields.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(16, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Для договора"
        '
        'txtAgreement
        '
        Me.txtAgreement.CausesValidation = False
        Me.txtAgreement.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsR_clients, "client_face_agreement", True))
        Me.txtAgreement.Location = New System.Drawing.Point(100, 157)
        Me.txtAgreement.MaxLength = 500
        Me.txtAgreement.Name = "txtAgreement"
        Me.txtAgreement.Size = New System.Drawing.Size(581, 20)
        Me.txtAgreement.TabIndex = 14
        '
        'Client_typeLabel
        '
        Me.Client_typeLabel.AutoSize = True
        Me.Client_typeLabel.CausesValidation = False
        Me.Client_typeLabel.Location = New System.Drawing.Point(2, 7)
        Me.Client_typeLabel.Name = "Client_typeLabel"
        Me.Client_typeLabel.Size = New System.Drawing.Size(70, 13)
        Me.Client_typeLabel.TabIndex = 50
        Me.Client_typeLabel.Text = "Тип клиента"
        '
        'Client_typeComboBox
        '
        Me.Client_typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Client_typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Client_typeComboBox.CausesValidation = False
        Me.Client_typeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsR_clients, "client_type", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Client_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Client_typeComboBox.FormattingEnabled = True
        Me.Client_typeComboBox.Location = New System.Drawing.Point(96, 2)
        Me.Client_typeComboBox.Name = "Client_typeComboBox"
        Me.Client_typeComboBox.Size = New System.Drawing.Size(210, 21)
        Me.Client_typeComboBox.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pnlFieldsContainer
        '
        Me.pnlFieldsContainer.CausesValidation = False
        Me.pnlFieldsContainer.Controls.Add(Me.pnlFieldsType)
        Me.pnlFieldsContainer.Controls.Add(Me.pnlFieldsMain)
        Me.pnlFieldsContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFieldsContainer.Location = New System.Drawing.Point(0, 47)
        Me.pnlFieldsContainer.Name = "pnlFieldsContainer"
        Me.pnlFieldsContainer.Size = New System.Drawing.Size(683, 57)
        Me.pnlFieldsContainer.TabIndex = 51
        '
        'pnlFieldsType
        '
        Me.pnlFieldsType.CausesValidation = False
        Me.pnlFieldsType.Controls.Add(Me.Client_typeComboBox)
        Me.pnlFieldsType.Controls.Add(Client_representativeLabel)
        Me.pnlFieldsType.Controls.Add(Me.Client_typeLabel)
        Me.pnlFieldsType.Controls.Add(Me.Client_representativeTextBox)
        Me.pnlFieldsType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFieldsType.Location = New System.Drawing.Point(373, 0)
        Me.pnlFieldsType.Name = "pnlFieldsType"
        Me.pnlFieldsType.Size = New System.Drawing.Size(310, 57)
        Me.pnlFieldsType.TabIndex = 1
        '
        'pnlFieldsMain
        '
        Me.pnlFieldsMain.CausesValidation = False
        Me.pnlFieldsMain.Controls.Add(Me.btnNewINN)
        Me.pnlFieldsMain.Controls.Add(Me.Client_nameTextBox)
        Me.pnlFieldsMain.Controls.Add(Me.Client_kppMaskedTextBox)
        Me.pnlFieldsMain.Controls.Add(Me.Client_kppLabel)
        Me.pnlFieldsMain.Controls.Add(Me.Client_innMaskedTextBox)
        Me.pnlFieldsMain.Controls.Add(Client_nameLabel)
        Me.pnlFieldsMain.Controls.Add(Client_innLabel)
        Me.pnlFieldsMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFieldsMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlFieldsMain.Name = "pnlFieldsMain"
        Me.pnlFieldsMain.Size = New System.Drawing.Size(373, 57)
        Me.pnlFieldsMain.TabIndex = 0
        '
        'btnNewINN
        '
        Me.btnNewINN.CausesValidation = False
        Me.btnNewINN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewINN.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnNewINN.Location = New System.Drawing.Point(54, 28)
        Me.btnNewINN.Name = "btnNewINN"
        Me.btnNewINN.Size = New System.Drawing.Size(20, 20)
        Me.btnNewINN.TabIndex = 100
        Me.btnNewINN.Text = ">"
        Me.btnNewINN.UseVisualStyleBackColor = True
        '
        'frmClientsReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 309)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.pnlFields)
        Me.Controls.Add(Me.pnlFieldsContainer)
        Me.Controls.Add(Me.bnR_clients)
        Me.Controls.Add(Me.pnlSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.isEmptyForm = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmClientsReference"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Клиенты"
        Me.pnlSearch.ResumeLayout(False)
        CType(Me.bsR_clients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnR_clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnR_clients.ResumeLayout(False)
        Me.bnR_clients.PerformLayout()
        Me.pnlFields.ResumeLayout(False)
        Me.pnlFields.PerformLayout()
        Me.pnlFieldsContainer.ResumeLayout(False)
        Me.pnlFieldsType.ResumeLayout(False)
        Me.pnlFieldsType.PerformLayout()
        Me.pnlFieldsMain.ResumeLayout(False)
        Me.pnlFieldsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents bsR_clients As System.Windows.Forms.BindingSource
    Friend WithEvents taR_clients As Inspector.DocumentsTableAdapters.R_clientsTableAdapter
    Friend WithEvents bnR_clients As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents R_clientsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Client_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_innMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Client_kppMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Client_adressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_adress_factTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_adress_warehouseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_phoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Client_bank_nameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Client_bank_accountMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Client_regionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Client_region_rayonComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Client_representativeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dsDocuments As Inspector.Documents
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlFields As System.Windows.Forms.Panel
    Friend WithEvents Client_typeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Client_typeLabel As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtAgreement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlFieldsContainer As System.Windows.Forms.Panel
    Friend WithEvents pnlFieldsType As System.Windows.Forms.Panel
    Friend WithEvents pnlFieldsMain As System.Windows.Forms.Panel
    Friend WithEvents Client_kppLabel As System.Windows.Forms.Label
    Friend WithEvents btnNewINN As System.Windows.Forms.Button
End Class
