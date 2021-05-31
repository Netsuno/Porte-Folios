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
    public partial class BTravail : Form
    {
        int idequipement;

        
        public BTravail()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Equipement ORDER BY EquipementNom";
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    machine.Items.Add(reader.GetString("EquipementNom"));
                }
                mysqlCon.Close();

            }
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Emplacement ORDER BY EmplacementNom";
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    lieu.Items.Add(reader.GetString("EmplacementNom"));
                }
                mysqlCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string combo = machine.Text;
                string selectQueray = "SELECT * FROM Mario.Equipement WHERE EquipementNom = '" + combo + "';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    idequipement = (int)reader["idEquipement"];
                }
                mysqlCon.Close();
            }


                using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string lieux = lieu.Text;
                string equipement = idequipement.ToString();
                string demande = textBox1.Text;
                string type = comboBox3.Text;
                string prio = comboBox4.Text;
                string descri = richTextBox1.Text;
                DateTime date1 = DateTime.Now;
                DateTime dateonly = date1.Date;
                string selectQueray1 = "INSERT INTO Mario.Billet (demandeur, Lieu, T_travail, Descriptions, Priorite, statut, DateC, DateO, DateF, Technom, machine, commantair) VALUES ('" + demande + "','" + lieux + "','" + type + "','" + descri + "','" + prio + "', '1','" + dateonly + "','" + dateonly + "','" + dateonly + "','nom','" + equipement + "','comment');";
                mysqlCon.Open();
                MySqlCommand mySqlCmd1 = new MySqlCommand(selectQueray1, mysqlCon);
                mySqlCmd1.ExecuteNonQuery();
                long id = mySqlCmd1.LastInsertedId;
                MessageBox.Show("Ajout Réussi, numero de billet: "+ id +".");
                mysqlCon.Close();
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
