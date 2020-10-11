using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SchoolManagementSystem.Class;
using SchoolManagementSystem.ClassManager;
using SchoolManagementSystem.Presentation.StudentForms;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmLogin : Form
    {
        UserManager aUserManager = new UserManager();
        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAppMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to close", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(this))
                return;
            User aUser = new User();
            aUser.UserName = txtUserName.Text.ToString().Trim();
            aUser.Password = txtPassword.Text.ToString().Trim();

            int userRole = aUserManager.CheckCredentials(aUser);
            if (userRole > 0)
            {
                if (userRole.Equals(1))
                {
                    frmHome admin = new frmHome();
                    admin.Show();
                }else if (userRole.Equals(2)){
                    frmStudentMenu studentMenu = new frmStudentMenu();
                    studentMenu.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username and password");
            }
        }
    }
}
