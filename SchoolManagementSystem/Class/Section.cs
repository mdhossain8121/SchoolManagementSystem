using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Section:Base
    {
        public int Id { get; set; }

        public string SectionName { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String table = "section_setup_tbl";

        public Boolean Insert()
        {
            Command = CommandBuilder("insert into " + table + " (SECTION_NAME) values(@name)");
            Command.Parameters.AddWithValue("@name", SectionName);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + table + " set SECTION_NAME = @name where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", SectionName);
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
            Command = CommandBuilder("select SECTION_NAME from " + table + " where SECTION_NAME = @sectionName and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@sectionName", SectionName);
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command);
            return Reader.HasRows;
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, SECTION_NAME from " + table + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                SectionName = Reader["SECTION_NAME"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Console.WriteLine(SectionName);
            Command = CommandBuilder("select ID, SECTION_NAME from " + table + "  WHERE ACTIVE_STATUS = @ativeStatus");
            Command.Parameters.AddWithValue("@ativeStatus", ActiveStatus);
            if (SectionName != null && SectionName != "")
            {
                Command.CommandText += " AND SECTION_NAME like @search";
                Command.Parameters.AddWithValue("@search", "%" + SectionName + "%");
            }
            return ExecuteDataSet(Command);
        }
    }
}
