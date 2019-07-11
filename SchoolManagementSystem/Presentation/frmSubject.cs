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
    public partial class frmSubject : Form
    {
        private SubjectManager aSubjectManager = new SubjectManager();
        
        public frmSubject()
        {
            InitializeComponent();
        }

        private void loadDatagridview()
        {
            Subject aSubject = new Subject();
            aSubject.ActiveStatus = 1;
            aSubject.SubjectName = txtSearch.Text;
            DataTable dt = aSubjectManager.GetAllSubjectData(aSubject);
            if (dt == null)
            {
                MessageBox.Show(aSubject.Error);
                return;
            }
            dgvData.DataSource = dt;
        }

        private void resetControls()
        {
            Utilities.ResetAllControls(this.groupBox1);
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

            Subject aSubject = new Subject();
            aSubject.Id = (int)btn.Tag;
            aSubject.ActiveStatus = 0;
            String Message = aSubjectManager.DeleteSubject(aSubject);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(groupBox1))
                return;

            Subject aSubject = new Subject();
            aSubject.SubjectName = txtSubjectName.Text;
            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aSubjectManager.SaveSubject(aSubject);
            }
            else
            {
                aSubject.Id = (int)btnSave.Tag;
                message = aSubjectManager.UpdateSubject(aSubject);
            }

            MessageBox.Show(message);
            resetControls();
            loadDatagridview();
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;
            txtSubjectName.Text = dgvData.SelectedRows[0].Cells["colSubjectName"].Value.ToString();
            btnSave.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            loadDatagridview();
        }
    }
}
