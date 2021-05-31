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
    public partial class LReAchat : Form
    {
        //string Res;
        //string Neq;
        //string Fab;
        //string Aut;
        //string dtp;
        //string Mod;
        int q1a, q2a, q3a, q4a, q5a, q6a, q7a, q8a, q9a;
        public LReAchat()
        {
            InitializeComponent();
            using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
            {
                string combo = Var.global.infoRegi;
                string selectQueray = "SELECT * FROM Mario.ReAchat WHERE idReAchat = '" + combo + "';";
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(selectQueray, mysqlCon);
                MySqlDataReader reader = mySqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    ERes.Text = (string)reader["Responsable"];
                    ENeq.Text = (string)reader["Nom_Equi"];
                    EFab.Text = (string)reader["Fabricant"];
                    EAutre.Text = (string)reader["Autre"];
                    EDate.Text = Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd");
                    EMod.Text = (string)reader["Modele"];
                    q1a = (int)reader["q1"];
                    q2a = (int)reader["q2"];
                    q3a = (int)reader["q3"];
                    q4a = (int)reader["q4"];
                    q5a = (int)reader["q5"];
                    q6a = (int)reader["q6"];
                    q7a = (int)reader["q7"];
                    q8a = (int)reader["q8"];
                    q9a = (int)reader["q9"];
                }
                mysqlCon.Close();
                q1q(q1a);
                q2q(q2a);
                q3q(q3a);
                q4q(q4a);
                q5q(q5a);
                q6q(q6a);
                q7q(q7a);
                q8q(q8a);
                q9q(q9a);
            }
        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void q1q(int q1a)
        {
            if (q1a == 1)
            {
                c1.Checked = true;
                nc1.Checked = false;
                na1.Checked = false;
            }
            else if (q1a == 2)
            {
                c1.Checked = false;
                nc1.Checked = true;
                na1.Checked = false;
            }
            else if (q1a == 3)
            {
                c1.Checked = false;
                nc1.Checked = false;
                na1.Checked = true;
            }
            else
            {
                c1.Checked = false;
                nc1.Checked = false;
                na1.Checked = false;
            }
        }
        public void q2q(int q1a)
        {
            if (q1a == 1)
            {
                c2.Checked = true;
                nc2.Checked = false;
                na2.Checked = false;
            }
            else if (q1a == 2)
            {
                c2.Checked = false;
                nc2.Checked = true;
                na2.Checked = false;
            }
            else if (q1a == 3)
            {
                c2.Checked = false;
                nc2.Checked = false;
                na2.Checked = true;
            }
            else
            {
                c2.Checked = false;
                nc2.Checked = false;
                na2.Checked = false;
            }
        }
        public void q3q(int q1a)
        {
            if (q1a == 1)
            {
                c3.Checked = true;
                nc3.Checked = false;
                na3.Checked = false;
            }
            else if (q1a == 2)
            {
                c3.Checked = false;
                nc3.Checked = true;
                na3.Checked = false;
            }
            else if (q1a == 3)
            {
                c3.Checked = false;
                nc3.Checked = false;
                na3.Checked = true;
            }
            else
            {
                c3.Checked = false;
                nc3.Checked = false;
                na3.Checked = false;
            }
        }
        public void q4q(int q1a)
        {
            if (q1a == 1)
            {
                c4.Checked = true;
                nc4.Checked = false;
                na4.Checked = false;
            }
            else if (q1a == 2)
            {
                c4.Checked = false;
                nc4.Checked = true;
                na4.Checked = false;
            }
            else if (q1a == 3)
            {
                c4.Checked = false;
                nc4.Checked = false;
                na4.Checked = true;
            }
            else
            {
                c4.Checked = false;
                nc4.Checked = false;
                na4.Checked = false;
            }
        }
        public void q5q(int q1a)
        {
            if (q1a == 1)
            {
                c5.Checked = true;
                nc5.Checked = false;
                na5.Checked = false;
            }
            else if (q1a == 2)
            {
                c5.Checked = false;
                nc5.Checked = true;
                na5.Checked = false;
            }
            else if (q1a == 3)
            {
                c5.Checked = false;
                nc5.Checked = false;
                na5.Checked = true;
            }
            else
            {
                c5.Checked = false;
                nc5.Checked = false;
                na5.Checked = false;
            }
        }
        public void q6q(int q1a)
        {
            if (q1a == 1)
            {
                c6.Checked = true;
                nc6.Checked = false;
                na6.Checked = false;
            }
            else if (q1a == 2)
            {
                c6.Checked = false;
                nc6.Checked = true;
                na6.Checked = false;
            }
            else if (q1a == 3)
            {
                c6.Checked = false;
                nc6.Checked = false;
                na6.Checked = true;
            }
            else
            {
                c6.Checked = false;
                nc6.Checked = false;
                na6.Checked = false;
            }
        }
        public void q7q(int q1a)
        {
            if (q1a == 1)
            {
                c7.Checked = true;
                nc7.Checked = false;
                na7.Checked = false;
            }
            else if (q1a == 2)
            {
                c7.Checked = false;
                nc7.Checked = true;
                na7.Checked = false;
            }
            else if (q1a == 3)
            {
                c7.Checked = false;
                nc7.Checked = false;
                na7.Checked = true;
            }
            else
            {
                c7.Checked = false;
                nc7.Checked = false;
                na7.Checked = false;
            }
        }
        public void q8q(int q1a)
        {
            if (q1a == 1)
            {
                c8.Checked = true;
                nc8.Checked = false;
                na8.Checked = false;
            }
            else if (q1a == 2)
            {
                c8.Checked = false;
                nc8.Checked = true;
                na8.Checked = false;
            }
            else if (q1a == 3)
            {
                c8.Checked = false;
                nc8.Checked = false;
                na8.Checked = true;
            }
            else
            {
                c8.Checked = false;
                nc8.Checked = false;
                na8.Checked = false;
            }
        }
        public void q9q(int q1a)
        {
            if (q1a == 1)
            {
                c9.Checked = true;
                nc9.Checked = false;
                na9.Checked = false;
            }
            else if (q1a == 2)
            {
                c9.Checked = false;
                nc9.Checked = true;
                na9.Checked = false;
            }
            else if (q1a == 3)
            {
                c9.Checked = false;
                nc9.Checked = false;
                na9.Checked = true;
            }
            else
            {
                c9.Checked = false;
                nc9.Checked = false;
                na9.Checked = false;
            }
        }
       
    }

}
