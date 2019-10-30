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
    public partial class frmExam : Form
    {
        ExamManager aExamManager = new ExamManager();
        public frmExam()
        {
            InitializeComponent();
        }

        private void loadDatagridview()
        {
            Exam aExam = new Exam();
            aExam.ActiveStatus = 1;
            aExam.ExamName = txtSearch.Text;
            DataTable dt = aExamManager.GetAllExamData(aExam);
            if (dt == null)
            {
                MessageBox.Show(aExam.Error);
                return;
            }
            dgvData.DataSource = dt;
        }

        private void resetControls()
        {
            Utilities.EmptyAllControls(this.groupBox1);
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
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

            Exam aExam = new Exam();
            aExam.Id = (int)btn.Tag;
            aExam.ActiveStatus = 0;
            String Message = aExamManager.DeleteExam(aExam);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(groupBox1))
                return;

            Exam aExam = new Exam();
            aExam.ExamName = txtExamName.Text;
            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aExamManager.SaveExam(aExam);
            }
            else
            {
                aExam.Id = (int)btnSave.Tag;
                message = aExamManager.UpdateExam(aExam);
            }

            MessageBox.Show(message);
            resetControls();
            loadDatagridview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;
            txtExamName.Text = dgvData.SelectedRows[0].Cells["colExamName"].Value.ToString();
            btnSave.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            loadDatagridview();
        }
    }
}
