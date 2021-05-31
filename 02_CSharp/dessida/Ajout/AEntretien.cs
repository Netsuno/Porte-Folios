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
    public partial class AEntretien : Form
    {

        int idequipement = 0;
        int identretien = 0;
                
        public AEntretien()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("S_Equipement_A", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader reader = mySqlCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        machine.Items.Add(reader.GetString("EquipementNom"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur c'est produite");
                }
                finally
                {
                    mysqlCon.Close();
                }
            }
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                try
                {
                    mysqlCon1.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("S_Entretien_A", mysqlCon1);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader reader1 = mySqlCmd.ExecuteReader();
                    while (reader1.Read())
                    {
                        entretien.Items.Add(reader1.GetString("Type_EntretienNom"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur c'est produite");
                }
                finally
                {
                    mysqlCon1.Close();
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("S_Equipement_P", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_nom", machine.Text.Trim());
                    MySqlDataReader reader = mySqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        idequipement = (int)reader["idEquipement"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur c'est produite");
                }
                finally
                {
                    mysqlCon.Close();
                }
            }
      

            
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon1.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("S_Entretien_P", mysqlCon1);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_nom", entretien.Text.Trim());           
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    identretien = (int)reader["idType_Entretien"];
                }
                mysqlCon1.Close();

            }
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon1.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("A_Entretien", mysqlCon1);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_identretien", identretien.ToString());
                mySqlCmd.Parameters.AddWithValue("_frequence", frequence.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_idequipement", idequipement.ToString());               
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                mysqlCon1.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void entretien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void machine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
