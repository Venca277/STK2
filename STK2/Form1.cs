using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace STK2
{
    public partial class Form1 : KryptonForm
    {
        IniFile config;
        private string userName = "";
        private string password = "";
        public Form1()
        {
            InitializeComponent();
            this.config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\", "seen.ini"));
            if (config.Read("User", "autolog") == "true") {
                this.config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{config.Read("User", "Username")}\\", "config.ini"));-----------------------
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {



            this.config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{loginTextBox.Text}\\", "config.ini"));

            if (config == null){
                MessageBox.Show("Chyba při načítání konfiguračního souboru. Uzivatel neexistuje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            password = config.Read("UserInfo", "Password");
            userName = config.Read("UserInfo", "Username");

            if (password == hesloTextBox.Text && userName == loginTextBox.Text)
            {



                this.Hide();
                STKmain stkmain = new STKmain(userName);
                stkmain.ShowDialog();
                this.Close();
            }

            label2.Text = "Nesprávné heslo!";
            hesloTextBox.Clear();
        }
    }
}
