using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using DGVPrinterHelper;


namespace WindowsFormsApplication6
{
    public partial class statc : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public statc()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox5.Enabled = false;
            label1.Hide();
            textBox6.Hide();
            textBox4.Hide();
            textBox3.Hide();
            textBox1.Hide();
            month.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        if (cbSearch.Text != "")
            {
                if (cbSearch.Text.ToString() == "احصائيات ادويه من صرفوا")
                {
                    ds = new DataSet();
                    ds.Clear();
                   da = new SQLiteDataAdapter("Select medicine.Idm as رقم,medicine.medicine as اسم ,medicine.price as سعرالوحدة, sum (sarf.number) as العدد,sum(medicine.price*sarf.number)as الاجمالى  FROM sarf INNER JOIN medicine ON  sarf.idm=medicine.Idm INNER JOIN patient ON patient.number = sarf.idp  where (take=1 AND month=0 )OR ( month =1 AND secmonth=1) group by medicine.Idm,medicine.medicine,medicine.price", con);
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }

                }
                else if (cbSearch.Text.ToString() == "احصائيات ادويه من لم يصرفوا")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select medicine.Idm as رقم,medicine.medicine as اسم ,medicine.price as سعرالوحدة, sum (sarf.number) as العدد,sum(medicine.price*sarf.number)as الاجمالى  FROM sarf INNER JOIN medicine ON  sarf.idm=medicine.Idm INNER JOIN patient ON patient.number = sarf.idp  where (take=0 and month=0 )or ( month =1 and secmonth=2) group by medicine.Idm,medicine.medicine,medicine.price", con);
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }
                }
                else if (cbSearch.Text.ToString() == "احصائيات المرتبات المصروفه")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where(take=1 and month=0 )or ( month =1 and (secmonth=1 )) group by patient.number,patient.name,patient.place,patient.degree,patient.type  ", con);
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
                else if (cbSearch.Text.ToString() == "احصائيات المرتبات غير المصروفه")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where(take=0 and month=0 )or ( month =1 and ( secmonth=2)) group by patient.number,patient.name,patient.place,patient.degree,patient.type  ", con);
                    da.Fill(ds);
                   
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();
                        MessageBox.Show("لايوجد بيانات ");
                    }
                }
                else if(cbSearch.Text.ToString() == "احصائيات الادويه فى كل المرتبات")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select medicine.Idm as رقم,medicine.medicine as اسم ,medicine.price as سعرالوحدة, sum (sarf.number) as العدد,sum(medicine.price*sarf.number)as الاجمالى  FROM sarf INNER JOIN medicine ON  sarf.idm=medicine.Idm group by medicine.Idm,medicine.medicine,medicine.price", con);
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }

                }
                else if (cbSearch.Text.ToString() == "اجمالى احصائيات المرتبات")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm   group by patient.number,patient.name,patient.place,patient.degree,patient.type  ", con);
                    da.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }
                }
                 else if (cbSearch.Text.ToString() == "احصائيات الرتبة")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where patient.degree ='" + textBox3.Text + "'group by patient.number,patient.name,patient.place,patient.degree,patient.type ", con);
                    da.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }
                }
             else if (cbSearch.Text.ToString() == "احصائيات المكان")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where patient.place ='" + textBox4.Text + "'group by patient.number,patient.name,patient.place,patient.degree,patient.type ", con);
                    da.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }
                }
             else if (cbSearch.Text.ToString() == "احصائيات نوع الخدمة")
                {
                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where patient.service ='" + textBox6.Text + "'group by patient.number,patient.name,patient.place,patient.degree,patient.type ", con);
                    da.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }
                }
                else if (cbSearch.Text.ToString() == "احصائيات  القرابة")
                {

                    ds = new DataSet();

                    ds.Clear();
                    da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where patient.type ='" + textBox1.Text + "'group by patient.number,patient.name,patient.place,patient.degree,patient.type ", con);
                    da.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }

                }
                else if (cbSearch.Text.ToString() == "تكرار الصرف")
                {
                    ds = new DataSet();

                    ds.Clear();
                    if (month.Text == "شهر")
                    {
                        da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where patient.month = 0 group by patient.number,patient.name,patient.place,patient.degree,patient.type ", con);
                    }
                    else if (month.Text == "شهرين")
                    {
                        da = new SQLiteDataAdapter("Select patient.number رقم,patient.name اسم ,patient.place خدمة,patient.degree رتبة,patient.type قرابة ,sum(medicine.price*sarf.number)  الاجمالى FROM patient INNER JOIN sarf ON patient.number = sarf.idp INNER JOIN medicine ON sarf.idm =medicine.idm  where patient.month = 1 group by patient.number,patient.name,patient.place,patient.degree,patient.type ", con);

                    }
                        da.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds.Clear();

                        MessageBox.Show("لايوجد بيانات ");
                    }


                }
                double sum = 0, sum5 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum5 = Convert.ToDouble(dataGridView1.Rows[i].Cells["الاجمالى"].Value);
                    sum = sum + sum5;
                    textBox5.Text = (i + 1).ToString();

                }
                textBox2.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("اختار الاحصائيه لتظهر", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cbSearch.Text.ToString() == "احصائيات الرتبة")
                {
                    textBox3.Show();
                    textBox6.Hide();
                    textBox4.Hide();
                    textBox1.Hide();
                    month.Hide();
                    label1.Text = "الرتبة";
                    label1.Show();

                }
             else if (cbSearch.Text.ToString() == "احصائيات المكان")
                {
                    textBox4.Show();
                    label1.Text = " مكان الخدمة";
                    label1.Show();
                    textBox6.Hide();
                    textBox1.Hide();
                    month.Hide();
                    textBox3.Hide();


                }
             else if (cbSearch.Text.ToString() == "احصائيات نوع الخدمة")
             {
                 textBox6.Show();
                 textBox4.Hide();
                 textBox3.Hide();
                 textBox1.Hide();
                 month.Hide();
                 label1.Text = "نوع الخدمة";
                 label1.Show();

                 
             }
             else if (cbSearch.Text.ToString() == "احصائيات  القرابة")
             {
                 textBox6.Hide();
                 textBox4.Hide();
                 textBox3.Hide();
                 textBox1.Show();
                 month.Hide();
                 label1.Text = "القرابة";
                 label1.Show();

                 
             }
             else if (cbSearch.Text.ToString() == "تكرار الصرف")
             {
                 textBox6.Hide();
                 textBox4.Hide();
                 textBox3.Hide();
                 textBox1.Hide();
                 month.Show();
                 label1.Text = "تكرار الصرف";
                 label1.Show();


             }
             else
             {
                 label1.Hide();
                 textBox6.Hide();
                 textBox4.Hide();
                 textBox3.Hide();
                 month.Hide();
                 textBox1.Hide();
             }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text != "")
            {



               
                     DGVPrinter printer = new DGVPrinter();

                     printer.Title = " العيادة الخارجية رقم 7 بالهايكستب" + "\n" + "\n"+(DateTime.Today.Date) + "احصائية ادوية شهر        " + "\n";

                     printer.SubTitle = "\n" + textBox5.Text + "  /   الــــعـــدد" + "\n" + textBox2.Text + " /     الاجمالى "+"\n"+ "\n" ;


                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                    StringFormatFlags.NoClip;

                printer.PageNumbers = true;

                printer.PageNumberInHeader = false;

                printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Near;

                printer.Footer = "   عقيد ط / وليد احمد محمد احمد عبد الله     " + "\n" + "(قائد الوحدة)" + "\n" + "  رائد ص / احمد محمد يحيى " + "\n" + "(ضابط الصيدلية)" + "\n" + "  نقيب ص / هايدى محمود احمد " + "\n" + "(رئيس الامداد الطبى )";

                printer.FooterSpacing = 100;

                if (DialogResult.OK == printer.DisplayPrintDialog())  // replace DisplayPrintDialog() 

                    printer.PrintNoDisplay(dataGridView1);

                }
          
                       
            
            else
            {
                MessageBox.Show("اختار الاحصائيه لتظهر", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

