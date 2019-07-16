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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasicInformation = new System.Windows.Forms.TabPage();
            this.llImage = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabBasicInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabBasicInformation);
            this.tabControl1.Location = new System.Drawing.Point(23, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 275);
            this.tabControl1.TabIndex = 21;
            // 
            // tabBasicInformation
            // 
            this.tabBasicInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBasicInformation.Controls.Add(this.llImage);
            this.tabBasicInformation.Controls.Add(this.label4);
            this.tabBasicInformation.Controls.Add(this.btnDelete);
            this.tabBasicInformation.Controls.Add(this.dtpEndDate);
            this.tabBasicInformation.Controls.Add(this.dtpJoiningDate);
            this.tabBasicInformation.Controls.Add(this.label6);
            this.tabBasicInformation.Controls.Add(this.label5);
            this.tabBasicInformation.Controls.Add(this.label2);
            this.tabBasicInformation.Controls.Add(this.txtAddress);
            this.tabBasicInformation.Controls.Add(this.txtMobile);
            this.tabBasicInformation.Controls.Add(this.txtStudentName);
            this.tabBasicInformation.Controls.Add(this.pbImage);
            this.tabBasicInformation.Controls.Add(this.label3);
            this.tabBasicInformation.Controls.Add(this.btnReset);
            this.tabBasicInformation.Controls.Add(this.btnSave);
            this.tabBasicInformation.Controls.Add(this.label1);
            this.tabBasicInformation.Location = new System.Drawing.Point(4, 22);
            this.tabBasicInformation.Name = "tabBasicInformation";
            this.tabBasicInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicInformation.Size = new System.Drawing.Size(1173, 249);
            this.tabBasicInformation.TabIndex = 0;
            this.tabBasicInformation.Text = "Student Basic Information";
            this.tabBasicInformation.UseVisualStyleBackColor = true;
            // 
            // llImage
            // 
            this.llImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llImage.AutoSize = true;
            this.llImage.Location = new System.Drawing.Point(1119, 22);
            this.llImage.Name = "llImage";
            this.llImage.Size = new System.Drawing.Size(42, 13);
            this.llImage.TabIndex = 45;
            this.llImage.TabStop = true;
            this.llImage.Text = "Browse";
            this.llImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llImage_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(962, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Image :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(848, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Location = new System.Drawing.Point(621, 65);
            this.dtpEndDate.MinDate = new System.DateTime(2019, 7, 8, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(301, 26);
            this.dtpEndDate.TabIndex = 42;
            this.dtpEndDate.Value = new System.DateTime(2019, 7, 8, 11, 31, 16, 0);
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpJoiningDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpJoiningDate.Location = new System.Drawing.Point(143, 65);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(301, 26);
            this.dtpJoiningDate.TabIndex = 41;
            this.dtpJoiningDate.Tag = "Required";
            this.dtpJoiningDate.Value = new System.DateTime(2019, 7, 8, 16, 27, 16, 0);
            this.dtpJoiningDate.ValueChanged += new System.EventHandler(this.dtpJoiningDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "End Date : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Joining Date : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Address : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(143, 109);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(779, 92);
            this.txtAddress.TabIndex = 37;
            this.txtAddress.Tag = "Required";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(621, 19);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(301, 26);
            this.txtMobile.TabIndex = 35;
            this.txtMobile.Tag = "Required";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(143, 19);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(301, 26);
            this.txtStudentName.TabIndex = 30;
            this.txtStudentName.Tag = "Required";
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbImage.BackColor = System.Drawing.Color.LightGray;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(966, 43);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(195, 189);
            this.pbImage.TabIndex = 36;
            this.pbImage.TabStop = false;
            this.pbImage.Tag = "Required";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mobile : ";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(759, 207);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 27);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(670, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Student Name : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1126, 303);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 27);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(911, 303);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 26);
            this.txtSearch.TabIndex = 18;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colStudentName,
            this.colMobile,
            this.colStartDate,
            this.colAddress,
            this.colid});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.Location = new System.Drawing.Point(23, 335);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.RowTemplate.Height = 60;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1177, 291);
            this.dgvData.TabIndex = 20;
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
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 641);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvData);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBasicInformation.ResumeLayout(false);
            this.tabBasicInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasicInformation;
        private System.Windows.Forms.LinkLabel llImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
    }
}