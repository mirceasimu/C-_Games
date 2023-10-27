using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocP_Simu_Mircea
{
    public partial class Form1 : Form
    {
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        #region .. code for Flickering ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion
        public Form1()
        {
            InitializeComponent();
            SetDoubleBuffered(player);

            //fundal.Controls.Add(chestia);
            //chestia.Backcolor = Color.Transparent;
            fundal.Controls.Add(p2);
            fundal.Controls.Add(p1);
            p2.BackColor = Color.Transparent;
            fundal.Controls.Add(player);
            p2.BackColor = Color.Transparent;
            fundal.Controls.Add(p3);
            fundal.Controls.Add(p4);
            fundal.Controls.Add(p5);
            fundal.Controls.Add(p6);
            fundal.Controls.Add(c1);
            fundal.Controls.Add(c2);
            fundal.Controls.Add(c3);
            fundal.Controls.Add(c4);
            fundal.Controls.Add(c5);
            fundal.Controls.Add(usa_deschisa);
            fundal.Controls.Add(usa_inchisa);
        }

        bool st = false, dr = false, jump = false, jos = true;
        int wl, wr, s, puncte=5;

        //toate verificarile urmatoare returneaza false daca detecteaza ceva si true daca nu detecteaza ceva in partea respectiva
        //verificare daca da cu capu de ceva cand sare
        bool verificare_sus(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Top - 2 * viteza <= x.Top + x.Height && player.Top > x.Top + x.Height)
                        if ((player.Left + player.Width >= x.Left) && (player.Left <= x.Left + x.Width))
                            return false;
            }
            return true;
        }

        //verificare daca are o platforma sub el
        bool verificare_jos(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Top + player.Height + viteza >= x.Top && player.Top < x.Top)
                        if ((player.Left + player.Width >= x.Left) && (player.Left <= x.Left + x.Width))
                            return false;
            }
            return true;
        }

        //verificare daca are ceva langa el la dreapta sa nu intre prin platforma
        bool verificare_dreapta(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Left + player.Width + viteza >= x.Left && player.Left < x.Left)
                        if ((player.Top + player.Height >= x.Top) && (player.Top <= x.Top + x.Height))
                            return false;
            }
            return true;
        }

        //verificare daca are ceva langa el la stanga sa nu intre prin platforma
        bool verificare_stanga(PictureBox player)
        {
            foreach (Control x in this.fundal.Controls)
            {
                if ((string)x.Tag == "platforma")
                    if (player.Left - viteza <= x.Left + x.Width && player.Left > x.Left + x.Width)
                        if ((player.Top + player.Height >= x.Top) && (player.Top <= x.Top + x.Height))
                            return false;
            }
            return true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                st = true;
                player.Image = Properties.Resources.caracter_stanga;
            }
            if (e.KeyCode == Keys.Right)
            {
                dr = true;
                player.Image = Properties.Resources.caracter_dreapta;
            }
            if (e.KeyCode == Keys.Up && !jump && !verificare_jos(player))
            {
                s = player.Top;
                jump = true;
                jos = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = false;
            if (e.KeyCode == Keys.Right)
                dr = false;
        }

        int viteza = 5;
        // 174 si 234
        // 328 si 177 == 151

        private void timer1_Tick(object sender, EventArgs e)
        {
            wl = 0 - fundal.Left;
            wr = wl + 475;

            if (jos && verificare_jos(player))
                player.Top += viteza;

            if (st && verificare_stanga(player))
            {
                if (player.Left > wl + 50)
                    player.Left -= viteza;
                if (player.Left <= wl + 50 && wl > fundal.Left)
                {
                    fundal.Left += viteza;
                    player.Left -= viteza;
                }
            }

            if (dr && verificare_dreapta(player))
            {
                if (player.Left < wr - player.Width - 50)
                    player.Left += viteza;
                if (player.Left >= wr - player.Width - 50 && wr < fundal.Width)
                {
                    fundal.Left -= viteza;
                    player.Left += viteza;
                }
            }

            if (jump==true)
            {
                if(verificare_sus(player))
                {
                    if (player.Top > s - 150 && !jos)
                        player.Top -= viteza;
                    else
                        jos = true;
                }
                else
                {
                    jos = true;
                }
                if (!verificare_jos(player))
                    jump = false;
            }

            foreach(Control x in this.fundal.Controls)
            {
                if((string)x.Tag=="coin" && x.Visible==true && player.Bounds.IntersectsWith(x.Bounds))
                {
                    x.Visible = false;
                    puncte--;
                    lbl_scor.Text = Convert.ToString(puncte);
                }
            }

            if (puncte == 0)
            {
                usa_deschisa.Visible = true;
                usa_inchisa.Visible = false;
            }

            if (usa_deschisa.Visible == true && player.Bounds.IntersectsWith(usa_deschisa.Bounds))
            {
                Game_Over f = new Game_Over();
                timer1.Stop();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
