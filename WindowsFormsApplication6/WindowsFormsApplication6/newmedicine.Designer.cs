namespace WindowsFormsApplication6
{
    partial class newmedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newmedicine));
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.totalcus = new System.Windows.Forms.TextBox();
            this.btnPO = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbQuantity.Location = new System.Drawing.Point(86, 192);
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(209, 30);
            this.mtbQuantity.TabIndex = 82;
            this.mtbQuantity.Text = "1";
            this.mtbQuantity.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbQuantity_MaskInputRejected);
            // 
            // totalcus
            // 
            this.totalcus.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcus.Location = new System.Drawing.Point(86, 135);
            this.totalcus.Name = "totalcus";
            this.totalcus.Size = new System.Drawing.Size(209, 30);
            this.totalcus.TabIndex = 80;
            this.totalcus.TextChanged += new System.EventHandler(this.totalcus_TextChanged);
            // 
            // btnPO
            // 
            this.btnPO.BackColor = System.Drawing.Color.Red;
            this.btnPO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPO.BackgroundImage")));
            this.btnPO.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPO.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPO.Location = new System.Drawing.Point(86, 289);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(209, 38);
            this.btnPO.TabIndex = 78;
            this.btnPO.Text = "اضــــافـــــة";
            this.btnPO.UseVisualStyleBackColor = false;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(310, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 26);
            this.label8.TabIndex = 109;
            this.label8.Text = "اسم الصنف\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(310, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 110;
            this.label1.Text = "السعر\r\n";
            // 
            // newmedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.totalcus);
            this.Controls.Add(this.btnPO);
            this.MaximizeBox = false;
            this.Name = "newmedicine";
            this.Text = "اضافه صنف جديد";
            this.Load += new System.EventHandler(this.newmedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.TextBox totalcus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}