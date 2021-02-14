namespace SchoolManagementSystem.Presentation
{
    partial class frmAttendanceReport
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
            this.gpAttendance = new System.Windows.Forms.GroupBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.Student = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAttendanceSearch = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.crvAttendanceReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gpAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpAttendance
            // 
            this.gpAttendance.Controls.Add(this.cmbStudent);
            this.gpAttendance.Controls.Add(this.Student);
            this.gpAttendance.Controls.Add(this.cmbSection);
            this.gpAttendance.Controls.Add(this.label6);
            this.gpAttendance.Controls.Add(this.cmbClass);
            this.gpAttendance.Controls.Add(this.label3);
            this.gpAttendance.Controls.Add(this.dtpFrom);
            this.gpAttendance.Controls.Add(this.label1);
            this.gpAttendance.Controls.Add(this.btnAttendanceSearch);
            this.gpAttendance.Controls.Add(this.dtpTo);
            this.gpAttendance.Controls.Add(this.label2);
            this.gpAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpAttendance.Location = new System.Drawing.Point(0, 0);
            this.gpAttendance.Name = "gpAttendance";
            this.gpAttendance.Size = new System.Drawing.Size(1356, 48);
            this.gpAttendance.TabIndex = 69;
            this.gpAttendance.TabStop = false;
            // 
            // cmbStudent
            // 
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(1031, 15);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(227, 26);
            this.cmbStudent.TabIndex = 19;
            this.cmbStudent.Tag = "Required";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Student.Location = new System.Drawing.Point(959, 19);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(70, 18);
            this.Student.TabIndex = 18;
            this.Student.Text = "Student : ";
            // 
            // cmbSection
            // 
            this.cmbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(799, 15);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(143, 26);
            this.cmbSection.TabIndex = 17;
            this.cmbSection.Tag = "Required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(730, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Section : ";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(562, 15);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(149, 26);
            this.cmbClass.TabIndex = 14;
            this.cmbClass.Tag = "Required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(498, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Class : ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(107, 16);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(135, 24);
            this.dtpFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date : ";
            // 
            // btnAttendanceSearch
            // 
            this.btnAttendanceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceSearch.Location = new System.Drawing.Point(1275, 16);
            this.btnAttendanceSearch.Name = "btnAttendanceSearch";
            this.btnAttendanceSearch.Size = new System.Drawing.Size(75, 24);
            this.btnAttendanceSearch.TabIndex = 4;
            this.btnAttendanceSearch.Text = "Search";
            this.btnAttendanceSearch.UseVisualStyleBackColor = true;
            this.btnAttendanceSearch.Click += new System.EventHandler(this.btnAttendanceSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(343, 16);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(135, 24);
            this.dtpTo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date : ";
            // 
            // crvAttendanceReport
            // 
            this.crvAttendanceReport.ActiveViewIndex = -1;
            this.crvAttendanceReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvAttendanceReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvAttendanceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvAttendanceReport.Location = new System.Drawing.Point(0, 48);
            this.crvAttendanceReport.Name = "crvAttendanceReport";
            this.crvAttendanceReport.Size = new System.Drawing.Size(1356, 566);
            this.crvAttendanceReport.TabIndex = 70;
            this.crvAttendanceReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 614);
            this.Controls.Add(this.crvAttendanceReport);
            this.Controls.Add(this.gpAttendance);
            this.Name = "frmAttendanceReport";
            this.Text = "frmAttendanceReport";
            this.Load += new System.EventHandler(this.frmAttendanceReport_Load);
            this.gpAttendance.ResumeLayout(false);
            this.gpAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAttendance;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAttendanceSearch;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvAttendanceReport;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label Student;
    }
}