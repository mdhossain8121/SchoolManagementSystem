using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Session:Base
    {
        public int Id { get; set; }

        public string SessionYear { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "session_setup_tbl";

        public Boolean Insert()
        {
            Command = CommandBuilder("insert into " + table + " (SESSION_YEAR) values(@sessionYear)");
            Command.Parameters.AddWithValue("@sessionYear", SessionYear);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + table + " set SESSION_YEAR = @sessionYear where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@sessionYear", SessionYear);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectBySessionYear()
        {
            Command = CommandBuilder("select SESSION_YEAR from " + table + " where SESSION_YEAR = @sessionYear and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@sessionYear", SessionYear);
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command);
            return Reader.HasRows;
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, SESSION_YEAR from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                SessionYear = Reader["SESSION_YEAR"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Console.WriteLine(SessionYear);
            Command = CommandBuilder("select ID, SESSION_YEAR from " + table + "  WHERE ACTIVE_STATUS = @ativeStatus");
            Command.Parameters.AddWithValue("@ativeStatus", ActiveStatus);
            if (SessionYear != null && SessionYear != "")
            {
                Command.CommandText += " AND SESSION_YEAR like @search";
                Command.Parameters.AddWithValue("@search", "%" + SessionYear + "%");
            }
            return ExecuteDataSet(Command);
        }
    }
}
