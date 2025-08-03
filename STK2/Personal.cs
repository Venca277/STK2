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
            config = new IniFile(Path.Combine(Paths.Users, user, "config.ini"));
            jmenoTextBox.Text = config.Read("UserInfo", "Name");
            emailTextBox.Text = config.Read("UserInfo", "email");
            telefonTextBox.Text = config.Read("UserInfo", "phone");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("POZOR! Změna osobních údajů má vliv na emailové oznámení! PROJDĚTE A ULOŽTE svá vozidla, aby došlo k propsání změn, zejména emailové adresy. Pokud emailová oznámení nepoužíváte toto oznámení se vás netýka.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            config.Write("UserInfo", "Name", jmenoTextBox.Text);
            config.Write("UserInfo", "email", emailTextBox.Text);
            config.Write("UserInfo", "phone", telefonTextBox.Text);
            notifyIcon1.BalloonTipText = "Vaše osobní údaje byly aktualizovány.";
            notifyIcon1.ShowBalloonTip(1000);
            this.Close();
        }
    }
}
