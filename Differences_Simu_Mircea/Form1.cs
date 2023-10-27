using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diferente_Gurbai_Bogdan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dif_1.Visible = true;
            dif_2.Visible = true;
            dif_3.Visible = true;
            dif_4.Visible = true;
            dif_5.Visible = true;
            picbox3.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        int nr = 6;
        int viata = 3;

        private void dif_1_Click(object sender, EventArgs e)
        {
            nr--;
            dif_1.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void dif_2_Click(object sender, EventArgs e)
        {
            nr--;
            dif_2.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void dif_3_Click(object sender, EventArgs e)
        {
            nr--;
            dif_3.Visible = false;
            picbox3.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void restart_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            dif_1.Visible = true;
            dif_2.Visible = true;
            dif_3.Visible = true;
            dif_4.Visible = true;
            picbox3.Visible = true;
            pictureBox3.Visible = true;
            dif_5.Visible = true;
            pictureBox4.Visible = true;
            dif_6.Visible = true;
            viata1.Visible = true;
            viata2.Visible = true;
            viata3.Visible = true;
            nr = 6;
            viata = 3;
            contor.Text = Convert.ToString(nr);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            picbox3.Visible = false;
            nr--;
            dif_3.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void dif_4_Click(object sender, EventArgs e)
        {
            nr--;
            dif_4.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            nr--;
            dif_1.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void dif_5_Click(object sender, EventArgs e)
        {
            nr--;
            dif_5.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dif_2.Visible = false;
            pictureBox4.Visible = false;
            nr--;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            viata--;
            if (viata == 2)
                viata3.Visible = false;
            if (viata == 1)
            {
                viata2.Visible = false;
                viata3.Visible = false;
            }
            if (viata == 0)
            {
                viata1.Visible = false;
                viata2.Visible = false;
                viata3.Visible = false;
                label6.Visible = true;
                dif_1.Visible = true;
                dif_2.Visible = true;
                dif_3.Visible = true;
                dif_4.Visible = true;
                picbox3.Visible = true;
                pictureBox3.Visible = true;
                dif_5.Visible = true;
                pictureBox4.Visible = true;
                dif_6.Visible = true;
                viata1.Visible = true;
                viata2.Visible = true;
                viata3.Visible = true;
                nr = 6;
                viata = 3;
                contor.Text = Convert.ToString(nr);
            }
        }

        private void dif_6_Click(object sender, EventArgs e)
        {
            nr--;
            dif_6.Visible = false;
            contor.Text = Convert.ToString(nr);
            if (nr == 0)
                MessageBox.Show("Ai câștigat!");
        }
    }
}