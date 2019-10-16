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
        ClassSectionWiseTeacherManager aClassSectionWiseTeacherManager = new ClassSectionWiseTeacherManager();

        DataTable dtTeacherClassInfo;
        public frmTeacher()
        {
            InitializeComponent();
            dtpJoiningDate.Value = DateTime.Now;
            dtpEndDate.MinDate = dtpJoiningDate.Value;
            dtpEndDate.MaxDate = DateTime.Now;
            loadClassSectionTree();
            loadTeacherClassSectionDatagridview();
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


        private void loadTeacherClassSectionDatagridview()
        {
            ClassSectionWiseTeacher aClassSectionWiseTeacher = new ClassSectionWiseTeacher();
            aClassSectionWiseTeacher.ActiveStatus = 1;
            dtTeacherClassInfo = aClassSectionWiseTeacherManager.GetAllClassSectionWiseTeacherData(aClassSectionWiseTeacher);
            if (dtTeacherClassInfo == null)
            {
                MessageBox.Show(aClassSectionWiseTeacher.Error);
                return;
            }
            dgvTeacherClassInfo.DataSource = dtTeacherClassInfo;
        }


        private void loadClassSectionTree()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.ActiveStatus = 1;
            DataSet dsStudent = aTeacher.Select();
            if (dsStudent == null)
            {
                MessageBox.Show(aTeacher.Error);
                return;
            }
            cmbTeacher.DataSource = dsStudent.Tables[0];
            cmbTeacher.DisplayMember = "TEACHER_NAME";
            cmbTeacher.ValueMember = "ID";
            cmbTeacher.SelectedIndex = -1;

            string aclass = "Class";
            ClassWiseSection aClassWiseSection = new ClassWiseSection();
            aClassWiseSection.ActiveStatus = 1;
            DataTable dtClassWiseSection = aClassWiseSection.Select().Tables[0];
            if (dtClassWiseSection == null)
            {
                MessageBox.Show(aClassWiseSection.Error);
                return;
            }
            tvClassSection.Nodes.Add(aclass, "Class");
            tvClassSection.ExpandAll();
            foreach (DataRow row in dtClassWiseSection.Rows)
            {
                string id = row["ID"].ToString();
                string section = row["SECTION_NAME"].ToString();
                string className = row["CLASS_NAME"].ToString();
                if (!tvClassSection.Nodes[aclass].Nodes.ContainsKey(className))
                {
                    tvClassSection.Nodes[aclass].Nodes.Add(className, className);
                    tvClassSection.Nodes[aclass].Nodes[className].ExpandAll();
                }
                    
                tvClassSection.Nodes[aclass].Nodes[className].Nodes.Add(id, section);
                
            }         
        }

        private void uncheckTreeNode(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    uncheckTreeNode(trNode.Nodes, isCheck);
            }
        }

        private void resetControls()
        {
            Utilities.EmptyAllControls(tabBasicInformation);
            uncheckTreeNode(tvClassSection.Nodes, false);
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

        private void tabAssignClassSection_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveTeacherClassSection_Click(object sender, EventArgs e)
        {

            //if (Utilities.EmptyRequiredField(tabBasicInformation))
            //    return;
            ClassSectionWiseTeacher aClassSectionWiseTeacher = new ClassSectionWiseTeacher();
            aClassSectionWiseTeacher.TeacherId = Convert.ToInt32(cmbTeacher.SelectedValue.ToString());
            //aClassSectionWiseTeacher.ClassSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString());
            aClassSectionWiseTeacher.ActiveStatus = 1;

            string message = "";
            if (btnSaveTeacherClassSection.Text == "Confirm")
            {
                foreach (TreeNode prNode in tvClassSection.Nodes["Class"].Nodes)
                {
                    foreach (TreeNode chdNode in prNode.Nodes)
                    {
                        if (chdNode.Checked)
                        {
                            aClassSectionWiseTeacher.ClassSectionId = Convert.ToInt32(chdNode.Name);
                            message = aClassSectionWiseTeacherManager.SaveClassSectionWiseTeacher(aClassSectionWiseTeacher);
                        }
                            
                    }
                }
                
            }
            else
            {
                aClassSectionWiseTeacher.Id = (int)btnSaveTeacherClassSection.Tag;
                message = aClassSectionWiseTeacherManager.UpdateClassSectionWiseTeacher(aClassSectionWiseTeacher);
            }

            MessageBox.Show(message);
            ////resetClassInfoControls();
            ////loadClassInfoDatagridview();
        }

        private void btnTeacherClassInfoSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTeacherClassInfoSearch_Click(object sender, EventArgs e)
        {
            dtTeacherClassInfo.DefaultView.RowFilter = string.Format("TEACHER_NAME LIKE '%{0}%'", txtTeacherClassInfoSearch.Text);
        }
    }
}
