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
    public partial class MLMachine : Form
    {
        string image;
        string Folders;
        
        public MLMachine()
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
                    CBequipement.Items.Add(reader.GetString("EquipementNom"));
                }
            }

        }
        private void ComboBox_TextUpdate(Object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string combo = CBequipement.Text;
                string selectQueray = "SELECT * FROM Mario.Equipement WHERE EquipementNom = '" + combo + "';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    TBdescription.Text = (string)reader["EquipementDescription"];
                    TBstatut.Text = (string)reader["EquipementStatut"];
                    image = (string)reader["photo"];
                    Folders = (string)reader["folder"];
                    Var.global.infoRegi = reader["idReAchat"].ToString();

                }
                mysqlCon.Close();


            }
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string combo = CBequipement.Text;
                string selectQueray = "SELECT EmplacementNom FROM Emplacement join Machine M on Emplacement.idEmplacement = M.idEmplacement join Equipement E on M.idMachine = E.idMachine WHERE EquipementNom = '" + combo + "';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lieu.Text = (string)reader["EmplacementNom"];
                }
                mysqlCon.Close();
            }

                using (MySqlConnection mysqlCon1 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = CBequipement.Text;
                mysqlCon1.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT  Type_EntretienNom as 'Entretien',  RaportDate +  INTERVAL EntretienFrequence * 7 DAY + INTERVAL 7 DAY as 'Du' FROM Entretien E join Type_Entretien TE ON E.idType_Entretien = TE.idType_Entretien join Equipement E2 on E.idEquipement = E2.idEquipement join Machine M on E2.idMachine = M.idMachine join Raport R on E.idEntretien = R.idEntretien WHERE EquipementNom = '" + combo + "' AND R.RaportDate = (SELECT MAX(R2.RaportDate) FROM Raport R2 where R2.idEntretien = R.idEntretien) ORDER BY Type_EntretienNom", mysqlCon1);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DGVMP.DataSource = dtbl;
                mysqlCon1.Close();

            }
            using (MySqlConnection mysqlCon2 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = CBequipement.Text;
                mysqlCon2.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT DISTINCT Type_EntretienNom as 'Entretien', EntretienFrequence AS 'Fréquence (Semaine)'  FROM  Equipement JOIN Entretien E on Equipement.idEquipement = E.idEquipement JOIN Type_Entretien TE on TE.idType_Entretien = E.idType_Entretien WHERE EquipementNom = '" + combo + "' ORDER BY Type_EntretienNom", mysqlCon2);
                DataTable dtb2 = new DataTable();
                sqlDa.Fill(dtb2);
                DGVMN.DataSource = dtb2;
                mysqlCon2.Close();

            }
            using (MySqlConnection mysqlCon3 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = CBequipement.Text;
                mysqlCon3.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT  Type_EntretienNom as 'Entretien', RaportDate as 'Date', Commentair as 'Commentair' FROM  Equipement JOIN Entretien E on Equipement.idEquipement = E.idEquipement JOIN Type_Entretien TE on TE.idType_Entretien = E.idType_Entretien JOIN Raport R on E.idEntretien = R.idEntretien WHERE EquipementNom = '" + combo + "' ORDER BY RaportDate DESC", mysqlCon3);
                DataTable dtb3 = new DataTable();
                sqlDa.Fill(dtb3);
                DGVMA.DataSource = dtb3;
                mysqlCon3.Close();

            }
            using (MySqlConnection mysqlCon4 = new MySqlConnection(Var.Sqlmy))
            {
                string combo = CBequipement.Text;
                mysqlCon4.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT  dateReparation as 'Date', temps as 'Dure en heur',commantair as 'Commentaire', TechNom as 'Par' From Equipement join Reparation R on Equipement.idEquipement = R.idEquipement join Tech T on R.idtech = T.idTech WHERE EquipementNom = '" + combo +"' ORDER BY dateReparation ASC", mysqlCon4);
                DataTable dtb4 = new DataTable();
                sqlDa.Fill(dtb4);
                DGVR.DataSource = dtb4;
                mysqlCon4.Close();

            }
            try
            {
                PBphoto.Image = Image.FromFile("P:/MAINTENANCE/Machine/" + Folders + "/"+ image + ".jpg");
            }
            catch (System.IO.FileNotFoundException)
            {
                PBphoto.Image = PBphoto.ErrorImage;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"P:\MAINTENANCE\Machine\" + Folders);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liste des réparations éffectué de: " + CBequipement.Text;
            printer.SubTitle = "En date du " + localdate.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liste des maintenace éffectuée de: " + CBequipement.Text;
            printer.SubTitle = "En date du " + localdate.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Viandes Cote";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DGVMA);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liste des maintenance prévue de: " +CBequipement.Text;
            printer.SubTitle = "En date du " + localdate.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Viandes Cote";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DGVMP);
        }

        private void Imprimé_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title ="Liste des maintenance possible de: " + CBequipement.Text;
            printer.SubTitle = "En date du " + localdate.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Viandes Cote";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DGVMN);
        }

        private void Vali_Click(object sender, EventArgs e)
        {
            LReAchat f3 = new LReAchat(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
        }
    }
}
