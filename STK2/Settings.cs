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
        IniFile config;
        private string userName;
        public Settings(string user)
        {
            InitializeComponent();
            userName = user;
            config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{userName}\\", "config.ini"));

            autologCheckBox.Checked = config.Read("Settings", "autolog") == "true";
            email_pripominkaCheckBox.Checked = config.Read("Settings", "emails") == "true";
            sifrovaniCheckBox.Checked = config.Read("Settings", "cypher") == "true";
            zobrazitComboBox.SelectedIndex = int.TryParse(config.Read("Settings", "show"), out int index) ? index : 0;
        }

        private void stornoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ulozitButton_Click(object sender, EventArgs e)
        {
            config.Write("Settings", "autolog", autologCheckBox.Checked ? "true" : "false");
            config.Write("Settings", "emails", email_pripominkaCheckBox.Checked ? "true" : "false");
            config.Write("Settings", "cypher", sifrovaniCheckBox.Checked ? "true" : "false");
            config.Write("Settings", "show", zobrazitComboBox.SelectedIndex.ToString());

            MessageBox.Show("Nastavení byla uložena.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
