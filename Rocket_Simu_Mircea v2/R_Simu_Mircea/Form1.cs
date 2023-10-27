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
        bool sus, jos, st, dr, tragere;
        int v = 5; //viteza rachetei
        int va = 7; // viteza asteroidului

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            // miscarea asteroidului

            foreach(Control x in this.Controls)
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
                    if (laser.Bounds.IntersectsWith(x.Bounds))
                    {
                        Random nr = new Random();
                        int y = nr.Next(1, this.Width);
                        x.Top = -x.Height;
                        x.Left = y;
                        x.Width = nr.Next(30, 150);
                        x.Height = nr.Next(30, 150);
                        laser.Top = -10;
                    }
                }
            }
            // tragere laser
            if (tragere == true && laser.Visible == false)
            {
                laser.Top = racheta.Top;
                laser.Left = racheta.Left + 28;
                laser.Visible = true;
            }
            laser.Top = laser.Top - 20;
            if (laser.Top < 0)
                laser.Visible = false;

            //mori
            if (vieti == 0)
            {
                timer1.Stop();
                this.Hide();
                Form f = new Game_Over();
                f.ShowDialog();
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
                tragere = false;
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
                tragere = true;
        }
    }
}
