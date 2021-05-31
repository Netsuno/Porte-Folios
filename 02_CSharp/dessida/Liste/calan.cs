using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dessida.Services;
using MySql.Data.MySqlClient;




namespace dessida
{
    public partial class calan : Form
    {
         int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24, n25, n26, n27, n28, n29, n30, n31, n32, n33, n34, n35, n36, n37, n38, n39, n40, n41, n42;


        public calan()
        {
            InitializeComponent();
           



        }
        private void CBM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public dynamic Model { get; }

        private void bp1_Click(object sender, EventArgs e)
        {
            pBar.Value = 0;
            int i = 0;
            var annee1 = CBA.Text;
            Var.global.A = Int32.Parse(annee1);
            var mois1 = CBM.Text;
            Var.global.M = Int32.Parse(mois1);
            CalendarManager _calendar = new CalendarManager();
            var model = _calendar.getCalender(DateTime.Now.Month, DateTime.Now.Year);           
            var model1 = _calendar.getCalender(Var.global.M, Var.global.A);  //Mois année
            Var.global.lWeek1 = model1.Week1.Count;
            Var.global.lWeek2 = model1.Week2.Count;
            Var.global.lWeek3 = model1.Week3.Count;
            Var.global.lWeek4 = model1.Week4.Count;
            Var.global.lWeek5 = model1.Week5.Count;
            Var.global.lWeek6 = model1.Week6.Count;
            pBar.Maximum = System.DateTime.DaysInMonth(Var.global.A, Var.global.M); 
            

            var Ljour1 = model1.Week1[model1.Week1.Count - 1];
            var Ljour2 = model1.Week1[model1.Week1.Count - 1];
            var Ljour3 = model1.Week1[model1.Week1.Count - 1];
            var Ljour4 = model1.Week1[model1.Week1.Count - 1];
            if (model1.Week6.Count > 0)
            {
                var Ljour5 = model1.Week1[model1.Week1.Count - 1];
            }
            else
            {
                var Ljour5 = 0;
            }
            if (model1.Week6.Count > 0)
            {
                var Ljour6 = model1.Week1[model1.Week1.Count - 1];
            }
            else
            {
                var Ljour6 = 0;
            }

            if (model1.Week1[0] != null)  // Si week1 position 0 est not null
            {
                int v1 = model1.Week1[0].dtDay;  //n'aurais pas pu etre N1?
               n1 = v1;  // utiliser plus tard pour ouvrire jour.
               Var.global.j2 = v1;   //Utilisé pour Var.uniqueDato 
                txt1.Text = v1.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1; // on nomme le boutton par raport au info recu
                pBar.Value = pBar.Value + 1; // Bar de progression +1 
            }
            else
            {
                txt1.Text = ""; // si il y a pas de date metre le bouton vide
            }
            if (model1.Week1[1] != null)
            {
                int v2 = model1.Week1[1].dtDay;
                n2 = v2;
                Var.global.j2 = v2;
                txt2.Text = v2.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt2.Text = "";
            }
            if (model1.Week1[2] != null)
            {
                int v3 = model1.Week1[2].dtDay;
                n3 = v3;
                Var.global.j2 = v3;
                txt3.Text = v3.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt3.Text = "";
            }
            if (model1.Week1[3] != null)
            {
                int v4 = model1.Week1[3].dtDay;
                n4 = v4;
                Var.global.j2 = v4;
                txt4.Text = v4.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;

            }
            else
            {
                txt4.Text = "";
            }
            if (model1.Week1[4] != null)
            {
                int v5 = model1.Week1[4].dtDay;
                n5 = v5;
                Var.global.j2 = v5;
                txt5.Text = v5.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt5.Text = "";
            }
            if (model1.Week1[5] != null)
            {
                int v6 = model1.Week1[5].dtDay;
                n6 = v6;
                Var.global.j2 = v6;
                txt6.Text = v6.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt6.Text = "";
            }
            if (model1.Week1[6] != null)
            {
                int v7 = model1.Week1[6].dtDay;
                n7 = v7;
                Var.global.j2 = v7;
                txt7.Text = v7.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt7.Text = "";
            }
            //week2
            if (model1.Week2[0] != null)
            {
                int v1 = model1.Week2[0].dtDay;
                n8 = v1;
                Var.global.j2 = v1;
                txt8.Text = v1.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week2[1] != null)
            {
                int v2 = model1.Week2[1].dtDay;
                n9 = v2;
                Var.global.j2 = v2;
                txt9.Text = v2.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week2[2] != null)
            {
                int v3 = model1.Week2[2].dtDay;
                n10 = v3;
                Var.global.j2 = v3;
                txt10.Text = v3.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week2[3] != null)
            {
                int v4 = model1.Week2[3].dtDay;
                n11 = v4;
                Var.global.j2 = v4;
                txt11.Text = v4.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week2[4] != null)
            {
                int v5 = model1.Week2[4].dtDay;
                n12 = v5;
                Var.global.j2 = v5;
                txt12.Text = v5.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week2[5] != null)
            {
                int v6 = model1.Week2[5].dtDay;
                n13 = v6;
                Var.global.j2 = v6;
                txt13.Text = v6.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week2[6] != null)
            {
                int v7 = model1.Week2[6].dtDay;
                n14 = v7;
                Var.global.j2 = v7;
                txt14.Text = v7.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            //week3
            if (model1.Week3[0] != null)
            {
                int v1 = model1.Week3[0].dtDay;
                n15 = v1;
                Var.global.j2 = v1;
                txt15.Text = v1.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week3[1] != null)
            {
                int v2 = model1.Week3[1].dtDay;
                n16 = v2;
                Var.global.j2 = v2;
                txt16.Text = v2.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week3[2] != null)
            {
                int v3 = model1.Week3[2].dtDay;
                n17 = v3;
                Var.global.j2 = v3;
                txt17.Text = v3.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week3[3] != null)
            {
                int v4 = model1.Week3[3].dtDay;
                n18 = v4;
                Var.global.j2 = v4;
                txt18.Text = v4.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week3[4] != null)
            {
                int v5 = model1.Week3[4].dtDay;
                n19 = v5;
                Var.global.j2 = v5;
                txt19.Text = v5.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week3[5] != null)
            {
                int v6 = model1.Week3[5].dtDay;
                n20 = v6;
                Var.global.j2 = v6;
                txt20.Text = v6.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            if (model1.Week3[6] != null)
            {
                int v7 = model1.Week3[6].dtDay;
                n21 = v7;
                Var.global.j2 = v7;
                txt21.Text = v7.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            //week4
            if (model1.Week4[0] != null)
            {
                int v1 = model1.Week4[0].dtDay;
                n22 = v1;
                Var.global.j2 = v1;
                txt22.Text = v1.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt22.Text = "";
            }
            if (model1.Week4[1] != null)
            {
                int v2 = model1.Week4[1].dtDay;
                n23 = v2;
                Var.global.j2 = v2;
                txt23.Text = v2.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt23.Text = "";
            }
            if (model1.Week4[2] != null)
            {
                int v3 = model1.Week4[2].dtDay;
                n24 = v3;
                Var.global.j2 = v3;
                txt24.Text = v3.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt24.Text = "";
            }
            if (model1.Week4[3] != null)
            {
                int v4 = model1.Week4[3].dtDay;
                n25 = v4;
                Var.global.j2 = v4;
                txt25.Text = v4.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt25.Text = "";
            }
            if (model1.Week4[4] != null)
            {
                int v5 = model1.Week4[4].dtDay;
                n26 = v5;
                Var.global.j2 = v5;
                txt26.Text = v5.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt26.Text = "";
            }
            if (model1.Week4[5] != null)
            {
                int v6 = model1.Week4[5].dtDay;
                n27 = v6;
                Var.global.j2 = v6;
                txt27.Text = v6.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt27.Text = "";
            }
            if (model1.Week4[6] != null)
            {
                int v7 = model1.Week4[6].dtDay;
                n28 = v7;
                Var.global.j2 = v7;
                txt28.Text = v7.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                pBar.Value = pBar.Value + 1;
            }
            else
            {
                txt28.Text = "";
            }
            //week5
            if (model1.Week5.Count > 0)
            {
                if (model1.Week5.Count >= 1)
                {
                    if (model1.Week5[0] != null)
                    {
                        int v1 = model1.Week5[0].dtDay;
                        n29 = v1;
                        Var.global.j2 = v1;
                        txt29.Text = v1.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt29.Text = "";
                    }
                }
                else
                {
                    txt29.Text = "";
                }
                if (model1.Week5.Count >= 2)
                {
                    if (model1.Week5[1] != null)

                    {
                        int v2 = model1.Week5[1].dtDay;
                        n30 = v2;
                        Var.global.j2 = v2;
                        txt30.Text = v2.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt30.Text = "";
                    }
                }
                else
                {
                    txt30.Text = "";
                }
                if (model1.Week5.Count >= 3)
                {
                    if (model1.Week5[2] != null)
                    {
                        int v3 = model1.Week5[2].dtDay;
                        n31 = v3;
                        Var.global.j2 = v3;
                        txt31.Text = v3.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt31.Text = "";
                    }
                }
                else
                {
                    txt31.Text = "";
                }
                if (model1.Week5.Count >= 4)
                {
                    if (model1.Week5[3] != null || model1.Week5.Count >= 4)
                    {
                        int v4 = model1.Week5[3].dtDay;
                        n32 = v4;
                        Var.global.j2 = v4;
                        txt32.Text = v4.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt32.Text = "";
                    }
                }
                else
                {
                    txt32.Text = "";
                }
                if (model1.Week5.Count >= 5)
                {
                    if (model1.Week5[4] != null)
                    {
                        int v5 = model1.Week5[4].dtDay;
                        n33 = v5;
                        Var.global.j2 = v5;
                        txt33.Text = v5.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt33.Text = "";
                    }
                }
                else
                {
                    txt33.Text = "";
                }
                if (model1.Week5.Count >= 6)
                {
                    if (model1.Week5[5] != null)
                    {
                        int v6 = model1.Week5[5].dtDay;
                        n34 = v6;
                        Var.global.j2 = v6;
                        txt34.Text = v6.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt34.Text = "";
                    }
                }
                else
                {
                    txt34.Text = "";
                }
                if (model1.Week5.Count >= 7)
                {
                    if (model1.Week5[6] != null)
                    {
                        int v7 = model1.Week5[6].dtDay;
                        n35 = v7;
                        Var.global.j2 = v7;
                        txt35.Text = v7.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt35.Text = "";
                    }
                }
                else
                {
                    txt35.Text = "";
                }
            }
            else
            {
                txt29.Text = "";
                txt30.Text = "";
                txt31.Text = "";
                txt32.Text = "";
                txt33.Text = "";
                txt34.Text = "";
                txt35.Text = "";
            }
            //week 6
            if (model1.Week6.Count > 0)
            {
                if (model1.Week6.Count >= 1)
                {
                    if (model1.Week6[0] != null)
                    {
                        int v1 = model1.Week6[0].dtDay;
                        n36 = v1;
                        Var.global.j2 = v1;
                        txt36.Text = v1.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt36.Text = "";
                    }
                }
                if (model1.Week6.Count >= 2)
                {
                    if (model1.Week6[1] != null)
                    {
                        int v2 = model1.Week6[1].dtDay;
                        n37 = v2;
                        Var.global.j2 = v2;
                        txt37.Text = v2.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt37.Text = "";
                    }
                }
                if (model1.Week6.Count >= 3)
                {
                    if (model1.Week6[2] != null)
                    {
                        int v3 = model1.Week6[2].dtDay;
                        n38 = v3;
                        Var.global.j2 = v3;
                        txt38.Text = v3.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt38.Text = "";
                    }
                }
                if (model1.Week6.Count >= 4)
                {
                    if (model1.Week6[3] != null)
                    {
                        int v4 = model1.Week6[3].dtDay;
                        n39 = v4;
                        Var.global.j2 = v4;
                        txt39.Text = v4.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt39.Text = "";
                    }
                }
                if (model1.Week6.Count >= 5)
                {
                    if (model1.Week6[4] != null)
                    {
                        int v5 = model1.Week6[4].dtDay;
                        n40 = v5;
                        Var.global.j2 = v5;
                        txt40.Text = v5.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt40.Text = "";
                    }
                }
                if (model1.Week6.Count >= 6)
                {
                    if (model1.Week6[5] != null)
                    {
                        int v6 = model1.Week6[5].dtDay;
                        n41 = v6;
                        Var.global.j2 = v6;
                        txt41.Text = v6.ToString() + "\n \n EP:" + Var.sqlreturn2 + "\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt41.Text = "";
                    }
                }
                if (model1.Week6.Count >= 7)
                {
                    if (model1.Week6[6] != null)
                    {
                        int v7 = model1.Week6[6].dtDay;
                        n41 = v7;
                        Var.global.j2 = v7;
                        txt42.Text = v7.ToString() + "\n \n EP:"+ Var.sqlreturn2 +"\n EF:" + Var.sqlreturn + "  R:" + Var.sqlreturn1;
                        pBar.Value = pBar.Value + 1;
                    }
                    else
                    {
                        txt42.Text = "";
                    }
                }
            }
            else
            {
                txt36.Text = "";
                txt37.Text = "";
                txt38.Text = "";
                txt39.Text = "";
                txt40.Text = "";
                txt41.Text = "";
                txt42.Text = "";
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt1.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n1;
                CalanIn f3 = new CalanIn(); 
                f3.Show(); 
            }
        }

        private void txt2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt2.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n2;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt3.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n3;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt4.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n4;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt5.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n5;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt6.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n6;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt7.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n7;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt8.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n8;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt9.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n9;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt10_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt10.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n10;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt11_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt11.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n11;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt12_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt12.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n12;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt13_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt13.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n13;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt14_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt14.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n14;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt15_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt15.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n15;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt16_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt16.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n16;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt17_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt17.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n17;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt18_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt18.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n18;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt19_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt19.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n19;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt20_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt20.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n20;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt21_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt21.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n21;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt22_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt22.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n22;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt23_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt23.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n23;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt24_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt24.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n24;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt25_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt25.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n25;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt26_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt26.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n26;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt27_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt27.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n27;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt28_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt28.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n28;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt29_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt29.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n29;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt30_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt30.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n30;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt31_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt31.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n31;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt32_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt32.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n32;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt33_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt33.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n33;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt34_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt34.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n34;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt35_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt35.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n35;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt36_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt36.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n36;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt37_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt37.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n37;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt38_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt38.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n38;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt39_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt39.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n39;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt40_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt40.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n40;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt41_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt41.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n41;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }

        private void txt42_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt42.Text))
            {
                Console.WriteLine("null");
            }
            else
            {
                Var.global.J = n42;
                CalanIn f3 = new CalanIn();
                f3.Show();
            }
        }
    }
    
}
