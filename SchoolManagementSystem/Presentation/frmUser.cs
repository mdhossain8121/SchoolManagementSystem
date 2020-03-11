using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.ClassManager;
using SchoolManagementSystem.Class;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmUser : Form
    {
        private UserManager aUserManager = new UserManager();
        public frmUser()
        {
            InitializeComponent();
        }

        private void loadDatagridview()
        {
            User aUser = new User();
            aUser.ActiveStatus = 1;
            aUser.UserName = txtSearch.Text;
            DataTable dt = aUserManager.GetAllUserData(aUser);
            if (dt == null)
            {
                MessageBox.Show(aUser.Error);
                return;
            }
            dgvData.DataSource = dt;
        }

        private void resetControls()
        {
            Utilities.EmptyAllControls(groupBox1);
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
            txtPassword.Enabled = true;
            txtUserName.Focus();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadDatagridview();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn.Tag == null)
                return;

            DialogResult dr = MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            User aUser = new User();
            aUser.Id = (int)btn.Tag;
            aUser.ActiveStatus = 0;
            String Message = aUserManager.DeleteUser(aUser);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnRoleSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(this.groupBox1))
                return;

            User aUser = new User();
            aUser.UserName = txtUserName.Text;
            aUser.Password = txtPassword.Text;
            aUser.RoleId = (int)cmbRole.SelectedValue;
            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aUserManager.SaveUser(aUser);
            }
            else
            {
                aUser.Id = (int)btnSave.Tag;
                message = aUserManager.UpdateUser(aUser);
            }

            MessageBox.Show(message);
            resetControls();
            loadDatagridview();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            loadDatagridview();
            dgvData.Columns[1].Width = 350;
            Console.WriteLine();
            Class.Role role = new Class.Role();
            role.ActiveStatus = 1;
            cmbRole.DataSource = role.Select().Tables[0];
            cmbRole.DisplayMember = "ROLE_NAME";
            cmbRole.ValueMember = "ID";
            cmbRole.SelectedValue = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;
            txtUserName.Text = dgvData.SelectedRows[0].Cells["colUserName"].Value.ToString();
            cmbRole.SelectedIndex = cmbRole.FindStringExact(dgvData.SelectedRows[0].Cells["colRoleName"].Value.ToString());
            txtPassword.Enabled = false;
            btnSave.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void cmbRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbUser.DataSource = null;
            cmbUser.Items.Clear();
            cmbUser.IntegralHeight = false;
            int userType = 0;
            try
            {
                userType = Convert.ToInt32(cmbRole.SelectedValue.ToString());
            }
            catch (Exception)
            {
                return;
            }
            
            if (userType == 2)
            {
                Student student = new Student();
                student.ActiveStatus = 1;

                DataSet dsStudent = student.Select();
                if (dsStudent == null)
                {
                    MessageBox.Show(student.Error);
                    return;
                }
                cmbUser.DataSource = dsStudent.Tables[0];
                cmbUser.DisplayMember = "STUDENT_NAME";
                cmbUser.ValueMember = "ID";
            }
            else if (userType == 3)
            {
                Teacher student = new Teacher();
                student.ActiveStatus = 1;

                DataSet dsStudent = student.Select();
                if (dsStudent == null)
                {
                    MessageBox.Show(student.Error);
                    return;
                }
                cmbUser.DataSource = dsStudent.Tables[0];
                cmbUser.DisplayMember = "TEACHER_NAME";
                cmbUser.ValueMember = "ID";
            }
            cmbUser.SelectedIndex = -1;
        }
    }
}
