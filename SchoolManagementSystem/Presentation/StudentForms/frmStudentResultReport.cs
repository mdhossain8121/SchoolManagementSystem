using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SchoolManagementSystem.Class;
using SchoolManagementSystem.ClassManager;
//using Excel = Microsoft.Office.Interop.Excel;

namespace SchoolManagementSystem.Presentation.StudentForms
{
    public partial class frmStudentResultReport : Form
    {
        ResultManager aResultManager = new ResultManager();
        public frmStudentResultReport()
        {
            InitializeComponent();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            // Load Class
            ResultReport rr = new ResultReport();
            rr.StudentId= UserSession.UserId;
            DataSet dsResultReport = rr.SelectUniqueClass();
            if (dsResultReport == null)
            {
                MessageBox.Show(rr.Error);
                return;
            }
            cmbClass.DataSource = dsResultReport.Tables[0];
            cmbClass.DisplayMember = "CLASS_NAME";
            cmbClass.ValueMember = "CLASS_ID";
            cmbClass.SelectedIndex = -1;

            //cmbSession.DataSource = dsResultReport.Tables[0];
            //cmbSession.DisplayMember = "SESSION_YEAR";
            //cmbSession.ValueMember = "SESSION_ID";
            
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ResultReport rrSession = new ResultReport();
            rrSession.StudentId = UserSession.UserId;
            rrSession.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            DataSet dsResultReportSession = rrSession.SelectUniqueClassWiseSession();
            if (dsResultReportSession == null)
            {
                MessageBox.Show(rrSession.Error);
                return;
            }
            cmbSession.BindingContext = new BindingContext();
            cmbSession.DataSource = dsResultReportSession.Tables[0];
            cmbSession.DisplayMember = "SESSION_YEAR";
            cmbSession.ValueMember = "SESSION_ID";
            cmbSession.SelectedIndex = -1;

            ResultReport rrExam = new ResultReport();
            rrExam.StudentId = UserSession.UserId;
            rrExam.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            DataSet dsResultReportExam = rrExam.SelectUniqueClassWiseExam();
            if (dsResultReportExam == null)
            {
                MessageBox.Show(rrExam.Error);
                return;
            }
            cmbClassWiseExam.BindingContext = new BindingContext();
            cmbClassWiseExam.DataSource = dsResultReportExam.Tables[0];
            cmbClassWiseExam.DisplayMember = "EXAM_NAME";
            cmbClassWiseExam.ValueMember = "EXAM_ID";
            cmbClassWiseExam.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(groupBox1))
                return;

            // CHECK IF RESULT ALREADY SUBMITTED
            ResultReport aResultReport = new ResultReport();
            aResultReport.StudentId = UserSession.UserId;
            aResultReport.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            aResultReport.ClassWiseSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString());
            aResultReport.ClassWiseExamId = Convert.ToInt32(cmbClassWiseExam.SelectedValue.ToString());
            aResultReport.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString());

            DataTable dt = aResultReport.SelectStudentWiseResult().Tables[0];

            Reports.Student.StudentResultReport resultReport = new Reports.Student.StudentResultReport();
            resultReport.Database.Tables["dtStudentResultReport"].SetDataSource(dt);
            crvResultReport.ReportSource = null;
            crvResultReport.ReportSource = resultReport;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex < 0 || cmbSession.SelectedIndex < 0) return;

            ResultReport rr = new ResultReport();
            rr.StudentId = UserSession.UserId;
            rr.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            rr.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString());
            DataSet dsResultReport = rr.SelectUniqueClassSessionWiseSection();
            if (dsResultReport == null)
            {
                MessageBox.Show(rr.Error);
                return;
            }

            cmbClassWiseSection.BindingContext = new BindingContext();
            cmbClassWiseSection.DataSource = dsResultReport.Tables[0];
            cmbClassWiseSection.DisplayMember = "SECTION_NAME";
            cmbClassWiseSection.ValueMember = "SECTION_ID";
            cmbClassWiseSection.SelectedIndex = -1;
        }
    }
}
