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

namespace SchoolManagementSystem.Presentation
{
    public partial class frmResult : Form
    {
        
        public frmResult()
        {
            InitializeComponent();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            Console.WriteLine(cmbClass.SelectedIndex);
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
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex < 0) return;
            ClassWiseSection aClassWiseSection = new ClassWiseSection();
            aClassWiseSection.ActiveStatus = 1;
            aClassWiseSection.ClassId = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            DataSet dsClassWiseSection = aClassWiseSection.SelectByClassId();
            if (dsClassWiseSection == null)
            {
                MessageBox.Show(aClassWiseSection.Error);
                return;
            }
            cmbClassWiseSection.DataSource = dsClassWiseSection.Tables[0];
            cmbClassWiseSection.DisplayMember = "SECTION_NAME";
            cmbClassWiseSection.ValueMember = "ID";
            cmbClassWiseSection.SelectedIndex = -1;


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
            ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
            aClassSectionWiseStudent.ActiveStatus = 1;
            aClassSectionWiseStudent.ClassSectionId = Convert.ToInt32(cmbClassWiseSection.SelectedValue.ToString()); ;
            
            DataTable dt = aClassSectionWiseStudent.SelectBySection().Tables[0];

            dt.Columns.Add("SL", typeof(int)).AutoIncrement=true;
            dt.Columns["SL"].SetOrdinal(0);
            dt.Columns["SL"].AutoIncrementSeed = 1;
            dt.Columns["SL"].AutoIncrementStep = 1;

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine("row" +item[0]);
            }

            if (dt == null)
            {
                MessageBox.Show(aClassSectionWiseStudent.Error);
                return;
            }
            dgvResultEntry.DataSource = dt;

        }

        private void btmSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
