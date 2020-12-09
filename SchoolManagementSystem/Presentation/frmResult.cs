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
    public partial class frmResult : Form
    {
        ResultManager aResultManager = new ResultManager();
        public frmResult()
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

            ResultMaster aResultMaster = new ResultMaster();
            aResultMaster.ClassExamId = Convert.ToInt32(cmbClassWiseExam.SelectedValue.ToString());
            aResultMaster.ClassSubjectId = Convert.ToInt32(cmbClassWiseSubject.SelectedValue.ToString());
            aResultMaster.TotalMarks = Convert.ToInt32(txtMarks.Text.ToString());
            //aResultMaster.ExamDate = DateTime.Parse(dtpExamDate.Value.ToShortDateString());
            aResultMaster.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString());

            if (aResultMaster.CheckIfResultExist() > 0)
            {
                //string s = "You already submitted result of Class: ({0}) Section: ({1}) Exam :({2}) for Year :({3})";
                string s = "You already submitted result of Class: ({0}) Section: ({1}) Exam :({2}) for Session :({3})";
                //string msg = string.Format(s, cmbClass.Text, cmbClassWiseSection.Text, cmbClassWiseExam.Text, DateTime.Parse(dtpExamDate.Value.ToString()).Year.ToString());
                string msg = string.Format(s, cmbClass.Text, cmbClassWiseSection.Text, cmbClassWiseExam.Text, cmbSession.Text);
                MessageBox.Show(msg);
                return;
            }

            ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
            aClassSectionWiseStudent.ActiveStatus = 1;
            aClassSectionWiseStudent.ClassSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString()); 
            
            DataTable dt = aClassSectionWiseStudent.SelectBySection().Tables[0];

            if (dt == null)
            {
                MessageBox.Show(aClassSectionWiseStudent.Error);
                return;
            }
            dgvResultEntry.DataSource = dt;
        }

        private void btmSubmit_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(this))
                return;
            //if (Utilities.EmptyDataGridViewRequiredCell(dgvResultEntry))
            //    return;
            ResultMaster aResultMaster = new ResultMaster();
            aResultMaster.ClassExamId = Convert.ToInt32(cmbClassWiseExam.SelectedValue.ToString());
            aResultMaster.ClassSubjectId = Convert.ToInt32(cmbClassWiseSubject.SelectedValue.ToString());
            aResultMaster.TotalMarks = Convert.ToInt32(txtMarks.Text.ToString());
            //aResultMaster.ExamDate = DateTime.Parse(dtpExamDate.Value.ToShortDateString());
            aResultMaster.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString());
            aResultMaster.Id = aResultMaster.Insert();
            if (aResultMaster.Id > 0)
            {
                ResultChild aResultChild;
                foreach (DataGridViewRow row in dgvResultEntry.Rows)
                {
                    aResultChild = new ResultChild();
                    aResultChild.ClassSectionStudentId = Convert.ToInt32(row.Cells["colid"].Value.ToString());
                    aResultChild.Marks = Convert.ToInt32(row.Cells["colMarks"].Value.ToString());
                    aResultChild.ResultMasterId = aResultMaster.Id;
                    bool success = aResultChild.Insert();
                    if (!success)
                    {
                        File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Marks Entry (Insert)" + Environment.NewLine);
                        File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aResultChild.Error + Environment.NewLine);
                        MessageBox.Show(aResultChild.Error);
                    }
                }

                Utilities.EmptyAllControls(this);
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Result Submission (Insert)" + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aResultMaster.Error + Environment.NewLine);
                MessageBox.Show( aResultMaster.Error);
            }
            
        }

        private void dgvResultEntry_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Console.WriteLine("row post paint");
            //this.dgvResultEntry.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
            this.dgvResultEntry.Rows[e.RowIndex].Cells["colSL"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvResultEntry_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvResultEntry.CurrentCell.Style.BackColor = Color.White;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //int i = 0;
            //int j = 0;

            //for (i = 0; i <= dgvResultEntry.RowCount - 1; i++)
            //{
            //    for (j = 0; j <= dgvResultEntry.ColumnCount - 1; j++)
            //    {
            //        DataGridViewCell cell = dgvResultEntry[j, i];
            //        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
            //    }
            //}

            //xlWorkBook.SaveAs("D:\\csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            //MessageBox.Show("Excel file created , you can find the file D:\\csharp.net-informations.xls");
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
