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
    public partial class APiece : Form
    {
        string connectionString = @"Server=51.222.9.116;Database=Mario;Uid=datauser;Pwd=petitlapin;";
        int idnom = 0;
        public APiece()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string selectQuery = "SELECT * FROM Mario.Equipement";
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    equipement.Items.Add(reader.GetString("EquipementNom"));
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string combo = equipement.Text;
                string selectQueray = "SELECT * FROM Mario.Equipement WHERE EquipementNom = '" + combo + "';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    idnom = (int)reader["idEquipement"];
                }

                mysqlCon.Close();
            }
            using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                string nom1 = nom.Text;
                string description1 = description.Text;
                string selectQueray1 = "INSERT INTO Mario.Piece (PieceNom, PieceDescription, idEquipement) VALUES ('" + nom1 + "','" + description1 + "','" + idnom + "');";
                mysqlCon1.Open();
                MySqlCommand mySqlCmd1 = new MySqlCommand(selectQueray1, mysqlCon1);
                mySqlCmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                mysqlCon1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
