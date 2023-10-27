using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT_Simu_Mircea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[,] m = new int[3, 3]
        {
            {0,0,0},
            {0,0,0},
            {0,0,0}
        };
        int j=1;

        //butoane
        private void m1_Click(object sender, EventArgs e)
        {
            if (j == 1)
            {
                x1.Visible = true;
            }
            if (j == 2)
            {
                o1.Visible = true;
            }
            m[0, 0] = j;
            m1.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m2_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x2.Visible = true;
            if (j == 2)
                o2.Visible = true;
            m[0, 1] = j;
            m2.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m3_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x3.Visible = true;
            if (j == 2)
                o3.Visible = true;
            m[0, 2] = j;
            m3.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m4_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x4.Visible = true;
            if (j == 2)
                o4.Visible = true;
            m[1, 0] = j;
            m4.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m5_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x5.Visible = true;
            if (j == 2)
                o5.Visible = true;
            m[1, 1] = j;
            m5.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m6_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x6.Visible = true;
            if (j == 2)
                o6.Visible = true;
            m[1, 2] = j;
            m6.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m7_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x7.Visible = true;
            if (j == 2)
                o7.Visible = true;
            m[2, 0] = j;
            m7.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m8_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x8.Visible = true;
            if (j == 2)
                o8.Visible = true;
            m[2, 1] = j;
            m8.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void m9_Click(object sender, EventArgs e)
        {
            if (j == 1)
                x9.Visible = true;
            if (j == 2)
                o9.Visible = true;
            m[2, 2] = j;
            m9.Visible = false;
            if (j == 1)
                j = 2;
            else
                j = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j == 1)
            {
                xj.Visible = true;
                oj.Visible = false;
            }
            if (j == 2)
            {
                xj.Visible = false;
                oj.Visible = true;
            }
            if(m[0,0]==1 && m[0,1]==1 && m[0,2]==1 || m[1, 0] == 1 && m[1, 1] == 1 && m[1, 2] == 1 ||
                m[2, 0] == 1 && m[2, 1] == 1 && m[2, 2] == 1 || m[0, 0] == 1 && m[1, 0] == 1 && m[2, 0] == 1 ||
                m[0, 1] == 1 && m[1, 1] == 1 && m[2, 1] == 1 || m[0, 2] == 1 && m[1, 2] == 1 && m[2, 2] == 1 ||
                m[0, 0] == 1 && m[1, 1] == 1 && m[2, 2] == 1 || m[0, 2] == 1 && m[1, 1] == 1 && m[2, 0] == 1)
            {
                Finalx f = new Finalx();
                f.Show();
                this.Close();
            }
            else
                if (m[0, 0] == 2 && m[0, 1] == 2 && m[0, 2] == 2 || m[1, 0] == 2 && m[1, 1] == 2 && m[1, 2] == 2 ||
                m[2, 0] == 2 && m[2, 1] == 2 && m[2, 2] == 2 || m[0, 0] == 2 && m[1, 0] == 2 && m[2, 0] == 2 ||
                m[0, 1] == 2 && m[1, 1] == 2 && m[2, 1] == 2 || m[0, 2] == 2 && m[1, 2] == 2 && m[2, 2] == 2 ||
                m[0, 0] == 2 && m[1, 1] == 2 && m[2, 2] == 2 || m[0, 2] == 2 && m[1, 1] == 2 && m[2, 0] == 2)
            {
                Finalo f = new Finalo();
                f.Show();
                this.Close();
            }
                else
                if (m1.Visible == false && m2.Visible == false && m3.Visible == false && m4.Visible == false && m5.Visible == false &&
                 m6.Visible == false && m7.Visible == false && m8.Visible == false && m9.Visible == false)
            {
                Egalitate f = new Egalitate();
                f.Show();
                this.Close();
            }
        }
    }
}
