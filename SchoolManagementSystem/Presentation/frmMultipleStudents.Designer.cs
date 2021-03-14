namespace SchoolManagementSystem.Presentation
{
    partial class frmMultipleStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMultipleStudentsEntry = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClassWiseSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMultipleStudentsSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleStudentsEntry)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMultipleStudentsEntry
            // 
            this.dgvMultipleStudentsEntry.AllowUserToAddRows = false;
            this.dgvMultipleStudentsEntry.AllowUserToOrderColumns = true;
            this.dgvMultipleStudentsEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMultipleStudentsEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultipleStudentsEntry.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMultipleStudentsEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultipleStudentsEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvMultipleStudentsEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultipleStudentsEntry.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvMultipleStudentsEntry.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvMultipleStudentsEntry.Location = new System.Drawing.Point(31, 78);
            this.dgvMultipleStudentsEntry.MultiSelect = false;
            this.dgvMultipleStudentsEntry.Name = "dgvMultipleStudentsEntry";
            this.dgvMultipleStudentsEntry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultipleStudentsEntry.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvMultipleStudentsEntry.RowHeadersWidth = 4;
            this.dgvMultipleStudentsEntry.RowTemplate.Height = 30;
            this.dgvMultipleStudentsEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMultipleStudentsEntry.Size = new System.Drawing.Size(1073, 535);
            this.dgvMultipleStudentsEntry.TabIndex = 67;
            this.dgvMultipleStudentsEntry.Tag = "Required";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnMultipleStudentsSave);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.cmbSession);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbClassWiseSection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 60);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImport.Location = new System.Drawing.Point(893, 18);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(78, 28);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // cmbSession
            // 
            this.cmbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(384, 19);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(210, 26);
            this.cmbSession.TabIndex = 13;
            this.cmbSession.Tag = "Required";
            this.cmbSession.SelectionChangeCommitted += new System.EventHandler(this.cmbSession_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(307, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Session :";
            // 
            // cmbClassWiseSection
            // 
            this.cmbClassWiseSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClassWiseSection.FormattingEnabled = true;
            this.cmbClassWiseSection.Location = new System.Drawing.Point(687, 19);
            this.cmbClassWiseSection.Name = "cmbClassWiseSection";
            this.cmbClassWiseSection.Size = new System.Drawing.Size(175, 26);
            this.cmbClassWiseSection.TabIndex = 3;
            this.cmbClassWiseSection.Tag = "Required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(615, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Section :";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(86, 19);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(201, 26);
            this.cmbClass.TabIndex = 0;
            this.cmbClass.Tag = "Required";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class :";
            // 
            // btnMultipleStudentsSave
            // 
            this.btnMultipleStudentsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnMultipleStudentsSave.Location = new System.Drawing.Point(992, 18);
            this.btnMultipleStudentsSave.Name = "btnMultipleStudentsSave";
            this.btnMultipleStudentsSave.Size = new System.Drawing.Size(75, 28);
            this.btnMultipleStudentsSave.TabIndex = 15;
            this.btnMultipleStudentsSave.Text = "Save";
            this.btnMultipleStudentsSave.UseVisualStyleBackColor = true;
            this.btnMultipleStudentsSave.Click += new System.EventHandler(this.btnMultipleStudentsSave_Click);
            // 
            // frmMultipleStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMultipleStudentsEntry);
            this.Name = "frmMultipleStudents";
            this.Text = "frmMultipleStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleStudentsEntry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMultipleStudentsEntry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClassWiseSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnMultipleStudentsSave;
    }
}