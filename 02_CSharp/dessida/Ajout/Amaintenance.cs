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

    public partial class Amaintenance : Form
    {

        int idequipement = 0;
        int identretien = 0;
        int identre = 0;
        DateTime due;
        

        char RaportDu;
        public Amaintenance()
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
            }


        }

        private void Save_Click(object sender, EventArgs e)
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
                string combo = entretien.Text;
                string selectQueray = "SELECT * FROM Mario.Type_Entretien WHERE Type_EntretienNom = '" + combo + "';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    identretien = (int)reader["idType_Entretien"];
                }
                mysqlCon.Close();
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                {
                string combo = entretien.Text;
                string selectQueray = "SELECT * FROM Mario.Entretien WHERE idType_Entretien = '" + identretien + "' AND idEquipement ='" + idequipement + "' ;";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                   identre = (int)reader["idEntretien"];
                }
                    mysqlCon.Close();

                }
            using (MySqlConnection mysqlCon7 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = machine.Text;
                string combo2 = entretien.Text;
                string selectQueray = "SELECT Du FROM Mario.Datae WHERE Equipement = '" + combo + "' AND Entretien = '"+ combo2 +"';";
                mysqlCon7.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon7);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    due = (DateTime)reader["Du"];
                }
                mysqlCon7.Close();

            }
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                string frequence1 = commen.Text;
                string selectQueray1 = @"INSERT INTO Mario.Raport (idEntretien, RaportDate, Commentair, idTech, RaportDu ) VALUES ('" + identre + "', CURDATE() ,'" + frequence1 + "',' 2 ','" + due +"');";
                mysqlCon1.Open();
                MySqlCommand mySqlCmd1 = new MySqlCommand(selectQueray1, mysqlCon1);
                mySqlCmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                mysqlCon1.Close();
            }
        }

        private void entretien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void machine_SelectedIndexChanged(object sender, EventArgs e)
        {
            entretien.Items.Clear();
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = machine.Text;
                string selectQueray = "SELECT Type_EntretienNom FROM Mario.Type_Entretien E join Entretien TE ON E.idType_Entretien = TE.idType_Entretien join Equipement EQ ON EQ.idEquipement = TE.idEquipement  WHERE EQ.EquipementNom = '" + combo + "';";
                mysqlCon1.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon1);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    entretien.Items.Add(reader.GetString("Type_EntretienNom"));                 
                }
                mysqlCon1.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
