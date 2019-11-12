using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace SchoolManagementSystem.Class
{
    class FingerRegister:Base
    {
        public int Id { get; set; }

        public byte[] FingerSample1 { get; set; }

        public int StudentId { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "user_finger";

        public Boolean Insert()
        {
            //Command = CommandBuilder("insert into " + table + " (STUDENT_ID,FINGERSAMPLE1) values(@studentId,@fingerSample1)");
            Command = CommandBuilder("insert into " + table + " (STUDENT_ID,FINGERSAMPLE1) values(@studentId,@fingerSample1) ON DUPLICATE KEY UPDATE fingerSample1 = @fingerSample1");
            Command.Parameters.AddWithValue("@studentId", StudentId);
            Command.Parameters.AddWithValue("@fingerSample1", FingerSample1);
            return Execute(Command);
        }

        //public bool Update()
        //{
        //    Command = CommandBuilder("update " + table + " set IMAGE = @image, STUDENT_NAME = @studentId, MOBILE = @mobile, ADDRESS = @address, START_DATE = @startDate, END_DATE = @endDate  where ID = @id");
        //    Command.Parameters.AddWithValue("@id", Id);
        //    Command.Parameters.AddWithValue("@studentId", StudentName);
        //    Command.Parameters.AddWithValue("@mobile", Mobile);
        //    Command.Parameters.AddWithValue("@address", Address);
        //    Command.Parameters.AddWithValue("@startDate", StartDate);
        //    Command.Parameters.AddWithValue("@endDate", EndDate);
        //    Command.Parameters.AddWithValue("@image", Image);
        //    return Execute(Command);
        //}

        //public bool Delete()
        //{
        //    Command = CommandBuilder("update " + table + " set ACTIVE_STATUS = @activeStatus and END_DATE = @endDate where ID = @id");
        //    //Command = CommandBuilder("delete from " + table + " where ID = @id");
        //    Command.Parameters.AddWithValue("@id", Id);
        //    Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
        //    Command.Parameters.AddWithValue("@endDate", EndDate);
        //    return Execute(Command);
        //}

        public byte[] SelectById()
        {
            Command = CommandBuilder("select FINGERSAMPLE1 from " + table + " where STUDENT_ID = @id");
            Command.Parameters.AddWithValue("@id", StudentId);
            Reader = ExecuteReader(Command);
            Console.WriteLine("Student ID " + StudentId);
            while (Reader.Read())
            {
                //StudentId = Reader["STUDENT_NAME"];
                FingerSample1 = (Byte[]) Reader["FINGERSAMPLE1"];
                //Address = Reader["ADDRESS"].ToString();
                //StartDate = (DateTime)Reader["START_DATE"];
                //EndDate = (DateTime)Reader["END_DATE"];
                return FingerSample1;
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
                FingerSample1 = (Byte[])Reader["FINGERSAMPLE1"];
                Id = Convert.ToInt32(Reader["ID"]);
                //Address = Reader["ADDRESS"].ToString();
                //StartDate = (DateTime)Reader["START_DATE"];
                //EndDate = (DateTime)Reader["END_DATE"];
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select FINGERSAMPLE1,STUDENT_ID from " + table);
            return ExecuteDataSet(Command);
        }
    }
}
