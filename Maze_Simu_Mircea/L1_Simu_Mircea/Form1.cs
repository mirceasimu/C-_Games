using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_Simu_Mircea
{
    public partial class Labirint1 : Form
    {
        public Labirint1()
        {
            InitializeComponent();
        }
        bool sus, jos, st, dr;
        int v = 5;
        int vieti=5;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (st == true)
                player.Left = player.Left - v;
            if (dr == true)
                player.Left = player.Left + v;
            if (sus == true)
                player.Top = player.Top - v;
            if (jos == true)
                player.Top = player.Top + v;
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "ziduri")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        vieti--;
                        lbl_vieti.Text = Convert.ToString(vieti);
                        player.Left = 773;
                        player.Top = 60;
                    }
                }
            }
            if (player.Bounds.IntersectsWith(finish_line.Bounds))
            {
                ai_castigat.Visible = true;
                exit.Visible = true;
                v = 0;
            }
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
            if (vieti == 0)
            {
                ai_pierdut.Visible = true;
                v = 0;
                exit.Visible = true;
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
        }
    }
}
