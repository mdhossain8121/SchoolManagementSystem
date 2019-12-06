namespace SchoolManagementSystem.Presentation
{
    partial class frmTeacher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBasicInformation = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.llImage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAssignClassSection = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSaveTeacherClassSection = new System.Windows.Forms.Button();
            this.tvClassSection = new System.Windows.Forms.TreeView();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTeacherClassInfoSearch = new System.Windows.Forms.TextBox();
            this.btnTeacherClassInfoSearch = new System.Windows.Forms.Button();
            this.dgvTeacherClassInfo = new System.Windows.Forms.DataGridView();
            this.cswtColTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cswtColClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cswtColSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cswtColAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cswtColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabBasicInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAssignClassSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1093, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 27);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(893, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 26);
            this.txtSearch.TabIndex = 14;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colTeacherName,
            this.colMobile,
            this.colJoiningDate,
            this.colAddress,
            this.colid});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.Location = new System.Drawing.Point(14, 40);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvData.RowTemplate.Height = 60;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1153, 303);
            this.dgvData.TabIndex = 16;
            this.dgvData.Tag = "Required";
            this.dgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentDoubleClick);
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "IMAGE";
            this.colImage.HeaderText = "Image";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTeacherName
            // 
            this.colTeacherName.DataPropertyName = "TEACHER_NAME";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTeacherName.DefaultCellStyle = dataGridViewCellStyle13;
            this.colTeacherName.FillWeight = 98.47716F;
            this.colTeacherName.HeaderText = "Teacher Name";
            this.colTeacherName.Name = "colTeacherName";
            this.colTeacherName.ReadOnly = true;
            // 
            // colMobile
            // 
            this.colMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMobile.DataPropertyName = "MOBILE";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMobile.DefaultCellStyle = dataGridViewCellStyle14;
            this.colMobile.FillWeight = 101.5228F;
            this.colMobile.HeaderText = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            // 
            // colJoiningDate
            // 
            this.colJoiningDate.DataPropertyName = "JOINING_DATE";
            this.colJoiningDate.HeaderText = "Joining Date";
            this.colJoiningDate.Name = "colJoiningDate";
            this.colJoiningDate.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "ADDRESS";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colid
            // 
            this.colid.DataPropertyName = "ID";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colid.DefaultCellStyle = dataGridViewCellStyle15;
            this.colid.HeaderText = "ID";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            // 
            // tabBasicInformation
            // 
            this.tabBasicInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBasicInformation.Controls.Add(this.splitContainer1);
            this.tabBasicInformation.Location = new System.Drawing.Point(4, 22);
            this.tabBasicInformation.Name = "tabBasicInformation";
            this.tabBasicInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicInformation.Size = new System.Drawing.Size(1188, 589);
            this.tabBasicInformation.TabIndex = 0;
            this.tabBasicInformation.Text = "Teacher Basic Information";
            this.tabBasicInformation.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel1.Controls.Add(this.llImage);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.dtpJoiningDate);
            this.splitContainer1.Panel1.Controls.Add(this.pbImage);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtTeacherName);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtMobile);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1MinSize = 20;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvData);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Size = new System.Drawing.Size(1180, 581);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 46;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(148, 96);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(779, 92);
            this.txtAddress.TabIndex = 37;
            this.txtAddress.Tag = "Required";
            // 
            // llImage
            // 
            this.llImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llImage.AutoSize = true;
            this.llImage.Location = new System.Drawing.Point(1124, 9);
            this.llImage.Name = "llImage";
            this.llImage.Size = new System.Drawing.Size(42, 13);
            this.llImage.TabIndex = 45;
            this.llImage.TabStop = true;
            this.llImage.Text = "Browse";
            this.llImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llImage_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Teacher Name : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(967, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Image :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(675, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(853, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(764, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 27);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Location = new System.Drawing.Point(626, 52);
            this.dtpEndDate.MinDate = new System.DateTime(2019, 7, 8, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(301, 26);
            this.dtpEndDate.TabIndex = 42;
            this.dtpEndDate.Value = new System.DateTime(2019, 7, 8, 11, 31, 16, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mobile : ";
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpJoiningDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpJoiningDate.Location = new System.Drawing.Point(148, 52);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(301, 26);
            this.dtpJoiningDate.TabIndex = 41;
            this.dtpJoiningDate.Tag = "Required";
            this.dtpJoiningDate.Value = new System.DateTime(2019, 7, 8, 16, 27, 16, 0);
            this.dtpJoiningDate.ValueChanged += new System.EventHandler(this.dtpJoiningDate_ValueChanged);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Image = global::SchoolManagementSystem.Properties.Resources.professor;
            this.pbImage.Location = new System.Drawing.Point(971, 30);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(195, 189);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 36;
            this.pbImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "End Date : ";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.Location = new System.Drawing.Point(148, 6);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(301, 26);
            this.txtTeacherName.TabIndex = 30;
            this.txtTeacherName.Tag = "Required";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Joining Date : ";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(626, 6);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(301, 26);
            this.txtMobile.TabIndex = 35;
            this.txtMobile.Tag = "Required";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Address : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasicInformation);
            this.tabControl1.Controls.Add(this.tabAssignClassSection);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 615);
            this.tabControl1.TabIndex = 17;
            // 
            // tabAssignClassSection
            // 
            this.tabAssignClassSection.Controls.Add(this.splitContainer2);
            this.tabAssignClassSection.Location = new System.Drawing.Point(4, 22);
            this.tabAssignClassSection.Name = "tabAssignClassSection";
            this.tabAssignClassSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignClassSection.Size = new System.Drawing.Size(1188, 589);
            this.tabAssignClassSection.TabIndex = 1;
            this.tabAssignClassSection.Text = "Assign Class & Section";
            this.tabAssignClassSection.UseVisualStyleBackColor = true;
            this.tabAssignClassSection.Enter += new System.EventHandler(this.tabAssignClassSection_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveTeacherClassSection);
            this.splitContainer2.Panel1.Controls.Add(this.tvClassSection);
            this.splitContainer2.Panel1.Controls.Add(this.cmbTeacher);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtTeacherClassInfoSearch);
            this.splitContainer2.Panel2.Controls.Add(this.btnTeacherClassInfoSearch);
            this.splitContainer2.Panel2.Controls.Add(this.dgvTeacherClassInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1182, 583);
            this.splitContainer2.SplitterDistance = 416;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 49;
            // 
            // btnSaveTeacherClassSection
            // 
            this.btnSaveTeacherClassSection.Location = new System.Drawing.Point(338, 11);
            this.btnSaveTeacherClassSection.Name = "btnSaveTeacherClassSection";
            this.btnSaveTeacherClassSection.Size = new System.Drawing.Size(66, 29);
            this.btnSaveTeacherClassSection.TabIndex = 50;
            this.btnSaveTeacherClassSection.Text = "Confirm";
            this.btnSaveTeacherClassSection.UseVisualStyleBackColor = true;
            this.btnSaveTeacherClassSection.Click += new System.EventHandler(this.btnSaveTeacherClassSection_Click);
            // 
            // tvClassSection
            // 
            this.tvClassSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvClassSection.CheckBoxes = true;
            this.tvClassSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvClassSection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvClassSection.FullRowSelect = true;
            this.tvClassSection.ItemHeight = 20;
            this.tvClassSection.LineColor = System.Drawing.Color.DarkGreen;
            this.tvClassSection.Location = new System.Drawing.Point(0, 46);
            this.tvClassSection.Name = "tvClassSection";
            this.tvClassSection.Size = new System.Drawing.Size(414, 535);
            this.tvClassSection.TabIndex = 49;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(98, 11);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(234, 29);
            this.cmbTeacher.TabIndex = 47;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(13, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Teacher : ";
            // 
            // txtTeacherClassInfoSearch
            // 
            this.txtTeacherClassInfoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeacherClassInfoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherClassInfoSearch.Location = new System.Drawing.Point(491, 14);
            this.txtTeacherClassInfoSearch.Name = "txtTeacherClassInfoSearch";
            this.txtTeacherClassInfoSearch.Size = new System.Drawing.Size(194, 26);
            this.txtTeacherClassInfoSearch.TabIndex = 18;
            this.txtTeacherClassInfoSearch.TextChanged += new System.EventHandler(this.btnTeacherClassInfoSearch_TextChanged);
            // 
            // btnTeacherClassInfoSearch
            // 
            this.btnTeacherClassInfoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeacherClassInfoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherClassInfoSearch.Location = new System.Drawing.Point(691, 13);
            this.btnTeacherClassInfoSearch.Name = "btnTeacherClassInfoSearch";
            this.btnTeacherClassInfoSearch.Size = new System.Drawing.Size(74, 27);
            this.btnTeacherClassInfoSearch.TabIndex = 19;
            this.btnTeacherClassInfoSearch.Text = "Search";
            this.btnTeacherClassInfoSearch.UseVisualStyleBackColor = true;
            this.btnTeacherClassInfoSearch.Click += new System.EventHandler(this.btnTeacherClassInfoSearch_Click);
            // 
            // dgvTeacherClassInfo
            // 
            this.dgvTeacherClassInfo.AllowUserToAddRows = false;
            this.dgvTeacherClassInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherClassInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTeacherClassInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeacherClassInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTeacherClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherClassInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cswtColTeacher,
            this.cswtColClass,
            this.cswtColSection,
            this.cswtColAction,
            this.cswtColID});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeacherClassInfo.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTeacherClassInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTeacherClassInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTeacherClassInfo.Location = new System.Drawing.Point(0, 46);
            this.dgvTeacherClassInfo.MultiSelect = false;
            this.dgvTeacherClassInfo.Name = "dgvTeacherClassInfo";
            this.dgvTeacherClassInfo.ReadOnly = true;
            this.dgvTeacherClassInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeacherClassInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvTeacherClassInfo.RowTemplate.Height = 60;
            this.dgvTeacherClassInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherClassInfo.Size = new System.Drawing.Size(762, 535);
            this.dgvTeacherClassInfo.TabIndex = 17;
            this.dgvTeacherClassInfo.Tag = "Required";
            this.dgvTeacherClassInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherClassInfo_CellContentClick);
            // 
            // cswtColTeacher
            // 
            this.cswtColTeacher.DataPropertyName = "TEACHER_NAME";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cswtColTeacher.DefaultCellStyle = dataGridViewCellStyle19;
            this.cswtColTeacher.FillWeight = 98.47716F;
            this.cswtColTeacher.HeaderText = "Teacher";
            this.cswtColTeacher.Name = "cswtColTeacher";
            this.cswtColTeacher.ReadOnly = true;
            // 
            // cswtColClass
            // 
            this.cswtColClass.DataPropertyName = "CLASS_NAME";
            this.cswtColClass.HeaderText = "Class";
            this.cswtColClass.Name = "cswtColClass";
            this.cswtColClass.ReadOnly = true;
            // 
            // cswtColSection
            // 
            this.cswtColSection.DataPropertyName = "SECTION_NAME";
            this.cswtColSection.HeaderText = "Section";
            this.cswtColSection.Name = "cswtColSection";
            this.cswtColSection.ReadOnly = true;
            // 
            // cswtColAction
            // 
            this.cswtColAction.HeaderText = "Action";
            this.cswtColAction.Name = "cswtColAction";
            this.cswtColAction.ReadOnly = true;
            this.cswtColAction.Text = "Remove";
            this.cswtColAction.UseColumnTextForButtonValue = true;
            // 
            // cswtColID
            // 
            this.cswtColID.DataPropertyName = "ID";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cswtColID.DefaultCellStyle = dataGridViewCellStyle20;
            this.cswtColID.HeaderText = "ID";
            this.cswtColID.Name = "cswtColID";
            this.cswtColID.ReadOnly = true;
            this.cswtColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cswtColID.Visible = false;
            // 
            // frmTeacher
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 615);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTeacher";
            this.Text = "frmTeacher";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabBasicInformation.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAssignClassSection.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherClassInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tabBasicInformation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llImage;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabAssignClassSection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvClassSection;
        private System.Windows.Forms.Button btnSaveTeacherClassSection;
        private System.Windows.Forms.DataGridView dgvTeacherClassInfo;
        private System.Windows.Forms.TextBox txtTeacherClassInfoSearch;
        private System.Windows.Forms.Button btnTeacherClassInfoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cswtColTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn cswtColClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn cswtColSection;
        private System.Windows.Forms.DataGridViewButtonColumn cswtColAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cswtColID;
    }
}