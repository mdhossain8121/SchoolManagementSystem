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

namespace SchoolManagementSystem.Presentation
{
    public partial class frmResultReport : Form
    {
        ResultManager aResultManager = new ResultManager();
        public frmResultReport()
        {
            InitializeComponent();
        }

        private void frmResult_Load(object sender, EventArgs e)
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

            // Load Session
            Class.Session s = new Class.Session();
            s.ActiveStatus = 1;
            DataSet dsSession = s.Select();
            if (dsSession == null)
            {
                MessageBox.Show(s.Error);
                return;
            }
            cmbSession.DataSource = dsSession.Tables[0];
            cmbSession.DisplayMember = "SESSION_YEAR";
            cmbSession.ValueMember = "ID";
            cmbSession.SelectedIndex = -1;
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClassWiseSubject aClassWiseSubject = new ClassWiseSubject();
            aClassWiseSubject.ActiveStatus = 1;
            aClassWiseSubject.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            DataSet dsClassWiseSubject = aClassWiseSubject.SelectByClassId();
            if (dsClassWiseSubject == null)
            {
                MessageBox.Show(aClassWiseSubject.Error);
                return;
            }
            cmbClassWiseSubject.DataSource = dsClassWiseSubject.Tables[0];
            cmbClassWiseSubject.DisplayMember = "SUBJECT_NAME";
            cmbClassWiseSubject.ValueMember = "ID";
            cmbClassWiseSubject.SelectedIndex = -1;


            ClassWiseExam aClassWiseExam = new ClassWiseExam();
            aClassWiseExam.ActiveStatus = 1;
            aClassWiseExam.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            DataSet dsClassWiseExam = aClassWiseExam.SelectByClassId();
            if (dsClassWiseExam == null)
            {
                MessageBox.Show(aClassWiseExam.Error);
                return;
            }
            cmbClassWiseExam.DataSource = dsClassWiseExam.Tables[0];
            cmbClassWiseExam.DisplayMember = "EXAM_NAME";
            cmbClassWiseExam.ValueMember = "ID";
            cmbClassWiseExam.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(groupBox1))
                return;

            // CHECK IF RESULT ALREADY SUBMITTED
            ResultReport aResultReport = new ResultReport();
            //aResultReport.ClassId = Convert.ToInt32(cmbClassWiseExam.SelectedValue.ToString());
            aResultReport.ClassWiseSubjectId = Convert.ToInt32(cmbClassWiseSubject.SelectedValue.ToString());
            aResultReport.ClassWiseSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString());
            aResultReport.ClassWiseExamId = Convert.ToInt32(cmbClassWiseExam.SelectedValue.ToString());
            //aResultMaster.ExamDate = DateTime.Parse(dtpExamDate.Value.ToShortDateString());
            //aResultReport.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString()); 
            
            DataTable dt = aResultReport.Select().Tables[0];

            Reports.ResultReport resultReport = new Reports.ResultReport();
            resultReport.Database.Tables["dtResult"].SetDataSource(dt);
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
            ClassWiseSection aClassWiseSection = new ClassWiseSection();
            aClassWiseSection.ActiveStatus = 1;
            aClassWiseSection.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            aClassWiseSection.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString());
            DataSet dsClassWiseSection = aClassWiseSection.SelectByClassSessionId();
            if (dsClassWiseSection == null)
            {
                MessageBox.Show(aClassWiseSection.Error);
                return;
            }
            cmbClassWiseSection.DataSource = dsClassWiseSection.Tables[0];
            cmbClassWiseSection.DisplayMember = "SECTION_NAME";
            cmbClassWiseSection.ValueMember = "ID";
            cmbClassWiseSection.SelectedIndex = -1;
        }
    }
}
