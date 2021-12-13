namespace SchoolManagementSystem.Presentation
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblTotalTeacher = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDashboardSummary = new System.Windows.Forms.DataGridView();
            this.dcolClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolStudentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel6.Controls.Add(this.pictureBox10);
            this.panel6.Controls.Add(this.lblTotalTeacher);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(320, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 110);
            this.panel6.TabIndex = 7;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(150, 13);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(87, 81);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 6;
            this.pictureBox10.TabStop = false;
            // 
            // lblTotalTeacher
            // 
            this.lblTotalTeacher.AutoSize = true;
            this.lblTotalTeacher.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTotalTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalTeacher.Location = new System.Drawing.Point(3, 29);
            this.lblTotalTeacher.Name = "lblTotalTeacher";
            this.lblTotalTeacher.Size = new System.Drawing.Size(80, 46);
            this.lblTotalTeacher.TabIndex = 4;
            this.lblTotalTeacher.Text = "120";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(14, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Teachers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel5.Controls.Add(this.pictureBox9);
            this.panel5.Controls.Add(this.lblTotalStudent);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(5, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 110);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(150, 13);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(87, 81);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalStudent.Location = new System.Drawing.Point(3, 29);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(80, 46);
            this.lblTotalStudent.TabIndex = 4;
            this.lblTotalStudent.Text = "250";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(14, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Students";
            // 
            // dgvDashboardSummary
            // 
            this.dgvDashboardSummary.AllowUserToAddRows = false;
            this.dgvDashboardSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDashboardSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboardSummary.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDashboardSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboardSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDashboardSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboardSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolClass,
            this.dcolSection,
            this.dcolStudentCount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDashboardSummary.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDashboardSummary.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDashboardSummary.Location = new System.Drawing.Point(22, 185);
            this.dgvDashboardSummary.MultiSelect = false;
            this.dgvDashboardSummary.Name = "dgvDashboardSummary";
            this.dgvDashboardSummary.ReadOnly = true;
            this.dgvDashboardSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboardSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDashboardSummary.RowTemplate.Height = 60;
            this.dgvDashboardSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashboardSummary.Size = new System.Drawing.Size(1090, 306);
            this.dgvDashboardSummary.TabIndex = 24;
            // 
            // dcolClass
            // 
            this.dcolClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolClass.DataPropertyName = "CLASS_NAME";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcolClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dcolClass.FillWeight = 101.5228F;
            this.dcolClass.HeaderText = "Class";
            this.dcolClass.Name = "dcolClass";
            this.dcolClass.ReadOnly = true;
            // 
            // dcolSection
            // 
            this.dcolSection.DataPropertyName = "SECTION_NAME";
            this.dcolSection.HeaderText = "Section";
            this.dcolSection.Name = "dcolSection";
            this.dcolSection.ReadOnly = true;
            // 
            // dcolStudentCount
            // 
            this.dcolStudentCount.DataPropertyName = "TOTAL_STUDENT";
            this.dcolStudentCount.HeaderText = "Total Student";
            this.dcolStudentCount.Name = "dcolStudentCount";
            this.dcolStudentCount.ReadOnly = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1137, 611);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDashboardSummary);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.Enter += new System.EventHandler(this.DashBoard_Enter);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblTotalTeacher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDashboardSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolStudentCount;
    }
}