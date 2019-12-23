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
                //dgvStudentBasicInfo.DataSource = null;
                dgvStudentBasicInfo.AutoGenerateColumns = false;
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
            Utilities.EmptyAllControls(pnlStudentBasicInfo);
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
        }


        private void resetClassInfoControls()
        {
            Utilities.EmptyAllControls(splitContainer2.Panel1);
            Utilities.ResetComboBox(cmbClassWiseSection);
            btnDeleteClassInfo.Enabled = false;
            btnSaveClassInfo.Text = "Save";
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
            if (Utilities.EmptyRequiredField(pnlStudentBasicInfo))
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
            if (Utilities.EmptyRequiredField(splitContainer2.Panel1))
                return;
            ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
            aClassSectionWiseStudent.StudentId = Convert.ToInt32(cmbStudent.SelectedValue.ToString());
            aClassSectionWiseStudent.ClassSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString());
            aClassSectionWiseStudent.Roll = Convert.ToInt32(txtRoll.Text.ToString());
            aClassSectionWiseStudent.Year = Convert.ToInt32(txtYear.Text.ToString());
            aClassSectionWiseStudent.ActiveStatus = 1;
            
            string message = "";
            if (btnSaveClassInfo.Text == "Save")
            {
                message = aClassSectionWiseStudentManager.SaveClassSectionWiseStudent(aClassSectionWiseStudent);
            }
            else
            {
                aClassSectionWiseStudent.Id = (int)btnSaveClassInfo.Tag;
                message = aClassSectionWiseStudentManager.UpdateClassSectionWiseStudent(aClassSectionWiseStudent);
            }

            MessageBox.Show(message);
            resetClassInfoControls();
            loadClassInfoDatagridview();
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
            resetClassInfoControls();
            loadClassInfoDatagridview();
        }

        private void tabClassInfo_Enter(object sender, EventArgs e)
        {
            resetClassInfoControls();
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

            // Load Session
            Class.Session s = new Class.Session();
            s.ActiveStatus = 1;
            DataSet dsSession = s.Select();
            if (dsSession == null)
            {
                MessageBox.Show(s.Error);
                return;
            }
            cmbSession.DataSource = dsSession.Tables[0];
            cmbSession.DisplayMember = "SESSION_YEAR";
            cmbSession.ValueMember = "ID";
            cmbSession.SelectedIndex = -1;


            Student aStudent = new Student();
            aStudent.ActiveStatus = 1;
            DataSet dsStudent = aStudent.Select();
            if (dsStudent == null)
            {
                MessageBox.Show(aStudent.Error);
                return;
            }
            cmbStudent.DataSource = dsStudent.Tables[0];
            cmbStudent.DisplayMember = "STUDENT_NAME";
            cmbStudent.ValueMember = "ID";
            cmbStudent.SelectedIndex = -1;
            loadClassInfoDatagridview();
            
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadAllSection();
        }

        private void dgvClassInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClassInfo.SelectedRows.Count <= 0)
                return;
            cmbStudent.Text = dgvClassInfo.SelectedRows[0].Cells["cscolStudentName"].Value.ToString();
            cmbClass.Text = dgvClassInfo.SelectedRows[0].Cells["cscolClass"].Value.ToString();
            cmbClassWiseSection.Text = dgvClassInfo.SelectedRows[0].Cells["cscolSection"].Value.ToString();
            txtRoll.Text = dgvClassInfo.SelectedRows[0].Cells["cscolRoll"].Value.ToString();
            txtYear.Text = dgvClassInfo.SelectedRows[0].Cells["cscolYear"].Value.ToString();
            btnSaveClassInfo.Tag = dgvClassInfo.SelectedRows[0].Cells["cscolid"].Value;
            btnDeleteClassInfo.Tag = dgvClassInfo.SelectedRows[0].Cells["cscolid"].Value;
            btnSaveClassInfo.Text = "Update";
            btnDeleteClassInfo.Enabled = true;
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAllSection();
        }

        public void loadAllSection()
        {
            cmbClassWiseSection.DataSource = null;
            cmbClassWiseSection.Items.Clear();
            cmbClassWiseSection.IntegralHeight = false;
            ClassWiseSection aClassWiseSection = new ClassWiseSection();
            aClassWiseSection.ActiveStatus = 1;
            try
            {
                aClassWiseSection.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
                aClassWiseSection.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString());
            }
            catch (Exception)
            {
                return;
            }
            DataSet dsClassWiseSection = aClassWiseSection.SelectByClassSessionId();
            if (dsClassWiseSection == null)
            {
                MessageBox.Show(aClassWiseSection.Error);
                return;
            }
            cmbClassWiseSection.DataSource = dsClassWiseSection.Tables[0];
            cmbClassWiseSection.DisplayMember = "SECTION_NAME";
            cmbClassWiseSection.ValueMember = "ID";
            cmbClassWiseSection.SelectedIndex = -1;
        }

        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadAllSection();
        }
    }
}
