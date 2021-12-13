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
    public partial class DashBoard : Form
    {
        Student aStudent = new Student();
        Teacher aTeacher = new Teacher();
        ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
        public DashBoard()
        {
            InitializeComponent();
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            Console.WriteLine(aStudent.countStudent());
            
        }

        private void DashBoard_Enter(object sender, EventArgs e)
        {
            lblTotalStudent.Text = aStudent.countStudent().ToString();
            lblTotalTeacher.Text = aTeacher.countTeacher().ToString();
            loadDashBoardDatagridview();
        }

        private void loadDashBoardDatagridview()
        {
            ClassSectionWiseStudent aClassSectionWiseStudent = new ClassSectionWiseStudent();
            aClassSectionWiseStudent.Year = Convert.ToInt32(DateTime.Now.Year.ToString()); ;
            DataTable dt = aClassSectionWiseStudent.CurrentYearStudentSummary().Tables[0];
            if (dt == null)
            {
                MessageBox.Show(aClassSectionWiseStudent.Error);
                return;
            }
            try
            {
                dgvDashboardSummary.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch = " + ex.Message);
            }
        }
    }
}
