namespace Schoollogmanagementsystem
{
    partial class logmanagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewbtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.outbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 632);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.viewbtn);
            this.panel2.Controls.Add(this.adminbtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.minbtn);
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 132);
            this.panel2.TabIndex = 1;
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.Location = new System.Drawing.Point(1052, 86);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(150, 35);
            this.viewbtn.TabIndex = 4;
            this.viewbtn.Text = "VIEW HISTORY";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click_1);
            // 
            // adminbtn
            // 
            this.adminbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.Location = new System.Drawing.Point(970, 12);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(148, 46);
            this.adminbtn.TabIndex = 3;
            this.adminbtn.Text = "ADMIN";
            this.adminbtn.UseVisualStyleBackColor = false;
            this.adminbtn.Visible = false;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attendance Management System";
            // 
            // minbtn
            // 
            this.minbtn.Image = global::Schoollogmanagementsystem.Properties.Resources.icons8_subtract_30;
            this.minbtn.Location = new System.Drawing.Point(1137, 12);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(30, 30);
            this.minbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minbtn.TabIndex = 1;
            this.minbtn.TabStop = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Image = global::Schoollogmanagementsystem.Properties.Resources.icons8_close_30;
            this.closebtn.Location = new System.Drawing.Point(1173, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(30, 30);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closebtn.TabIndex = 0;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(34, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDENT LOG";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.outbtn);
            this.panel4.Location = new System.Drawing.Point(595, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 245);
            this.panel4.TabIndex = 3;
            // 
            // outbtn
            // 
            this.outbtn.BackColor = System.Drawing.Color.White;
            this.outbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.outbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.outbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outbtn.ForeColor = System.Drawing.Color.Black;
            this.outbtn.Location = new System.Drawing.Point(13, 114);
            this.outbtn.Name = "outbtn";
            this.outbtn.Size = new System.Drawing.Size(337, 110);
            this.outbtn.TabIndex = 1;
            this.outbtn.Text = "OUT";
            this.outbtn.UseVisualStyleBackColor = false;
            this.outbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.logbtn);
            this.panel3.Location = new System.Drawing.Point(213, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 245);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Schoollogmanagementsystem.Properties.Resources.icons8_login_64;
            this.pictureBox1.Location = new System.Drawing.Point(150, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.White;
            this.logbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbtn.ForeColor = System.Drawing.Color.Black;
            this.logbtn.Location = new System.Drawing.Point(16, 114);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(337, 110);
            this.logbtn.TabIndex = 0;
            this.logbtn.Text = "IN";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 632);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1233, 679);
            this.Name = "logmanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Log Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.logmanagement_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button outbtn;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox minbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button viewbtn;
    }
}

