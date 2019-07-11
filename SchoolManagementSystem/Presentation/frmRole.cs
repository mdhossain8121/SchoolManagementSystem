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
    public partial class frmRole : Form
    {
        RoleManager aRoleManager = new RoleManager();

        public frmRole()
        {
            InitializeComponent();
        }
        
        private void loadDatagridview()
        {
            Role aRole = new Role();
            aRole.ActiveStatus = 1;
            aRole.RoleName = txtSearch.Text;
            DataTable dt = aRoleManager.GetAllRoleData(aRole);
            if (dt == null)
            {
                MessageBox.Show(aRole.Error);
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
            if (btn.Tag==null)
                return;

            DialogResult dr = MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            Role role = new Role();
            role.Id = (int) btn.Tag;
            role.ActiveStatus = 0;
            String Message = aRoleManager.DeleteRole(role);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(this.groupBox1))
                return;

            Role aRole = new Role();
            aRole.RoleName = txtRoleName.Text;
            aRole.Description = txtDescription.Text;
            string message = "";
            if(btnSave.Text == "Save")
            {
                message = aRoleManager.SaveRole(aRole);
            }
            else
            {
                aRole.Id = (int) btnSave.Tag;
                message = aRoleManager.UpdateRole(aRole);
            }
            
            MessageBox.Show(message);
            resetControls();
            loadDatagridview();
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            loadDatagridview();
            dgvData.Columns[1].Width = 200;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count <= 0)
                return;
            txtRoleName.Text = dgvData.SelectedRows[0].Cells["colRoleName"].Value.ToString();
            txtDescription.Text = dgvData.SelectedRows[0].Cells["colDescription"].Value.ToString();
            btnSave.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnDelete.Tag = dgvData.SelectedRows[0].Cells["colid"].Value;
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }
    }
}
