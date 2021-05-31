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
using DGVPrinterHelper;

namespace dessida
{
    public partial class LMaintenance : Form
    {

        public LMaintenance()
        {
            InitializeComponent();

        }
        DataTable dtbl = new DataTable();
        bool but = true;



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


     
        private void button2_Click(object sender, EventArgs e)
        {
            but = true;
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT EquipementNom as 'Nom', Type_EntretienNom as 'Entretien',  RaportDate +  INTERVAL EntretienFrequence * 7 DAY + INTERVAL 7 DAY as 'Du' FROM  Entretien E join Type_Entretien TE ON E.idType_Entretien = TE.idType_Entretien join Equipement E2 on E.idEquipement = E2.idEquipement join Machine M on E2.idMachine = M.idMachine join Raport R on E.idEntretien = R.idEntretien WHERE RaportDate + INTERVAL EntretienFrequence * 7 DAY < CURDATE() AND R.RaportDate = (SELECT MAX(R2.RaportDate) FROM Raport R2 where R2.idEntretien = R.idEntretien) ORDER BY EquipementNom", mysqlCon);
                dtbl.Clear();
                sqlDa.Fill(dtbl);
                mysqlCon.Close();
                //direct
                dgv1.DataSource = dtbl;
            }

        }
    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
             DataRowView drv;
            if (but == true) {
            if (e.RowIndex >= 0)
            {
             drv = dtbl.DefaultView[e.RowIndex];
            Color c;
            DateTime today = DateTime.Now;

            {
                DateTime dt = DateTime.Parse(drv["Du"].ToString());
                
                if (dt > today)
                {
                        c = Color.LightBlue;
                  }
                else
                {
                        c = Color.Pink;
                    }
                    e.CellStyle.BackColor = c;
                }
        }
        }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                but = false;
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT EquipementNom 'Nom', Type_EntretienNom as 'Entrtetien', RaportDate as 'Date fait', Commentair FROM  Entretien E join Type_Entretien TE ON E.idType_Entretien = TE.idType_Entretien join Equipement E2 on E.idEquipement = E2.idEquipement join Raport R on E.idEntretien = R.idEntretien ", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                dgv1.DataSource = dtbl;
            }
        }

        private void Imprimé_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Maintenance";
            printer.SubTitle = "En date du " + localdate.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Viandes Cote";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv1);
        }
    }
}
