﻿using System;
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
    public partial class newmortb : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataTable dt = new DataTable();

        DataSet ds = new DataSet();
        public newmortb()
        {
            InitializeComponent();
        }

        
        private void newmortb_Load(object sender, EventArgs e)
        {
            ds.Clear();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;
            


            ds.Clear();
            cmd = new SQLiteCommand();
            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT medicine FROM medicine WHERE medicine LIKE '" + cbMtrlName.Text + "%'";
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
            cbMtrlName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbMtrlName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbMtrlName.AutoCompleteCustomSource = namesCollection;
            con.Close();


        }


        private void mtbQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPO_Click(object sender, EventArgs e)
        {
        }

        private void txtCstName_TextChanged(object sender, EventArgs e)
        {

        }

        public void cbMtrlName_OnCausesValidationChanged(object sender, EventArgs e)
        {

        }

        public void cbMtrlName_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbMtrlName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            month.Enabled = false;


            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Idm FROM medicine WHERE medicine LIKE '" + cbMtrlName.Text + "'", con);
            DataSet ds = new DataSet();
            string x = "";
            try
            {
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    x = ds.Tables[0].Rows[0]["Idm"].ToString();

                }
                else
                {
                    MessageBox.Show("خطا فى الصنف", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            finally { }
            if (textBox1.Text != "" && cbMtrlName.Text != "")
            {
                DataColumn dco0 = new DataColumn("العدد");
                DataColumn dco1 = new DataColumn("رقم الصنف");
                DataColumn dco2 = new DataColumn("رقم المرتب");
                if (dt.Columns.Count == 0)
                {
                    dt.Columns.Add(dco0);
                    dt.Columns.Add(dco1);
                    dt.Columns.Add(dco2);
                }
                for (int i = 1; i < 2; i++)
                {
                    DataRow row1 = dt.NewRow();
                    row1["رقم الصنف"] = x;
                    row1["رقم المرتب"] = textBox1.Text;
                    row1["العدد"] = number.Text;
                    dt.Rows.Add(row1);
                }
                dataGridView1.DataSource = dt;

            }
            else
            {
                MessageBox.Show("خطا ", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void btnPO_Click_1(object sender, EventArgs e)
        {
           if (textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!=""&&textBox4.Text!=""&&textBox5.Text!="")
           {
               if (month.Text.ToString() == "شهر")
               {
                   SQLiteCommand cmd = new SQLiteCommand();
                   cmd.Connection = con;
                   con.Open();

                   cmd = new SQLiteCommand("Insert into patient (number,degree,place,name,type,service) values(@a,@b,@c,@d,@e,@f)", con);
                   cmd.Parameters.AddWithValue("@a", textBox1.Text);
                   cmd.Parameters.AddWithValue("@b", textBox3.Text);
                   cmd.Parameters.AddWithValue("@c", textBox4.Text);
                   cmd.Parameters.AddWithValue("@d", textBox2.Text);
                   cmd.Parameters.AddWithValue("@e", textBox5.Text);
                   cmd.Parameters.AddWithValue("@f", textBox6.Text);




                   try
                   {
                       int r = cmd.ExecuteNonQuery();
                   }
                  
                   finally
                   {

                       con.Close();

                   }
                   con.Open();
                   int count = dataGridView1.Rows.Count;
                   for (int i = 0; i < count; i++)
                   {
                       cmd = new SQLiteCommand("Insert into sarf (number,idp,idm) values(@a,@b,@c)", con);
                       cmd.Parameters.AddWithValue("@a", dataGridView1.Rows[i].Cells["العدد"].Value);
                       cmd.Parameters.AddWithValue("@b", dataGridView1.Rows[i].Cells["رقم المرتب"].Value);
                       cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["رقم الصنف"].Value);




                       try
                       {
                           int r = cmd.ExecuteNonQuery();
                       }
                       catch
                       {

                       }

                       finally
                       {

                       }
                   }
                   con.Close();
                   MessageBox.Show("تمت الاضافه بنجاح ", "Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);


               }
               else if (month.Text.ToString() == "شهرين")
               {
                   SQLiteCommand cmd = new SQLiteCommand();
                   cmd.Connection = con;
                   con.Open();

                   cmd = new SQLiteCommand("Insert into patient (number,degree,place,name,type,month,service) values(@a,@b,@c,@d,@e,1,@f)", con);
                   cmd.Parameters.AddWithValue("@a", textBox1.Text);
                   cmd.Parameters.AddWithValue("@b", textBox3.Text);
                   cmd.Parameters.AddWithValue("@c", textBox4.Text);
                   cmd.Parameters.AddWithValue("@d", textBox2.Text);
                   cmd.Parameters.AddWithValue("@e", textBox5.Text);
                   cmd.Parameters.AddWithValue("@f", textBox5.Text);

                   int count = dataGridView1.Rows.Count;


                   try
                   {
                       int r = cmd.ExecuteNonQuery();
                   }
                   catch
                   {
                       MessageBox.Show("الرقم موجود بالفعل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                       this.Close();
                   }

                   finally
                   {
                       con.Close();
                       
                   }
                   con.Open();

                   for (int i = 0; i < count; i++)
                   {
                       cmd = new SQLiteCommand("Insert into sarf (number,idp,idm) values(@a,@b,@c)", con);
                       cmd.Parameters.AddWithValue("@a", dataGridView1.Rows[i].Cells["العدد"].Value);
                       cmd.Parameters.AddWithValue("@b", dataGridView1.Rows[i].Cells["رقم المرتب"].Value);
                       cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["رقم الصنف"].Value);
                       try
                       {
                           int r = cmd.ExecuteNonQuery();
                       }
                       catch
                       {

                       }

                       finally
                       {

                       }

                   }
                   con.Close();
                   MessageBox.Show("تمت الاضافه بنجاح ", "Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
               else
               {
                   MessageBox.Show("اكمل كل البيانات ", "مشكلة", MessageBoxButtons.OK, MessageBoxIcon.Stop);

               }
               this.Close();
           }
           else
           {



               MessageBox.Show("اكمل كل البيانات ", "مشكلة", MessageBoxButtons.OK, MessageBoxIcon.Stop);


           }
        }

        private void textBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

