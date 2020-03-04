namespace SchoolManagementSystem.Presentation.Student
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
            this.pnlSideBar.SuspendLayout();
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
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(186, 556);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResult.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnResult.IconColor = System.Drawing.Color.Gainsboro;
            this.btnResult.IconSize = 32;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(0, 162);
            this.btnResult.Name = "btnResult";
            this.btnResult.Rotation = 0D;
            this.btnResult.Size = new System.Drawing.Size(186, 45);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "   Result";
            this.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAttendance.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnAttendance.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAttendance.IconSize = 32;
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 117);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Rotation = 0D;
            this.btnAttendance.Size = new System.Drawing.Size(186, 45);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = "   Attendance";
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = true;
            // 
            // pnlSideBarLogo
            // 
            this.pnlSideBarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlSideBarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSideBarLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBarLogo.Name = "pnlSideBarLogo";
            this.pnlSideBarLogo.Size = new System.Drawing.Size(186, 117);
            this.pnlSideBarLogo.TabIndex = 1;
            // 
            // frmStudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 556);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "frmStudentMenu";
            this.Text = "frmStudentMenu";
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlSideBarLogo;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnResult;
    }
}