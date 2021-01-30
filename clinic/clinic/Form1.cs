using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void صرفمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add x = new Add();
            x.Show();
        }

        private void مرتبجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تعديلمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stat x = new stat();
            x.Show();
        }
    }
}
