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
using Microsoft.VisualBasic;
using System.IO;
using Newtonsoft.Json;

namespace STK2
{
    public partial class STKmain : KryptonForm
    {
        private string userName;
        private int settingsIndex = -1;
        private int currentPanel = -1;
        private VozidloData vozidloData;

        public STKmain(string user)
        {
            InitializeComponent();
            this.userName = user;
            
            RefreshTreeView();
            ApplySettings();
            HidePanels();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            // notify user if no node is selected
            if (kryptonTreeView1.SelectedNode == null)
            {
                notifyIcon1.BalloonTipTitle = "Upozornění!";
                notifyIcon1.BalloonTipText = "Vyberte sekci pro Vaše vozidlo!";
                notifyIcon1.ShowBalloonTip(5000);

                return;
            }

            // selected node is not null and is exactly one under the root
            if (kryptonTreeView1.Nodes.Contains(kryptonTreeView1.SelectedNode.Parent))
            {

                //asks user to imput vehicle name
                string odpoved = Interaction.InputBox("Zadej název vozidla:", "Název - lze změnit později", "např Audi R8");
                odpoved = string.IsNullOrEmpty(odpoved) ? "temp1" : odpoved;
                TreeNode odpovedNode = new TreeNode(odpoved);
                kryptonTreeView1.SelectedNode.Nodes.Add(odpovedNode);

                //creates JSON file of the vehicle
                InitializeJSON(odpoved);

                //notifying user about successful addition
                notifyIcon1.BalloonTipTitle = "Upozornění!";
                notifyIcon1.BalloonTipText = $"Vozidlo {odpoved} bylo úspěšně vytvořeno!";
                notifyIcon1.ShowBalloonTip(5000);
                kryptonTreeView1.SelectedNode = odpovedNode;
            }
            // selected node is not allowed to add any subnodes
            else
            {
                notifyIcon1.BalloonTipTitle = "Upozornění!";
                notifyIcon1.BalloonTipText = $"Do této sekce ({kryptonTreeView1.SelectedNode.Text}) nezle vložit vozidlo!";
                notifyIcon1.ShowBalloonTip(5000);
            }
        }

        private void odebratButton_Click(object sender, EventArgs e)
        {
            if (!IsLeaf())
                return;

            var result = MessageBox.Show("Opravdu odebrat vozidlo?", "Potvrzení odebrání", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
                return;

            File.Delete(Path.Combine(Application.StartupPath, "users", userName, 
                kryptonTreeView1.SelectedNode.Parent.Parent.Name, kryptonTreeView1.SelectedNode.Parent.Name, 
                kryptonTreeView1.SelectedNode.Text + ".json"));

            kryptonTreeView1.SelectedNode.Remove();
            notifyIcon1.BalloonTipTitle = "Upozornění!";
            notifyIcon1.BalloonTipText = "Vozidlo bylo odebrano!";
            notifyIcon1.ShowBalloonTip(5000);
        }

        public void RefreshTreeView()
        {
            //kryptonTreeView1.Nodes.Clear();
            string[] sekce = Directory.GetDirectories(Path.Combine(Application.StartupPath, "users", userName));
            foreach (string sekcePath in sekce)
            {
                string[] typy = Directory.GetDirectories(sekcePath);
                foreach (string typ in typy)
                {
                    string[] files = Directory.GetFiles(typ, "*.json");
                    foreach (string file in files)
                    {
                        AppendNode(file);
                    }
                }
            }
        }

        public void AppendNode(string filepath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filepath);
            string[] dirs = Path.GetDirectoryName(filepath).Split(Path.DirectorySeparatorChar);
            string sectionName = dirs[dirs.Length - 2]; // Get the parent directory name
            string typeName = dirs[dirs.Length - 1]; // Get the current directory name

            foreach(TreeNode root in kryptonTreeView1.Nodes)
            {
                if(root.Name != sectionName)
                    continue;

                foreach (TreeNode typeNode in root.Nodes)
                {
                    if (typeNode.Name != typeName)
                        continue;

                    TreeNode newNode = new TreeNode(fileName);
                    typeNode.Nodes.Add(newNode);
                    return; // Exit after adding the node
                }
            }

        }

