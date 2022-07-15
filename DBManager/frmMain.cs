using System;
using System.Windows.Forms;
using DBManager.Properties;
using System.IO;

namespace DBManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtServer.Text = SettingsLoader.Connection.server;
            txtUser.Text = SettingsLoader.Connection.user;
            txtPassword.Text = SettingsLoader.Connection.password;

            txtBackupPath.Text = Properties.Settings.Default.BackupPath;
            cbAskUser.Checked = SettingsLoader.askUser;
			cbAllowEditUnits.Checked = SettingsLoader.allowEditUnits;
		}

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            SettingsLoader.DBConnection cn = new SettingsLoader.DBConnection();
            cn.server = txtServer.Text;
            cn.user = txtUser.Text;
            cn.password = txtPassword.Text;

            bool res = Program.CheckConnection(cn);
            if (res)
            {
                MessageBox.Show("Подключение прошло успешно!", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            SettingsLoader.DBConnection cn = new SettingsLoader.DBConnection();
            cn.server = txtServer.Text;
            cn.user = txtUser.Text;
            cn.password = txtPassword.Text;

            if (Program.CheckConnection(cn))
                Program.SaveConnection(cn);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string backupPath = Settings.Default.BackupPath.Substring(0, Settings.Default.BackupPath.Length - 4) + DateTime.Now.Ticks.ToString() + ".bak";
            bool flag = CBackup.Get.BackupDatabase(backupPath) && Program.UpdateDB();
            Cursor.Current = Cursors.Default;

            if (flag)
            {
                MessageBox.Show("Программа обновлена!", "Сообщение", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Settings.Default.LastBackupPath = backupPath;
                Settings.Default.Save();
            }
            else
            {
                this.HelpRequested += new HelpEventHandler(frmMain_HelpRequested);
                MessageBox.Show("Не удалось обновить программу! \nСправка - открывает файл с сообщениями.",
                    "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1, 0, true);
                this.HelpRequested -= new HelpEventHandler(frmMain_HelpRequested);
            }
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Восстановить старую версию? Все данные, введённые с момента последнего резервного копирования будут потеряны!", 
                                "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                MessageBoxDefaultButton.Button2)
                == System.Windows.Forms.DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            bool flag = Program.RollbackDB();
            Cursor.Current = Cursors.Default;
            if (flag)
            {
                MessageBox.Show("Программа восстановлена до старой версии!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            else
            {
                base.HelpRequested += new HelpEventHandler(this.frmMain_HelpRequested);
                MessageBox.Show("Не удалось восстановить программу! \nСправка - открывает файл с сообщениями.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, 0, true);
                base.HelpRequested -= new HelpEventHandler(this.frmMain_HelpRequested);
            }
        }

        private void frmMain_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Diagnostics.Process.Start(Log.LogPath);
        }

        private void timerChecker_Tick(object sender, EventArgs e)
        {
            if (Program.autoStart)
            {
                timerChecker.Enabled = false;
                btnUpdate_Click(sender, new EventArgs());
                this.Close();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtBackupPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackupPath = txtBackupPath.Text;
            Properties.Settings.Default.Save();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bool success = CBackup.Get.BackupDatabase();
            Cursor.Current = Cursors.Default;            

            if (success)
                MessageBox.Show("Резервная копия создана!", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
            {
                this.HelpRequested += new HelpEventHandler(frmMain_HelpRequested);
                MessageBox.Show("Не удалось создать резервную копию! \nСправка - открывает файл с сообщениями.",
                    "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1, 0, true);
                this.HelpRequested -= new HelpEventHandler(frmMain_HelpRequested);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Восстановить БД из резервной копии?", 
                "Вопрос", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            Cursor.Current = Cursors.WaitCursor;
            bool success = CBackup.Get.RestoreDatabase();
            Cursor.Current = Cursors.Default;            

            if (success)
                MessageBox.Show("База восстановлена!", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
            {
                this.HelpRequested += new HelpEventHandler(frmMain_HelpRequested);
                MessageBox.Show("Не удалось восстановить базу! \nСправка - открывает файл с сообщениями.",
                    "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1, 0, true);
                this.HelpRequested -= new HelpEventHandler(frmMain_HelpRequested);
            }
        }

        private void cbAskUser_CheckedChanged(object sender, EventArgs e)
        {
            SettingsLoader.askUser = cbAskUser.Checked;
        }

		private void cbAllowEditUnits_CheckedChanged(object sender, EventArgs e)
		{
			SettingsLoader.allowEditUnits = cbAllowEditUnits.Checked;			
		}
	}
}