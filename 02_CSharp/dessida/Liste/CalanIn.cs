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
    public partial class CalanIn : Form
    {

        public CalanIn()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy)) //PLanifier
            {
                string combo = Var.dato;
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT EmplacementNom AS 'Emplacement', EquipementNom as 'Nom', Type_EntretienNom as 'Entretien',  RaportDate +  INTERVAL EntretienFrequence * 7 DAY  as 'Du' FROM  Entretien E join Type_Entretien TE ON E.idType_Entretien = TE.idType_Entretien join Equipement E2 on E.idEquipement = E2.idEquipement join Machine M on E2.idMachine = M.idMachine join Raport R on E.idEntretien = R.idEntretien JOIN Emplacement EM ON M.idEmplacement = EM.idEmplacement WHERE RaportDate + INTERVAL EntretienFrequence * 7 DAY - INTERVAL 1 DAY <'" + combo + "'  AND R.RaportDate = (SELECT MAX(R2.RaportDate) FROM Raport R2 where R2.idEntretien = R.idEntretien)  ORDER BY Du;", mysqlCon) ;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                DGVP.DataSource = dtbl;
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy)) //Fait
            {
                string combo = Var.dato;
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select EquipementNom,Type_EntretienNom,Commentair,TechNom FROM Equipement JOIN Entretien E on Equipement.idEquipement = E.idEquipement JOIN Type_Entretien TE on TE.idType_Entretien = E.idType_Entretien JOIN Raport R on E.idEntretien = R.idEntretien JOIN Tech T on T.idTech = R.idTech WHERE RaportDate ='" + combo + "';", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                DGVF.DataSource = dtbl;
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy)) //Reparation
            {
                string combo = Var.dato;
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select EquipementNom,commantair FROM Reparation JOIN Equipement E on E.idEquipement = Reparation.idEquipement WHERE dateReparation >= '" + combo + "'AND dateReparation < '" + combo + "' + INTERVAL 1 DAY;", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                DGVR.DataSource = dtbl;
            }
        }

        private void CalanIn_Load(object sender, EventArgs e)
        {

        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liste des maintenances faites ";
            printer.SubTitle = "Le " + Var.dato;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Viandes Cote";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DGVF);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liste des réparations faites ";
            printer.SubTitle = "Le " + Var.dato;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Viandes Cote";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DGVR);
        }

        private void Imprimé_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liste des maintenances du";
            printer.SubTitle = "En date du " + localdate.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Viandes Cote";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DGVP);
        }

        private void DGVR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
