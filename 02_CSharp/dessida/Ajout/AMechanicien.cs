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
    public partial class AMechanicien : Form
    {
   
        public AMechanicien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("A_Tech", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_nom", nom.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_post", poste.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout Réussi");

                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

