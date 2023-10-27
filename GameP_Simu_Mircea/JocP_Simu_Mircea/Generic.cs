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
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form1 f;
            f = new Form1();
            this.Hide();
            f.ShowDialog();
        }
    }
}
