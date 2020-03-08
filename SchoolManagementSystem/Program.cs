using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Presentation.StudentForms;
using SchoolManagementSystem.Presentation;

namespace SchoolManagementSystem
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmStudentMenu());
            //Application.Run(new frmHome());
            Application.Run(new frmLogin());
        }
    }
}