        public void ApplySettings() { 
            IniFile config = new IniFile(Path.Combine(Application.StartupPath, "users", userName, "config.ini"));
            if (config == null)
            {
                MessageBox.Show("Chyba při načítání konfiguračního souboru. Uzivatel neexistuje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            settingsIndex = Convert.ToInt32(config.Read("Settings", "show"));
            nameLabel.Text = config.Read("UserInfo", "Name");
        }

        public bool IsLeaf()
        {
            TreeNode node = kryptonTreeView1.SelectedNode;
            if (node == null)
                return false;

            if (kryptonTreeView1.Nodes.Contains(node.Parent))
                return false;

            if (node.Nodes.Count != 0)
                return false;

            return true;
        }

        private void kryptonTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!IsLeaf()) 
                return;
            TreeNode selectedNode = kryptonTreeView1.SelectedNode;
            //TODO: Load vehicle data from JSON file
            string json = File.ReadAllText(Path.Combine($"C:\\Users\\venca\\source\\repos\\STK2\\STK2\\bin\\Debug\\users\\{userName}\\" +
                    $"{selectedNode.Parent.Parent.Name}\\{selectedNode.Parent.Name}\\", selectedNode.Text + ".json"));
            vozidloData = JsonConvert.DeserializeObject<VozidloData>(json);

            //TODO : Show vehicle data in the appropriate panel
            LoadPanelData();
            HidePanels();
            switch (settingsIndex) {
                case 1:  zakladni_infoPanel.Visible = true; currentPanel = 1;
                    break;
                case 2:  stav_stkPanel.Visible = true; currentPanel = 2;
                    break;
                case 3:  technicke_udajePanel.Visible = true; currentPanel = 3;
                    break;
                case 4:  majitelPanel.Visible = true; currentPanel = 4;
                    break;
                case 5:  historiePanel.Visible = true; currentPanel = 5;
                    break;
                case -1:  zakladni_infoPanel.Visible = true; currentPanel = 1;
                    break;
                default:
                     zakladni_infoPanel.Visible = true; currentPanel = 1;
                    break;
            }
        }

        private void HidePanels() { 
            majitelPanel.Visible = false;
            historiePanel.Visible = false;
            stav_stkPanel.Visible = false;
            technicke_udajePanel.Visible = false;
            zakladni_infoPanel.Visible = false;
            zakladni_infoPanel.Location = new Point(290, 7);
            stav_stkPanel.Location = new Point(290, 7);
            technicke_udajePanel.Location = new Point(290, 7);
            majitelPanel.Location = new Point(290, 7);
            historiePanel.Location = new Point(290, 7);
        }
        
        private void InitializeJSON(string odpoved)
        {
            VozidloData data = new VozidloData
            {
                zakladniInfo = new ZakladniInfo(),
                stavSTK = new StavSTK(),
                technickeUdaje = new TechnickeUdaje(),
                majitel = new Majitel(),
                nehody = new Nehody()
            };
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(Path.Combine($"C:\\Users\\venca\\source\\repos\\STK2\\STK2\\bin\\Debug\\users\\{userName}\\" +
                    $"{kryptonTreeView1.SelectedNode.Parent.Name}\\{kryptonTreeView1.SelectedNode.Name}\\", odpoved + ".json"), json);
        }

