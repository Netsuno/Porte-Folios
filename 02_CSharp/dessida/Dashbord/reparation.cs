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
    public partial class reparation : Form
    {
        public reparation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amaintenance f3 = new Amaintenance();
            f3.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReAchat f3 = new ReAchat();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LRegistre f3 = new LRegistre();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            Amaintenance f3 = new Amaintenance();
            f3.Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            ReAchat f3 = new ReAchat();
            f3.Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            LRegistre f3 = new LRegistre();
            f3.Show();
        }
    }
}
