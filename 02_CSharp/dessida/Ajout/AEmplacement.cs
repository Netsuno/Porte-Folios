using MySql.Data.MySqlClient;
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
    public partial class AEmplacement : Form
    {

        public AEmplacement()
        {
            InitializeComponent();
        }

        private void b_Sauv_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("A_Emplacement", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_nom", textBox1.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                Clear();
            }
        }
        void Clear()
        {
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