        private void LoadPanelData()
        {
            LoadPanel1();
            LoadPanel2();
            LoadPanel3();
            LoadPanel4();
            LoadPanel5();
        }
        public void LoadPanel1() {
            //---------Panel 1---------------
            znacka_modeltxt.Text = vozidloData.zakladniInfo.znacka;
            druh_vozidlatxt.Text = vozidloData.zakladniInfo.druh;
            spz_rztxt.Text = vozidloData.zakladniInfo.spz;
            vintxt.Text = vozidloData.zakladniInfo.vin;
            var reg = vozidloData.zakladniInfo.prvni_registrace;
            registraceDateTimePicker.Value = (reg > registraceDateTimePicker.MinDate && reg < registraceDateTimePicker.MaxDate) ? reg : DateTime.Now;
            typ_variantatxt.Text = vozidloData.zakladniInfo.typ;
            barva_karoserietxt.Text = vozidloData.zakladniInfo.barva;
            //-------------------------------
        }
        public void LoadPanel2()
        {
            //---------Panel 2---------------
            var platSTK = vozidloData.stavSTK.platnostSTK;
            platnostSTKDateTimePicker.Value = (platSTK > platnostSTKDateTimePicker.MinDate && platSTK < platnostSTKDateTimePicker.MaxDate) ? platSTK : DateTime.Now;
            var platEK = vozidloData.stavSTK.platnostEmise;
            platnostEKDateTimePicker.Value = (platEK > platnostEKDateTimePicker.MinDate && platEK < platnostEKDateTimePicker.MaxDate) ? platEK : DateTime.Now;
            if (vozidloData.stavSTK.vysledekSTK) { vysledekSTKPanel.BackColor = Color.LimeGreen; label15.Text = "Platná"; }
            else { vysledekSTKPanel.BackColor = Color.Crimson; label15.Text = "Neplatná"; }
            if (vozidloData.stavSTK.vysledekEmise) { vysledekEKPanel.BackColor = Color.LimeGreen; label16.Text = "Platná"; }
            else { vysledekEKPanel.BackColor = Color.Crimson; label16.Text = "Neplatná"; }
            typSTKTextBox.Text = vozidloData.stavSTK.typSTK;
            var poslSTK = vozidloData.stavSTK.posledniSTK;
            posledniSTKDateTimePicker.Value = (poslSTK > posledniSTKDateTimePicker.MinDate && poslSTK < posledniSTKDateTimePicker.MaxDate) ? poslSTK : DateTime.Now;
            poznamkyTextBox.Text = vozidloData.stavSTK.poznamka;
            //-------------------------------
        }
        public void LoadPanel3()
        {
            //---------Panel 3---------------
            vykonTextBox.Text = vozidloData.technickeUdaje.vykon.ToString();
            palivoTextBox.Text = vozidloData.technickeUdaje.palivo;
            pohonTextBox.Text = vozidloData.technickeUdaje.pohon;
            hmotnostTextBox.Text = vozidloData.technickeUdaje.hmotnost.ToString();
            mistaTextBox.Text = vozidloData.technickeUdaje.pocetMist.ToString();
            pneuTextBox.Text = vozidloData.technickeUdaje.pneumatiky;
            rozmeryTextBox.Text = vozidloData.technickeUdaje.rozmery;
            //-------------------------------
        }
        public void LoadPanel4()
        {
            //---------Panel 4---------------
            vlastnikTextBox.Text = vozidloData.majitel.jmeno_vlastnik;
            provozovatelTextBox.Text = vozidloData.majitel.provozovatel;
            kontaktTextBox.Text = vozidloData.majitel.kontakt;
            poznamky_vlastnikBox.Text = vozidloData.majitel.poznamky;
            //-------------------------------
        }
        public void LoadPanel5()
        {
            //---------Panel 5---------------
            zaznamyTextBox.Text = vozidloData.nehody.zaznam;
            poznamkySTKTextBox.Text = vozidloData.nehody.poznamkykSTK;
            vlastnictviTextBox.Text = vozidloData.majitel.zmena_vlastnictvi;
            //-------------------------------
        }

        private void nastaveniLabel_LinkClicked(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(userName);
            settingsForm.ShowDialog();
        }

        private void logoutLabel_LinkClicked(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            if(currentPanel == -1)
                return;
            currentPanel = (currentPanel+1) > 5 ? 1 : currentPanel + 1;
            UpdatePanel();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            if (currentPanel == -1)
                return;
            currentPanel = (currentPanel - 1) < 1 ? 5 : currentPanel - 1;
            UpdatePanel();
        }

