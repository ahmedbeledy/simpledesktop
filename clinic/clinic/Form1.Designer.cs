namespace clinic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلمرتبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صرفمرتبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.تعديلمرتبToolStripMenuItem,
            this.صرفمرتبToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(236, 156);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(335, 42);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 34);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 34);
            // 
            // تعديلمرتبToolStripMenuItem
            // 
            this.تعديلمرتبToolStripMenuItem.Name = "تعديلمرتبToolStripMenuItem";
            this.تعديلمرتبToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            this.تعديلمرتبToolStripMenuItem.Text = "احصائيات";
            this.تعديلمرتبToolStripMenuItem.Click += new System.EventHandler(this.تعديلمرتبToolStripMenuItem_Click);
            // 
            // صرفمرتبToolStripMenuItem
            // 
            this.صرفمرتبToolStripMenuItem.Name = "صرفمرتبToolStripMenuItem";
            this.صرفمرتبToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.صرفمرتبToolStripMenuItem.Text = "اضافة البيانات اليومية";
            this.صرفمرتبToolStripMenuItem.Click += new System.EventHandler(this.صرفمرتبToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 645);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem صرفمرتبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلمرتبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

