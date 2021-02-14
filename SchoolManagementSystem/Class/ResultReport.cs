using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ResultReport : Base
    {
        public int Id { get; set; }

        public DateTime ExamDate { get; set; }

        public int StudentId { get; set; }

        public int ClassId { get; set; }

        public int SectionId { get; set; }

        public int ExamId { get; set; }

        public int SessionId { get; set; }

        public int SubjectId { get; set; }

        private static readonly String table = "attendance_tbl";

        public DataSet Select()
        {
            String queryString = "SELECT rct.marks, vcswst.*, rmt.EXAM_DATE , rmt.SESSION_ID, rmt.TOTAL_MARKS FROM result_child_tbl rct " +
                                    "LEFT JOIN result_master_tbl rmt ON rmt.ID = rct.RESULTMASTER_ID " +
                                    "LEFT JOIN view_class_section_wise_student_tbl vcswst ON vcswst.ID = rct.CLASSSECTIONSTUDENT_ID " +
                "WHERE CLASS_ID = @classId and SECTION_ID = @sectionId and EXAM_ID = @examId and SESSION_ID = @sessionId";

            Command = CommandBuilder(queryString);
            Command.Parameters.AddWithValue("@examDate", ExamDate.Date);
            Command.Parameters.AddWithValue("@sectionId", SectionId);
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@examId", ExamId);
            Command.Parameters.AddWithValue("@sessionId", SessionId);
            Command.Parameters.AddWithValue("@subjectId", SubjectId);
            return ExecuteDataSet(Command);
        }
    }
}
