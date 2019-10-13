namespace SchoolManagementSystem.Presentation
{
    partial class frmStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabStudentInformation = new System.Windows.Forms.TabControl();
            this.tabBasicInformation = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudentBasicInfo = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabClassInfo = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbClassWiseSection = new System.Windows.Forms.ComboBox();
            this.btnDeleteClassInfo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnResetClassInfo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveClassInfo = new System.Windows.Forms.Button();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvClassInfo = new System.Windows.Forms.DataGridView();
            this.cscolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cscolStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cscolClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cscolSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cscolRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cscolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSearchClassInfo = new System.Windows.Forms.Button();
            this.tabStudentInformation.SuspendLayout();
            this.tabBasicInformation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBasicInfo)).BeginInit();
            this.tabClassInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStudentInformation
            // 
            this.tabStudentInformation.Controls.Add(this.tabBasicInformation);
            this.tabStudentInformation.Controls.Add(this.tabClassInfo);
            this.tabStudentInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStudentInformation.Location = new System.Drawing.Point(0, 0);
            this.tabStudentInformation.Multiline = true;
            this.tabStudentInformation.Name = "tabStudentInformation";
            this.tabStudentInformation.SelectedIndex = 0;
            this.tabStudentInformation.Size = new System.Drawing.Size(1184, 613);
            this.tabStudentInformation.TabIndex = 21;
            this.tabStudentInformation.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabStudentBasicInfo_Selected);
            // 
            // tabBasicInformation
            // 
            this.tabBasicInformation.Controls.Add(this.tableLayoutPanel1);
            this.tabBasicInformation.Location = new System.Drawing.Point(4, 22);
            this.tabBasicInformation.Name = "tabBasicInformation";
            this.tabBasicInformation.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabBasicInformation.Size = new System.Drawing.Size(1176, 587);
            this.tabBasicInformation.TabIndex = 0;
            this.tabBasicInformation.Text = "Student Basic Information";
            this.tabBasicInformation.UseVisualStyleBackColor = true;
            this.tabBasicInformation.Enter += new System.EventHandler(this.tabBasicInformation_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 585);
            this.tableLayoutPanel1.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.llImage);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpJoiningDate);
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtStudentName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMobile);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 226);
            this.panel2.TabIndex = 68;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(151, 93);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(779, 92);
            this.txtAddress.TabIndex = 70;
            this.txtAddress.Tag = "Required";
            // 
            // llImage
            // 
            this.llImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.llImage.AutoSize = true;
            this.llImage.Location = new System.Drawing.Point(1102, 6);
            this.llImage.Name = "llImage";
            this.llImage.Size = new System.Drawing.Size(42, 13);
            this.llImage.TabIndex = 78;
            this.llImage.TabStop = true;
            this.llImage.Text = "Browse";
            this.llImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llImage_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Student Name : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(946, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Image :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(677, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(854, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(766, 192);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 27);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Location = new System.Drawing.Point(628, 52);
            this.dtpEndDate.MinDate = new System.DateTime(2019, 7, 8, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(301, 26);
            this.dtpEndDate.TabIndex = 75;
            this.dtpEndDate.Value = new System.DateTime(2019, 7, 8, 11, 31, 16, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Mobile : ";
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpJoiningDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpJoiningDate.Location = new System.Drawing.Point(151, 52);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(301, 26);
            this.dtpJoiningDate.TabIndex = 74;
            this.dtpJoiningDate.Tag = "Required";
            this.dtpJoiningDate.Value = new System.DateTime(2019, 7, 8, 16, 27, 16, 0);
            this.dtpJoiningDate.ValueChanged += new System.EventHandler(this.dtpJoiningDate_ValueChanged);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbImage.BackColor = System.Drawing.Color.LightGray;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(950, 29);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(195, 189);
            this.pbImage.TabIndex = 69;
            this.pbImage.TabStop = false;
            this.pbImage.Tag = "Required";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "End Date : ";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(151, 6);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(301, 26);
            this.txtStudentName.TabIndex = 63;
            this.txtStudentName.Tag = "Required";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Joining Date : ";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(628, 6);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(301, 26);
            this.txtMobile.TabIndex = 68;
            this.txtMobile.Tag = "Required";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Address : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvStudentBasicInfo);
            this.panel1.Location = new System.Drawing.Point(3, 234);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 348);
            this.panel1.TabIndex = 67;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(860, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 26);
            this.txtSearch.TabIndex = 63;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1074, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 27);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvStudentBasicInfo
            // 
            this.dgvStudentBasicInfo.AllowUserToAddRows = false;
            this.dgvStudentBasicInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentBasicInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentBasicInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStudentBasicInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentBasicInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentBasicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentBasicInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colStudentName,
            this.colMobile,
            this.colStartDate,
            this.colAddress,
            this.colid,
            this.colEndDate});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentBasicInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentBasicInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudentBasicInfo.Location = new System.Drawing.Point(18, 37);
            this.dgvStudentBasicInfo.MultiSelect = false;
            this.dgvStudentBasicInfo.Name = "dgvStudentBasicInfo";
            this.dgvStudentBasicInfo.ReadOnly = true;
            this.dgvStudentBasicInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentBasicInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentBasicInfo.RowTemplate.Height = 60;
            this.dgvStudentBasicInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentBasicInfo.Size = new System.Drawing.Size(1130, 301);
            this.dgvStudentBasicInfo.TabIndex = 65;
            this.dgvStudentBasicInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentDoubleClick);
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
            // colStudentName
            // 
            this.colStudentName.DataPropertyName = "STUDENT_NAME";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStudentName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colStudentName.FillWeight = 98.47716F;
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            // 
            // colMobile
            // 
            this.colMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMobile.DataPropertyName = "MOBILE";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMobile.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMobile.FillWeight = 101.5228F;
            this.colMobile.HeaderText = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "START_DATE";
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colid.DefaultCellStyle = dataGridViewCellStyle4;
            this.colid.HeaderText = "ID";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            // 
            // colEndDate
            // 
            this.colEndDate.DataPropertyName = "END_DATE";
            this.colEndDate.HeaderText = "End Date";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Visible = false;
            // 
            // tabClassInfo
            // 
            this.tabClassInfo.Controls.Add(this.splitContainer2);
            this.tabClassInfo.Location = new System.Drawing.Point(4, 22);
            this.tabClassInfo.Name = "tabClassInfo";
            this.tabClassInfo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabClassInfo.Size = new System.Drawing.Size(1176, 587);
            this.tabClassInfo.TabIndex = 1;
            this.tabClassInfo.Text = "Class Information";
            this.tabClassInfo.UseVisualStyleBackColor = true;
            this.tabClassInfo.Enter += new System.EventHandler(this.tabClassInfo_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cmbClass);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.cmbStudent);
            this.splitContainer2.Panel1.Controls.Add(this.cmbClassWiseSection);
            this.splitContainer2.Panel1.Controls.Add(this.btnDeleteClassInfo);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.btnResetClassInfo);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveClassInfo);
            this.splitContainer2.Panel1.Controls.Add(this.txtRoll);
            this.splitContainer2.Panel1.Controls.Add(this.txtYear);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1MinSize = 20;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer2.Panel2.Controls.Add(this.dgvClassInfo);
            this.splitContainer2.Panel2.Controls.Add(this.textBox2);
            this.splitContainer2.Panel2.Controls.Add(this.btnSearchClassInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1170, 581);
            this.splitContainer2.SplitterDistance = 171;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 49;
            // 
            // cmbClass
            // 
            this.cmbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(281, 58);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(234, 28);
            this.cmbClass.TabIndex = 7;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            this.cmbClass.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(200, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Student : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(201, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Class : ";
            // 
            // cmbStudent
            // 
            this.cmbStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(281, 11);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(234, 28);
            this.cmbStudent.TabIndex = 47;
            // 
            // cmbClassWiseSection
            // 
            this.cmbClassWiseSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClassWiseSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbClassWiseSection.FormattingEnabled = true;
            this.cmbClassWiseSection.Location = new System.Drawing.Point(281, 105);
            this.cmbClassWiseSection.Name = "cmbClassWiseSection";
            this.cmbClassWiseSection.Size = new System.Drawing.Size(234, 28);
            this.cmbClassWiseSection.TabIndex = 9;
            // 
            // btnDeleteClassInfo
            // 
            this.btnDeleteClassInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteClassInfo.Enabled = false;
            this.btnDeleteClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClassInfo.Location = new System.Drawing.Point(853, 133);
            this.btnDeleteClassInfo.Name = "btnDeleteClassInfo";
            this.btnDeleteClassInfo.Size = new System.Drawing.Size(75, 27);
            this.btnDeleteClassInfo.TabIndex = 46;
            this.btnDeleteClassInfo.Text = "Delete";
            this.btnDeleteClassInfo.UseVisualStyleBackColor = true;
            this.btnDeleteClassInfo.Click += new System.EventHandler(this.btnDeleteClassInfo_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(201, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Section : ";
            // 
            // btnResetClassInfo
            // 
            this.btnResetClassInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetClassInfo.Location = new System.Drawing.Point(763, 133);
            this.btnResetClassInfo.Name = "btnResetClassInfo";
            this.btnResetClassInfo.Size = new System.Drawing.Size(75, 27);
            this.btnResetClassInfo.TabIndex = 45;
            this.btnResetClassInfo.Text = "Reset";
            this.btnResetClassInfo.UseVisualStyleBackColor = true;
            this.btnResetClassInfo.Click += new System.EventHandler(this.btnResetClassInfo_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(622, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Roll : ";
            // 
            // btnSaveClassInfo
            // 
            this.btnSaveClassInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClassInfo.Location = new System.Drawing.Point(674, 133);
            this.btnSaveClassInfo.Name = "btnSaveClassInfo";
            this.btnSaveClassInfo.Size = new System.Drawing.Size(75, 27);
            this.btnSaveClassInfo.TabIndex = 44;
            this.btnSaveClassInfo.Text = "Save";
            this.btnSaveClassInfo.UseVisualStyleBackColor = true;
            this.btnSaveClassInfo.Click += new System.EventHandler(this.btnSaveClassInfo_Click);
            // 
            // txtRoll
            // 
            this.txtRoll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRoll.Location = new System.Drawing.Point(694, 12);
            this.txtRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(234, 26);
            this.txtRoll.TabIndex = 11;
            this.txtRoll.Tag = "Required";
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYear.Location = new System.Drawing.Point(694, 59);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(234, 26);
            this.txtYear.TabIndex = 13;
            this.txtYear.Tag = "Required";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(622, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Year : ";
            // 
            // dgvClassInfo
            // 
            this.dgvClassInfo.AllowUserToAddRows = false;
            this.dgvClassInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClassInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClassInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cscolId,
            this.cscolStudentName,
            this.cscolClass,
            this.cscolSection,
            this.cscolRoll,
            this.cscolYear});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassInfo.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClassInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClassInfo.Location = new System.Drawing.Point(11, 37);
            this.dgvClassInfo.MultiSelect = false;
            this.dgvClassInfo.Name = "dgvClassInfo";
            this.dgvClassInfo.ReadOnly = true;
            this.dgvClassInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClassInfo.RowTemplate.Height = 60;
            this.dgvClassInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassInfo.Size = new System.Drawing.Size(1147, 354);
            this.dgvClassInfo.TabIndex = 23;
            this.dgvClassInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassInfo_CellContentDoubleClick);
            // 
            // cscolId
            // 
            this.cscolId.DataPropertyName = "ID";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cscolId.DefaultCellStyle = dataGridViewCellStyle8;
            this.cscolId.HeaderText = "ID";
            this.cscolId.Name = "cscolId";
            this.cscolId.ReadOnly = true;
            this.cscolId.Visible = false;
            // 
            // cscolStudentName
            // 
            this.cscolStudentName.DataPropertyName = "STUDENT_NAME";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cscolStudentName.DefaultCellStyle = dataGridViewCellStyle9;
            this.cscolStudentName.FillWeight = 98.47716F;
            this.cscolStudentName.HeaderText = "Student Name";
            this.cscolStudentName.Name = "cscolStudentName";
            this.cscolStudentName.ReadOnly = true;
            // 
            // cscolClass
            // 
            this.cscolClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cscolClass.DataPropertyName = "CLASS_NAME";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cscolClass.DefaultCellStyle = dataGridViewCellStyle10;
            this.cscolClass.FillWeight = 101.5228F;
            this.cscolClass.HeaderText = "Class";
            this.cscolClass.Name = "cscolClass";
            this.cscolClass.ReadOnly = true;
            // 
            // cscolSection
            // 
            this.cscolSection.DataPropertyName = "SECTION_NAME";
            this.cscolSection.HeaderText = "Section";
            this.cscolSection.Name = "cscolSection";
            this.cscolSection.ReadOnly = true;
            // 
            // cscolRoll
            // 
            this.cscolRoll.DataPropertyName = "ROLL";
            this.cscolRoll.HeaderText = "Roll";
            this.cscolRoll.Name = "cscolRoll";
            this.cscolRoll.ReadOnly = true;
            // 
            // cscolYear
            // 
            this.cscolYear.DataPropertyName = "YEAR";
            this.cscolYear.HeaderText = "Year";
            this.cscolYear.Name = "cscolYear";
            this.cscolYear.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(870, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 21;
            // 
            // btnSearchClassInfo
            // 
            this.btnSearchClassInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClassInfo.Location = new System.Drawing.Point(1084, 4);
            this.btnSearchClassInfo.Name = "btnSearchClassInfo";
            this.btnSearchClassInfo.Size = new System.Drawing.Size(74, 27);
            this.btnSearchClassInfo.TabIndex = 22;
            this.btnSearchClassInfo.Text = "Search";
            this.btnSearchClassInfo.UseVisualStyleBackColor = true;
            this.btnSearchClassInfo.Click += new System.EventHandler(this.btnSearchClassInfo_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 613);
            this.Controls.Add(this.tabStudentInformation);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.tabStudentInformation.ResumeLayout(false);
            this.tabBasicInformation.ResumeLayout(false);
            this.tabBasicInformation.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBasicInfo)).EndInit();
            this.tabClassInfo.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudentInformation;
        private System.Windows.Forms.TabPage tabBasicInformation;
        private System.Windows.Forms.TabPage tabClassInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbClassWiseSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteClassInfo;
        private System.Windows.Forms.Button btnResetClassInfo;
        private System.Windows.Forms.Button btnSaveClassInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvClassInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSearchClassInfo;
        private System.Windows.Forms.DataGridView dgvStudentBasicInfo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.LinkLabel llImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscolStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscolClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscolSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscolRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscolYear;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
    }
}