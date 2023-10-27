using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_Simu_Mircea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] m = new int[16, 30] { {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                                     {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 }};

        int l;
        int c;
        int l1, c1;
        Random r = new Random();
        Point current = new Point();

        private void start_verde_Click_1(object sender, EventArgs e)
        {
            int bombe = 0;
            int bombemax = 90;
            //l = r.Next(0, 16);
            //c = r.Next(0, 30);
            //l1 = l;
            //c1 = c;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 30; j++)
            //    {
            //        l = new Random().Next(0, 16);
            //        c = new Random().Next(0, 30);
            //        if (l != l1 || c != c1)
            //        {
            //            l1 = l;
            //            c1 = c;
            //            listBox1.Items.Add(l + " " + c);
            //            int aux;
            //            aux = m[i, j];
            //            m[i, j] = m[l, c];
            //            m[l, c] = aux;
            //        }
            //        else
            //            j--;
            //    }
            //}

            do
            {
                bombe++;
                do
                {
                    l = r.Next(0, 16);
                    c = r.Next(0, 30);
                } while (m[l, c] != 0);
                m[l, c] = -1;
            } while (bombe <= bombemax);

            start_verde.Visible = false;
            // pana aici se face matricea cu 0 si -1 random puși

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if(m[i,j]==-1)
                    {
                        for(int v1=-1;v1<=1;v1++)
                            for(int v2=-1;v2<=1;v2++)
                            {
                                if(i+v1 >=0 && i+v1 <16 && j+v2<30 && j+v2>=0)
                                    if (m[i + v1, j + v2] != -1)
                                        m[i + v1, j + v2]++;
                            }
                    }
                }
            }
        }

        void parcurgere(int i, int j, PictureBox pic)
        {
            if(i>=0 && i<16 && j>=0 && j<30)
            {
                if (m[i, j] == 0)
                {
                    pic.Image = Properties.Resources._0;
                    pic.Top = i * 16 + 50;
                    pic.Left = j * 16 + 8;
                    pic.Visible = true;
                    pic.BringToFront();
                    pic.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.Controls.Add(pic);
                    PictureBox pic1 = new PictureBox();
                    parcurgere(i, j+1, pic1);
                    //parcurgere(i, j-1, pic1);
                    //parcurgere(i+1, j);
                    //parcurgere(i-1, j);
                }
                else
                    if (m[i, j] > 0)
                {
                    if (m[i, j] == 1)
                        pic.Image = Properties.Resources._1;
                    if (m[i, j] == 2)
                        pic.Image = Properties.Resources._2;
                    if (m[i, j] == 3)
                        pic.Image = Properties.Resources._3;
                    if (m[i, j] == 4)
                        pic.Image = Properties.Resources._4;
                    if (m[i, j] == 5)
                        pic.Image = Properties.Resources._5;
                    pic.Top = i * 16 + 50;
                    pic.Left = j * 16 + 8;
                    pic.Visible = true;
                    pic.BringToFront();
                    pic.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.Controls.Add(pic);
                }
                else
                    if (m[i, j] == -1)
                {
                    pic.Image = Properties.Resources.bomba_nelovita;
                    pic.Top = i * 16 + 50;
                    pic.Left = j * 16 + 8;
                    pic.Visible = true;
                    pic.BringToFront();
                    pic.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.Controls.Add(pic);
                }
            }
        }

    private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            current = me.Location;
            int mx=me.X, my=me.Y;
            mx = (mx - 8) / 16;
            my = (my - 50) / 16;
            if(me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                /*foreach(Control x in this.Controls)
                {
                    if((string)x.Tag=="steag")
                    {
                        x.Dispose();
                    }
                }*/
                PictureBox p = new PictureBox();
                p.Image = Properties.Resources.steag;
                p.Top = my * 16 + 50;
                p.Left = mx * 16 + 8;
                p.Visible = true;
                p.Tag = "steag";
                p.BringToFront();
                p.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(p);
            }
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PictureBox p = new PictureBox();
                if (m[my, mx] == 0)
                {
                    parcurgere(my, mx, p);
                    //p.Image = Properties.Resources._0;
                }
                if (m[my, mx] == 1)
                    p.Image = Properties.Resources._1;
                if (m[my, mx] == 2)
                    p.Image = Properties.Resources._2;
                if (m[my, mx] == 3)
                    p.Image = Properties.Resources._3;
                if (m[my, mx] == 4)
                    p.Image = Properties.Resources._4;
                if (m[my, mx] == 5)
                    p.Image = Properties.Resources._5;
                p.Top = my * 16 + 50;
                p.Left = mx * 16 + 8;
                p.Visible = true;
                p.BringToFront();
                p.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(p);
                if (m[my, mx] == -1)
                {
                    p.Image = Properties.Resources.bomba_lovita;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            for (int i = 0; i != 16; i++)
            {
                listBox1.Items.Add(m[i, 0] + " " + m[i, 1] + " " + m[i, 2] + " " + m[i, 3] + " " + m[i, 4] + " " + m[i, 5] + " " + m[i, 6] + " " + m[i, 7] + " " + m[i, 8] + " " + m[i, 9] + " " + m[i, 10] + " " +
                                    m[i, 11] + " " + m[i, 12] + " " + m[i, 13] + " " + m[i, 14] + " " + m[i, 15] + " " + m[i, 16] + " " + m[i, 17] + " " + m[i, 18] + " " + m[i, 19] + " " + m[i, 20] + " " +
                                    m[i, 21] + " " + m[i, 22] + " " + m[i, 23] + " " + m[i, 24] + " " + m[i, 25] + " " + m[i, 26] + " " + m[i, 27] + " " + m[i, 28] + " " + m[i, 29]);
            }
        }
    }
}
