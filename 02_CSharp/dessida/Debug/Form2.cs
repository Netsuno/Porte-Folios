using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dessida
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AEmplacement f3 = new AEmplacement(); 
            f3.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aequipement f3 = new Aequipement(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AMachine f3 = new AMachine(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APiece f3 = new APiece(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AInventaire f3 = new AInventaire(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AEntretien f3 = new AEntretien(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ATEntretien f3 = new ATEntretien(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AReparation f3 = new AReparation(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AMechanicien f3 = new AMechanicien(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LMaintenance f3 = new LMaintenance(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LRaport f3 = new LRaport(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LCout f3 = new LCout(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }



        private void button13_Click(object sender, EventArgs e)
        {
            calan f3 = new calan(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SPiece f3 = new SPiece(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

 //       private void button15_Click(object sender, EventArgs e)
 //       {
 //           CPiece f3 = new CPiece(); // Instantiate a Form3 object.
 //           f3.Show(); // Show Form3 and
 //       }

        private void button17_Click(object sender, EventArgs e)
        {
            HMachine f3 = new HMachine(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void button18_Click(object sender, EventArgs e)
        {
            LMachine f3 = new LMachine(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void Interface_Click(object sender, EventArgs e)
        {
            Main f3 = new Main();
            f3.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReAchat f3 = new ReAchat();
            f3.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            BTravail f3 = new BTravail();
            f3.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BTravailO f3 = new BTravailO();
            f3.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Var.Sqlmy))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(Var.ini.backup);
                        conn.Close();
                    }
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
    }
    
}
