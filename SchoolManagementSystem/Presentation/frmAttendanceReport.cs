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
            //attendanceReport.ActiveStatus = 1;
            //aStudent.StudentName = txtSearch.Text;
            DataSet ds = attendanceReportClass.Select();
            DataTable dt = ds.Tables[0];
            Reports.AttendanceReport attendanceReport = new Reports.AttendanceReport();
            attendanceReport.Database.Tables["dtAttendance"].SetDataSource(dt);
            crvAttendanceReport.ReportSource = null;
            crvAttendanceReport.ReportSource = attendanceReport;
        }
    }
}
