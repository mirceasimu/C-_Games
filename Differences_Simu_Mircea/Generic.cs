﻿using System;
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
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void Generic_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Generic_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
