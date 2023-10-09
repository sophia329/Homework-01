namespace LoginPage
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
            this.components = new System.ComponentModel.Container();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoDataSet = new LoginPage.StudentInfoDataSet();
            this.btn_display = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.studentInfoTableAdapter = new LoginPage.StudentInfoDataSetTableAdapters.StudentInfoTableAdapter();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_dept = new System.Windows.Forms.TextBox();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_search2 = new System.Windows.Forms.TextBox();
            this.btn_display2 = new System.Windows.Forms.Button();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_login2 = new System.Windows.Forms.Button();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentInfoDataSet1 = new LoginPage.StudentInfoDataSet1();
            this.studentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter1 = new LoginPage.StudentInfoDataSet1TableAdapters.StudentInfoTableAdapter();
            this.studentInfoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoDataSet2 = new LoginPage.StudentInfoDataSet2();
            this.studentInfoDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter2 = new LoginPage.StudentInfoDataSet2TableAdapters.StudentInfoTableAdapter();
            this.regIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(734, 34);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(312, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Information";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 449);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(214, 449);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(110, 449);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(833, 174);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGrid.DataMember = "StudentInfo";
            this.dataGrid.DataSource = this.studentInfoDataSet2BindingSource;
            this.dataGrid.Location = new System.Drawing.Point(374, 219);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(561, 224);
            this.dataGrid.TabIndex = 10;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentInfoDataSet;
            // 
            // studentInfoDataSet
            // 
            this.studentInfoDataSet.DataSetName = "StudentInfoDataSet";
            this.studentInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(437, 479);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(126, 23);
            this.btn_display.TabIndex = 11;
            this.btn_display.Text = "Display Students";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(374, 175);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(435, 22);
            this.txt_search.TabIndex = 12;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(100, 175);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(208, 22);
            this.txt_reg.TabIndex = 13;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(100, 219);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 22);
            this.txt_name.TabIndex = 14;
            // 
            // txt_dept
            // 
            this.txt_dept.Location = new System.Drawing.Point(100, 316);
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.Size = new System.Drawing.Size(208, 22);
            this.txt_dept.TabIndex = 15;
            // 
            // txt_course
            // 
            this.txt_course.Location = new System.Drawing.Point(100, 268);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(208, 22);
            this.txt_course.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Register ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(42, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(2, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Department";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::LoginPage.Properties.Resources.dunwoody_logo;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.label6);
            this.login_panel.Controls.Add(this.pictureBox2);
            this.login_panel.Controls.Add(this.txt_search2);
            this.login_panel.Controls.Add(this.btn_display2);
            this.login_panel.Controls.Add(this.dataGrid2);
            this.login_panel.Controls.Add(this.btn_search2);
            this.login_panel.Controls.Add(this.label10);
            this.login_panel.Controls.Add(this.btn_login2);
            this.login_panel.Location = new System.Drawing.Point(-5, 5);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(952, 502);
            this.login_panel.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(337, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "*Please login to add, delete, or update a student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::LoginPage.Properties.Resources.dunwoody_logo;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(22, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // txt_search2
            // 
            this.txt_search2.Location = new System.Drawing.Point(219, 176);
            this.txt_search2.Name = "txt_search2";
            this.txt_search2.Size = new System.Drawing.Size(435, 22);
            this.txt_search2.TabIndex = 30;
            // 
            // btn_display2
            // 
            this.btn_display2.Location = new System.Drawing.Point(400, 469);
            this.btn_display2.Name = "btn_display2";
            this.btn_display2.Size = new System.Drawing.Size(126, 23);
            this.btn_display2.TabIndex = 29;
            this.btn_display2.Text = "Display Students";
            this.btn_display2.UseVisualStyleBackColor = true;
            this.btn_display2.Click += new System.EventHandler(this.btn_display2_Click);
            // 
            // dataGrid2
            // 
            this.dataGrid2.AutoGenerateColumns = false;
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.courseDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1});
            this.dataGrid2.DataSource = this.studentInfoBindingSource2;
            this.dataGrid2.Location = new System.Drawing.Point(195, 224);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.RowHeadersWidth = 51;
            this.dataGrid2.RowTemplate.Height = 24;
            this.dataGrid2.Size = new System.Drawing.Size(561, 224);
            this.dataGrid2.TabIndex = 28;
            this.dataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid2_CellContentClick);
            // 
            // btn_search2
            // 
            this.btn_search2.Location = new System.Drawing.Point(681, 175);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(75, 23);
            this.btn_search2.TabIndex = 27;
            this.btn_search2.Text = "Search";
            this.btn_search2.UseVisualStyleBackColor = true;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(322, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(305, 37);
            this.label10.TabIndex = 23;
            this.label10.Text = "Student Information";
            // 
            // btn_login2
            // 
            this.btn_login2.Location = new System.Drawing.Point(721, 31);
            this.btn_login2.Name = "btn_login2";
            this.btn_login2.Size = new System.Drawing.Size(75, 23);
            this.btn_login2.TabIndex = 22;
            this.btn_login2.Text = "Login";
            this.btn_login2.UseVisualStyleBackColor = true;
            this.btn_login2.Click += new System.EventHandler(this.btn_login2_Click);
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(100, 365);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(208, 22);
            this.txt_year.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(48, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Year";
            // 
            // studentInfoDataSet1
            // 
            this.studentInfoDataSet1.DataSetName = "StudentInfoDataSet1";
            this.studentInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource1
            // 
            this.studentInfoBindingSource1.DataMember = "StudentInfo";
            this.studentInfoBindingSource1.DataSource = this.studentInfoDataSet1;
            // 
            // studentInfoTableAdapter1
            // 
            this.studentInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // studentInfoDataSet1BindingSource
            // 
            this.studentInfoDataSet1BindingSource.DataSource = this.studentInfoDataSet1;
            this.studentInfoDataSet1BindingSource.Position = 0;
            // 
            // regIDDataGridViewTextBoxColumn
            // 
            this.regIDDataGridViewTextBoxColumn.DataPropertyName = "RegID";
            this.regIDDataGridViewTextBoxColumn.HeaderText = "RegID";
            this.regIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regIDDataGridViewTextBoxColumn.Name = "regIDDataGridViewTextBoxColumn";
            this.regIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentInfoDataSetBindingSource
            // 
            this.studentInfoDataSetBindingSource.DataSource = this.studentInfoDataSet;
            this.studentInfoDataSetBindingSource.Position = 0;
            // 
            // studentInfoDataSet2
            // 
            this.studentInfoDataSet2.DataSetName = "StudentInfoDataSet2";
            this.studentInfoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoDataSet2BindingSource
            // 
            this.studentInfoDataSet2BindingSource.DataSource = this.studentInfoDataSet2;
            this.studentInfoDataSet2BindingSource.Position = 0;
            // 
            // studentInfoDataSet2BindingSource1
            // 
            this.studentInfoDataSet2BindingSource1.DataSource = this.studentInfoDataSet2;
            this.studentInfoDataSet2BindingSource1.Position = 0;
            // 
            // studentInfoBindingSource2
            // 
            this.studentInfoBindingSource2.DataMember = "StudentInfo";
            this.studentInfoBindingSource2.DataSource = this.studentInfoDataSet2BindingSource;
            // 
            // studentInfoTableAdapter2
            // 
            this.studentInfoTableAdapter2.ClearBeforeFill = true;
            // 
            // regIDDataGridViewTextBoxColumn1
            // 
            this.regIDDataGridViewTextBoxColumn1.DataPropertyName = "RegID";
            this.regIDDataGridViewTextBoxColumn1.HeaderText = "RegID";
            this.regIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.regIDDataGridViewTextBoxColumn1.Name = "regIDDataGridViewTextBoxColumn1";
            this.regIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // courseDataGridViewTextBoxColumn1
            // 
            this.courseDataGridViewTextBoxColumn1.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn1.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn1.Name = "courseDataGridViewTextBoxColumn1";
            this.courseDataGridViewTextBoxColumn1.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            this.departmentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(947, 514);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.txt_dept);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_reg);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.TextBox txt_search;
        private StudentInfoDataSet studentInfoDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentInfoDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_dept;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_search2;
        private System.Windows.Forms.Button btn_display2;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_login2;
        public System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label7;
        private StudentInfoDataSet1 studentInfoDataSet1;
        private System.Windows.Forms.BindingSource studentInfoBindingSource1;
        private StudentInfoDataSet1TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentInfoDataSet1BindingSource;
        private System.Windows.Forms.BindingSource studentInfoDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentInfoDataSet2BindingSource;
        private StudentInfoDataSet2 studentInfoDataSet2;
        private System.Windows.Forms.BindingSource studentInfoDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource studentInfoBindingSource2;
        private StudentInfoDataSet2TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn regIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
    }
}

