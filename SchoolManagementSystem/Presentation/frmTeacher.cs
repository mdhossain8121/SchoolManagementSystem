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
    public partial class frmTeacher : Form
    {

        TeacherManager aTeacherManager = new TeacherManager();
        public frmTeacher()
        {
            InitializeComponent();
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
            dgvData.DataSource = dt;
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
            ofd.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif|TUSHARSIR|*.sir";
            ofd.ShowDialog();

            if (ofd.FileName == null || ofd.FileName == "")
                return;
            Console.WriteLine("image");
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
            Console.WriteLine("asds");
            Console.WriteLine(dtpEndDate.Value.Date);
            return;
            aTeacher.TeacherName = txtTeacherName.Text;
            aTeacher.Mobile = txtMobile.Text;
            aTeacher.Address = txtAddress.Text;
            aTeacher.JoiningDate = dtpJoiningDate.Value.Date;
            aTeacher.EndDate =  dtpEndDate.Value.Date;
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
            txtTeacherName.Text = dgvData.SelectedRows[0].Cells["colTeacherName"].Value.ToString();
            txtMobile.Text = dgvData.SelectedRows[0].Cells["colMobile"].Value.ToString();
            dtpJoiningDate.Value = (DateTime) dgvData.SelectedRows[0].Cells["colJoiningDate"].Value;
            dtpEndDate.Value = DateTime.Now;
            txtAddress.Text = dgvData.SelectedRows[0].Cells["colAddress"].Value.ToString();
            btnSave.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }
    }
}
