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
    public partial class BtravailC : Form
    {
        int idconfig = 1;
        int machineid;
        public BtravailC()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Billet where id = '" + idconfig + "' ";
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    demandeur1.Text = (string)reader["demandeur"];
                    date1.Text = Convert.ToDateTime(reader["DateC"]).ToString("yyyy-MM-dd");
                    bon1.Text = Convert.ToInt32(reader["id"]).ToString();
                    prio1.Text = Convert.ToInt32(reader["Priorite"]).ToString();
                    lieu1.Text = (string)reader["Lieu"];
                    type1.Text = (string)reader["T_travail"];
                    machineid = (int)reader["machine"];
                    descri1.Text = (string)reader["Descriptions"];
                    comment2.Text = (string)reader["commantair"];
                    par2.Text = (string)reader["Technom"];

                }
                mysqlCon.Close();
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Equipement where idEquipement = '" + machineid + "' ";
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    machine1.Text = (string)reader["EquipementNom"];
                }
                mysqlCon.Close();
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
