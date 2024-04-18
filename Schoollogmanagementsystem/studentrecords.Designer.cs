namespace Schoollogmanagementsystem
{
    partial class studentrecords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrecord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toexcelbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.studguardtxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gradelvltxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studagetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studidtxt = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrecord)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dgrecord);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 620);
            this.panel1.TabIndex = 0;
            // 
            // dgrecord
            // 
            this.dgrecord.AllowUserToAddRows = false;
            this.dgrecord.AllowUserToDeleteRows = false;
            this.dgrecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgrecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrecord.Location = new System.Drawing.Point(40, 117);
            this.dgrecord.Name = "dgrecord";
            this.dgrecord.RowHeadersWidth = 51;
            this.dgrecord.RowTemplate.Height = 24;
            this.dgrecord.Size = new System.Drawing.Size(928, 223);
            this.dgrecord.TabIndex = 4;
            this.dgrecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrecord_CellClick);
            this.dgrecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrecord_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "studentID";
            this.Column1.HeaderText = "LRN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "firstname";
            this.Column2.HeaderText = "Firstname";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "middlename";
            this.Column3.HeaderText = "Middlename";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "lastname";
            this.Column4.HeaderText = "Lastname";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "gender";
            this.Column5.HeaderText = "Gender";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "age";
            this.Column6.HeaderText = "Age";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "gradelvl";
            this.Column7.HeaderText = "Year Level";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "guardianname";
            this.Column8.HeaderText = "Guardian Name ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "contactno";
            this.Column9.HeaderText = "Contact No";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Id";
            this.Column10.HeaderText = "ObjectId";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.addbtn);
            this.panel7.Controls.Add(this.toexcelbtn);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.studguardtxt);
            this.panel7.Controls.Add(this.gendertxt);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.gradelvltxt);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.studagetxt);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.txtcontact);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.lnametxt);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.mnametxt);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.fnametxt);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.studidtxt);
            this.panel7.Controls.Add(this.deletebtn);
            this.panel7.Controls.Add(this.editbtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(40, 340);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(928, 240);
            this.panel7.TabIndex = 6;
            // 
            // toexcelbtn
            // 
            this.toexcelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toexcelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toexcelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toexcelbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toexcelbtn.Location = new System.Drawing.Point(822, 6);
            this.toexcelbtn.Name = "toexcelbtn";
            this.toexcelbtn.Size = new System.Drawing.Size(100, 63);
            this.toexcelbtn.TabIndex = 37;
            this.toexcelbtn.Text = "Export to Excel";
            this.toexcelbtn.UseVisualStyleBackColor = false;
            this.toexcelbtn.Click += new System.EventHandler(this.toexcelbtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "GUARDIAN\'S NAME";
            // 
            // studguardtxt
            // 
            this.studguardtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studguardtxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studguardtxt.Location = new System.Drawing.Point(547, 92);
            this.studguardtxt.Multiline = true;
            this.studguardtxt.Name = "studguardtxt";
            this.studguardtxt.Size = new System.Drawing.Size(178, 24);
            this.studguardtxt.TabIndex = 35;
            // 
            // gendertxt
            // 
            this.gendertxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gendertxt.FormattingEnabled = true;
            this.gendertxt.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gendertxt.Location = new System.Drawing.Point(145, 170);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(179, 24);
            this.gendertxt.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "GENDER";
            // 
            // gradelvltxt
            // 
            this.gradelvltxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradelvltxt.FormattingEnabled = true;
            this.gradelvltxt.Items.AddRange(new object[] {
            "11",
            "12"});
            this.gradelvltxt.Location = new System.Drawing.Point(547, 53);
            this.gradelvltxt.Name = "gradelvltxt";
            this.gradelvltxt.Size = new System.Drawing.Size(179, 24);
            this.gradelvltxt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(360, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "GRADE LEVEL";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "AGE";
            // 
            // studagetxt
            // 
            this.studagetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studagetxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studagetxt.Location = new System.Drawing.Point(548, 12);
            this.studagetxt.Multiline = true;
            this.studagetxt.Name = "studagetxt";
            this.studagetxt.Size = new System.Drawing.Size(178, 27);
            this.studagetxt.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "CONTACT NO";
            // 
            // txtcontact
            // 
            this.txtcontact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcontact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(145, 211);
            this.txtcontact.Multiline = true;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(179, 23);
            this.txtcontact.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "LAST NAME";
            // 
            // lnametxt
            // 
            this.lnametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnametxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametxt.Location = new System.Drawing.Point(145, 132);
            this.lnametxt.Multiline = true;
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(179, 27);
            this.lnametxt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "MIDDLE NAME";
            // 
            // mnametxt
            // 
            this.mnametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mnametxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnametxt.Location = new System.Drawing.Point(145, 89);
            this.mnametxt.Multiline = true;
            this.mnametxt.Name = "mnametxt";
            this.mnametxt.Size = new System.Drawing.Size(179, 27);
            this.mnametxt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "FIRST NAME";
            // 
            // fnametxt
            // 
            this.fnametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fnametxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(145, 50);
            this.fnametxt.Multiline = true;
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(179, 27);
            this.fnametxt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "STUDENT ID";
            // 
            // studidtxt
            // 
            this.studidtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studidtxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studidtxt.Location = new System.Drawing.Point(145, 12);
            this.studidtxt.Multiline = true;
            this.studidtxt.Name = "studidtxt";
            this.studidtxt.Size = new System.Drawing.Size(179, 27);
            this.studidtxt.TabIndex = 19;
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(812, 193);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(113, 41);
            this.deletebtn.TabIndex = 6;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(679, 193);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(113, 41);
            this.editbtn.TabIndex = 5;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.refreshbtn);
            this.panel6.Controls.Add(this.searchbtn);
            this.panel6.Controls.Add(this.searchtxt);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(40, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(928, 77);
            this.panel6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(6, 42);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(110, 29);
            this.refreshbtn.TabIndex = 7;
            this.refreshbtn.Text = "REFRESH";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(811, 24);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(110, 40);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtxt.Location = new System.Drawing.Point(590, 35);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(215, 28);
            this.searchtxt.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(40, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 40);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(40, 580);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(928, 40);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(968, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 620);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 620);
            this.panel3.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(547, 193);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(113, 41);
            this.addbtn.TabIndex = 38;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // studentrecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "studentrecords";
            this.Size = new System.Drawing.Size(1008, 620);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrecord)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrecord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studidtxt;
        private System.Windows.Forms.ComboBox gendertxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gradelvltxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studagetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studguardtxt;
        private System.Windows.Forms.Button toexcelbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button addbtn;
    }
}
