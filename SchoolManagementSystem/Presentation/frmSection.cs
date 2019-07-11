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
    public partial class frmSection : Form
    {
        SectionManager aSectionManager = new SectionManager();
        public frmSection()
        {
            InitializeComponent();
        }

        private void loadDatagridview()
        {
            Section aSection = new Section();
            aSection.ActiveStatus = 1;
            aSection.SectionName = txtSearch.Text;
            DataTable dt = aSectionManager.GetAllSectionData(aSection);
            if (dt == null)
            {
                MessageBox.Show(aSection.Error);
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

            Section aSection = new Section();
            aSection.Id = (int)btn.Tag;
            aSection.ActiveStatus = 0;
            String Message = aSectionManager.DeleteSection(aSection);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(groupBox1))
                return;

            Section aSection = new Section();
            aSection.SectionName = txtSectionName.Text;
            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aSectionManager.SaveSection(aSection);
            }
            else
            {
                aSection.Id = (int)btnSave.Tag;
                message = aSectionManager.UpdateSection(aSection);
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
            txtSectionName.Text = dgvData.SelectedRows[0].Cells["colSectionName"].Value.ToString();
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
