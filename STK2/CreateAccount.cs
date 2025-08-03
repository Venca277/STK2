using ComponentFactory.Krypton.Toolkit;
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

namespace STK2
{
    public partial class CreateAccount : KryptonForm
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        public static bool IsValidUsername(string username)
        {
            // forbidden characters in filenames
            char[] invalidChars = Path.GetInvalidFileNameChars();

            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (username.Any(c => invalidChars.Contains(c)))
                return false;

            // forbidden names in Windows
            string[] reservedNames = {
            "CON", "PRN", "AUX", "NUL",
            "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9",
            "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"
            };

            if (reservedNames.Contains(username.ToUpper()))
                return false;

            return true;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!IsValidUsername(loginTextBox.Text))
            {
                errorLabel.Text = "Neplatné znaky v uživatelském jméně!";
                return;
            }

            if(Directory.Exists(Path.Combine(Paths.Users, loginTextBox.Text)))
            {
                errorLabel.Text = "Uživatel již existuje!";
                return;
            }

            if (string.IsNullOrEmpty(heslo2TextBox.Text) || string.IsNullOrEmpty(hesloTextBox.Text) || hesloTextBox.Text != heslo2TextBox.Text) {
                errorLabel.Text = "Hesla nesmí být prázdná a musí se shodovat!";
                return;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(telefonTextBox.Text)) {
                errorLabel.Text = "Email a telefon nesmí být prázdné!";
                return;
            }

            if (string.IsNullOrEmpty(jmenoTextBox.Text)) {
                errorLabel.Text = "Jméno nesmí být prázdné!";
                return;
            }

            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text));
            string defaultIni =
                $@"[UserInfo]
                Password={hesloTextBox.Text}
                Username={loginTextBox.Text}
                Name={jmenoTextBox.Text}
                email={emailTextBox.Text}
                phone={telefonTextBox.Text}

                [Settings]
                autolog=false
                emails=false
                cypher=true
                show=2
                ";
            File.WriteAllText(Path.Combine(Paths.Users, loginTextBox.Text, "config.ini"), defaultIni, Encoding.Unicode);

            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "silnicni_vozidla"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "silnicni_vozidla", "karavany"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "silnicni_vozidla", "motocykly"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "silnicni_vozidla", "nakladni"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "silnicni_vozidla", "osobni"));

            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "specialni_vozidla"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "specialni_vozidla", "specialni_vozidla"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "specialni_vozidla", "stavebni_technika"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "specialni_vozidla", "vojenska_technika"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "specialni_vozidla", "zemedelska_technika"));

            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "plavidla"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "plavidla", "mala_plavidla"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "plavidla", "velka_plavidla"));

            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "letouny"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "letouny", "dopravni_letadla"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "letouny", "mala_letadla"));
            Directory.CreateDirectory(Path.Combine(Paths.Users, loginTextBox.Text, "letouny", "vrtulniky"));

            notifyIcon1.BalloonTipText = "Účet byl úspěšně vytvořen!";
            notifyIcon1.BalloonTipTitle = "Účet vytvořen";
            notifyIcon1.ShowBalloonTip(3000);
            this.Close();
        }
    }
}
