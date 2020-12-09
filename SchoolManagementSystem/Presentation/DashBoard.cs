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
        }
    }
}
