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
    public partial class ReAchat : Form
    {
        // 1 = Conforme, 2 = Non Conforme, 3 = Non Applicable
        public ReAchat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
            string combo1 = Res.Text;
            string combo2 = Neq.Text;
            string combo3 = Fab.Text;
            string combo4 = Autre.Text;
            string combo5 = dtp.Value.ToString("yyyy-MM-dd");
            string combo6 = Mod.Text;
            string selectQueray1 = "INSERT INTO Mario.ReAchat (Responsable, Nom_Equi, Fabricant, Autre, Date, Modele, q1, q2, q3, q4, q5, q6, q7, q8, q9) VALUES ('" + combo1 + "','" + combo2 + "','" + combo3 + "','" + combo4 + "','" + combo5 + "','" + combo6 + "','" + qr1 + "','" + qr2 + "','" + qr3 + "','" + qr4 + "','" + qr5 + "','" + qr6 + "','" + qr7 + "','" + qr8 + "','" + qr9 + "');";
            mysqlCon1.Open();
            MySqlCommand mySqlCmd1 = new MySqlCommand(selectQueray1, mysqlCon1);
            mySqlCmd1.ExecuteNonQuery();
            MessageBox.Show("Ajout Réussi");
            mysqlCon1.Close();
            }

        }
        public int qr1
        {
            get
            {
                if (c1.Checked)
                {
                    return 1;
                }
                else if (nc1.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr2
        {
            get
            {
                if (c2.Checked)
                {
                    return 1;
                }
                else if (nc2.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr3
        {
            get
            {
                if (c3.Checked)
                {
                    return 1;
                }
                else if (nc3.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr4
        {
            get
            {
                if (c4.Checked)
                {
                    return 1;
                }
                else if (nc4.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr5
        {
            get
            {
                if (c5.Checked)
                {
                    return 1;
                }
                else if (nc5.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr6
        {
            get
            {
                if (c6.Checked)
                {
                    return 1;
                }
                else if (nc6.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr7
        {
            get
            {
                if (c7.Checked)
                {
                    return 1;
                }
                else if (nc7.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr8
        {
            get
            {
                if (c8.Checked)
                {
                    return 1;
                }
                else if (nc8.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }
        public int qr9
        {
            get
            {
                if (c9.Checked)
                {
                    return 1;
                }
                else if (nc9.Checked)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Autre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
