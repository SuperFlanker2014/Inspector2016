namespace DBManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tabDBManager = new System.Windows.Forms.TabControl();
			this.pageUpdateDB = new System.Windows.Forms.TabPage();
			this.pageConnection = new System.Windows.Forms.TabPage();
			this.btnCheckConnection = new System.Windows.Forms.Button();
			this.btnSaveConnection = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.pageBackup = new System.Windows.Forms.TabPage();
			this.btnRestore = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBackupPath = new System.Windows.Forms.TextBox();
			this.btnBackup = new System.Windows.Forms.Button();
			this.pageOptions = new System.Windows.Forms.TabPage();
			this.cbAllowEditUnits = new System.Windows.Forms.CheckBox();
			this.cbAskUser = new System.Windows.Forms.CheckBox();
			this.timerChecker = new System.Windows.Forms.Timer(this.components);
			this.tabDBManager.SuspendLayout();
			this.pageUpdateDB.SuspendLayout();
			this.pageConnection.SuspendLayout();
			this.pageBackup.SuspendLayout();
			this.pageOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(8, 6);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(523, 23);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Обновить";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tabDBManager
			// 
			this.tabDBManager.Controls.Add(this.pageUpdateDB);
			this.tabDBManager.Controls.Add(this.pageConnection);
			this.tabDBManager.Controls.Add(this.pageBackup);
			this.tabDBManager.Controls.Add(this.pageOptions);
			this.tabDBManager.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabDBManager.Location = new System.Drawing.Point(0, 0);
			this.tabDBManager.Name = "tabDBManager";
			this.tabDBManager.SelectedIndex = 0;
			this.tabDBManager.Size = new System.Drawing.Size(547, 239);
			this.tabDBManager.TabIndex = 3;
			// 
			// pageUpdateDB
			// 
			this.pageUpdateDB.Controls.Add(this.btnUpdate);
			this.pageUpdateDB.Location = new System.Drawing.Point(4, 22);
			this.pageUpdateDB.Name = "pageUpdateDB";
			this.pageUpdateDB.Padding = new System.Windows.Forms.Padding(3);
			this.pageUpdateDB.Size = new System.Drawing.Size(539, 213);
			this.pageUpdateDB.TabIndex = 0;
			this.pageUpdateDB.Text = "Обновление  БД";
			this.pageUpdateDB.UseVisualStyleBackColor = true;
			// 
			// pageConnection
			// 
			this.pageConnection.Controls.Add(this.btnCheckConnection);
			this.pageConnection.Controls.Add(this.btnSaveConnection);
			this.pageConnection.Controls.Add(this.label3);
			this.pageConnection.Controls.Add(this.label2);
			this.pageConnection.Controls.Add(this.label1);
			this.pageConnection.Controls.Add(this.txtPassword);
			this.pageConnection.Controls.Add(this.txtUser);
			this.pageConnection.Controls.Add(this.txtServer);
			this.pageConnection.Location = new System.Drawing.Point(4, 22);
			this.pageConnection.Name = "pageConnection";
			this.pageConnection.Padding = new System.Windows.Forms.Padding(3);
			this.pageConnection.Size = new System.Drawing.Size(539, 213);
			this.pageConnection.TabIndex = 1;
			this.pageConnection.Text = "Подключение к БД";
			this.pageConnection.UseVisualStyleBackColor = true;
			// 
			// btnCheckConnection
			// 
			this.btnCheckConnection.Location = new System.Drawing.Point(11, 90);
			this.btnCheckConnection.Name = "btnCheckConnection";
			this.btnCheckConnection.Size = new System.Drawing.Size(162, 23);
			this.btnCheckConnection.TabIndex = 7;
			this.btnCheckConnection.Text = "Проверить подключение";
			this.btnCheckConnection.UseVisualStyleBackColor = true;
			this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
			// 
			// btnSaveConnection
			// 
			this.btnSaveConnection.Location = new System.Drawing.Point(190, 90);
			this.btnSaveConnection.Name = "btnSaveConnection";
			this.btnSaveConnection.Size = new System.Drawing.Size(165, 23);
			this.btnSaveConnection.TabIndex = 6;
			this.btnSaveConnection.Text = "Сохранить";
			this.btnSaveConnection.UseVisualStyleBackColor = true;
			this.btnSaveConnection.Click += new System.EventHandler(this.btnSaveConnection_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Пароль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Пользователь";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Сервер";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(92, 58);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(263, 20);
			this.txtPassword.TabIndex = 2;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(92, 32);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(263, 20);
			this.txtUser.TabIndex = 1;
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(92, 6);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(263, 20);
			this.txtServer.TabIndex = 0;
			// 
			// pageBackup
			// 
			this.pageBackup.Controls.Add(this.btnRestore);
			this.pageBackup.Controls.Add(this.label4);
			this.pageBackup.Controls.Add(this.txtBackupPath);
			this.pageBackup.Controls.Add(this.btnBackup);
			this.pageBackup.Location = new System.Drawing.Point(4, 22);
			this.pageBackup.Name = "pageBackup";
			this.pageBackup.Size = new System.Drawing.Size(539, 213);
			this.pageBackup.TabIndex = 2;
			this.pageBackup.Text = "Резервное копирование";
			this.pageBackup.UseVisualStyleBackColor = true;
			// 
			// btnRestore
			// 
			this.btnRestore.Location = new System.Drawing.Point(186, 29);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(169, 23);
			this.btnRestore.TabIndex = 4;
			this.btnRestore.Text = "Восстановить БД";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Путь для резервной копии";
			// 
			// txtBackupPath
			// 
			this.txtBackupPath.Location = new System.Drawing.Point(156, 3);
			this.txtBackupPath.Name = "txtBackupPath";
			this.txtBackupPath.Size = new System.Drawing.Size(200, 20);
			this.txtBackupPath.TabIndex = 2;
			this.txtBackupPath.TextChanged += new System.EventHandler(this.txtBackupPath_TextChanged);
			// 
			// btnBackup
			// 
			this.btnBackup.Location = new System.Drawing.Point(11, 29);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(169, 23);
			this.btnBackup.TabIndex = 0;
			this.btnBackup.Text = "Сохранить БД";
			this.btnBackup.UseVisualStyleBackColor = true;
			this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
			// 
			// pageOptions
			// 
			this.pageOptions.Controls.Add(this.cbAllowEditUnits);
			this.pageOptions.Controls.Add(this.cbAskUser);
			this.pageOptions.Location = new System.Drawing.Point(4, 22);
			this.pageOptions.Name = "pageOptions";
			this.pageOptions.Size = new System.Drawing.Size(539, 213);
			this.pageOptions.TabIndex = 3;
			this.pageOptions.Text = "Настройки";
			this.pageOptions.UseVisualStyleBackColor = true;
			// 
			// cbAllowEditUnits
			// 
			this.cbAllowEditUnits.AutoSize = true;
			this.cbAllowEditUnits.Location = new System.Drawing.Point(8, 26);
			this.cbAllowEditUnits.Name = "cbAllowEditUnits";
			this.cbAllowEditUnits.Size = new System.Drawing.Size(327, 17);
			this.cbAllowEditUnits.TabIndex = 1;
			this.cbAllowEditUnits.Text = "Разрешить редактирование \"Единицы измерения (услуги)\"";
			this.cbAllowEditUnits.UseVisualStyleBackColor = true;
			this.cbAllowEditUnits.CheckedChanged += new System.EventHandler(this.cbAllowEditUnits_CheckedChanged);
			// 
			// cbAskUser
			// 
			this.cbAskUser.AutoSize = true;
			this.cbAskUser.Location = new System.Drawing.Point(8, 3);
			this.cbAskUser.Name = "cbAskUser";
			this.cbAskUser.Size = new System.Drawing.Size(185, 17);
			this.cbAskUser.TabIndex = 0;
			this.cbAskUser.Text = "Спрашивать имя пользователя";
			this.cbAskUser.UseVisualStyleBackColor = true;
			this.cbAskUser.CheckedChanged += new System.EventHandler(this.cbAskUser_CheckedChanged);
			// 
			// timerChecker
			// 
			this.timerChecker.Enabled = true;
			this.timerChecker.Interval = 500;
			this.timerChecker.Tick += new System.EventHandler(this.timerChecker_Tick);
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 239);
			this.Controls.Add(this.tabDBManager);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Настройка программы Inspector.exe";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tabDBManager.ResumeLayout(false);
			this.pageUpdateDB.ResumeLayout(false);
			this.pageConnection.ResumeLayout(false);
			this.pageConnection.PerformLayout();
			this.pageBackup.ResumeLayout(false);
			this.pageBackup.PerformLayout();
			this.pageOptions.ResumeLayout(false);
			this.pageOptions.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabControl tabDBManager;
        private System.Windows.Forms.TabPage pageUpdateDB;
        private System.Windows.Forms.TabPage pageConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Button btnSaveConnection;
        private System.Windows.Forms.Timer timerChecker;
        private System.Windows.Forms.TabPage pageBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TabPage pageOptions;
        private System.Windows.Forms.CheckBox cbAskUser;
		private System.Windows.Forms.CheckBox cbAllowEditUnits;
	}
}

