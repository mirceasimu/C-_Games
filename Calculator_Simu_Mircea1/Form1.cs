using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator_Simu_Mircea1
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);
        public Form1()
        {
            InitializeComponent();
        }

        int nr1, nr2;
        int op;

        private void button4_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(lbl_ecran.Text);
            lbl_ecran.Text = " ";
            op = 2;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '1';
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '2';
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '3';
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '5';
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '6';
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '7';
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '8';
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '9';
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '0';
        }

        private void btn_inmultire_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(lbl_ecran.Text);
            lbl_ecran.Text = " ";
            op = 4;
        }

        private void btn_impartire_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(lbl_ecran.Text);
            lbl_ecran.Text = " ";
            op = 3;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            lbl_ecran.Text = lbl_ecran.Text + '4';
        }

        private void btn_egal_Click(object sender, EventArgs e)
        {
            nr2 = Convert.ToInt32(lbl_ecran.Text);
            lbl_ecran.Text = " ";
            if (op == 1)
                lbl_ecran.Text = Convert.ToString(nr1 + nr2);
            else
                if (op == 2)
                lbl_ecran.Text = Convert.ToString(nr1 - nr2);
            else
                    if (op == 3)
                lbl_ecran.Text = Convert.ToString(nr1 / nr2);
            else
                lbl_ecran.Text = Convert.ToString(nr1 * nr2);
        }

        private void lbl_ecran_Click(object sender, EventArgs e)
        {

        }

        private void btn_sterge_Click(object sender, EventArgs e)
        {
            if (lbl_ecran.Text != string.Empty)
            {
                int txtlenght = lbl_ecran.Text.Length;
                if (txtlenght != 1)
                {
                    lbl_ecran.Text = lbl_ecran.Text.Remove(txtlenght - 1);
                }
                else
                {
                    lbl_ecran.Text = 0.ToString();
                    lbl_ecran.Text = "";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, 0xA1, 0x2, 0);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nr1 = 0;
            nr2 = 0;
            op = 0;
            lbl_ecran.Text = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            nr1 = Convert.ToInt32(lbl_ecran.Text);
            lbl_ecran.Text = " ";
            op = 1;
        }

    }
}
