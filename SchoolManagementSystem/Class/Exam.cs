using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Exam:Base
    {
        public int Id { get; set; }

        public string ExamName { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "exam_setup_tbl";

        public Boolean Insert()
        {
            Command = CommandBuilder("insert into " + table + " (EXAM_NAME) values(@name)");
            Command.Parameters.AddWithValue("@name", ExamName);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + table + " set EXAM_NAME = @name where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", ExamName);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectByName()
        {
            Command = CommandBuilder("select EXAM_NAME from " + table + " where EXAM_NAME = @examName and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@examName", ExamName);
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command);
            return Reader.HasRows;
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, EXAM_NAME from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                ExamName = Reader["EXAM_NAME"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Console.WriteLine(ExamName);
            Command = CommandBuilder("select ID, EXAM_NAME from " + table + "  WHERE ACTIVE_STATUS = @ativeStatus");
            Command.Parameters.AddWithValue("@ativeStatus", ActiveStatus);
            if (ExamName != null && ExamName != "")
            {
                Command.CommandText += " AND EXAM_NAME like @search";
                Command.Parameters.AddWithValue("@search", "%" + ExamName + "%");
            }
            return ExecuteDataSet(Command);
        }
    }
}
