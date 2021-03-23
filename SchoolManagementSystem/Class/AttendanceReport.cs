using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class AttendanceReport : Base
    {
        public int Id { get; set; }

        public DateTime InTime { get; set; }

        public DateTime OutTime { get; set; }

        public DateTime TodayDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int PersonId { get; set; }

        public int ClassId { get; set; }

        public int SectionId { get; set; }

        public int StudentId { get; set; }

        public int PersonType { get; set; }

        public char Status { get; set; }

        private static readonly String table = "attendance_tbl";

        public DataSet SelectStudentAttendance()
        {
            //Command = CommandBuilder("select DATE, IN_TIME from " + table + " where DATE between @fromDate and @toDate ORDER BY DATE");
            String queryString = "SELECT vcsws.*,aat.* FROM attendance_tbl aat LEFT JOIN view_class_section_wise_student_tbl vcsws ON vcsws.STUDENT_ID = aat.PERSON_ID " +
                "WHERE vcsws.CLASS_ID IS NOT null and DATE between @fromDate and @toDate and PERSON_TYPE = @personType";

            if (ClassId != 0)
            {
                queryString += " and CLASS_ID = @classId ";
            }

            if (SectionId != 0)
            {
                queryString += " and SECTION_ID = @sectionId ";
            }

            if (PersonId != 0)
            {
                queryString += " and PERSON_ID = @personId ";
            }

            queryString += " ORDER BY DATE";
            Command = CommandBuilder(queryString);
            
            Command.Parameters.AddWithValue("@fromDate", FromDate.Date);
            Command.Parameters.AddWithValue("@toDate", ToDate.Date);
            Command.Parameters.AddWithValue("@personType", PersonType);

            if (ClassId != 0)
            {
                Command.Parameters.AddWithValue("@classId", ClassId);
            }
            if (SectionId != 0)
            {
                Command.Parameters.AddWithValue("@sectionId", SectionId);
            }
            if (PersonId != 0)
            {
                Command.Parameters.AddWithValue("@personId", PersonId);
            }
            return ExecuteDataSet(Command);
        }

        public DataSet SelectTeacherAttendance()
        {
            //Command = CommandBuilder("select DATE, IN_TIME from " + table + " where DATE between @fromDate and @toDate ORDER BY DATE");
            String queryString = "SELECT tst.*,aat.* FROM attendance_tbl aat LEFT JOIN teacher_setup_tbl tst ON tst.ID = aat.PERSON_ID " +
                "WHERE DATE between @fromDate and @toDate AND aat.PERSON_TYPE = 2";

            if (PersonId != 0)
            {
                Console.WriteLine("student" + PersonId);
                queryString += " and PERSON_ID = @personId";
            }

            queryString += " ORDER BY DATE";
            Command = CommandBuilder(queryString);

            Command.Parameters.AddWithValue("@fromDate", FromDate.Date);
            Command.Parameters.AddWithValue("@toDate", ToDate.Date);
            Command.Parameters.AddWithValue("@personType", PersonType);

            if (PersonId != 0)
            {
                Command.Parameters.AddWithValue("@personId", PersonId);
            }
            return ExecuteDataSet(Command);
        }


    }
}
