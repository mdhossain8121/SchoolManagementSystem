using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Class;
using SchoolManagementSystem.ClassManager;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmTeacher : Form
    {
        TeacherManager aTeacherManager = new TeacherManager();
        public frmTeacher()
        {
            InitializeComponent();
            dtpJoiningDate.Value = DateTime.Now;
            dtpEndDate.MinDate = dtpJoiningDate.Value;
            dtpEndDate.MaxDate = DateTime.Now;
        }

        private void loadDatagridview()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.ActiveStatus = 1;
            aTeacher.TeacherName = txtSearch.Text;
            DataTable dt = aTeacherManager.GetAllTeacherData(aTeacher);
            if (dt == null)
            {
                MessageBox.Show(aTeacher.Error);
                return;
            }
            try
            {
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch = "+ex.Message);
            }
        }

        private void resetControls()
        {
            Utilities.EmptyAllControls(tabBasicInformation);
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

            Teacher teacher = new Teacher();
            teacher.Id = (int)btn.Tag;
            teacher.ActiveStatus = 0;
            teacher.EndDate = DateTime.Now;
            String Message = aTeacherManager.DeleteTeacher(teacher);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(tabBasicInformation))
                return;
            Teacher aTeacher = new Teacher();
            aTeacher.Image = FileImage.ImageToByte(pbImage.BackgroundImage);
            aTeacher.TeacherName = txtTeacherName.Text;
            aTeacher.Mobile = txtMobile.Text;
            aTeacher.Address = txtAddress.Text;
            aTeacher.JoiningDate = DateTime.Parse(dtpJoiningDate.Value.ToShortDateString());
            if(dtpEndDate.Checked)
            {
                aTeacher.EndDate = dtpEndDate.Value.Date;
                aTeacher.ActiveStatus = 0;
            }
                
            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aTeacherManager.SaveTeacher(aTeacher);
            }
            else
            {
                aTeacher.Id = (int)btnSave.Tag;
                message = aTeacherManager.UpdateTeacher(aTeacher);
            }

            MessageBox.Show(message);
            resetControls();
            loadDatagridview();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
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
            txtTeacherName.Text = dgvData.SelectedRows[0].Cells["colTeacherName"].Value.ToString();
            txtMobile.Text = dgvData.SelectedRows[0].Cells["colMobile"].Value.ToString();
            dtpJoiningDate.Value = (DateTime) dgvData.SelectedRows[0].Cells["colJoiningDate"].Value;
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
