using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Reports;
using SchoolManagementSystem.Class;
using SchoolManagementSystem.Dataset;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmTeacherAttendanceReport : Form
    {
        public frmTeacherAttendanceReport()
        {
            InitializeComponent();
        }

        private void btnAttendanceSearch_Click(object sender, EventArgs e)
        {
            Class.AttendanceReport attendanceReportClass = new Class.AttendanceReport();
            attendanceReportClass.FromDate = DateTime.Parse(dtpFrom.Value.ToShortDateString());
            attendanceReportClass.ToDate = DateTime.Parse(dtpTo.Value.ToShortDateString());
            if (cmbTeacher.SelectedIndex >= 0) attendanceReportClass.PersonId = Convert.ToInt32(cmbTeacher.SelectedValue.ToString());
            if (cmbTeacher.SelectedIndex >= 0) attendanceReportClass.PersonType = 2;
            DataTable dt = attendanceReportClass.SelectTeacherAttendance().Tables[0];
            //DataTable dt = ds.Tables[0];
            Reports.TeacherAttendanceReport teacherAttendanceReport = new Reports.TeacherAttendanceReport();
            teacherAttendanceReport.Database.Tables["dtTeacherAttendance"].SetDataSource(dt);
            crvAttendanceReport.ReportSource = null;
            crvAttendanceReport.ReportSource = teacherAttendanceReport;
        }

        private void frmAttendanceReport_Load(object sender, EventArgs e)
        {
            //Load Teacher
            Class.Teacher aTeacher = new Class.Teacher();
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
            cmbTeacher.SelectedIndex = -1;
        }
    }
}
