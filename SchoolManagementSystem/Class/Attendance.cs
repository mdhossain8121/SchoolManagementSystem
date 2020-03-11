using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Attendance : Base
    {
        public int Id { get; set; }

        public DateTime InTime { get; set; }

        public DateTime TodayDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int StudentId { get; set; }

        public char Status { get; set; }

        private static readonly String table = "attendance_tbl";

        public Boolean Insert()
        {
            //Command = CommandBuilder("insert into " + table + " (STUDENT_ID,FINGERSAMPLE1) values(@studentId,@fingerSample1)");
            Command = CommandBuilder("insert IGNORE into " + table + " (STUDENT_ID,DATE) values(@studentId,@date)");
            Command.Parameters.AddWithValue("@studentId", StudentId);
            Command.Parameters.AddWithValue("@date", TodayDate.Date);
            return Execute(Command);
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select DATE, IN_TIME from " + table + " where DATE between @fromDate and @toDate ORDER BY DATE");
            //Command.Parameters.AddWithValue("@studentId", StudentId);
            Command.Parameters.AddWithValue("@fromDate", FromDate.Date);
            Command.Parameters.AddWithValue("@toDate", ToDate.Date);
            return ExecuteDataSet(Command);
        }
    }
}
