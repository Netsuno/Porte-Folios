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
    public partial class LRegistre : Form
    {
        public LRegistre()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT idReAchat AS 'ID', Nom_Equi AS 'Nom', Date FROM ReAchat ORDER BY Date", mysqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //direct
                dgv1.DataSource = dtbl;
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
          Var.global.infoRegi = dgv1.CurrentRow.Cells[0].Value.ToString();
          LReAchat f3 = new LReAchat(); // Instantiate a Form3 object.
          f3.Show(); // Show Form3 and
        }
    }
}
