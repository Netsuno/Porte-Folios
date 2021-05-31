using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dessida
{
    public partial class Raport : Form
    {
        public Raport()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LMaintenance f3 = new LMaintenance();
            f3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LCout f3 = new LCout();
            f3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LRaport f3 = new LRaport();
            f3.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            LMachine f3 = new LMachine();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste_complet f3 = new Liste_complet();
            f3.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            LMaintenance f3 = new LMaintenance();
            f3.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            LRaport f3 = new LRaport();
            f3.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            Liste_complet f3 = new Liste_complet();
            f3.Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            LCout f3 = new LCout();
            f3.Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            LMachine f3 = new LMachine();
            f3.Show();
        }
    }
}
