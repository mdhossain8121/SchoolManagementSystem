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
    public partial class frmClass : Form
    {
        ClassSetupManager aClassSetupManager = new ClassSetupManager();
        public frmClass()
        {
            InitializeComponent();
        }

        private void loadDatagridview()
        {
            ClassSetup aClassSetup = new ClassSetup();
            aClassSetup.ActiveStatus = 1;
            aClassSetup.ClassName = txtSearch.Text;
            DataTable dt = aClassSetupManager.GetAllClassData(aClassSetup);
            if (dt == null)
            {
                MessageBox.Show(aClassSetup.Error);
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

            ClassSetup aClassSetup = new ClassSetup();
            aClassSetup.Id = (int)btn.Tag;
            aClassSetup.ActiveStatus = 0;
            String Message = aClassSetupManager.DeleteClass(aClassSetup);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(groupBox1))
                return;

            ClassSetup aClassSetup = new ClassSetup();
            aClassSetup.ClassName = txtClassName.Text;
            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aClassSetupManager.SaveClass(aClassSetup);
            }
            else
            {
                aClassSetup.Id = (int)btnSave.Tag;
                message = aClassSetupManager.UpdateClass(aClassSetup);
            }

            MessageBox.Show(message);
            resetControls();
            loadDatagridview();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            loadDatagridview();
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;
            txtClassName.Text = dgvData.SelectedRows[0].Cells["colClassName"].Value.ToString();
            btnSave.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }
    }
}
