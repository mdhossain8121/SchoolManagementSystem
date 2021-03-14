using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SchoolManagementSystem.Class;
using SchoolManagementSystem.ClassManager;
using System.IO;
using System.Runtime.InteropServices;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmMultipleStudents : Form
    {
        ClassSectionWiseStudentManager aClassSectionWiseStudentManager = new ClassSectionWiseStudentManager();
        public frmMultipleStudents()
        {
            InitializeComponent();

            ClassSetup cs = new ClassSetup();
            DataSet dsClass = cs.Select();
            if (dsClass == null)
            {
                MessageBox.Show(cs.Error);
                return;
            }
            cmbClass.BindingContext = new BindingContext();
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

        public void btnImportOld()
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string file = "";   //variable for the Excel File Location
            DataTable dt = new DataTable();   //container for our excel data
            DataRow row;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();  // Show the dialog.
            if (result == DialogResult.OK)   // Check if Result == "OK".
            {
                file = openFileDialog1.FileName; //get the filename with the location of the file
                try

                {
                    //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file

                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);

                    Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                    Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;


                    int rowCount = excelRange.Rows.Count;  //get row count of excel data

                    int colCount = excelRange.Columns.Count; // get column count of excel data

                    //Get the first Column of excel file which is the Column Name         

                    dt.Columns.Add("ROLL");
                    dt.Columns.Add("STUDENT_NAME");
                    dt.Columns.Add("MOBILE");
                    dt.Columns.Add("ADDRESS");
                    dt.Columns.Add("START_DATE");

                    //Get Row Data of Excel              
                    int rowCounter;  //This variable is used for row index number
                    for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
                    {
                        row = dt.NewRow();  //assign new row to DataTable
                        rowCounter = 0;
                        for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                        {
                            //check if cell is empty
                            if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            {
                                row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                                Console.WriteLine(excelRange.Cells[i, j].Value2.ToString());
                            }
                            else
                            {
                                row[i] = "";
                            }

                            rowCounter++;
                        }
                        dt.Rows.Add(row); //add row to DataTable
                    }

                    dgvMultipleStudentsEntry.DataSource = dt; //assign DataTable as Datasource for DataGridview

                    dgvMultipleStudentsEntry.Columns[0].HeaderText = "Roll";
                    dgvMultipleStudentsEntry.Columns[1].HeaderText = "Student Name";
                    dgvMultipleStudentsEntry.Columns[2].HeaderText = "Mobile";
                    dgvMultipleStudentsEntry.Columns[3].HeaderText = "Address";
                    dgvMultipleStudentsEntry.Columns[4].HeaderText = "Start Date";
                    

                    //Close and Clean excel process
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(excelRange);
                    Marshal.ReleaseComObject(excelWorksheet);
                    excelWorkbook.Close();
                    Marshal.ReleaseComObject(excelWorkbook);

                    //quit 
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            //OpenFileDialog ofd = new OpenFileDialog();
            //DataTable table = new DataTable();

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    string path = System.IO.Path.GetFullPath(ofd.FileName);

            //    string querry = "SELECT * FROM [sheet$]";

            //    OleDbConnection conn = new OleDbConnection();

            //    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = '" + path + "'" + @";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;ImportMixedTypes=Text;TypeGuessRows=0""";

            //    OleDbDataAdapter fag = new OleDbDataAdapter(querry, conn);

            //    fag.AcceptChangesDuringFill = false;
            //    fag.Fill(table);
            //    dgvMultipleStudentsEntry.DataSource = table;
            //}
            //else
            //{
            //    ofd.Dispose();
            //}
        }

        private void resetClassInfoControls()
        {
            Utilities.EmptyAllControls(this);
            //Utilities.ResetComboBox(cmbClassWiseSection);
        }

        private void btnMultipleStudentsSave_Click(object sender, EventArgs e)
        {
            if (Utilities.EmptyRequiredField(this))
                return;
            string message = "Data not saved";
            foreach (DataGridViewRow row in dgvMultipleStudentsEntry.Rows)
            {
                Student aStudent = new Student();
                aStudent.StudentName = row.Cells["STUDENT_NAME"].Value.ToString();
                aStudent.Image = FileImage.ImageToByte(SchoolManagementSystem.Properties.Resources.reading);
                aStudent.Mobile = row.Cells["MOBILE"].Value.ToString();
                aStudent.Address = row.Cells["ADDRESS"].Value.ToString();
                aStudent.StartDate = DateTime.Parse(row.Cells["START_DATE"].Value.ToString());
                bool success = aStudent.Insert();
                if (success)
                {
                    ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
                    aClassSectionWiseStudent.StudentId = Convert.ToInt32(aStudent.maxId());
                    aClassSectionWiseStudent.ClassSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString());
                    aClassSectionWiseStudent.Roll = Convert.ToInt32(row.Cells["ROLL"].Value.ToString());
                    aClassSectionWiseStudent.Year = Convert.ToInt32(DateTime.Now.Year.ToString());
                    aClassSectionWiseStudent.ActiveStatus = 1;
                    message = aClassSectionWiseStudentManager.SaveClassSectionWiseStudent(aClassSectionWiseStudent);
                }
                else
                {
                    File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Multiple Students Entry (Insert)" + Environment.NewLine);
                    File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aStudent.Error + Environment.NewLine);
                    MessageBox.Show(aStudent.Error);
                }
            }
            MessageBox.Show(message);
            resetClassInfoControls();
        }

        public void loadAllSection()
        {
            cmbClassWiseSection.DataSource = null;
            cmbClassWiseSection.Items.Clear();
            cmbClassWiseSection.IntegralHeight = false;
            ClassWiseSection aClassWiseSection = new ClassWiseSection();
            aClassWiseSection.ActiveStatus = 1;
            try
            {
                aClassWiseSection.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
                aClassWiseSection.SessionId = Convert.ToInt32(cmbSession.SelectedValue.ToString());
            }
            catch (Exception)
            {
                return;
            }
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

        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadAllSection();
        }
    }
}
