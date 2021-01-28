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
            string aclass = "Class";
            if (!tvClassSection.Nodes.ContainsKey(aclass))
            {
                ClassSectionWiseTeacher aClassWiseSection = new ClassSectionWiseTeacher();
                aClassWiseSection.ActiveStatus = 1;
                DataTable dtClassWiseSection = aClassWiseSection.SelectNotAssignedClasses().Tables[0];
                if (dtClassWiseSection == null)
                {
                    MessageBox.Show(aClassWiseSection.Error);
                    return;
                }
                tvClassSection.Nodes.Add(aclass, "Class");
                //tvClassSection.ExpandAll();
                foreach (DataRow row in dtClassWiseSection.Rows)
                {
                    string id = row["ID"].ToString();
                    string section = row["SECTION_NAME"].ToString();
                    string className = row["CLASS_NAME"].ToString();
                    if (!tvClassSection.Nodes[aclass].Nodes.ContainsKey(className))
                    {
                        tvClassSection.Nodes[aclass].Nodes.Add(className, className);
                        //tvClassSection.Nodes[aclass].Nodes[className].ExpandAll();
                    }

                    tvClassSection.Nodes[aclass].Nodes[className].Nodes.Add(id, section);

                }
            }
            tvClassSection.ExpandAll();
        }

        private void resetControls()
        {
            Utilities.EmptyAllControls(tabBasicInformation);
            
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
            if(cmbTeacher.Items.Count<=0)
            {
                Teacher aTeacher = new Teacher();
                aTeacher.ActiveStatus = 1;
                DataSet dsTeacher = aTeacher.Select();
                if (dsTeacher == null)
                {
                    MessageBox.Show(aTeacher.Error);
                    return;
                }
                cmbTeacher.DataSource = dsTeacher.Tables[0];
                cmbTeacher.DisplayMember = "UNIQUE_TEACHER_NAME";
                cmbTeacher.ValueMember = "ID";
            }
            cmbTeacher.SelectedIndex = -1;

            loadClassSectionTree();
        }

        private void btnSaveTeacherClassSection_Click(object sender, EventArgs e)
        {

            //if (Utilities.EmptyRequiredField(tabBasicInformation))
            //    return;
            ClassSectionWiseTeacher aClassSectionWiseTeacher = new ClassSectionWiseTeacher();
            if (cmbTeacher.SelectedIndex < 0) return;
            aClassSectionWiseTeacher.TeacherId = Convert.ToInt32(cmbTeacher.SelectedValue.ToString());
            //aClassSectionWiseTeacher.ClassSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString());
            aClassSectionWiseTeacher.ActiveStatus = 1;

            string message = "No class Selected";
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
            tvClassSection.Nodes.Clear();
            loadClassSectionTree();
            loadTeacherClassSectionDatagridview();
        }

        private void btnTeacherClassInfoSearch_TextChanged(object sender, EventArgs e)
        {
            dtTeacherClassInfo.DefaultView.RowFilter = string.Format("TEACHER_NAME LIKE '%{0}%'", txtTeacherClassInfoSearch.Text);
        }

        private void btnTeacherClassInfoSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClassWiseSection aClassWiseSection = new ClassWiseSection();
            //aClassWiseSection.ActiveStatus = 1;
            //try
            //{
            //    aClassWiseSection.ClassId = Convert.ToInt32(cmbTeacher.SelectedValue.ToString());
            //}
            //catch (Exception)
            //{
            //    return;
            //}
            //DataSet dsClassWiseSection = aClassWiseSection.SelectByClassId();
            //if (dsClassWiseSection == null)
            //{
            //    MessageBox.Show(aClassWiseSection.Error);
            //    return;
            //}
            //cmbClassWiseSection.DataSource = dsClassWiseSection.Tables[0];
            //cmbClassWiseSection.DisplayMember = "SECTION_NAME";
            //cmbClassWiseSection.ValueMember = "ID";
            //cmbClassWiseSection.SelectedIndex = -1;
        }

        private void dgvTeacherClassInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTeacherClassInfo.Columns["cswtColAction"].Index) return;
                MessageBox.Show(dgvTeacherClassInfo.Rows[e.RowIndex].Cells["cswtColID"].Value.ToString());
            ClassSectionWiseTeacher aClassSectionWiseTeacher = new ClassSectionWiseTeacher();
            aClassSectionWiseTeacher.Id = Convert.ToInt32(dgvTeacherClassInfo.Rows[e.RowIndex].Cells["cswtColID"].Value.ToString());
            aClassSectionWiseTeacher.ActiveStatus = 0;
            
            String Message = aClassSectionWiseTeacherManager.DeleteClassSectionWiseTeacher(aClassSectionWiseTeacher);
            MessageBox.Show(Message);
            loadTeacherClassSectionDatagridview();
            tvClassSection.Nodes.Clear();
            loadClassSectionTree();
        }
    }
}
