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

        public DateTime OutTime { get; set; }

        public DateTime TodayDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int PersonId { get; set; }

        public int PersonType { get; set; }

        public char Status { get; set; }

        private static readonly String table = "attendance_tbl";

        public Boolean Insert()
        {
            
            //Command = CommandBuilder("insert IGNORE into " + table + " (STUDENT_ID,DATE) values(@studentId,@date)");
            //Command.Parameters.AddWithValue("@studentId", PersonId);
            //Command.Parameters.AddWithValue("@date", TodayDate.Date);
            ////Command.Parameters.AddWithValue("@date", DateTime.Now);
            //return Execute(Command);

            //Command = CommandBuilder("insert into " + table + " (PERSON_ID,PERSON_TYPE,DATE,IN_TIME,OUT_TIME) values(@personId,@personType,@date,@inTime,@outTime) ON DUPLICATE KEY UPDATE OUT_TIME = @outTime");
            Command = CommandBuilder("insert into " + table + " (PERSON_ID,PERSON_TYPE,DATE,IN_TIME) values(@personId,@personType,@date,@inTime) ON DUPLICATE KEY UPDATE OUT_TIME = @outTime");
            //Command = CommandBuilder("UPDATE " + table + " SET OUT_TIME = @outTime WHERE STUDENT_ID = ,DATE");
            Command.Parameters.AddWithValue("@personId", PersonId);
            Command.Parameters.AddWithValue("@personType", PersonType);
            Command.Parameters.AddWithValue("@date", TodayDate.Date);
            Command.Parameters.AddWithValue("@inTime", DateTime.Now);
            Command.Parameters.AddWithValue("@outTime", DateTime.Now);
            Console.WriteLine("sd : "+Command.ToString());
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
