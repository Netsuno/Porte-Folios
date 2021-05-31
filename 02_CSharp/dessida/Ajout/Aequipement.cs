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
    public partial class Aequipement : Form
            
    {

        int idnom = 0;

        public Aequipement()
        {
            InitializeComponent();
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                {
                    string selectQuery = "SELECT * FROM Mario.Machine";
                    mysqlCon.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString("MachineNom"));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string combo = comboBox1.Text;
                string selectQueray = "SELECT * FROM Mario.Machine WHERE MachineNom = '"+combo+"';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    idnom = (int)reader["idMachine"];
                }

                mysqlCon.Close();
            }
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                string valeur1 = valeurtxt.Text;
                string nom1 = nomtxt.Text;
                string description1 = descriptiontxt.Text;
                string statut1 = statuttxt.Text;
                string img1 = imgTxt.Text;
                string dossier1 = dossierTxt.Text;
                string id1 = idtxt.Text;
                string selectQueray1 = "INSERT INTO Mario.Equipement (idMachine, EquipementValeur, EquipementNom, EquipementDescription, EquipementStatut, photo, folder, idReAchat) VALUES ('" + idnom + "','" + valeur1 + "','" + nom1 + "','" + description1 + "','" + statut1 + "','" + img1 + "','" + dossier1 + "','" + id1 + "');";
                mysqlCon1.Open();
                MySqlCommand mySqlCmd1 = new MySqlCommand(selectQueray1, mysqlCon1);
                mySqlCmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                mysqlCon1.Close();
            }
            MLMachine f3 = new MLMachine(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void valeur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
