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
    public partial class BTravailO : Form
    {
        int machineid;
        string idconfig = "1";
        public BTravailO()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Billet where id = '"+ idconfig +"' ";
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
                    if ((int)reader["statut"] == 2)
                    {
                        comment2.Text = (string)reader["commantair"];
                        par2.Text = (string)reader["Technom"];
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Etes-vous certain de vouloir complété ce billet?";
            string title = "Complété";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                {
                    string comment = comment2.Text;
                    string par = par2.Text;
                    string dtp = dtp2.Value.ToString("yyyy-MM-dd");
                    string selectQuery = "UPDATE Mario.Billet t set t.commantair = '" + comment + "', t.Technom = '" + par + "', t.DateO = '" + dtp + "', t.DateF = '" + dtp + "', t.statut = '3' WHERE t.id = '"+ idconfig +"';";
                    MySqlCommand mySqlCmd = new MySqlCommand(selectQuery, mysqlCon);
                    mysqlCon.Open();
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Billet complété");
                    mysqlCon.Close();
                    
                }
                              
            }
            else
            {
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
             using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
             {
                    string comment = comment2.Text;
                    string par = par2.Text;
                    string dtp = dtp2.Value.ToString("yyyy-MM-dd");
                    string selectQuery = "UPDATE Mario.Billet t set t.commantair = '" + comment + "', t.Technom = '" + par + "', t.DateO = '" + dtp + "',  t.statut = '2' WHERE t.id = '" + idconfig + "';";
                    MySqlCommand mySqlCmd = new MySqlCommand(selectQuery, mysqlCon);
                    mysqlCon.Open();
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Billet mis a jour");
                    mysqlCon.Close();

             }


        }
    }
}
