using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Presentation;
using MatchingAnsi;

namespace SchoolManagementSystem
{
    public partial class frmHome : Form
    {
        DashBoard dashBoard = new DashBoard();
        frmClass cst = new frmClass();
        frmSection section = new frmSection();
        frmExam exam = new frmExam();
        frmSession session = new frmSession();
        frmRole role = new frmRole();
        frmUser user = new frmUser();
        frmSubject subject = new frmSubject();
        frmClassWiseSubjectList cwsl = new frmClassWiseSubjectList();
        frmClassWiseSection cws = new frmClassWiseSection();
        frmClassWiseExam cwe = new frmClassWiseExam();
        frmAttendance attendance = new frmAttendance();
        frmTeacher teacher = new frmTeacher();
        frmStudent student = new frmStudent();
        frmResult result = new frmResult();
        frmDatabase database = new frmDatabase();
        frmAttendanceReport attendanceReport = new frmAttendanceReport();
        Form1 matchingAnsi = new Form1();
        frmFingerRegister frmFingerRegister = new frmFingerRegister();
        frmLogin login = new frmLogin();
        

        public frmHome()
        {
            InitializeComponent();
            //Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }


        private void menuClick(Form frm)
        {
            //if (frm.IsDisposed)
            //    frm = new Form();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cst.IsDisposed)
                cst = new frmClass();
            menuClick(cst);
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (role.IsDisposed)
                role = new frmRole();
            menuClick(role);
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (subject.IsDisposed)
                subject = new frmSubject();
            menuClick(subject);
        }

        private void classWiseSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cwsl.IsDisposed)
                cwsl = new frmClassWiseSubjectList();
            menuClick(cwsl);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.IsDisposed)
                user = new frmUser();
            menuClick(user);
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (section.IsDisposed)
                section = new frmSection();
            menuClick(section);
        }

        private void classWiseSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cws.IsDisposed)
                cws = new frmClassWiseSection();
            menuClick(cws);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (attendance.IsDisposed)
                attendance = new frmAttendance();
            menuClick(attendance);
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (teacher.IsDisposed)
                teacher = new frmTeacher();
            menuClick(teacher);
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (student.IsDisposed)
                student = new frmStudent();
            menuClick(student);
        }

        private void dBBackupRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database.IsDisposed)
                database = new frmDatabase();
            menuClick(database);
        }

        private void fingerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmFingerRegister.IsDisposed)
                frmFingerRegister = new frmFingerRegister();
            menuClick(frmFingerRegister);


            //if (matchingAnsi.IsDisposed)
            //    matchingAnsi = new Form1();
            //menuClick(matchingAnsi);
        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exam.IsDisposed)
                exam = new frmExam();
            menuClick(exam);
        }

        private void classWiseExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cwe.IsDisposed)
                cwe = new frmClassWiseExam();
            menuClick(cwe);
        }

        private void resultEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(result.IsDisposed)
                result = new frmResult();
            menuClick(result);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            dashBoard = new DashBoard();
            
            menuClick(dashBoard);
            //dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Dock = DockStyle.Fill;

        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session.IsDisposed)
                session = new frmSession();
            menuClick(session);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (attendanceReport.IsDisposed)
                attendanceReport = new frmAttendanceReport();
            menuClick(attendanceReport);
        }
    }
}
