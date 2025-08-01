using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace STK2
{
    public partial class Personal : Form
    {
        string user;
        IniFile config;
        public Personal(string user)
        {
            this.user = user;
            InitializeComponent();
            config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{user}\\", "config.ini"));
            jmenoTextBox.Text = config.Read("UserInfo", "Name");
            emailTextBox.Text = config.Read("UserInfo", "email");
            telefonTextBox.Text = config.Read("UserInfo", "phone");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            config.Write("UserInfo", "Name", jmenoTextBox.Text);
            config.Write("UserInfo", "email", emailTextBox.Text);
            config.Write("UserInfo", "phone", telefonTextBox.Text);
            notifyIcon1.BalloonTipText = "Vaše osobní údaje byly aktualizovány.";
            notifyIcon1.ShowBalloonTip(1000);
            this.Close();
        }
    }
}
