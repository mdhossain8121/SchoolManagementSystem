using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmClassWiseExam : Form
    {
        ErrorProvider ep = new ErrorProvider();
        public frmClassWiseExam()
        {
            InitializeComponent();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);

            Class.ClassWiseExam cws = new Class.ClassWiseExam();
            if (cmbClass.SelectedIndex < 0)
            {
                ep.SetError(cmbClass, "Please select a class");
                cb.Checked = false;
                return;
            }
            cws.ClassId = (int)cmbClass.SelectedValue;
            cws.ExamId = (int)cb.Tag;

            if (cws.Insert())
            {
                tssMessage.Text = "Action completed.........";
            }
            else
            {
                tssMessage.Text = cws.Error;
            }
        }

        private void frmClassWiseExam_Load(object sender, EventArgs e)
        {
            // Load Class
            Class.ClassSetup cs = new Class.ClassSetup();
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

            //---------------- Load subject --------------//
            CheckBox cb;
            Class.Exam exam = new Class.Exam();
            exam.ActiveStatus = 1;
            DataTable dt = exam.Select().Tables[0];
            if (dt == null)
            {
                MessageBox.Show(exam.Error);
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                cb = new CheckBox();
                cb.Tag = dr["ID"];
                cb.Name = "EXAM_ID_" + dr["ID"].ToString();
                cb.Text = dr["EXAM_NAME"].ToString();
                cb.Click += new EventHandler(check_CheckedChanged);
                flowLayoutPanel.Controls.Add(cb);
            }
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ep.Clear();
            Class.Utilities.EmptyAllControls(flowLayoutPanel);
            if (cmbClass.SelectedIndex > -1)
            {
                Class.ClassWiseExam cws = new Class.ClassWiseExam();
                cws.ClassId = (int)cmbClass.SelectedValue;
                DataTable dt = cws.SelectByClassId().Tables[0];
                if (dt == null)
                {
                    MessageBox.Show(cws.Error);
                    return;
                }
                foreach (DataRow dr in dt.Rows)
                {
                    CheckBox cb = (CheckBox)flowLayoutPanel.Controls.Find("EXAM_ID_" + dr["EXAM_ID"], true)[0];
                    cb.Checked = true;
                }
            }
        }
    }
}
