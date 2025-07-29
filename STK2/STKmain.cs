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
    }
}
