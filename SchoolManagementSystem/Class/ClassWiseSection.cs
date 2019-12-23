using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ClassWiseSection:Base
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public int SessionId { get; set; }

        public int SectionId { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String tblClassWiseSection = "class_wise_section_tbl";
        private static readonly String tblClassWiseSectionView = "view_class_wise_section_tbl";


        public bool Insert()
        {
            Command = CommandBuilder("insert into " + tblClassWiseSection + " (CLASS_ID, SECTION_ID,SESSION_ID) values(@classId, @sectionId, @sessionId) ON DUPLICATE KEY UPDATE ACTIVE_STATUS = (CASE WHEN ACTIVE_STATUS = 1 THEN 0 ELSE 1 END)");
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@sectionId", SectionId);
            Command.Parameters.AddWithValue("@sessionId", SessionId);
            return Execute(Command);
        }

        public DataSet SelectByClassSessionId()
        {
            Command = CommandBuilder("SELECT ID,SECTION_ID,SECTION_NAME from " + tblClassWiseSectionView + " WHERE CLASS_ID = @classId AND SESSION_ID = @sessionId AND CLASS_ACTIVE = 1 and SESSION_ACTIVE = 1 and ACTIVE_STATUS = 1");
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@sessionId", SessionId);
            return ExecuteDataSet(Command);
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ID, CLASS_NAME, SECTION_NAME, SESSION_YEAR from " + tblClassWiseSectionView + " where ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            //if (ClassName != null && !ClassName.Trim().Equals(""))
            //{
            //    Command.CommandText += " Where CLASS_NAME like @search";
            //    Command.Parameters.AddWithValue("@search", "%" + ClassName + "%");
            //}
            return ExecuteDataSet(Command);
        }
    }
}
