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
    public partial class Generic2 : Form
    {
        public Generic2()
        {
            InitializeComponent();
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void incepe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Labirint1 f = new Labirint1();
            f.ShowDialog();
        }
    }
}
