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
    public partial class Piece : Form
    {
        public Piece()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AEmplacement f3 = new AEmplacement();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AMachine f3 = new AMachine();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AInventaire f3 = new AInventaire();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ATEntretien f3 = new ATEntretien();
            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AMechanicien f3 = new AMechanicien();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aequipement f3 = new Aequipement();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APiece f3 = new APiece();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AEntretien f3 = new AEntretien();
            f3.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AReparation f3 = new AReparation();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MLMachine f3 = new MLMachine();
            f3.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            AEmplacement f3 = new AEmplacement();
            f3.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Aequipement f3 = new Aequipement();
            f3.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            AMachine f3 = new AMachine();
            f3.Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            AEntretien f3 = new AEntretien();
            f3.Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            AReparation f3 = new AReparation();
            f3.Show();
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            AMechanicien f3 = new AMechanicien();
            f3.Show();
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            ATEntretien f3 = new ATEntretien();
            f3.Show();
        }
    }
}
