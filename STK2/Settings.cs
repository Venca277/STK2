using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STK2
{
    public partial class Settings : KryptonForm
    {
        IniFile config;
        IniFile seenConfig;
        private string userName;
        public Settings(string user)
        {
            InitializeComponent();
            userName = user;
            config = new IniFile(Path.Combine(Application.StartupPath + $"\\users\\{userName}\\", "config.ini"));

            jmenoLabel.Text = config.Read("UserInfo", "Name");
            emailLinkLabel.Text = config.Read("UserInfo", "email");
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
            seenConfig = new IniFile(Path.Combine(Application.StartupPath, "seen.ini"));
            seenConfig.Write("User", "autolog", autologCheckBox.Checked ? "true" : "false");
            MessageBox.Show("Nastavení byla uložena.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Personal personalForm = new Personal(userName);
            personalForm.ShowDialog();
            jmenoLabel.Text = config.Read("UserInfo", "Name");
            emailLinkLabel.Text = config.Read("UserInfo", "email");
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            var odpoved = MessageBox.Show("Opravdu chcete smazat plánovače? Tato akce vypne emailové upomínky! Obnova oznámení proběhne po restartu programu pokud je možnost zaškrtnutá.", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (odpoved == DialogResult.Yes) {
                string nazevUkoluDaily = "STKReminder_Daily";
                string nazevUkoluOnLogon = "STKReminder_OnLogon";
                string prikaz1 = $@"/Delete /TN ""{nazevUkoluDaily}"" /F";
                string prikaz2 = $@"/Delete /TN ""{nazevUkoluOnLogon}"" /F";
                Process.Start("schtasks", prikaz1);
                Process.Start("schtasks", prikaz2);
            }
            else
            {
                return;
            }
        }
    }
}
