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
    public partial class AReparation : Form
    {

        int idcommentaire = 0;
        int idmachine = 0;
        int idtech = 0;
        public AReparation()
        {

            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Equipement order by EquipementNom";
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Machine.Items.Add(reader.GetString("EquipementNom"));
                }
                mysqlCon.Close();
            }
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Tech";
                mysqlCon1.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon1);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Mechanicien.Items.Add(reader.GetString("TechNom"));
                }
                mysqlCon1.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {




            using (MySqlConnection mysqlCon3 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = Machine.Text;
                string selectQueray = "SELECT * FROM Mario.Equipement WHERE EquipementNom = '" + combo + "';";
                mysqlCon3.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon3);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    idmachine = (int)reader["idEquipement"];
                }
                mysqlCon3.Close();

            }

            using (MySqlConnection mysqlCon4 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = Mechanicien.Text;
                string selectQueray = "SELECT * FROM Mario.Tech WHERE TechNom = '" + combo + "';";
                mysqlCon4.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon4);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    idtech = (int)reader["idTech"];
                }
                mysqlCon4.Close();
            }

            using (MySqlConnection mysqlCon2 = new MySqlConnection(Var.Sqlmy))
            {

                string combo = description.Text;
                string temps1 = temps.Text;
                string selectQueray1 = "INSERT INTO Mario.Reparation (idEquipement, commantair, temps, idtech) VALUES ('" + idmachine + "','" + combo + "','" + temps1 + "','" + idtech + "');";
                mysqlCon2.Open();
                MySqlCommand mySqlCmd1 = new MySqlCommand(selectQueray1, mysqlCon2);
                mySqlCmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                mysqlCon2.Close();
            }
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
