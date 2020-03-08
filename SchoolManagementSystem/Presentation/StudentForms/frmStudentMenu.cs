using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace SchoolManagementSystem.Presentation.StudentForms
{
    public partial class frmStudentMenu : Form
    {
        private IconButton currentButton;
        private Form activeForm;
        private Panel leftBorderBtn;
        
        public frmStudentMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 45);
            pnlSideBar.Controls.Add(leftBorderBtn);
            btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color colorMenuBtnClick = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /*"#3F51B5",blue
        "#009688", green
        "#FF5722", orange
        "#607D8B",
        "#9C27B0",purple
        "#EA676C",red
        "#E41A4A",red force
        "#5978BB",
        "#018790",
        "#0E3441",
        "#00B0AD",
        "#721D47",
        "#EA4833",
        "#EF937E",
        "#F37521",
        "#A12059",
        "#126881",
        "#8BC240",
        "#364D5B",
        "#C7DC5B",
        "#0094BC",
        "#E4126B",
        "#43B76E",
        "#7BCFE9",
        "#B71C46"*/

        private void ActivateButton(object btnSender)
        {
            if(btnSender!=null)
            {
                if(currentButton!= (IconButton) btnSender)
                {
                    DisableButton();
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = Color.FromArgb(39, 39, 58) ;
                    currentButton.ForeColor = RGBColors.colorMenuBtnClick;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.TextAlign = ContentAlignment.MiddleLeft;
                    currentButton.IconColor = RGBColors.colorMenuBtnClick;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.ImageAlign = ContentAlignment.MiddleRight;

                    btnCloseChildForm.Visible = true;

                    //Left border button
                    leftBorderBtn.BackColor = RGBColors.colorMenuBtnClick;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
            }
        }


        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(51, 51, 70);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudentAttendance(), sender);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudentResult(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            currentButton = null;
            btnCloseChildForm.Visible = false;
            leftBorderBtn.SendToBack();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to close", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAppMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAppMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void frmStudentMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