        private void UpdatePanel() {
            switch (currentPanel)
            {
                case 1:
                    zakladni_infoPanel.Visible = true; currentPanel = 1;
                    break;
                case 2:
                    stav_stkPanel.Visible = true; currentPanel = 2;
                    break;
                case 3:
                    technicke_udajePanel.Visible = true; currentPanel = 3;
                    break;
                case 4:
                    majitelPanel.Visible = true; currentPanel = 4;
                    break;
                case 5:
                    historiePanel.Visible = true; currentPanel = 5;
                    break;
                case -1:
                    zakladni_infoPanel.Visible = true; currentPanel = 1;
                    break;
                default:
                    zakladni_infoPanel.Visible = true; currentPanel = 1;
                    break;
            }
        }

        private void ulozitLabel_LinkClicked(object sender, EventArgs e)
        {
            if (!IsLeaf())
                return;

            //-----------------Panel 1-----------------
            vozidloData.zakladniInfo.znacka = znacka_modeltxt.Text;
            vozidloData.zakladniInfo.druh = druh_vozidlatxt.Text;
            vozidloData.zakladniInfo.spz = spz_rztxt.Text;
            vozidloData.zakladniInfo.vin = vintxt.Text;
            vozidloData.zakladniInfo.prvni_registrace = registraceDateTimePicker.Value;
            vozidloData.zakladniInfo.typ = typ_variantatxt.Text;
            vozidloData.zakladniInfo.barva = barva_karoserietxt.Text;
            //-----------------------------------------

            //---------------Panel 2-------------------
            vozidloData.stavSTK.platnostSTK = platnostSTKDateTimePicker.Value;
            vozidloData.stavSTK.platnostEmise = platnostEKDateTimePicker.Value;
            vozidloData.stavSTK.vysledekSTK = label15.Text == "Platná";
            vozidloData.stavSTK.vysledekEmise = label16.Text == "Platná";
            vozidloData.stavSTK.typSTK = typSTKTextBox.Text;
            vozidloData.stavSTK.posledniSTK = posledniSTKDateTimePicker.Value;
            vozidloData.stavSTK.poznamka = poznamkyTextBox.Text;
            //-----------------------------------------

            //---------------Panel 3-------------------
            int val;
            vozidloData.technickeUdaje.vykon = int.TryParse(vykonTextBox.Text, out val) ? val : 0;
            vozidloData.technickeUdaje.palivo = palivoTextBox.Text;
            vozidloData.technickeUdaje.pohon = pohonTextBox.Text;
            vozidloData.technickeUdaje.hmotnost = int.TryParse(hmotnostTextBox.Text, out val) ? val : 0;
            vozidloData.technickeUdaje.pocetMist = int.TryParse(mistaTextBox.Text, out val) ? val : 0;
            vozidloData.technickeUdaje.pneumatiky = pneuTextBox.Text;
            vozidloData.technickeUdaje.rozmery = rozmeryTextBox.Text;
            //-----------------------------------------

            //---------------Panel 4-------------------
            vozidloData.majitel.jmeno_vlastnik = vlastnikTextBox.Text;
            vozidloData.majitel.provozovatel = provozovatelTextBox.Text;
            vozidloData.majitel.kontakt = kontaktTextBox.Text;
            vozidloData.majitel.poznamky = poznamky_vlastnikBox.Text;
            //-----------------------------------------

            //---------------Panel 5-------------------
            vozidloData.nehody.zaznam = zaznamyTextBox.Text;
            vozidloData.nehody.poznamkykSTK = poznamkySTKTextBox.Text;
            vozidloData.majitel.zmena_vlastnictvi = vlastnictviTextBox.Text;
            //-----------------------------------------

            TreeNode node = kryptonTreeView1.SelectedNode;
            string json = JsonConvert.SerializeObject(vozidloData, Formatting.Indented);
            File.WriteAllText(Path.Combine($"C:\\Users\\venca\\source\\repos\\STK2\\STK2\\bin\\Debug\\users\\{userName}\\" +
                    $"{node.Parent.Parent.Name}\\{node.Parent.Name}\\", node.Text + ".json"), json);

            notifyIcon1.BalloonTipTitle = "Upozornění!";
            notifyIcon1.BalloonTipText = "Data vozidla byla úspěšně uložena!";
            notifyIcon1.ShowBalloonTip(5000);
        }

    }
}
