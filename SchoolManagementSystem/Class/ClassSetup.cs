using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ClassSetup:Base
    {
        public int Id { get; set; }

        public string ClassName { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "class_setup_tbl";
        
        public Boolean Insert()
        {
            Command = CommandBuilder("insert into "+ table + " (CLASS_NAME) values(@name)");
            Command.Parameters.AddWithValue("@name", ClassName);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + table + " set CLASS_NAME = @name where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", ClassName);
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
            Command = CommandBuilder("select CLASS_NAME from " + table + " where CLASS_NAME = @className and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@className", ClassName);
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command);
            return Reader.HasRows;
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, CLASS_NAME from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                ClassName = Reader["CLASS_NAME"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ID, CLASS_NAME from " + table );
            if (ClassName != null && !ClassName.Trim().Equals(""))
            {
                Command.CommandText += " Where CLASS_NAME like @search";
                Command.Parameters.AddWithValue("@search", "%" + ClassName + "%");
            }
            return ExecuteDataSet(Command);
        }
    }
}
