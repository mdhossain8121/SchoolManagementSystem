using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Class;
using SchoolManagementSystem.ClassManager;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmStudent : Form
    {
        StudentManager aStudentManager = new StudentManager();
        public frmStudent()
        {
            InitializeComponent();
            dtpJoiningDate.Value = DateTime.Now;
            dtpEndDate.MinDate = dtpJoiningDate.Value;
            dtpEndDate.MaxDate = DateTime.Now;
        }

        private void loadDatagridview()
        {
            Student aStudent = new Student();
            aStudent.ActiveStatus = 1;
            aStudent.StudentName = txtSearch.Text;
            DataTable dt = aStudentManager.GetAllStudentData(aStudent);
            if (dt == null)
            {
                MessageBox.Show(aStudent.Error);
                return;
            }
            try
            {
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch = " + ex.Message);
            }
        }

        private void resetControls()
        {
            Utilities.ResetAllControls(tabBasicInformation);
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
        }

        private void llImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif";
            ofd.ShowDialog();

            if (ofd.FileName == null || ofd.FileName == "")
                return;
            pbImage.BackgroundImage = Image.FromFile(ofd.FileName);
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

            Student student = new Student();
            student.Id = (int)btn.Tag;
            student.ActiveStatus = 0;
            student.EndDate = DateTime.Now;
            String Message = aStudentManager.DeleteStudent(student);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(tabBasicInformation))
                return;
            Student aStudent = new Student();
            aStudent.Image = FileImage.ImageToByte(pbImage.BackgroundImage);
            aStudent.StudentName = txtStudentName.Text;
            aStudent.Mobile = txtMobile.Text;
            aStudent.Address = txtAddress.Text;
            aStudent.StartDate = DateTime.Parse(dtpJoiningDate.Value.ToShortDateString());
            if (dtpEndDate.Checked)
            {
                aStudent.EndDate = dtpEndDate.Value.Date;
                aStudent.ActiveStatus = 0;
            }

            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aStudentManager.SaveStudent(aStudent);
            }
            else
            {
                aStudent.Id = (int)btnSave.Tag;
                message = aStudentManager.UpdateStudent(aStudent);
            }

            MessageBox.Show(message);
            resetControls();
            loadDatagridview();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            loadDatagridview();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;
            pbImage.BackgroundImage = FileImage.ImageFromByte((Byte[])dgvData.SelectedRows[0].Cells["colImage"].Value);
            txtStudentName.Text = dgvData.SelectedRows[0].Cells["colStudentName"].Value.ToString();
            txtMobile.Text = dgvData.SelectedRows[0].Cells["colMobile"].Value.ToString();
            dtpJoiningDate.Value = (DateTime)dgvData.SelectedRows[0].Cells["colStartDate"].Value;
            txtAddress.Text = dgvData.SelectedRows[0].Cells["colAddress"].Value.ToString();
            btnSave.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void dtpJoiningDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpJoiningDate.Value;
            dtpEndDate.Checked = false;
        }
    }
}
