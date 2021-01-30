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
    public partial class sarf : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        string xx = "", y = "",res="", xy ="";

        public struct x
        {
            public  string name;
            public int number;
            public double price;
            public int numt;

            public x( string n, int numr,  float p, int nu)
            {
                name = n;
                number = numr;
                price = p;
                numt = nu;

            }
        }
      


        int m1, m2;
        int m3;
        DataSet ds = new DataSet();

        DataSet dx = new DataSet();


        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteCommand cmd = new SQLiteCommand();
        DataTable dt = new DataTable();




        public sarf()
        {
            


            InitializeComponent();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox2.Text != "" && textBox1.Text != "")
            {

                if (m2 == 0)
                {
                    if (m1 == 1)
                    {
                        MessageBox.Show("هذا الراتب مصروف من قبل ", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   

                    }
                    else
                    {
                        cmd = new SQLiteCommand("UPDATE patient SET take='1' WHERE number= '" + textBox1.Text + "'", con);

                        int r = cmd.ExecuteNonQuery();


                        
                       double sum = 0, sum5 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    
                    sum5 = Convert.ToDouble(dataGridView1.Rows[i].Cells["سعرالوحدة"].Value)*Convert.ToDouble(dataGridView1.Rows[i].Cells["العدد"].Value);

                    sum = sum + sum5;

                }

                            cmd = new SQLiteCommand();
                            cmd.Connection = con;

                            cmd = new SQLiteCommand("Insert into information (total,idp,date,place,service) values(@a,@b,@c,@d,@e)", con);
                            cmd.Parameters.AddWithValue("@a", sum);
                            cmd.Parameters.AddWithValue("@b", textBox1.Text);
                            cmd.Parameters.AddWithValue("@c", DateTime.Now);
                            cmd.Parameters.AddWithValue("@d", textBox4.Text);
                            cmd.Parameters.AddWithValue("@e", textBox6.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم صرف المرتب ", "good", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            int count = dataGridView1.Rows.Count;
                            SQLiteDataReader dr;
                            cmd = new SQLiteCommand("Select Id from information ORDER BY Id ", con);
                            dr = cmd.ExecuteReader();
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {

                                    res = dr[0].ToString();
                                }

                            }
                            dr.Close();
                            for (int i = 0; i < count ; i++)
                            {

                                cmd.Connection = con;
                                cmd = new SQLiteCommand("Insert into stats (id,idm,number,price) values(@d,@a,@b,@c)", con);
                                cmd.Parameters.AddWithValue("@d", res);
                                cmd.Parameters.AddWithValue("@a", dataGridView1.Rows[i].Cells["رقم"].Value);
                                cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["سعرالوحدة"].Value);
                                cmd.Parameters.AddWithValue("@b", dataGridView1.Rows[i].Cells["العدد"].Value);


                                cmd.ExecuteNonQuery();


                            }



                    }

                }
                else if (m2 == 1 && m3 == 2)
                {
                    cmd = new SQLiteCommand("UPDATE patient SET secmonth ='1' WHERE number='" + textBox1.Text + "'", con);
                    MessageBox.Show("تم صرف المرتب ", "good", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int r = cmd.ExecuteNonQuery();


                    double sum = 0, sum5 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {

                        sum5 = Convert.ToDouble(dataGridView1.Rows[i].Cells["سعرالوحدة"].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells["العدد"].Value);

                        sum = sum + sum5;

                    }
                    cmd = new SQLiteCommand();
                    cmd.Connection = con;

                    cmd = new SQLiteCommand("Insert into information (total,idp,date,place,service) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", sum);
                    cmd.Parameters.AddWithValue("@b", textBox1.Text);
                    cmd.Parameters.AddWithValue("@c", DateTime.Now);
                    cmd.Parameters.AddWithValue("@d", textBox4.Text);
                    cmd.Parameters.AddWithValue("@e", textBox6.Text);


                    cmd.ExecuteNonQuery();
                    int count = dataGridView1.Rows.Count;

                   count = dataGridView1.Rows.Count;
                        SQLiteDataReader dr;
                        cmd = new SQLiteCommand("Select Id from information ORDER BY Id ", con);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {

                                res = dr[0].ToString();
                            }

                        }
                        dr.Close();
                        for (int i = 0; i < count ; i++)
                        {

                            cmd = new SQLiteCommand();
                            cmd.Connection = con;
                            cmd = new SQLiteCommand("Insert into stats (id,idm,number,price) values(@d,@a,@b,@c)", con);
                            cmd.Parameters.AddWithValue("@d", res);
                            cmd.Parameters.AddWithValue("@a", dataGridView1.Rows[i].Cells["رقم"].Value);
                            cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["سعرالوحدة"].Value);
                            cmd.Parameters.AddWithValue("@b", dataGridView1.Rows[i].Cells["العدد"].Value);


                            cmd.ExecuteNonQuery();
                           
                        }
                    }
       

                else if (m3 == 1)
                {
                    MessageBox.Show(" لايمكن صرف هذا الراتب مصروف من شهر واحد فقط وهو مرتب شهرين ", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                   
                }
                else if (m3 == 0)
                {
                    MessageBox.Show(" تم صرف هذ الراتب  ", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   


                }

                

            }
            else { MessageBox.Show(" not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            dt.Clear();
            ds.Clear();

                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    cbMtrlName.Text = "";

                    con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string connectionString = ("Data Source=E:\\bele.db;Version=3;");
            ds.Clear();

            SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
            con.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select name,degree ,place,take ,month,secmonth,type,service FROM patient where number = '" + textBox1.Text + "'", con);


            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                textBox2.Text = ds.Tables[0].Rows[0]["name"].ToString();
                textBox3.Text = ds.Tables[0].Rows[0]["degree"].ToString();
                textBox4.Text = ds.Tables[0].Rows[0]["place"].ToString();
                textBox5.Text = ds.Tables[0].Rows[0]["type"].ToString();
                textBox6.Text = ds.Tables[0].Rows[0]["service"].ToString();

                 xy = ds.Tables[0].Rows[0]["take"].ToString();
                m1 = Convert.ToInt32(xy);
                xy = ds.Tables[0].Rows[0]["month"].ToString();
                m2 = Convert.ToInt32(xy);
                xy = ds.Tables[0].Rows[0]["secmonth"].ToString();
                m3 = Convert.ToInt32(xy);
                ds.Clear();

                ds = new DataSet();

                da = new SQLiteDataAdapter("Select medicine.Idm as رقم, medicine.medicine as اسم ,medicine.price as سعرالوحدة, sarf.number  as العدد  FROM sarf INNER JOIN medicine ON  sarf.idm=medicine.Idm INNER JOIN patient ON patient.number = sarf.idp  where patient.number ='" + textBox1.Text + "' ", con);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Requested Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("ادخل البيانات  ", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);



            }
            if (ds != null)
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[0].ReadOnly = true;

                dataGridView1.Columns[1].ReadOnly = true;
            }
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

                  int count = dataGridView1.Rows.Count;
                  x[] data = new x[count + 1];

                  for (int i = 0; i < count; i++)
                  {


                      data[i].number = Convert.ToInt32(dataGridView1.Rows[i].Cells["رقم"].Value);
                      data[i].name = (dataGridView1.Rows[i].Cells["اسم"].Value).ToString();
                      data[i].price = Convert.ToDouble(dataGridView1.Rows[i].Cells["سعرالوحدة"].Value);
                      data[i].numt = Convert.ToInt32(dataGridView1.Rows[i].Cells["العدد"].Value);


                  }
                  dt.Clear();

                  ds.Clear();
                  ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Idm ,price FROM medicine WHERE medicine LIKE '" + cbMtrlName.Text + "'", con);
               
                    da.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        xx = ds.Tables[0].Rows[0]["Idm"].ToString();
                        y = ds.Tables[0].Rows[0]["price"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("خطا فى الصنف", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                
               
    if (textBox1.Text != "" && cbMtrlName.Text != "")
                {
      
        data[count].number = Convert.ToInt32(xx);
        data[count].name = cbMtrlName.Text;
        data[count].price = Convert.ToDouble(y);
        data[count].numt = Convert.ToInt32(number.Text);
                    DataColumn dco1 = new DataColumn("رقم");
                    DataColumn dco2 = new DataColumn("اسم");            
                    DataColumn dco3 = new DataColumn("سعرالوحدة");
                    DataColumn dco4 = new DataColumn("العدد");
                    if (dt.Columns.Count == 0)
                    {
                        dt.Columns.Add(dco1);
                        dt.Columns.Add(dco2);
                        dt.Columns.Add(dco3);
                        dt.Columns.Add(dco4);
                    }

                    for (int i = 0; i < count+1; i++)
                    {

                        DataRow row1 = dt.NewRow();
                        row1["رقم"] = data[i].number;
                        row1["اسم"] = data[i].name;
                        row1["سعرالوحدة"] = data[i].price;
                        row1["العدد"] = data[i].numt;
                        dt.Rows.Add(row1);

                        //}           
                    }
        
                    dataGridView1.DataSource = dt;


                

        }
    }
}
}
