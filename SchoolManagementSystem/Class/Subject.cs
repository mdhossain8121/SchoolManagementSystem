using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Subject:Base
    {
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "subject_setup_tbl";

        public Boolean Insert()
        {
            Command = CommandBuilder("insert into " + table + " (SUBJECT_NAME) values(@name)");
            Command.Parameters.AddWithValue("@name", SubjectName);
            return Execute(Command);
        }


        public bool Update()
        {
            
            Command = CommandBuilder("update " + table + " set SUBJECT_NAME = @name where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", SubjectName);
            return Execute(Command);
        }

        public bool Delete()
        {
            //Command = CommandBuilder("delete from " + table + " where ID = @id");
            Command = CommandBuilder("update " + table + " set ACTIVE_STATUS = @activeStatus where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            return Execute(Command);
        }

        public bool SelectByName()
        {
            Command = CommandBuilder("select SUBJECT_NAME from " + table + " where SUBJECT_NAME = @subjectName and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@subjectName", SubjectName);
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command);
            return Reader.HasRows;
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, SUBJECT_NAME from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                SubjectName = Reader["SUBJECT_NAME"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ID, SUBJECT_NAME from " + table + " WHERE ACTIVE_STATUS = 1");
            if (SubjectName != null && SubjectName != "")
            {
                Command.CommandText += " AND SUBJECT_NAME like @search";
                Command.Parameters.AddWithValue("@search", "%" + SubjectName + "%");
            }
            return ExecuteDataSet(Command);
        }
    }
}
