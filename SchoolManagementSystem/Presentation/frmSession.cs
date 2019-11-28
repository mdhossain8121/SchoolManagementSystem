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
    public partial class frmSession : Form
    {
        SessionManager aSessionManager = new SessionManager();
        public frmSession()
        {
            InitializeComponent();
        }

        private void loadDatagridview()
        {
            Session aSession = new Session();
            aSession.ActiveStatus = 1;
            aSession.SessionYear = txtSearch.Text;
            DataTable dt = aSessionManager.GetAllSessionData(aSession);
            if (dt == null)
            {
                MessageBox.Show(aSession.Error);
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

            Session aSession = new Session();
            aSession.Id = (int)btn.Tag;
            aSession.ActiveStatus = 0;
            String Message = aSessionManager.DeleteSession(aSession);
            MessageBox.Show(Message);
            resetControls();
            loadDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(groupBox1))
                return;

            Session aSession = new Session();
            aSession.SessionYear = txtSessionYear.Text;
            string message = "";
            if (btnSave.Text == "Save")
            {
                message = aSessionManager.SaveSession(aSession);
            }
            else
            {
                aSession.Id = (int)btnSave.Tag;
                message = aSessionManager.UpdateSession(aSession);
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
            txtSessionYear.Text = dgvData.SelectedRows[0].Cells["colSessionYear"].Value.ToString();
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
