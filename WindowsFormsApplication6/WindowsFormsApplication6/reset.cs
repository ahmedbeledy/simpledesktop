using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication6
{
    public partial class reset : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public reset()
        {
            InitializeComponent();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            if (((textBox2.Text == "drwaled") || (textBox2.Text == "drhaidy")) && textBox5.Text == "clinic")
            {






                SQLiteDataAdapter da = new SQLiteDataAdapter("Select  secmonth,Id FROM patient", con);

                DataSet ds = new DataSet();
                MessageBox.Show("شهر جديد سعيد ", "نم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                da.Fill(ds);
                string y, id;
                SQLiteCommand cmd;

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    con.Open();

                    cmd = new SQLiteCommand("UPDATE patient Set take = 0  WHERE take =  1", con);
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        y = ds.Tables[0].Rows[i]["secmonth"].ToString();
                        id = ds.Tables[0].Rows[i]["Id"].ToString();
                        if (y == "1")
                        {
                            cmd = new SQLiteCommand("UPDATE patient Set secmonth = 0  WHERE Id = '" + id + "'", con);
                            cmd.ExecuteNonQuery();
                        }
                        else if (y == "2")
                        {
                            cmd = new SQLiteCommand("UPDATE patient Set secmonth = 1  WHERE Id = '" + id + "'", con);
                            cmd.ExecuteNonQuery();
                        }
                        else if (y == "0")
                        {
                            cmd = new SQLiteCommand("UPDATE patient Set secmonth = 2   WHERE id = '" + id + "'", con);
                            cmd.ExecuteNonQuery();
                        }



                    }
                }
               
            }

            else
            {
                MessageBox.Show("خطا فى البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            this.Close();

        }
               private void label5_Click(object sender, EventArgs e)
        {

        }

               private void reset_Load(object sender, EventArgs e)
               {

               }
 
    
    
    }
}
    
             
              
                

        
    

