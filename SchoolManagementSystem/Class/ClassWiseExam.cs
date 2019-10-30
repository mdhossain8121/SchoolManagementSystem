using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ClassWiseExam:Base
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public int ExamId { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String tblClassWiseExam = "class_wise_exam_tbl";
        private static readonly String tblClassWiseExamView = "view_class_wise_exam_tbl";


        public bool Insert()
        {
            Command = CommandBuilder("insert into " + tblClassWiseExam + " (CLASS_ID, EXAM_ID) values(@classId, @examId) ON DUPLICATE KEY UPDATE ACTIVE_STATUS = (CASE WHEN ACTIVE_STATUS = 1 THEN 0 ELSE 1 END)");
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@examId", ExamId);
            return Execute(Command);
        }

        public DataSet SelectByClassId()
        {
            Command = CommandBuilder("SELECT ce.ID,EXAM_ID,EXAM_NAME from " + tblClassWiseExam + " as ce LEFT JOIN EXAM_SETUP_TBL as e ON ce.EXAM_ID = e.ID WHERE CLASS_ID = @classId AND ce.ACTIVE_STATUS = 1");
            Command.Parameters.AddWithValue("@classId", ClassId);
            return ExecuteDataSet(Command);
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ID, CLASS_NAME, EXAM_NAME from " + tblClassWiseExamView + " where ACTIVE_STATUS = @activeStatus");
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
