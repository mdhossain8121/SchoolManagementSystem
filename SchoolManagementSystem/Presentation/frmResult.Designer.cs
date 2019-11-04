namespace SchoolManagementSystem.Presentation
{
    partial class frmResult
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
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClassWiseExam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClassWiseSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClassWiseSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultEntry = new System.Windows.Forms.DataGridView();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btmSubmit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultEntry)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(105, 42);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(353, 30);
            this.cmbClass.TabIndex = 0;
            this.cmbClass.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbClassWiseExam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbClassWiseSubject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbClassWiseSection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1461, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(607, 106);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 28);
            this.textBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker1.Location = new System.Drawing.Point(1099, 106);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(353, 28);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(1011, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(485, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Marks: ";
            // 
            // cmbClassWiseExam
            // 
            this.cmbClassWiseExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClassWiseExam.FormattingEnabled = true;
            this.cmbClassWiseExam.Location = new System.Drawing.Point(104, 105);
            this.cmbClassWiseExam.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClassWiseExam.Name = "cmbClassWiseExam";
            this.cmbClassWiseExam.Size = new System.Drawing.Size(353, 30);
            this.cmbClassWiseExam.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exam : ";
            // 
            // cmbClassWiseSubject
            // 
            this.cmbClassWiseSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClassWiseSubject.FormattingEnabled = true;
            this.cmbClassWiseSubject.Location = new System.Drawing.Point(1096, 42);
            this.cmbClassWiseSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClassWiseSubject.Name = "cmbClassWiseSubject";
            this.cmbClassWiseSubject.Size = new System.Drawing.Size(353, 30);
            this.cmbClassWiseSubject.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(983, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject : ";
            // 
            // cmbClassWiseSection
            // 
            this.cmbClassWiseSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClassWiseSection.FormattingEnabled = true;
            this.cmbClassWiseSection.Location = new System.Drawing.Point(607, 42);
            this.cmbClassWiseSection.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClassWiseSection.Name = "cmbClassWiseSection";
            this.cmbClassWiseSection.Size = new System.Drawing.Size(353, 30);
            this.cmbClassWiseSection.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(485, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Section : ";
            // 
            // dgvResultEntry
            // 
            this.dgvResultEntry.AllowUserToAddRows = false;
            this.dgvResultEntry.AllowUserToOrderColumns = true;
            this.dgvResultEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultEntry.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResultEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSL,
            this.colStudentName,
            this.colRoll,
            this.colMarks,
            this.colid});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultEntry.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultEntry.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvResultEntry.Location = new System.Drawing.Point(16, 182);
            this.dgvResultEntry.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultEntry.MultiSelect = false;
            this.dgvResultEntry.Name = "dgvResultEntry";
            this.dgvResultEntry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultEntry.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultEntry.RowHeadersWidth = 4;
            this.dgvResultEntry.RowTemplate.Height = 30;
            this.dgvResultEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultEntry.Size = new System.Drawing.Size(1573, 582);
            this.dgvResultEntry.TabIndex = 66;
            this.dgvResultEntry.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvResultEntry_RowPostPaint);
            // 
            // colSL
            // 
            this.colSL.DataPropertyName = "SL";
            this.colSL.FillWeight = 30F;
            this.colSL.HeaderText = "SL";
            this.colSL.Name = "colSL";
            // 
            // colStudentName
            // 
            this.colStudentName.DataPropertyName = "STUDENT_NAME";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStudentName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colStudentName.FillWeight = 350F;
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            // 
            // colRoll
            // 
            this.colRoll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoll.DataPropertyName = "ROLL";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRoll.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRoll.FillWeight = 80F;
            this.colRoll.HeaderText = "Roll";
            this.colRoll.Name = "colRoll";
            this.colRoll.ReadOnly = true;
            // 
            // colMarks
            // 
            this.colMarks.DataPropertyName = "MARKS";
            this.colMarks.HeaderText = "Marks";
            this.colMarks.Name = "colMarks";
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btmSubmit);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(1485, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(99, 159);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // btmSubmit
            // 
            this.btmSubmit.Location = new System.Drawing.Point(0, 64);
            this.btmSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btmSubmit.Name = "btmSubmit";
            this.btmSubmit.Size = new System.Drawing.Size(99, 31);
            this.btmSubmit.TabIndex = 1;
            this.btmSubmit.Text = "Submit";
            this.btmSubmit.UseVisualStyleBackColor = true;
            this.btmSubmit.Click += new System.EventHandler(this.btmSubmit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 779);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvResultEntry);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResult";
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultEntry)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbClassWiseSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClassWiseExam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClassWiseSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvResultEntry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btmSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
    }
}