using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dessida
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Var.global.user = userText.Text;
            Var.global.pass = passtxt.Text;
            if (Var.connect == true && Var.global.serveur == true)
            {

                this.Hide();
                if (Var.global.acess == 5)

                {
                    var Main = new Main();
                    Main.Closed += (s, args) => this.Close();
                    Main.Show();
                   // MessageBox.Show("Acess 5");
                }
                else if (Var.global.acess == 1)
                {
                    var Main = new Main();
                    Main.Closed += (s, args) => this.Close();
                    Main.Show();
                   // MessageBox.Show("Acess 1");

                }
                else //SI probleme d'acces 
                {
                    var Main = new Main();
                    Main.Closed += (s, args) => this.Close();
                    Main.Show();
                    //MessageBox.Show("Acess 0");
                }
            }
            else if (Var.connect == false && Var.global.serveur == true)
            {
                MessageBox.Show("Login Failed");
            }
            else if (Var.global.serveur == false)
            {
                MessageBox.Show("Erreur de connection au serveur de base de donné");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
