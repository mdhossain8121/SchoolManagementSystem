using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Student:Base
    {
        public int Id { get; set; }

        public byte[] Image { get; set; }

        public byte[] Finger { get; set; }

        public string StudentName { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "student_setup_tbl";

        public Boolean Insert()
        {
            Command = CommandBuilder("insert into " + table + " (STUDENT_NAME,MOBILE,ADDRESS,START_DATE,END_DATE,IMAGE) values(@studentName,@mobile,@address,@startDate,@endDate,@image)");
            Command.Parameters.AddWithValue("@studentName", StudentName);
            Command.Parameters.AddWithValue("@mobile", Mobile);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@startDate", StartDate);
            Command.Parameters.AddWithValue("@endDate", EndDate);
            Command.Parameters.AddWithValue("@image", Image);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + table + " set IMAGE = @image, STUDENT_NAME = @studentName, MOBILE = @mobile, ADDRESS = @address, START_DATE = @startDate, END_DATE = @endDate  where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@studentName", StudentName);
            Command.Parameters.AddWithValue("@mobile", Mobile);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@startDate", StartDate);
            Command.Parameters.AddWithValue("@endDate", EndDate);
            Command.Parameters.AddWithValue("@image", Image);
            return Execute(Command);
        }


        public bool InsertFinger()
        {
            Command = CommandBuilder("update " + table + " set FINGER = @finger where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@finger", Finger);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("update " + table + " set ACTIVE_STATUS = @activeStatus and END_DATE = @endDate where ID = @id");
            //Command = CommandBuilder("delete from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            Command.Parameters.AddWithValue("@endDate", EndDate);
            return Execute(Command);
        }

        //public bool SelectById()
        //{
        //    Command = CommandBuilder("select ID, STUDENT_NAME,MOBILE,ADDRESS,START_DATE,END_DATE from " + table + " where ID = @id");
        //    Command.Parameters.AddWithValue("@id", Id);
        //    Reader = ExecuteReader(Command);
        //    while (Reader.Read())
        //    {
        //        StudentName = Reader["STUDENT_NAME"].ToString();
        //        Mobile = Reader["MOBILE"].ToString();
        //        Address = Reader["ADDRESS"].ToString();
        //        StartDate = (DateTime)Reader["START_DATE"];
        //        EndDate = (DateTime)Reader["END_DATE"];
        //        return true;
        //    }
        //    return false;
        //}

        public int countStudent()
        {
            Command = CommandBuilder("select count(*) as TOTAL from " + table + " where ACTIVE_STATUS = 1");
            Reader = ExecuteReader(Command);
            if (Reader.Read())
            {
                return Convert.ToInt32( Reader["TOTAL"].ToString());
            }
            return 0;
        }

        public byte[] SelectFingerById()
        {
            Command = CommandBuilder("select FINGER from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Finger = (Byte[])Reader["FINGER"];
                return Finger;
            }
            return null;
        }

        public DataSet SelectAllFinger()
        {
            Command = CommandBuilder("select FINGER,STUDENT_NAME,ID from " + table + " where FINGER is not null");
            return ExecuteDataSet(Command);
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ID,STUDENT_NAME, CONCAT( ID,'-',STUDENT_NAME) AS UNIQUE_NAME,IMAGE,MOBILE,ADDRESS,START_DATE,END_DATE from " + table + " where ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            if (StudentName != null && !StudentName.Trim().Equals(""))
            {
                Command.CommandText += " AND STUDENT_NAME like @search";
                Command.Parameters.AddWithValue("@search", "%" + StudentName + "%");
            }
            return ExecuteDataSet(Command);
        }
    }
}
