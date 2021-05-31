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

    public partial class calandrie : Form
    {

        int combo1 = 2020;
        int combo2 = 02;

        public calandrie()

        {
            InitializeComponent();


            Dictionary<string, string> dict = new Dictionary<string, string>()
{
            {"01","01" },
            {"02","02" },
            {"03","03" },
            {"04","04" },
            {"05","05" },
            {"06","06" },
            {"07","07" },
            {"08","08" },
            {"09","09" },
            {"10","10" },
            {"11","11" },
            {"12","12" }
};


            Dictionary<string, string> dictj = new Dictionary<string, string>()
            {
              {"2020","2020" },
              {"2021","2021" },
              {"2022","2022" },
              {"2023","2023" },
              {"2024","2024" },
              {"2025","2025" },
              {"2026","2026" },
              {"2027","2027" },
              {"2028","2028" },
              {"2029","2029" },
              {"2030","2030" },
              {"2031","2031" },
              {"2032","2032" },
              {"2033","2034" },
              {"2035","2035" },
              {"2036","2036" },
              {"2037","2037" },
              {"2038","2038" },
              {"2039","2039" },
              {"2040","2040" }

            };

            CBAnnee.DataSource = new BindingSource(dictj, null);
            CBAnnee.DisplayMember = "Key";
            CBAnnee.ValueMember = "Value";
            CBAnnee.SelectedIndex = 0;

            CBMois.DataSource = new BindingSource(dict, null);
            CBMois.DisplayMember = "Key";
            CBMois.ValueMember = "Value";

           
           
            

           

        }

        private void calandrie_Load(object sender, EventArgs e)
        {

        }

        private void CBAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBAnnee.Text != null)
            {
                combo1 = int.Parse(CBAnnee.Text.ToString());
            }
            else
            {
                combo1 = 2020;
            }

            if (CBMois.Text != null)
            {
                combo2 = int.Parse(CBMois.Text.ToString());
            }
            else
            {
                combo2 = 01;
            }

            DateTime DateT = new DateTime(+ combo1, + combo2, 27);
            DateTime DateN = DateTime.Now;

            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {

                string combo3 = CBAnnee.Text;
                string combo4 = CBMois.Text;

                if (DateT.Date.Month == DateN.Date.Month )
                {
                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM Maint Where YEAR(Du) <= '" + combo3 + "' AND MONTH(Du) >= '" + combo4 + "'", mysqlCon);
                    DataTable dtbl = new DataTable();
                    dtbl.Clear();
                    sqlDa.Fill(dtbl);
                    mysqlCon.Close();
                    //direct
                    DGVT.DataSource = dtbl;
                }
            }
        }
        


    }
}
