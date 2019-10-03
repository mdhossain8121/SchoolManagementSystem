using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmClassWiseSubjectList : Form
    {
        ErrorProvider ep = new ErrorProvider();
        public frmClassWiseSubjectList()
        {
            InitializeComponent();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkSubject = (sender as CheckBox);

            Class.ClassWiseSubject cws = new Class.ClassWiseSubject();
            if(cmbClass.SelectedIndex<0)
            {
                ep.SetError(cmbClass, "Please select a class");
                chkSubject.Checked = false;
                return;
            }
            cws.ClassId = (int)cmbClass.SelectedValue;
            cws.SubjectId = (int)chkSubject.Tag;

            if (cws.Insert())
            {
                tssMessage.Text = "Action completed.........";
            }
            else
            {
                tssMessage.Text = cws.Error;
            }
        }

        private void frmClassWiseSubjectList_Load(object sender, EventArgs e)
        {
            // Load Class
            Class.ClassSetup cs = new Class.ClassSetup();
            DataSet dsClass = cs.Select();
            if(dsClass == null)
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
            Class.Subject subject = new Class.Subject();
            DataTable dt = subject.Select().Tables[0];
            if (dt == null)
            {
                MessageBox.Show(subject.Error);
                return;
            }
            foreach(DataRow dr in dt.Rows)
            {
                cb = new CheckBox();
                cb.Tag = dr["ID"];
                cb.Name = "SUBJECT_ID_" + dr["ID"].ToString();
                cb.Text = dr["SUBJECT_NAME"].ToString();
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
                Class.ClassWiseSubject cws = new Class.ClassWiseSubject();
                cws.ClassId = (int)cmbClass.SelectedValue;
                DataTable dt = cws.SelectBySubjectId().Tables[0];
                if (dt == null)
                {
                    MessageBox.Show(cws.Error);
                    return;
                }
                foreach (DataRow dr in dt.Rows)
                {
                    CheckBox cb = (CheckBox)flowLayoutPanel.Controls.Find("SUBJECT_ID_" + dr["SUBJECT_ID"], true)[0];
                    cb.Checked = true;
                }
            }
        }
    }
}
