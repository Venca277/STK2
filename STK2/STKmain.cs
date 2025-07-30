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
                kryptonTreeView1.SelectedNode.Nodes.Add(odpoved);

                //creates JSON file of the vehicle
                InitializeJSON(odpoved);

                //notifying user about successful addition
                notifyIcon1.BalloonTipTitle = "Upozornění!";
                notifyIcon1.BalloonTipText = $"Vozidlo {odpoved} bylo úspěšně vytvořeno!";
                notifyIcon1.ShowBalloonTip(5000);

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
                    $"{selectedNode.Parent.Parent.Name}\\{selectedNode.Parent.Name}\\", selectedNode.Name + ".json"));
            vozidloData = JsonConvert.DeserializeObject<VozidloData>(json);

            //TODO : Show vehicle data in the appropriate panel
        }

        private void HidePanels() { 
            majitelPanel.Visible = false;
            historiePanel.Visible = false;
            stav_stkPanel.Visible = false;
            technicke_udajePanel.Visible = false;
            zakladni_infoPanel.Visible = false;
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
    }
}
