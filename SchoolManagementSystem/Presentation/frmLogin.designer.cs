namespace SchoolManagementSystem.Presentation
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAppClose = new FontAwesome.Sharp.IconButton();
            this.btnAppMinimize = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(36, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(36, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(42, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login to Your Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(36, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(197, 27);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(36, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.iconLogin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(82, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAppClose
            // 
            this.btnAppClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAppClose.FlatAppearance.BorderSize = 0;
            this.btnAppClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAppClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAppClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnAppClose.IconColor = System.Drawing.Color.DimGray;
            this.btnAppClose.IconSize = 20;
            this.btnAppClose.Location = new System.Drawing.Point(250, 0);
            this.btnAppClose.Name = "btnAppClose";
            this.btnAppClose.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnAppClose.Rotation = 0D;
            this.btnAppClose.Size = new System.Drawing.Size(20, 18);
            this.btnAppClose.TabIndex = 8;
            this.btnAppClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppClose.UseVisualStyleBackColor = true;
            this.btnAppClose.Click += new System.EventHandler(this.btnAppClose_Click);
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
            this.btnAppMinimize.IconColor = System.Drawing.Color.DimGray;
            this.btnAppMinimize.IconSize = 20;
            this.btnAppMinimize.Location = new System.Drawing.Point(224, 0);
            this.btnAppMinimize.Name = "btnAppMinimize";
            this.btnAppMinimize.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnAppMinimize.Rotation = 0D;
            this.btnAppMinimize.Size = new System.Drawing.Size(20, 18);
            this.btnAppMinimize.TabIndex = 9;
            this.btnAppMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppMinimize.UseVisualStyleBackColor = true;
            this.btnAppMinimize.Click += new System.EventHandler(this.btnAppMinimize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(126, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Forgot Password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(270, 393);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAppMinimize);
            this.Controls.Add(this.btnAppClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAppClose;
        private FontAwesome.Sharp.IconButton btnAppMinimize;
        private System.Windows.Forms.Label label4;
    }
}