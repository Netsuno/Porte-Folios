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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MLMachine f3 = new MLMachine(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calan f3 = new calan(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LMaintenance f3 = new LMaintenance(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            MLMachine f3 = new MLMachine(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            calan f3 = new calan(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            LMaintenance f3 = new LMaintenance(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }
    }
}
