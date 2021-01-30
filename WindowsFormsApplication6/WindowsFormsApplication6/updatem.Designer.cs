namespace WindowsFormsApplication6
{
    partial class updatem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatem));
            this.label9 = new System.Windows.Forms.Label();
            this.btnPO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalcus = new System.Windows.Forms.TextBox();
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(276, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 26);
            this.label9.TabIndex = 84;
            this.label9.Text = "اسم الصنف";
            // 
            // btnPO
            // 
            this.btnPO.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPO.BackgroundImage")));
            this.btnPO.Font = new System.Drawing.Font("Vladimir Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPO.ForeColor = System.Drawing.Color.Silver;
            this.btnPO.Location = new System.Drawing.Point(119, 342);
            this.btnPO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(183, 47);
            this.btnPO.TabIndex = 83;
            this.btnPO.Text = "تعديـــــــل";
            this.btnPO.UseVisualStyleBackColor = false;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 89;
            this.label1.Text = "السعر الجديد";
            // 
            // totalcus
            // 
            this.totalcus.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcus.Location = new System.Drawing.Point(43, 172);
            this.totalcus.Name = "totalcus";
            this.totalcus.Size = new System.Drawing.Size(209, 30);
            this.totalcus.TabIndex = 98;
            this.totalcus.TextChanged += new System.EventHandler(this.cbMtrlName_TextChanged);
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Location = new System.Drawing.Point(36, 268);
            this.mtbQuantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(216, 27);
            this.mtbQuantity.TabIndex = 87;
            this.mtbQuantity.Text = "1";
            // 
            // updatem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 418);
            this.Controls.Add(this.totalcus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPO);
            this.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "updatem";
            this.RightToLeftLayout = true;
            this.Text = "تعديل صنف";
            this.Load += new System.EventHandler(this.updatem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox totalcus;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
    }
}