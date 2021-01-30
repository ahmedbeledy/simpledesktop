using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Web ;

namespace clinic
{
    public partial class Add : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\clinic\clinicdate.db;Version=3;Compress=True");
        SQLiteDataAdapter da;
        SQLiteCommand cmd = new SQLiteCommand();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int pers = 0, saf = 0, families = 0, fath = 0;
        int nummili = 0,numcit=0;
        float inmi = 0, incti = 0;

        public Add()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            con.Open();
            for (int i = 0; i < count; i++)
            {
             string x=dataGridView1.Rows[i].Cells["العيادة"].Value.ToString();;
                
                if (x=="مرتبات")
                {
                    nummili = nummili + (Convert.ToInt32(dataGridView1.Rows[i].Cells["ع ضباط"].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells["ع صف"].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells["والدين"].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells["شخصه"].Value));


                    inmi = inmi + (Convert.ToInt32(dataGridView1.Rows[i].Cells["شخصه"].Value) * 0 + Convert.ToInt32(dataGridView1.Rows[i].Cells["ع صف"].Value) * 3 + Convert.ToInt32(dataGridView1.Rows[i].Cells["والدين"].Value) * 10 + Convert.ToInt32(dataGridView1.Rows[i].Cells["ع ضباط"].Value) * 5) + Convert.ToInt32(dataGridView1.Rows[i].Cells["اجمالى مدنى"].Value);
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "والدين");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["والدين"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["والدين"].Value) * 10);
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
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "ع صف");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["ع صف"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["ع صف"].Value) * 3);
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
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "ع ضباط");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["ع ضباط"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["ع ضباط"].Value) * 5);
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

                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "شخصه");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["شخصه"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["شخصه"].Value) * 0);
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
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "مرتب");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["مدنى"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["اجمالى مدنى"].Value));
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
                else
        
                {

                    nummili = nummili + (Convert.ToInt32(dataGridView1.Rows[i].Cells["ع ضباط"].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells["ع صف"].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells["والدين"].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells["شخصه"].Value));

                    
                    inmi = inmi + (Convert.ToInt32(dataGridView1.Rows[i].Cells["شخصه"].Value) * 0 + Convert.ToInt32(dataGridView1.Rows[i].Cells["ع صف"].Value) * 3 + Convert.ToInt32(dataGridView1.Rows[i].Cells["والدين"].Value) * 10 + Convert.ToInt32(dataGridView1.Rows[i].Cells["ع ضباط"].Value) * 5) ;
                    numcit=numcit+ Convert.ToInt32(dataGridView1.Rows[i].Cells["مدنى"].Value);
                    incti=incti+ Convert.ToInt32(dataGridView1.Rows[i].Cells["اجمالى مدنى"].Value);
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "والدين");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["والدين"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["والدين"].Value) * 10);
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
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "ع صف");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["ع صف"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["ع صف"].Value) * 3);
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
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "ع ضباط");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["ع ضباط"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["ع ضباط"].Value) * 5);
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

                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "شخصه");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["شخصه"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["شخصه"].Value) * 0);
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
                    cmd = new SQLiteCommand("Insert into patient (type,date,number,clinic,income) values(@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("@a", "مدنى");
                    cmd.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["مدنى"].Value);
                    cmd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["العيادة"].Value);
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(dataGridView1.Rows[i].Cells["اجمالى مدنى"].Value));
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
            }
            cmd = new SQLiteCommand("Insert into day (date,numbermil,numbercit,military,citizen,outmedical,outleader) values(@a,@b,@c,@d,@e,@f,@g)", con);
            cmd.Parameters.AddWithValue("@a", DateTime.Now);
            cmd.Parameters.AddWithValue("@b",nummili );
            cmd.Parameters.AddWithValue("@c", numcit);
            cmd.Parameters.AddWithValue("@d",inmi);
            cmd.Parameters.AddWithValue("@e",incti);
            cmd.Parameters.AddWithValue("@f",medicine.Text );
            cmd.Parameters.AddWithValue("@g",solta.Text);
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
            con.Close();
            MessageBox.Show("تمت الاضافه بنجاح ", "Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            pers = Convert.ToInt32(person.Text);
            saf = Convert.ToInt32(saff.Text);
            fath = Convert.ToInt32(father.Text);

            families = Convert.ToInt32(dabt.Text);

            
           // Convert.ToString(pers + saf + fath + families);
           //Convert.ToString(pers * 0 + saf * 3 + fath * 10 + families * 5);

            if (patient.Text != "" && person.Text != "" && saff.Text != "" && dabt.Text != "" && total.Text != "" && patient.Text != "" && clinic.Text != "")
            {
                DataColumn dco0 = new DataColumn("العيادة");
                DataColumn dco1 = new DataColumn("والدين");
                DataColumn dco2 = new DataColumn("شخصه");
                DataColumn dco3 = new DataColumn("ع صف");
                DataColumn dco4 = new DataColumn("ع ضباط");
                DataColumn dco5 = new DataColumn("مدنى");
                DataColumn dco6 = new DataColumn("اجمالى مدنى");
          


                if (dt.Columns.Count == 0)
                {
                    dt.Columns.Add(dco0);
                    dt.Columns.Add(dco1);
                    dt.Columns.Add(dco2);
                    dt.Columns.Add(dco3);
                    dt.Columns.Add(dco4);
                    dt.Columns.Add(dco5);
                    dt.Columns.Add(dco6);
                  
                
                }
                for (int i = 1; i < 2; i++)
                {
                    DataRow row1 = dt.NewRow();
                    row1["العيادة"] = clinic.Text;
                    row1["والدين"] = father.Text;
                    row1["شخصه"] = person.Text;
                    row1["ع صف"] = saff.Text;
                    row1["ع ضباط"] = dabt.Text;
                    row1["مدنى"] = patient.Text;
                    row1["اجمالى مدنى"] = total.Text;
                  
                    dt.Rows.Add(row1);
                }
                dataGridView1.DataSource = dt;
                clinic.Items.Remove(clinic.Text);

               

            }
            else
            {
                MessageBox.Show("خطا ", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
     

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void milit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void clinic_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (clinic.Text.ToString() == "مرتبات")
            {
                label9.Text = "المرتب";
                label11.Hide();
                patient.Hide();

                person.Text = "0";
                patient.Text = "0";
                saff.Text = "0";
                total.Text = "0";
                dabt.Text = "0";
                patient.Text = "0";
                father.Text = "0";

            }
            else
            {
                person.Text = "0";
                patient.Text = "0";
                saff.Text = "0";
                total.Text="0";
                dabt.Text = "0";
                patient.Text = "0";
                father.Text = "0";
                label11.Show();
                patient.Show();
                label9.Text = "مدنى";

            }
        }

        private void total_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //protected void dataGridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{

        //    string userName = dataGridView1.DataSource[e.RowIndex].Value.ToString();
        //    clinic.Items.Insert(0, userName);



        //}
    }
}

