using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;

namespace STK2
{
    public partial class Settings : KryptonForm
    {
        private string userName;
        public Settings(string user)
        {
            InitializeComponent();
            userName = user;
            zobrazitComboBox.SelectedIndex = 0;
        }

        private void stornoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ulozitButton_Click(object sender, EventArgs e)
        {
            IniFile config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{userName}\\", "config.ini"));
            config.Write("Settings", "autolog", autologCheckBox.Checked ? "true" : "false");
            config.Write("Settings", "emails", email_pripominkaCheckBox.Checked ? "true" : "false");
            config.Write("Settings", "cypher", sifrovaniCheckBox.Checked ? "true" : "false");
            config.Write("Settings", "show", zobrazitComboBox.SelectedIndex.ToString());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
