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
    public partial class ATEntretien : Form
    {

        public ATEntretien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                string nom1 = nom.Text;
                string description1 = description.Text;
                string selectQueray1 = "INSERT INTO Mario.Type_Entretien (Type_EntretienNom, Type_EntretienDescription) VALUES ('" + nom1 + "','" + description1 + "');";
                mysqlCon1.Open();
                MySqlCommand mySqlCmd1 = new MySqlCommand(selectQueray1, mysqlCon1);
                mySqlCmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                mysqlCon1.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
