using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Role:Base
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "role_setup_tbl";

        public Boolean Insert()
        {
            Command = CommandBuilder("insert into "+ table + " (ROLE_NAME,DESCRIPTION) values(@name,@description)");
            Command.Parameters.AddWithValue("@name", RoleName);
            Command.Parameters.AddWithValue("@description", Description);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + table + " set ROLE_NAME = @name, DESCRIPTION = @description where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", RoleName);
            Command.Parameters.AddWithValue("@description", Description);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("update " + table + " set ACTIVE_STATUS = @activeStatus where ID = @id");
            //Command = CommandBuilder("delete from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            return Execute(Command);
        }

        public bool SelectByName()
        {
            Command = CommandBuilder("select ROLE_NAME from " + table + " where ROLE_NAME = @roleName and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@roleName", RoleName);
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command);
            return Reader.HasRows;
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, ROLE_NAME, DESCRIPTION from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                RoleName = Reader["ROLE_NAME"].ToString();
                Description = Reader["DESCRIPTION"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ID, ROLE_NAME, DESCRIPTION from " + table + " where ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            if (RoleName!=null  && !RoleName.Trim().Equals(""))
            {
                Command.CommandText += " AND ROLE_NAME like @search";
                Command.Parameters.AddWithValue("@search", "%" + RoleName + "%");
            }
            return ExecuteDataSet(Command);
        }
    }
}
