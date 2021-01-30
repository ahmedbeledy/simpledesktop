using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WindowsFormsApplication6
{
    public partial class mortbshow : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public mortbshow()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds = new DataSet();

            ds.Clear();
            da = new SQLiteDataAdapter("Select medicine.medicine as اسم ,medicine.price as سعرالوحدة, sarf.number  as العدد,medicine.price*sarf.number الاجمالى  FROM sarf INNER JOIN medicine ON  sarf.idm=medicine.Idm INNER JOIN patient ON patient.number = sarf.idp  where patient.number ='" + textBox1.Text + "' ", con);
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                ds = new DataSet();

                MessageBox.Show("لايوجد بيانات ");
            }
        }
    }
}
