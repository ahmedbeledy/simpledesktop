namespace clinic
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.MaskedTextBox();
            this.dabt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saff = new System.Windows.Forms.MaskedTextBox();
            this.person = new System.Windows.Forms.MaskedTextBox();
            this.father = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPO = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clinic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.solta = new System.Windows.Forms.MaskedTextBox();
            this.medicine = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(340, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 122;
            this.label9.Text = "مدنـــــــــــــــــــــــــــــــــــــــــــــــى";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(837, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 127;
            this.label1.Text = "عدد الحالات";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patient
            // 
            this.patient.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.Location = new System.Drawing.Point(331, 263);
            this.patient.Mask = "00000";
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(78, 30);
            this.patient.TabIndex = 130;
            this.patient.Text = "0";
            this.patient.ValidatingType = typeof(int);
            // 
            // dabt
            // 
            this.dabt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dabt.Location = new System.Drawing.Point(615, 335);
            this.dabt.Mask = "00000";
            this.dabt.Name = "dabt";
            this.dabt.Size = new System.Drawing.Size(61, 30);
            this.dabt.TabIndex = 131;
            this.dabt.Text = "0";
            this.dabt.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(684, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 132;
            this.label2.Text = "عائلات ضباط";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saff
            // 
            this.saff.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saff.Location = new System.Drawing.Point(811, 333);
            this.saff.Mask = "00000";
            this.saff.Name = "saff";
            this.saff.Size = new System.Drawing.Size(61, 30);
            this.saff.TabIndex = 133;
            this.saff.Text = "0";
            this.saff.ValidatingType = typeof(int);
            // 
            // person
            // 
            this.person.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person.Location = new System.Drawing.Point(1001, 331);
            this.person.Mask = "00000";
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(61, 30);
            this.person.TabIndex = 134;
            this.person.Text = "0";
            this.person.ValidatingType = typeof(int);
            // 
            // father
            // 
            this.father.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.father.Location = new System.Drawing.Point(1197, 331);
            this.father.Mask = "00000";
            this.father.Name = "father";
            this.father.Size = new System.Drawing.Size(61, 30);
            this.father.TabIndex = 135;
            this.father.Text = "0";
            this.father.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1307, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 136;
            this.label4.Text = "والدين";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(890, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 137;
            this.label5.Text = "عائلات صف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1079, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 138;
            this.label7.Text = "شخصه";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(331, 333);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(78, 30);
            this.total.TabIndex = 140;
            this.total.Text = "0";
            this.total.ValidatingType = typeof(int);
            this.total.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.total_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(471, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 139;
            this.label8.Text = "الاجمالى";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(997, 263);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 26);
            this.label10.TabIndex = 141;
            this.label10.Text = "عسكرى";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(450, 263);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 26);
            this.label11.TabIndex = 142;
            this.label11.Text = "عدد الحالات";
            // 
            // btnPO
            // 
            this.btnPO.BackColor = System.Drawing.Color.White;
            this.btnPO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPO.BackgroundImage")));
            this.btnPO.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnPO.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPO.Location = new System.Drawing.Point(61, 293);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(184, 38);
            this.btnPO.TabIndex = 143;
            this.btnPO.Text = "اضــــــــافــــــة";
            this.btnPO.UseVisualStyleBackColor = false;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(385, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(980, 317);
            this.dataGridView1.TabIndex = 144;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(56, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 145;
            this.button1.Text = "تاكيد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(82, 519);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 26);
            this.label13.TabIndex = 150;
            this.label13.Text = "منصرف ادوية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1017, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 121;
            this.label3.Text = "العيادة";
            // 
            // clinic
            // 
            this.clinic.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic.FormattingEnabled = true;
            this.clinic.Items.AddRange(new object[] {
            "استقبال",
            "اسنان ",
            "اشعة",
            "اطفال",
            "انف واذن ",
            "باطنة",
            "جراحة",
            "جلدية",
            "رمد ",
            "عظام ",
            "علاج طبيعى ",
            "قلب",
            "مرتبات",
            "معمل",
            "نسا وتوليد"});
            this.clinic.Location = new System.Drawing.Point(701, 185);
            this.clinic.Name = "clinic";
            this.clinic.Size = new System.Drawing.Size(274, 32);
            this.clinic.Sorted = true;
            this.clinic.TabIndex = 125;
            this.clinic.SelectedIndexChanged += new System.EventHandler(this.clinic_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 26);
            this.label6.TabIndex = 147;
            this.label6.Text = "منصرف سلطة قائد";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // solta
            // 
            this.solta.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solta.Location = new System.Drawing.Point(61, 466);
            this.solta.Name = "solta";
            this.solta.Size = new System.Drawing.Size(147, 30);
            this.solta.TabIndex = 151;
            this.solta.Text = "0";
            this.solta.ValidatingType = typeof(int);
            // 
            // medicine
            // 
            this.medicine.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine.Location = new System.Drawing.Point(61, 573);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(147, 30);
            this.medicine.TabIndex = 152;
            this.medicine.Text = "0";
            this.medicine.ValidatingType = typeof(int);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 714);
            this.Controls.Add(this.medicine);
            this.Controls.Add(this.solta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.father);
            this.Controls.Add(this.person);
            this.Controls.Add(this.saff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dabt);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clinic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox patient;
        private System.Windows.Forms.MaskedTextBox dabt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox saff;
        private System.Windows.Forms.MaskedTextBox person;
        private System.Windows.Forms.MaskedTextBox father;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPO;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clinic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox solta;
        private System.Windows.Forms.MaskedTextBox medicine;
    }
}