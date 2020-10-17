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
    public partial class frmAttendanceReport : Form
    {
        public frmAttendanceReport()
        {
            InitializeComponent();
        }

        private void btnAttendanceSearch_Click(object sender, EventArgs e)
        {
            Class.AttendanceReport attendanceReportClass = new Class.AttendanceReport();
            attendanceReportClass.FromDate = DateTime.Parse(dtpFrom.Value.ToShortDateString());
            attendanceReportClass.ToDate = DateTime.Parse(dtpTo.Value.ToShortDateString());
            if (cmbClass.SelectedIndex >= 0) attendanceReportClass.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            if (cmbSection.SelectedIndex >= 0) attendanceReportClass.SectionId = Convert.ToInt32(cmbSection.SelectedValue.ToString());
            if (cmbStudent.SelectedIndex >= 0) attendanceReportClass.StudentId = Convert.ToInt32(cmbStudent.SelectedValue.ToString());
            DataSet ds = attendanceReportClass.Select();
            DataTable dt = ds.Tables[0];
            Reports.AttendanceReport attendanceReport = new Reports.AttendanceReport();
            attendanceReport.Database.Tables["dtAttendance"].SetDataSource(dt);
            crvAttendanceReport.ReportSource = null;
            crvAttendanceReport.ReportSource = attendanceReport;
        }

        private void frmAttendanceReport_Load(object sender, EventArgs e)
        {
            // Load Class
            Class.ClassSetup cs = new Class.ClassSetup();
            cs.ActiveStatus = 1;
            DataSet dsClass = cs.Select();
            if (dsClass == null)
            {
                MessageBox.Show(cs.Error);
                return;
            }
            cmbClass.DataSource = dsClass.Tables[0];
            cmbClass.DisplayMember = "CLASS_NAME";
            cmbClass.ValueMember = "ID";
            cmbClass.SelectedIndex = -1;

            //Load Section
            Class.Section section = new Class.Section();
            section.ActiveStatus = 1;
            DataSet dsSection = section.Select();
            if (dsSection == null)
            {
                MessageBox.Show(section.Error);
                return;
            }
            cmbSection.DataSource = dsSection.Tables[0];
            cmbSection.DisplayMember = "SECTION_NAME";
            cmbSection.ValueMember = "ID";
            cmbSection.SelectedIndex = -1;

            //Load Section
            Class.Student student = new Class.Student();
            student.ActiveStatus = 1;
            DataSet dsStudent = student.Select();
            if (dsStudent == null)
            {
                MessageBox.Show(student.Error);
                return;
            }
            cmbStudent.DataSource = dsStudent.Tables[0];
            cmbStudent.DisplayMember = "STUDENT_NAME";
            cmbStudent.ValueMember = "ID";
            cmbStudent.SelectedIndex = -1;
        }
    }
}
