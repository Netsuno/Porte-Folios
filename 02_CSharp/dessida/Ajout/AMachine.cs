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

    public partial class AMachine : Form
    {

        int idemplacement = 0;

        public AMachine()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Emplacement";
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Emplacement.Items.Add(reader.GetString("EmplacementNom"));
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string combo = Emplacement.Text;
                string selectQueray = "SELECT * FROM Mario.Emplacement WHERE EmplacementNom = '" + combo + "';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    idemplacement = (int)reader["idEmplacement"];
                }

                mysqlCon.Close();



            }
            using (MySqlConnection mysqlCon2 = new MySqlConnection(Var.Sqlmy))
                {
                try
                {
                    string nom1 = nom.Text;
                    string nserie1 = nserie.Text;
                    string valeur1 = valeur.Text;
                    string description1 = description.Text;
                    string statut1 = statut.Text;
                    string selectQueray1 = "INSERT INTO Mario.Machine (MachineNom, idEmplacement, MachineNSerie, MachineValeur, MachineDescription,MachineStatut) VALUES ('" + nom1 + "','" + idemplacement + "','" + nserie1 + "','" + valeur1 + "','" + description1 + "','" + statut1 + "');";
                    mysqlCon2.Open();
                    MySqlCommand mySqlCmd2 = new MySqlCommand(selectQueray1, mysqlCon2);
                    mySqlCmd2.ExecuteNonQuery();
                    MessageBox.Show("Ajout Réussi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vérrifié Donné");
                }
                finally
                {
                    mysqlCon2.Close();
                }
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
