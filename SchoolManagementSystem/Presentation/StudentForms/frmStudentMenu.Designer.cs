namespace SchoolManagementSystem.Presentation.StudentForms
{
    partial class frmStudentMenu
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnResult = new FontAwesome.Sharp.IconButton();
            this.btnAttendance = new FontAwesome.Sharp.IconButton();
            this.pnlSideBarLogo = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnAppMinimize = new FontAwesome.Sharp.IconButton();
            this.btnAppMaximize = new FontAwesome.Sharp.IconButton();
            this.btnAppClose = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            this.pnlSideBarLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.pnlSideBar.Controls.Add(this.btnResult);
            this.pnlSideBar.Controls.Add(this.btnAttendance);
            this.pnlSideBar.Controls.Add(this.pnlSideBarLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(248, 684);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResult.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnResult.IconColor = System.Drawing.Color.Gainsboro;
            this.btnResult.IconSize = 35;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(0, 126);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Rotation = 0D;
            this.btnResult.Size = new System.Drawing.Size(248, 55);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "   Result";
            this.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAttendance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAttendance.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnAttendance.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAttendance.IconSize = 32;
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 71);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Rotation = 0D;
            this.btnAttendance.Size = new System.Drawing.Size(248, 55);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = "   Attendance";
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // pnlSideBarLogo
            // 
            this.pnlSideBarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlSideBarLogo.Controls.Add(this.label1);
            this.pnlSideBarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSideBarLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBarLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideBarLogo.Name = "pnlSideBarLogo";
            this.pnlSideBarLogo.Size = new System.Drawing.Size(248, 71);
            this.pnlSideBarLogo.TabIndex = 1;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlTitleBar.Controls.Add(this.btnAppMinimize);
            this.pnlTitleBar.Controls.Add(this.btnAppMaximize);
            this.pnlTitleBar.Controls.Add(this.btnAppClose);
            this.pnlTitleBar.Controls.Add(this.btnCloseChildForm);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(248, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(961, 71);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnAppMinimize
            // 
            this.btnAppMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppMinimize.FlatAppearance.BorderSize = 0;
            this.btnAppMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAppMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAppMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnAppMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAppMinimize.IconSize = 20;
            this.btnAppMinimize.Location = new System.Drawing.Point(883, 4);
            this.btnAppMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppMinimize.Name = "btnAppMinimize";
            this.btnAppMinimize.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAppMinimize.Rotation = 0D;
            this.btnAppMinimize.Size = new System.Drawing.Size(27, 22);
            this.btnAppMinimize.TabIndex = 7;
            this.btnAppMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppMinimize.UseVisualStyleBackColor = true;
            this.btnAppMinimize.Click += new System.EventHandler(this.btnAppMinimize_Click);
            // 
            // btnAppMaximize
            // 
            this.btnAppMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppMaximize.FlatAppearance.BorderSize = 0;
            this.btnAppMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAppMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAppMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnAppMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAppMaximize.IconSize = 15;
            this.btnAppMaximize.Location = new System.Drawing.Point(909, 4);
            this.btnAppMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppMaximize.Name = "btnAppMaximize";
            this.btnAppMaximize.Rotation = 0D;
            this.btnAppMaximize.Size = new System.Drawing.Size(27, 22);
            this.btnAppMaximize.TabIndex = 6;
            this.btnAppMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppMaximize.UseVisualStyleBackColor = true;
            this.btnAppMaximize.Click += new System.EventHandler(this.btnAppMaximize_Click);
            // 
            // btnAppClose
            // 
            this.btnAppClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppClose.FlatAppearance.BorderSize = 0;
            this.btnAppClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAppClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAppClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnAppClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAppClose.IconSize = 20;
            this.btnAppClose.Location = new System.Drawing.Point(930, 4);
            this.btnAppClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppClose.Name = "btnAppClose";
            this.btnAppClose.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAppClose.Rotation = 0D;
            this.btnAppClose.Size = new System.Drawing.Size(27, 22);
            this.btnAppClose.TabIndex = 5;
            this.btnAppClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppClose.UseVisualStyleBackColor = true;
            this.btnAppClose.Click += new System.EventHandler(this.btnAppClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(423, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(248, 71);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(961, 613);
            this.pnlChildForm.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCloseChildForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCloseChildForm.IconSize = 35;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Rotation = 0D;
            this.btnCloseChildForm.Size = new System.Drawing.Size(66, 71);
            this.btnCloseChildForm.TabIndex = 4;
            this.btnCloseChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Portal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 684);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "frmStudentMenu";
            this.Text = "frmStudentMenu";
            this.Resize += new System.EventHandler(this.frmStudentMenu_Resize);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBarLogo.ResumeLayout(false);
            this.pnlSideBarLogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlSideBarLogo;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnResult;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlChildForm;
        private FontAwesome.Sharp.IconButton btnAppClose;
        private FontAwesome.Sharp.IconButton btnAppMinimize;
        private FontAwesome.Sharp.IconButton btnAppMaximize;
        private FontAwesome.Sharp.IconButton btnCloseChildForm;
        private System.Windows.Forms.Label label1;
    }
}