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

namespace SchoolManagementSystem.Presentation.StudentForms
{
    public partial class frmStudentAttendance : Form
    {
        public frmStudentAttendance()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(gpAttendance))
                return;

            Attendance studentAttendance = new Attendance();
            studentAttendance.FromDate = DateTime.Parse(dtpFrom.Value.ToShortDateString());
            studentAttendance.ToDate = DateTime.Parse(dtpTo.Value.ToShortDateString());
            //aClassSectionWiseStudent.ClassSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString());

            DataTable dt = studentAttendance.Select().Tables[0];

            if (dt == null)
            {
                MessageBox.Show(studentAttendance.Error);
                return;
            }
            dgvStudentAttendance.DataSource = dt;
        }

        private void dgvStudentAttendance_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvStudentAttendance.Rows[e.RowIndex].Cells["colSL"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
