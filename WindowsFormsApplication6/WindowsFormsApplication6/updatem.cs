using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace WindowsFormsApplication6
{
    public partial class updatem : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public updatem()
        {
            InitializeComponent();
        }

        private void updatem_Load(object sender, EventArgs e)
        {
            ds.Clear();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT medicine FROM medicine WHERE medicine LIKE '" + totalcus.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["medicine"].ToString());
            }
            else
            {
                // namesCollection.Add(dReader["No record found"].ToString());

            }
            dReader.Close();
            totalcus.AutoCompleteMode = AutoCompleteMode.Suggest;
            totalcus.AutoCompleteSource = AutoCompleteSource.CustomSource;
            totalcus.AutoCompleteCustomSource = namesCollection;
            con.Close();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            if ( mtbQuantity.Text == "" || totalcus.Text == "")
            {
                MessageBox.Show("املىء الفراغات ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    con.Open();
                    SQLiteCommand cmd ;
                    cmd = new SQLiteCommand("UPDATE medicine Set price = '" + mtbQuantity.Text + "' WHERE medicine = '" + totalcus.Text + "'", con);
                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mtbQuantity.Text = "";
                        totalcus.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("خطا", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    }
                    
             
                finally
                {
                    con.Close();
                }


            }
        }

        private void cbMtrlName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
