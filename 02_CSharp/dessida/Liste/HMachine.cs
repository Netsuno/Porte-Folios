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
    public partial class HMachine : Form
    {

        public HMachine()
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
                    comboBox1.Items.Add(reader.GetString("EquipementNom"));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string machine = comboBox1.Text;
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT EmplacementNom, EquipementNom FROM Emplacement Ep join Machine M on Ep.idEmplacement = M.idEmplacement join Equipement E on M.idMachine = E.idMachine ORDER BY EmplacementNom", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                DGV1.DataSource = dtbl;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
