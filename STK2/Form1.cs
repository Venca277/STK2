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
        private string password = "";
        public Form1()
        {
            InitializeComponent();
            this.config = new IniFile(Path.Combine(Application.StartupPath, "config.ini"));
            password = config.Read("UserInfo", "Password");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if(password == kryptonTextBox1.Text)
            {
                this.Hide();
                STKmain stkmain = new STKmain();
                stkmain.ShowDialog();
                this.Close();
            }

            label2.Text = "Nesprávné heslo!";
            kryptonTextBox1.Clear();
        }
    }
}
