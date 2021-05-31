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
    public partial class Liste_complet : Form
    {

        public Liste_complet()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT MachineNom , Type_EntretienNom , RaportDate , adddate(RaportDate,INTERVAL EntretienFrequence WEEK )  FROM  Entretien E join Type_Entretien TE ON E.idType_Entretien = TE.idType_Entretien join Equipement E2 on E.idEquipement = E2.idEquipement join Machine M on E2.idMachine = M.idMachine join Raport R on E.idEntretien = R.idEntretien where MachineNom <> 'test1'", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                dgv1.DataSource = dtbl;
            }
        }
    }
}
