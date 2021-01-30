using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using DGVPrinterHelper;


namespace WindowsFormsApplication6
{
    public partial class stats : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\WindowsFormsApplication6\clinic.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataTable dt = new DataTable();

        DataSet ds = new DataSet();
        public stats()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox5.Enabled = false;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         if (cbSearch.Text != "")
            {
                if (cbSearch.Text.ToString() == "رقم المرتب -صرف")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        con.Open();

                        ds.Clear();
                        da = new SQLiteDataAdapter("select information.id  كود,  information.idp as رقم,patient.name اسم,information.date تاريخ ,medicine.medicine الدواء, stats.number العدد ,stats.price السعر,stats.number*stats.price مجموع from information inner join patient on information.idp = patient.number inner join medicine on stats.idm=medicine.idm inner join stats on stats.id =information.id where patient.number='" + txtSearch.Text + "'order by date", con);
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
                }
                else if (cbSearch.Text.ToString() == "رقم المرتب")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        con.Open();

                        ds.Clear();
                        da = new SQLiteDataAdapter("select  information.id  كود , information.idp رقم,patient.name اسم,information.total مجموع,information.date تاريخ from information INNER join patient ON patient.number=information.idp  where information.idp= '" + txtSearch.Text + "'ORDER BY  information.date", con);
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
                }
                else if (cbSearch.Text.ToString() == "كود الصرف")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        con.Open();

                        ds.Clear();
                        da = new SQLiteDataAdapter("select information.id  كود,  information.idp as رقم,patient.name اسم,information.date تاريخ ,medicine.medicine الدواء, stats.number العدد ,stats.price السعر,stats.number*stats.price  مجموع from information inner join patient on information.idp = patient.number inner join medicine on stats.idm=medicine.idm inner join stats on stats.id =information.id where stats.id = '" + txtSearch.Text + "'ORDER BY  information.date", con);
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
                }
                else if (cbSearch.Text.ToString() == "المبلغ")
                {
                    if (mtbFrom.Text == "" && mtbTo.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        con.Open();

                        ds.Clear();
                        da = new SQLiteDataAdapter("select information.id  كود , information.idp رقم,patient.name اسم,information.total مجموع,information.date تاريخ from information INNER join patient ON patient.number=information.idp  where information.total> '" + mtbFrom.Text + "' AND information.total < '" + mtbTo.Text + "'ORDER BY  information.date", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("No records exist within Quantity Range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                else if (cbSearch.Text.ToString() == "التاريخ")
                {
                    if (dtpFrom.Value.Date > System.DateTime.Today)
                    {
                        MessageBox.Show("Invalid Selected Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        con.Open();

                        ds.Clear();

                        da = new SQLiteDataAdapter("select information.id  كود , information.idp رقم,patient.name اسم,information.total مجموع,information.date تاريخ from information INNER join patient ON patient.number=information.idp  where information.date BETWEEN  ('" + dtpFrom.Text.ToString() + "') AND ('" + dtpTo.Text.ToString() + "')ORDER BY  information.date", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];

                        }
                        else
                        {
                            MessageBox.Show("No records exist within Specified Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }

                }
                
                else if (cbSearch.Text.ToString() == "التاريخ-ادوية")
                {
                    if (dtpFrom.Value.Date > System.DateTime.Today)
                    {
                        MessageBox.Show("Invalid Selected Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        con.Open();

                        ds.Clear();

                        da = new SQLiteDataAdapter("select medicine.idm كود  ,  medicine.medicine الاسم,sum (stats.number)العدد, medicine.price السعر ,sum(stats.number)*medicine.price مجموع from  stats inner join medicine on stats.idm=medicine.idm inner join information on information.id=stats.id   where information.date BETWEEN  ('" + dtpFrom.Text.ToString() + "') AND ('" + dtpTo.Text.ToString() + "')group by  stats.idm", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];

                        }
                        else
                        {
                            MessageBox.Show("No records exist within Specified Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }

                }
                else if (cbSearch.Text.ToString() == "التاريخ-مرتبات")
                {
                    if (dtpFrom.Value.Date > System.DateTime.Today)
                    {
                        MessageBox.Show("Invalid Selected Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        con.Open();

                        ds.Clear();

                        da = new SQLiteDataAdapter("select information.id  كود,  information.idp as رقم,patient.name اسم,information.date تاريخ ,medicine.medicine الدواء, stats.number العدد ,stats.price السعر,stats.number*stats.price  مجموع from information inner join patient on information.idp = patient.number inner join medicine on stats.idm=medicine.idm inner join stats on stats.id =information.id where  information.date BETWEEN  ('" + dtpFrom.Text.ToString() + "') AND ('" + dtpTo.Text.ToString() + "')ORDER BY  information.date", con);
                        da.Fill(ds);

                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];

                        }
                        else
                        {
                            MessageBox.Show("No records exist within Specified Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }

                }
                else if (cbSearch.Text.ToString() == "كل المنصرف")
                {
                    
                        con.Open();

                        ds.Clear();
                        da = new SQLiteDataAdapter("select  information.id  كود  , information.idp رقم,patient.name اسم,information.total مجموع,information.date تاريخ from information INNER join patient ON patient.number=information.idp ORDER BY  information.date", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("No records exist within Specified Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        
                    }

                }
                else if (cbSearch.Text.ToString() == "كل المنصرف-ادوية")
                {

                    con.Open();

                    ds.Clear();
                    da = new SQLiteDataAdapter("select information.id  كود,  information.idp as رقم,patient.name اسم,information.date تاريخ ,medicine.medicine الدواء, stats.number العدد ,stats.price السعر,stats.number*stats.price  مجموع from information inner join patient on information.idp = patient.number inner join medicine on stats.idm=medicine.idm inner join stats on stats.id =information.id  order by date  ", con);
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No records exist within Specified Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                    }

                }
        

                double sum = 0, sum5 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum5 = Convert.ToDouble(dataGridView1.Rows[i].Cells["مجموع"].Value);
                    sum = sum + sum5;
                    textBox5.Text = (i + 1).ToString();

                }
                textBox2.Text = sum.ToString();
                con.Close();
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.ToString() == "المبلغ")
            {
                txtSearch.Hide();
                mtbFrom.Show();
                mtbTo.Show();
                dtpFrom.Hide();
                dtpTo.Hide();
                label3.Show();
                ds.Reset();

            }



            else if (cbSearch.Text.ToString() == "رقم المرتب" || cbSearch.Text.ToString() == "رقم المرتب -صرف" || cbSearch.Text.ToString() == "كود الصرف")
            {
                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                txtSearch.Text = "";
                ds.Clear();

              
            }
            else if (cbSearch.Text.ToString() == "التاريخ" || cbSearch.Text.ToString() == "التاريخ-ادوية" || cbSearch.Text.ToString() == "التاريخ-مرتبات")
            {
     

                dtpFrom.Show();
                dtpTo.Show();
                txtSearch.Hide();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Show();
                ds.Reset();


            }
            else if (cbSearch.Text.ToString() == "كل المنصرف-ادوية" || cbSearch.Text.ToString() == "كل المنصرف" )
            {


                dtpFrom.Hide();
                dtpTo.Hide();
                txtSearch.Hide();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Hide();
                ds.Reset();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stats_Load(object sender, EventArgs e)
        {
            mtbTo.Hide();
            mtbFrom.Hide();
            txtSearch.Show();
            dtpFrom.Hide();
            dtpTo.Hide();
            label3.Hide();
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            dtpFrom.CustomFormat = "yyyy-MM-dd hh-mm-ss";



        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged_1(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        }
    }

