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
    public partial class newmedicine : Form

    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public newmedicine()
        {
            InitializeComponent();
        }

        private void totalcus_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            if (mtbQuantity.Text == "" || totalcus.Text == "")
            {
                MessageBox.Show("الاماكن فارغه من فضلك ادخل الارقام صحيحه", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                con.Open();

                cmd = new SQLiteCommand("Insert into medicine (medicine,price) values(@b,@c)", con);
                cmd.Parameters.AddWithValue("@b", totalcus.Text);
                cmd.Parameters.AddWithValue("@c", mtbQuantity.Text);



                try
                {
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت الاضافه بنجاح ", "Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("خطأ ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                finally
                {
                    con.Close();
                    mtbQuantity.Text = "";
                    totalcus.Text = "";
                }

            }
        }

        private void newmedicine_Load(object sender, EventArgs e)
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

        private void mtbQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
