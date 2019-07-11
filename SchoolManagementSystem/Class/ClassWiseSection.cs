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

        public int SectionId { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String tblClassWiseSection = "class_wise_section_tbl";


        public bool Insert()
        {
            Command = CommandBuilder("insert into " + tblClassWiseSection + " (CLASS_ID, SECTION_ID) values(@classId, @sectionId) ON DUPLICATE KEY UPDATE ACTIVE_STATUS = (CASE WHEN ACTIVE_STATUS = 1 THEN 0 ELSE 1 END)");
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@sectionId", SectionId);
            return Execute(Command);
        }

        public DataSet SelectBySubjectId()
        {
            Command = CommandBuilder("SELECT SECTION_ID from " + tblClassWiseSection + " WHERE CLASS_ID = @classId AND ACTIVE_STATUS = 1");
            Command.Parameters.AddWithValue("@classId", ClassId);
            return ExecuteDataSet(Command);
        }
    }
}
