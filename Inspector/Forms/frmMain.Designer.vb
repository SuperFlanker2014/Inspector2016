<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.btnDocuments = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnActs = New System.Windows.Forms.ToolStripMenuItem
        Me.btnConclusonsImport = New System.Windows.Forms.ToolStripMenuItem
        Me.btnConclusonsExport = New System.Windows.Forms.ToolStripMenuItem
        Me.btnConclusonsObjects = New System.Windows.Forms.ToolStripMenuItem
        Me.btnExaminations = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPayments = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnAgreements = New System.Windows.Forms.ToolStripMenuItem
        Me.btnBillsPre = New System.Windows.Forms.ToolStripMenuItem
        Me.btnBillsPost = New System.Windows.Forms.ToolStripMenuItem
        Me.btnClients = New System.Windows.Forms.ToolStripButton
        Me.btnChooseReference = New System.Windows.Forms.ToolStripButton
        Me.btnReports = New System.Windows.Forms.ToolStripButton
        Me.btnOptions = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.mnuContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДокументыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.АктыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ЗаключенияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ЗаключениявывозToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ЗаключенияНаОбъектыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.СвидетельстваЭкспертизыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ПлатежиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ДоговорыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.СчетаНаПредоплатуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.СчетафактурыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cnotextActs = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.contextReferences = New System.Windows.Forms.ToolStripMenuItem
        Me.ОтчётыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile = New System.Windows.Forms.MenuStrip
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.СменитьПарольToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ОкнаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip.SuspendLayout()
        Me.mnuContext.SuspendLayout()
        Me.mnuFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDocuments, Me.btnPayments, Me.btnClients, Me.btnChooseReference, Me.btnReports, Me.btnOptions})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(841, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnDocuments
        '
        Me.btnDocuments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDocuments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActs, Me.btnConclusonsImport, Me.btnConclusonsExport, Me.btnConclusonsObjects, Me.btnExaminations})
        Me.btnDocuments.Image = CType(resources.GetObject("btnDocuments.Image"), System.Drawing.Image)
        Me.btnDocuments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDocuments.Name = "btnDocuments"
        Me.btnDocuments.Size = New System.Drawing.Size(29, 22)
        Me.btnDocuments.Text = "Документы"
        '
        'btnActs
        '
        Me.btnActs.Name = "btnActs"
        Me.btnActs.Size = New System.Drawing.Size(215, 22)
        Me.btnActs.Text = "Акты"
        '
        'btnConclusonsImport
        '
        Me.btnConclusonsImport.Name = "btnConclusonsImport"
        Me.btnConclusonsImport.Size = New System.Drawing.Size(215, 22)
        Me.btnConclusonsImport.Text = "Заключения (ввоз)"
        '
        'btnConclusonsExport
        '
        Me.btnConclusonsExport.Name = "btnConclusonsExport"
        Me.btnConclusonsExport.Size = New System.Drawing.Size(215, 22)
        Me.btnConclusonsExport.Text = "Заключения (вывоз)"
        '
        'btnConclusonsObjects
        '
        Me.btnConclusonsObjects.Name = "btnConclusonsObjects"
        Me.btnConclusonsObjects.Size = New System.Drawing.Size(215, 22)
        Me.btnConclusonsObjects.Text = "Заключения на объекты"
        '
        'btnExaminations
        '
        Me.btnExaminations.Name = "btnExaminations"
        Me.btnExaminations.Size = New System.Drawing.Size(215, 22)
        Me.btnExaminations.Text = "Свидетельства экспертизы"
        '
        'btnPayments
        '
        Me.btnPayments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPayments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgreements, Me.btnBillsPre, Me.btnBillsPost})
        Me.btnPayments.Image = CType(resources.GetObject("btnPayments.Image"), System.Drawing.Image)
        Me.btnPayments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(29, 22)
        Me.btnPayments.Text = "Платежи"
        '
        'btnAgreements
        '
        Me.btnAgreements.Name = "btnAgreements"
        Me.btnAgreements.Size = New System.Drawing.Size(184, 22)
        Me.btnAgreements.Text = "Договоры"
        '
        'btnBillsPre
        '
        Me.btnBillsPre.Name = "btnBillsPre"
        Me.btnBillsPre.Size = New System.Drawing.Size(184, 22)
        Me.btnBillsPre.Text = "Счета на предоплату"
        '
        'btnBillsPost
        '
        Me.btnBillsPost.Name = "btnBillsPost"
        Me.btnBillsPost.Size = New System.Drawing.Size(184, 22)
        Me.btnBillsPost.Text = "Счета-фактуры"
        '
        'btnClients
        '
        Me.btnClients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClients.Image = CType(resources.GetObject("btnClients.Image"), System.Drawing.Image)
        Me.btnClients.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(23, 22)
        Me.btnClients.Text = "Клиенты"
        '
        'btnChooseReference
        '
        Me.btnChooseReference.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChooseReference.Image = CType(resources.GetObject("btnChooseReference.Image"), System.Drawing.Image)
        Me.btnChooseReference.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChooseReference.Name = "btnChooseReference"
        Me.btnChooseReference.Size = New System.Drawing.Size(23, 22)
        Me.btnChooseReference.Text = "Справочники"
        '
        'btnReports
        '
        Me.btnReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(23, 22)
        Me.btnReports.Text = "Отчёты"
        '
        'btnOptions
        '
        Me.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOptions.Image = CType(resources.GetObject("btnOptions.Image"), System.Drawing.Image)
        Me.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(23, 22)
        Me.btnOptions.Text = "ToolStripButton1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 476)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(841, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'mnuContext
        '
        Me.mnuContext.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.mnuContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДокументыToolStripMenuItem, Me.ПлатежиToolStripMenuItem, Me.ToolStripMenuItem2, Me.cnotextActs, Me.ToolStripMenuItem1, Me.contextReferences, Me.ОтчётыToolStripMenuItem, Me.НастройкиToolStripMenuItem})
        Me.mnuContext.Name = "ToolsContextMenu"
        Me.mnuContext.ShowItemToolTips = False
        Me.mnuContext.Size = New System.Drawing.Size(142, 148)
        '
        'ДокументыToolStripMenuItem
        '
        Me.ДокументыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.АктыToolStripMenuItem, Me.ЗаключенияToolStripMenuItem, Me.ЗаключениявывозToolStripMenuItem, Me.ЗаключенияНаОбъектыToolStripMenuItem, Me.СвидетельстваЭкспертизыToolStripMenuItem})
        Me.ДокументыToolStripMenuItem.Image = CType(resources.GetObject("ДокументыToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ДокументыToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ДокументыToolStripMenuItem.Name = "ДокументыToolStripMenuItem"
        Me.ДокументыToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ДокументыToolStripMenuItem.Text = "Документы"
        '
        'АктыToolStripMenuItem
        '
        Me.АктыToolStripMenuItem.Name = "АктыToolStripMenuItem"
        Me.АктыToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.АктыToolStripMenuItem.Text = "Акты"
        '
        'ЗаключенияToolStripMenuItem
        '
        Me.ЗаключенияToolStripMenuItem.Name = "ЗаключенияToolStripMenuItem"
        Me.ЗаключенияToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ЗаключенияToolStripMenuItem.Text = "Заключения (ввоз)"
        '
        'ЗаключениявывозToolStripMenuItem
        '
        Me.ЗаключениявывозToolStripMenuItem.Name = "ЗаключениявывозToolStripMenuItem"
        Me.ЗаключениявывозToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ЗаключениявывозToolStripMenuItem.Text = "Заключения (вывоз)"
        '
        'ЗаключенияНаОбъектыToolStripMenuItem
        '
        Me.ЗаключенияНаОбъектыToolStripMenuItem.Name = "ЗаключенияНаОбъектыToolStripMenuItem"
        Me.ЗаключенияНаОбъектыToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ЗаключенияНаОбъектыToolStripMenuItem.Text = "Заключения на объекты"
        '
        'СвидетельстваЭкспертизыToolStripMenuItem
        '
        Me.СвидетельстваЭкспертизыToolStripMenuItem.Name = "СвидетельстваЭкспертизыToolStripMenuItem"
        Me.СвидетельстваЭкспертизыToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.СвидетельстваЭкспертизыToolStripMenuItem.Text = "Свидетельства экспертизы"
        '
        'ПлатежиToolStripMenuItem
        '
        Me.ПлатежиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДоговорыToolStripMenuItem, Me.СчетаНаПредоплатуToolStripMenuItem, Me.СчетафактурыToolStripMenuItem})
        Me.ПлатежиToolStripMenuItem.Image = CType(resources.GetObject("ПлатежиToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ПлатежиToolStripMenuItem.Name = "ПлатежиToolStripMenuItem"
        Me.ПлатежиToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ПлатежиToolStripMenuItem.Text = "Платежи"
        '
        'ДоговорыToolStripMenuItem
        '
        Me.ДоговорыToolStripMenuItem.Name = "ДоговорыToolStripMenuItem"
        Me.ДоговорыToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ДоговорыToolStripMenuItem.Text = "Договоры"
        '
        'СчетаНаПредоплатуToolStripMenuItem
        '
        Me.СчетаНаПредоплатуToolStripMenuItem.Name = "СчетаНаПредоплатуToolStripMenuItem"
        Me.СчетаНаПредоплатуToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.СчетаНаПредоплатуToolStripMenuItem.Text = "Счета на предоплату"
        '
        'СчетафактурыToolStripMenuItem
        '
        Me.СчетафактурыToolStripMenuItem.Name = "СчетафактурыToolStripMenuItem"
        Me.СчетафактурыToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.СчетафактурыToolStripMenuItem.Text = "Счета-фактуры"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(138, 6)
        '
        'cnotextActs
        '
        Me.cnotextActs.Image = CType(resources.GetObject("cnotextActs.Image"), System.Drawing.Image)
        Me.cnotextActs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cnotextActs.Name = "cnotextActs"
        Me.cnotextActs.Size = New System.Drawing.Size(141, 22)
        Me.cnotextActs.Text = "Клиенты"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(138, 6)
        '
        'contextReferences
        '
        Me.contextReferences.Image = CType(resources.GetObject("contextReferences.Image"), System.Drawing.Image)
        Me.contextReferences.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.contextReferences.Name = "contextReferences"
        Me.contextReferences.Size = New System.Drawing.Size(141, 22)
        Me.contextReferences.Text = "Справочники"
        '
        'ОтчётыToolStripMenuItem
        '
        Me.ОтчётыToolStripMenuItem.Image = CType(resources.GetObject("ОтчётыToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ОтчётыToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.ОтчётыToolStripMenuItem.Name = "ОтчётыToolStripMenuItem"
        Me.ОтчётыToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ОтчётыToolStripMenuItem.Text = "Отчёты"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.Image = CType(resources.GetObject("НастройкиToolStripMenuItem.Image"), System.Drawing.Image)
        Me.НастройкиToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'mnuFile
        '
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ОкнаToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.MdiWindowListItem = Me.ОкнаToolStripMenuItem
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(841, 24)
        Me.mnuFile.TabIndex = 9
        Me.mnuFile.Text = "Файл"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СменитьПарольToolStripMenuItem, Me.ОПрограммеToolStripMenuItem, Me.ToolStripMenuItem3, Me.ВыходToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СменитьПарольToolStripMenuItem
        '
        Me.СменитьПарольToolStripMenuItem.Name = "СменитьПарольToolStripMenuItem"
        Me.СменитьПарольToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.СменитьПарольToolStripMenuItem.Text = "Сменить пароль..."
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(165, 6)
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'ОкнаToolStripMenuItem
        '
        Me.ОкнаToolStripMenuItem.Name = "ОкнаToolStripMenuItem"
        Me.ОкнаToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ОкнаToolStripMenuItem.Text = "Окна"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 498)
        Me.ContextMenuStrip = Me.mnuContext
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.mnuFile)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "frmMain"
        Me.Text = "Документооборот референтного центра"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.mnuContext.ResumeLayout(False)
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cnotextActs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contextReferences As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnChooseReference As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnClients As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFile As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СменитьПарольToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОкнаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДокументыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents АктыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаключенияToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаключениявывозToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDocuments As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnActs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnConclusonsImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnConclusonsExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnConclusonsObjects As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаключенияНаОбъектыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПлатежиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPayments As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnAgreements As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДоговорыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillsPre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СчетаНаПредоплатуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillsPost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СчетафактурыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnReports As System.Windows.Forms.ToolStripButton
    Friend WithEvents ОтчётыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents НастройкиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExaminations As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СвидетельстваЭкспертизыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
