using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ClassWiseSubject:Base
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public int SubjectId { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String tblClassWiseSubject = "class_wise_subject_tbl";
        private static readonly String tblSubject = "subject_setup_tbl";


        public bool Insert()
        {
            Command = CommandBuilder("insert into " + tblClassWiseSubject + " (CLASS_ID, SUBJECT_ID) values(@classId, @subjectId) ON DUPLICATE KEY UPDATE ACTIVE_STATUS = (CASE WHEN ACTIVE_STATUS = 1 THEN 0 ELSE 1 END)");
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@subjectId", SubjectId);
            return Execute(Command);
        }


        public DataSet SelectByClassId()
        {
            Command = CommandBuilder("SELECT cs.ID,SUBJECT_ID,SUBJECT_NAME from " + tblClassWiseSubject + " as cs LEFT JOIN SUBJECT_SETUP_TBL as s ON cs.SUBJECT_ID = s.ID WHERE CLASS_ID = @classId AND cs.ACTIVE_STATUS = 1 and s.ACTIVE_STATUS = 1");
            Command.Parameters.AddWithValue("@classId", ClassId);
            return ExecuteDataSet(Command);
        }

        public DataSet SelectBySubjectId()
        {
            Command = CommandBuilder("SELECT SUBJECT_ID from " + tblClassWiseSubject + " as cws LEFT JOIN " + tblSubject + " as s ON cws.SUBJECT_ID = s.ID WHERE CLASS_ID = @classId AND cws.ACTIVE_STATUS = 1 and s.ACTIVE_STATUS = 1");
            Command.Parameters.AddWithValue("@classId", ClassId);
            return ExecuteDataSet(Command);
        }
    }
}
