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
    public partial class LMachine : Form
    {

        public LMachine()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT EmplacementNom, EquipementNom FROM Emplacement Ep join Machine M on Ep.idEmplacement = M.idEmplacement join Equipement E on M.idMachine = E.idMachine ORDER BY EmplacementNom", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                dgv1.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT EmplacementNom, EquipementNom FROM Emplacement Ep join Machine M on Ep.idEmplacement = M.idEmplacement join Equipement E on M.idMachine = E.idMachine ORDER BY EmplacementNom", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                dgv1.DataSource = dtbl;
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Liste des machines";
            printer.SubTitle = localdate.ToString();
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
