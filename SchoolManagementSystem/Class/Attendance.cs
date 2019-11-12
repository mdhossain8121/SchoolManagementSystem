using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Class
{
    class Attendance:Base
    {
        public int Id { get; set; }

        public DateTime InTime { get; set; }

        public DateTime TodayDate { get; set; }

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

        public byte[] SelectById()
        {
            Command = CommandBuilder("select FINGERSAMPLE1 from " + table + " where STUDENT_ID = @id");
            Command.Parameters.AddWithValue("@id", StudentId);
            Reader = ExecuteReader(Command);
            Console.WriteLine("Student ID " + StudentId);
            while (Reader.Read())
            {
                //StudentId = Reader["STUDENT_NAME"];
               // FingerSample1 = (Byte[])Reader["FINGERSAMPLE1"];
                //Address = Reader["ADDRESS"].ToString();
                //StartDate = (DateTime)Reader["START_DATE"];
                //EndDate = (DateTime)Reader["END_DATE"];
                //return FingerSample1;
            }
            return null;
        }


        public bool SelectByFinger()
        {
            //Command = CommandBuilder("select COUNT(*) from " + table + " where FINGERSAMPLE1 = @id");
            Command = CommandBuilder("select * from " + table + " where STUDENT_ID = @studentId");
            Command.Parameters.AddWithValue("@studentId", StudentId);
            Reader = ExecuteReader(Command);

            while (Reader.Read())
            {
                //StudentId = Reader["STUDENT_NAME"];
               //FingerSample1 = (Byte[])Reader["FINGERSAMPLE1"];
                Id = Convert.ToInt32(Reader["ID"]);
                //Address = Reader["ADDRESS"].ToString();
                //StartDate = (DateTime)Reader["START_DATE"];
                //EndDate = (DateTime)Reader["END_DATE"];
                return true;
            }
            return false;
        }

        //public DataSet Select()
        //{
        //    Command = CommandBuilder("select FINGERSAMPLE1 from " + table);
        //    return ExecuteDataSet(Command);
        //}
    }
}
