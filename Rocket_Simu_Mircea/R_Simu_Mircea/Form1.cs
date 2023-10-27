using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_Simu_Mircea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sus, jos, st, dr, space;
        int v = 15; //viteza rachetei
        int va = 10; // viteza asteroidului
        int punctaj = 0;
        int l = 3;

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ai_pierdut.Visible = false;
            iesire.Visible = false;
            button1.Visible = false;
            timer1.Start();
            punctaj = 0;
            puncte.Text = Convert.ToString(punctaj);
            vieti = 5;
            lbl_vieti.Text = Convert.ToString(vieti);
        }

        int vieti =5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //miscarea rachetei
            if (st == true)
            {
                if (racheta.Left <= 0)
                    racheta.Left = racheta.Left + 3;
                else
                    racheta.Left = racheta.Left - v;
            }
            if (dr == true)
            {
                if (racheta.Left >= this.Width-racheta.Width-20)
                    racheta.Left = racheta.Left - 3;
                else
                    racheta.Left = racheta.Left + v;
            }
            if (sus == true)
            {
                if (racheta.Top <= 0)
                    racheta.Top = racheta.Top + 3;
                else
                    racheta.Top = racheta.Top - v;
            }
            if (jos == true)
            {
                if (racheta.Top >= this.Height-racheta.Height-40)
                    racheta.Top = racheta.Top - 3;
                else
                    racheta.Top = racheta.Top + v;
            }
            if (space == true)
            {
                if (l>0)
                {
                    if (l == 3 && laser.Left==-10)
                    {
                        l--;
                        lasere.Text = Convert.ToString(l);
                        laser.Visible = true;
                        laser.Top = racheta.Top - laser.Height;
                        laser.Left = racheta.Left + racheta.Width * 1 / 2 - 5;
                    }
                    else
                    {
                        if (l == 2 && laser2.Left == -10)
                        {
                            l--;
                            lasere.Text = Convert.ToString(l);
                            laser2.Visible = true;
                            laser2.Top = racheta.Top - laser2.Height;
                            laser2.Left = racheta.Left + racheta.Width * 1 / 2 - 5;
                        }
                        else
                        {
                            if (l == 1 && laser3.Left == -10)
                            {
                                l--;
                                lasere.Text = Convert.ToString(l);
                                laser3.Visible = true;
                                laser3.Top = racheta.Top - laser3.Height;
                                laser3.Left = racheta.Left + racheta.Width * 1 / 2 - 5;
                            }
                        }
                    }
                }
            }
            if(laser.Left!=-10)
                laser.Top = laser.Top - 10;
            if (laser2.Left != -10)
                laser2.Top = laser2.Top - 10;
            if (laser3.Left != -10)
                laser3.Top = laser3.Top - 10;

            if (laser.Top <= -laser.Top && laser.Left > 0)
            {
                laser.Left = -10;
                l++;
                lasere.Text = Convert.ToString(l);
            }
            if (laser2.Top <= -laser2.Top && laser2.Left>0)
            {
                laser2.Left = -10;
                l++;
                lasere.Text = Convert.ToString(l);
            }
            if (laser3.Top <= -laser3.Top && laser3.Left > 0)
            {
                laser3.Left = -10;
                l++;
                lasere.Text = Convert.ToString(l);
            }

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "asteroid")
                {
                    if (laser.Bounds.IntersectsWith(x.Bounds))
                    {
                        l++;
                        lasere.Text = Convert.ToString(l);
                        Random nr = new Random();
                        int y = nr.Next(1, this.Width);
                        x.Top = -x.Height;
                        x.Left = y;
                        x.Width = nr.Next(30, 150);
                        x.Height = nr.Next(30, 150);
                        laser.Left=-10;
                        punctaj = punctaj + 10;
                        puncte.Text = Convert.ToString(punctaj);
                    }
                    if (laser2.Bounds.IntersectsWith(x.Bounds))
                    {
                        l++;
                        lasere.Text = Convert.ToString(l);
                        Random nr = new Random();
                        int y = nr.Next(1, this.Width);
                        x.Top = -x.Height;
                        x.Left = y;
                        x.Width = nr.Next(30, 150);
                        x.Height = nr.Next(30, 150);
                        laser2.Left = -10;
                        punctaj = punctaj + 10;
                        puncte.Text = Convert.ToString(punctaj);
                    }
                    if (laser3.Bounds.IntersectsWith(x.Bounds))
                    {
                        l++;
                        lasere.Text = Convert.ToString(l);
                        Random nr = new Random();
                        int y = nr.Next(1, this.Width);
                        x.Top = -x.Height;
                        x.Left = y;
                        x.Width = nr.Next(30, 150);
                        x.Height = nr.Next(30, 150);
                        laser3.Left = -10;
                        punctaj = punctaj + 10;
                        puncte.Text = Convert.ToString(punctaj);
                    }
                }
            }

            if(punctaj==100)
            {
                ai_castigat.Visible = true;
                iesire.Visible = true;
                timer1.Stop();
            }

            if(vieti==0)
            {
                ai_pierdut.Visible = true;
                iesire.Visible = true;
                timer1.Stop();
            }

            // miscarea asteroidului

            foreach (Control x in this.Controls)
            {
                if((string)x.Tag=="asteroid")
                {
                    if (x.Top <= this.Height)
                        x.Top = x.Top + va;
                    else
                    {
                        Random nr = new Random();
                        int y = nr.Next(1, this.Width);
                        x.Top = -x.Height;
                        x.Left = y;
                        x.Width = nr.Next(30, 150);
                        x.Height = nr.Next(30, 150);
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "asteroid")
                {
                    if (racheta.Bounds.IntersectsWith(x.Bounds))
                    {
                        vieti--;
                        lbl_vieti.Text = Convert.ToString(vieti);
                        Random nr = new Random();
                        int y = nr.Next(1, this.Width);
                        x.Top = -x.Height;
                        x.Left = y;
                        x.Width = nr.Next(30, 150);
                        x.Height = nr.Next(30, 150);
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = false;
            if (e.KeyCode == Keys.Right)
                dr = false;
            if (e.KeyCode == Keys.Up)
                sus = false;
            if (e.KeyCode == Keys.Down)
                jos = false;
            if (e.KeyCode == Keys.Space)
                space = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = true;
            if (e.KeyCode == Keys.Right)
                dr = true;
            if (e.KeyCode == Keys.Up)
                sus = true;
            if (e.KeyCode == Keys.Down)
                jos = true;
            if (e.KeyCode == Keys.Space)
                space = true;
        }
    }
}
