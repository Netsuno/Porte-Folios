using System;
using System.Windows.Forms;

namespace dessida
{
    public partial class Main : Form
    {



        public Main()
        {
            InitializeComponent();
            panelLeft.Height = buttonDashbord.Height;
            panelLeft.Top = buttonDashbord.Top;
            this.maina.Controls.Clear();
            Dashbord frm = new Dashbord()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.maina.Controls.Add(frm);
            frm.Show();

        }

           
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashbord_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashbord.Height;
            panelLeft.Top = buttonDashbord.Top;
            this.maina.Controls.Clear();
            Dashbord frm = new Dashbord()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.maina.Controls.Add(frm);
            frm.Show();


        }

        private void buttonReparation_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonReparation.Height;
            panelLeft.Top = buttonReparation.Top;
            this.maina.Controls.Clear();
            reparation frm = new reparation()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.maina.Controls.Add(frm);
            frm.Show();

        }

        private void  buttonRaports_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonRaports.Height;
            panelLeft.Top = buttonRaports.Top;
            this.maina.Controls.Clear();
            Raport frm = new Raport()
            {
              Dock = DockStyle.Fill,
              TopLevel = false,
              TopMost = true
           };
          this.maina.Controls.Add(frm);
            frm.Show();

        }

        private void buttonPieces_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonPieces.Height;
            panelLeft.Top = buttonPieces.Top;
            this.maina.Controls.Clear();
            Piece frm = new Piece()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.maina.Controls.Add(frm);
            frm.Show();
        }

        private void buttonInventaire_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonInventaire.Height;
            panelLeft.Top = buttonInventaire.Top;
            this.maina.Controls.Clear();
            Inventaire frm = new Inventaire()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.maina.Controls.Add(frm);
            frm.Show();
        }

        private void buttonAdministration_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonAdministration.Height;
            panelLeft.Top = buttonAdministration.Top;
            Form2 frm = new Form2();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonQuitté_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
