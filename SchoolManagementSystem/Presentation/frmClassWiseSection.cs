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
    public partial class frmClassWiseSection : Form
    {
        ErrorProvider ep = new ErrorProvider();
        public frmClassWiseSection()
        {
            InitializeComponent();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);

            Class.ClassWiseSection cws = new Class.ClassWiseSection();
            if (cmbClass.SelectedIndex < 0)
            {
                ep.SetError(cmbClass, "Please select a class");
                cb.Checked = false;
                return;
            }

            if (cmbSession.SelectedIndex < 0)
            {
                ep.SetError(cmbSession, "Please select a session");
                cb.Checked = false;
                return;
            }
            cws.ClassId = (int)cmbClass.SelectedValue;
            cws.SessionId = (int)cmbSession.SelectedValue;
            cws.SectionId = (int)cb.Tag;

            if (cws.Insert())
            {
                tssMessage.Text = "Saved.........";
            }
            else
            {
                tssMessage.Text = cws.Error;
            }
        }

        private void frmClassWiseSection_Load(object sender, EventArgs e)
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

            //---------------- Load subject --------------//
            CheckBox cb;
            Class.Section section = new Class.Section();
            section.ActiveStatus = 1;
            DataTable dt = section.Select().Tables[0];
            if (dt == null)
            {
                MessageBox.Show(section.Error);
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                cb = new CheckBox();
                cb.Tag = dr["ID"];
                cb.Name = "SECTION_ID_" + dr["ID"].ToString();
                cb.Text = dr["SECTION_NAME"].ToString();
                cb.Click += new EventHandler(check_CheckedChanged);
                flowLayoutPanel.Controls.Add(cb);
            }
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Class.Utilities.EmptyAllControls(flowLayoutPanel);
            if (cmbClass.SelectedIndex > -1 && cmbSession.SelectedIndex > -1)
            {
                Class.ClassWiseSection cws = new Class.ClassWiseSection();
                cws.ClassId = (int)cmbClass.SelectedValue;
                cws.SessionId = (int)cmbSession.SelectedValue;
                DataTable dt = cws.SelectByClassSessionId().Tables[0];
                if (dt == null)
                {
                    MessageBox.Show(cws.Error);
                    return;
                }
                foreach (DataRow dr in dt.Rows)
                {
                    CheckBox cb = (CheckBox)flowLayoutPanel.Controls.Find("SECTION_ID_" + dr["SECTION_ID"], true)[0];
                    cb.Checked = true;
                }
            }
        }
    }
}
