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
        ClassSectionWiseStudentManager aClassSectionWiseStudentManager = new ClassSectionWiseStudentManager();
        public frmStudent()
        {
            InitializeComponent();
            dtpJoiningDate.Value = DateTime.Now;
            dtpEndDate.MinDate = dtpJoiningDate.Value;
            dtpEndDate.MaxDate = DateTime.Now;
        }

        private void loadStudentBasicInfoDatagridview()
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
                dgvStudentBasicInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch = " + ex.Message);
            }
        }

        private void loadClassInfoDatagridview()
        {
            ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
            aClassSectionWiseStudent.ActiveStatus = 1;
            //aStudent.StudentName = txtSearch.Text;
            DataTable dt = aClassSectionWiseStudentManager.GetAllClassSectionWiseStudentData(aClassSectionWiseStudent);
            if (dt == null)
            {
                MessageBox.Show(aClassSectionWiseStudent.Error);
                return;
            }
            try
            {
                dgvClassInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch = " + ex.Message);
            }
        }

        private void resetStudentBasicInfoControls()
        {
            Utilities.ResetAllControls(tabBasicInformation);
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
        }


        private void resetClassInfoControls()
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
            loadStudentBasicInfoDatagridview();
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
            resetStudentBasicInfoControls();
            loadStudentBasicInfoDatagridview();
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
            resetStudentBasicInfoControls();
            loadStudentBasicInfoDatagridview();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            loadStudentBasicInfoDatagridview();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetStudentBasicInfoControls();
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudentBasicInfo.SelectedRows.Count <= 0)
                return;
            pbImage.BackgroundImage = FileImage.ImageFromByte((Byte[])dgvStudentBasicInfo.SelectedRows[0].Cells["colImage"].Value);
            txtStudentName.Text = dgvStudentBasicInfo.SelectedRows[0].Cells["colStudentName"].Value.ToString();
            txtMobile.Text = dgvStudentBasicInfo.SelectedRows[0].Cells["colMobile"].Value.ToString();
            dtpJoiningDate.Value = (DateTime)dgvStudentBasicInfo.SelectedRows[0].Cells["colStartDate"].Value;
            txtAddress.Text = dgvStudentBasicInfo.SelectedRows[0].Cells["colAddress"].Value.ToString();
            btnSave.Tag = dgvStudentBasicInfo.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvStudentBasicInfo.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void dtpJoiningDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpJoiningDate.Value;
            dtpEndDate.Checked = false;
        }

        private void btnSaveClassInfo_Click(object sender, EventArgs e)
        {

        }

        private void tabStudentBasicInfo_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void tabBasicInformation_Enter(object sender, EventArgs e)
        {
            loadStudentBasicInfoDatagridview();
        }

        private void btnResetClassInfo_Click(object sender, EventArgs e)
        {
            resetClassInfoControls();
        }

        private void btnSearchClassInfo_Click(object sender, EventArgs e)
        {
            loadStudentBasicInfoDatagridview();
        }

        private void btnDeleteClassInfo_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn.Tag == null)
                return;

            DialogResult dr = MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;
            ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
            aClassSectionWiseStudent.Id = (int)btn.Tag;
            aClassSectionWiseStudent.ActiveStatus = 0;
            String Message = aClassSectionWiseStudentManager.DeleteClassSectionWiseStudent(aClassSectionWiseStudent);
            MessageBox.Show(Message);
            resetStudentBasicInfoControls();
            loadStudentBasicInfoDatagridview();
        }

        private void tabClassInfo_Enter(object sender, EventArgs e)
        {
            ClassSetup cs = new ClassSetup();
            DataSet dsClass = cs.Select();
            if (dsClass == null)
            {
                MessageBox.Show(cs.Error);
                return;
            }
            cmbClass.DataSource = dsClass.Tables[0];
            cmbClass.DisplayMember = "CLASS_NAME";
            cmbClass.ValueMember = "ID";
            cmbClass.SelectedIndex = -1;


            Student aStudet = new Student();
            aStudet.ActiveStatus = 1;
            DataSet dsStudent = aStudet.Select();
            if (dsStudent == null)
            {
                MessageBox.Show(cs.Error);
                return;
            }
            cmbStudent.DataSource = dsStudent.Tables[0];
            cmbStudent.DisplayMember = "STUDENT_NAME";
            cmbStudent.ValueMember = "ID";
            cmbStudent.SelectedIndex = -1;


        }
    }
}
