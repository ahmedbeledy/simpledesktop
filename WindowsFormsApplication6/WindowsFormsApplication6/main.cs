using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void احصائياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset x=new reset ();
            x.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void صرفمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
           sarf x = new sarf();
            x.Show();

        }

        private void اضافهصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newmedicine x = new newmedicine();
            x.Show();
        }

        private void تعديلصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatem x = new updatem();
            x.Show();
        }

        private void مرتبجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newmortb y = new newmortb();
            y.Show();
        }

        private void احصائياتمنصرفواToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void تعديلصنفToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            updatem x = new updatem();
            x.Show();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void صرفمرتبToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تعديلمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editmortb x=new editmortb();
            x.Show();
        }

        private void احصائياتمفصلةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats x = new stats();
            x.Show();

        }

        private void عرضمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mortbshow x = new mortbshow();
            x.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void مرتبجديدToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newmortb x = new newmortb();
            x.Show();

        }

        private void صرفمرتبToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sarf x = new sarf();
            x.Show();
        }

        private void احصائياتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            reset x = new reset();
            x.Show();
        }

        private void احصائياتفعليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats x = new stats();
            x.Show();
        }

        private void احصائياتمنصرفواToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            statc x = new statc();
            x.Show();
        }

        private void عرضمرتبToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mortbshow x = new mortbshow();
            x.Show();

        }

        private void تعديلمرتبToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editmortb x = new editmortb();
            x.Show();

        }

        private void اضافهصنفToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newmedicine x = new newmedicine();
            x.Show();
        }

        private void تعديلصنفToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            updatem x = new updatem();
            x.Show();
        }
    }
}
