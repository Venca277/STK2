using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace STK2
{
    public partial class Form1 : KryptonForm
    {
        IniFile config;
        IniFile seenConfig;
        private string userName = "";
        private string password = "";
        private bool autolog = false;

        public Form1(bool notAfterLogout)
        {
            InitializeComponent();
            checkIntegrity();
            progressBar1.Visible = false;
            seenConfig = new IniFile(Paths.Seen);

            //fill login and password if autolog is enabled
            if (seenConfig.Read("User", "autolog") == "true" && notAfterLogout) {
                config = new IniFile(Path.Combine(Paths.Users + $"\\{seenConfig.Read("User", "Username")}", "config.ini"));
                //config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{seenConfig.Read("User", "Username")}\\", "config.ini"));
                loginTextBox.Text = config.Read("UserInfo", "Username");
                hesloTextBox.Text = config.Read("UserInfo", "Password");
                config.Write("Settings", "autolog", "true");
                autologCheckBox.Checked = true;
                autolog = true;
                kryptonButton1_Click(null, null);
            }
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (autolog)
            {
                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Maximum = 50;
                progressBar1.Value = 0;

                for (int i = 0; i <= 50; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(1);
                }
                progressBar1.Visible = false;
            }

            //gets access to config of user in case other wants to login
            config = new IniFile(Path.Combine(Paths.Users + $"\\{loginTextBox.Text}\\", "config.ini"));
            //config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{loginTextBox.Text}\\", "config.ini"));

            //checks if config exists
            if (config == null)
            {
                MessageBox.Show("Chyba při načítání konfiguračního souboru. Uzivatel neexistuje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //reads password and username from config of user
            password = config.Read("UserInfo", "Password");
            userName = config.Read("UserInfo", "Username");

            if (password == hesloTextBox.Text && userName == loginTextBox.Text)
            {
                config.Write("Settings", "autolog", autologCheckBox.Checked ? "true" : "false");
                if (!autolog)
                {
                    seenConfig.Write("User", "Username", loginTextBox.Text);
                    seenConfig.Write("User", "autolog", autologCheckBox.Checked ? "true" : "false");
                }

                this.Hide();
                STKmain stkmain = new STKmain(userName);
                stkmain.ShowDialog();
                this.Close();
            }

            label2.Text = "Nesprávné heslo!";
            hesloTextBox.Clear();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            CreateAccount createAccountForm = new CreateAccount();
            createAccountForm.ShowDialog();
        }

        private void checkIntegrity()
        {
            if (!Directory.Exists(Paths.AppFolder))
            {
                Directory.CreateDirectory(Paths.AppFolder);
            }
            if (!Directory.Exists(Paths.Users))
            {
                Directory.CreateDirectory(Paths.Users);
            }
            if (!File.Exists(Paths.Seen))
            {
                File.WriteAllText(Paths.Seen, "[User]\nUsername=\nautolog=false");
            }
            if (!File.Exists(Paths.Config))
            {
                File.WriteAllText(Paths.Config, "[\n]");
            }
        }
    }
}
