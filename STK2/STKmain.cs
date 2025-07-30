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

namespace STK2
{
    public partial class STKmain : KryptonForm
    {
        public STKmain()
        {
            InitializeComponent();

            // Zaoblené rohy pro KryptonPanel1
           
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_Enter(object sender, EventArgs e)
        {
            kryptonComboBox1.SelectionStart = kryptonComboBox1.Text.Length;
            kryptonComboBox1.SelectionLength = 0;
        }

        private void kryptonComboBox1_Click(object sender, EventArgs e)
        {
            kryptonComboBox1.SelectionStart = kryptonComboBox1.Text.Length;
            kryptonComboBox1.SelectionLength = 0;
        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            // notify user if no node is selected
            if (kryptonTreeView1.SelectedNode == null) {
                notifyIcon1.BalloonTipTitle = "Upozornění!";
                notifyIcon1.BalloonTipText = "Vyberte sekci pro Vaše vozidlo!";
                notifyIcon1.ShowBalloonTip(5000);

                return;
            }

            // selected node is not null and is exactly one under the root
            if (kryptonTreeView1.Nodes.Contains(kryptonTreeView1.SelectedNode.Parent)){
                kryptonTreeView1.SelectedNode.Nodes.Add("temp1");
                string odpoved = Interaction.InputBox("Zadej název vozidla:", "Název - lze změnit později", "např Audi R8");
                odpoved = string.IsNullOrEmpty(odpoved) ? "temp1" : odpoved;


            }
            // selected node is not allowed to add any subnodes
            else {
                notifyIcon1.BalloonTipTitle = "Upozornění!";
                notifyIcon1.BalloonTipText = $"Do této sekce ({kryptonTreeView1.SelectedNode.Text}) nezle vložit vozidlo!";
                notifyIcon1.ShowBalloonTip(5000);
            }
        }

        private void odebratButton_Click(object sender, EventArgs e)
        {

        }
    }
}
