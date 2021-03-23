namespace SchoolManagementSystem.Presentation.StudentForms
{
    partial class frmStudentResultReport
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
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClassWiseExam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClassWiseSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crvResultReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClass
            // 
            this.cmbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(81, 23);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(165, 26);
            this.cmbClass.TabIndex = 0;
            this.cmbClass.Tag = "Required";
            this.cmbClass.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbSession);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbClassWiseExam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbClassWiseSection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(260, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSession
            // 
            this.cmbSession.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(340, 23);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(165, 26);
            this.cmbSession.TabIndex = 13;
            this.cmbSession.Tag = "Required";
            this.cmbSession.SelectionChangeCommitted += new System.EventHandler(this.cmbSession_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(264, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Session :";
            // 
            // cmbClassWiseExam
            // 
            this.cmbClassWiseExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClassWiseExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClassWiseExam.FormattingEnabled = true;
            this.cmbClassWiseExam.Location = new System.Drawing.Point(81, 65);
            this.cmbClassWiseExam.Name = "cmbClassWiseExam";
            this.cmbClassWiseExam.Size = new System.Drawing.Size(165, 26);
            this.cmbClassWiseExam.TabIndex = 6;
            this.cmbClassWiseExam.Tag = "Required";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exam : ";
            // 
            // cmbClassWiseSection
            // 
            this.cmbClassWiseSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClassWiseSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbClassWiseSection.FormattingEnabled = true;
            this.cmbClassWiseSection.Location = new System.Drawing.Point(593, 23);
            this.cmbClassWiseSection.Name = "cmbClassWiseSection";
            this.cmbClassWiseSection.Size = new System.Drawing.Size(165, 26);
            this.cmbClassWiseSection.TabIndex = 3;
            this.cmbClassWiseSection.Tag = "Required";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(521, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Section :";
            // 
            // crvResultReport
            // 
            this.crvResultReport.ActiveViewIndex = -1;
            this.crvResultReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvResultReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResultReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResultReport.Location = new System.Drawing.Point(19, 120);
            this.crvResultReport.Name = "crvResultReport";
            this.crvResultReport.Size = new System.Drawing.Size(779, 412);
            this.crvResultReport.TabIndex = 68;
            this.crvResultReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmStudentResultReport
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 532);
            this.Controls.Add(this.crvResultReport);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentResultReport";
            this.Text = "Result Report Form";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSession;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResultReport;
    }
}