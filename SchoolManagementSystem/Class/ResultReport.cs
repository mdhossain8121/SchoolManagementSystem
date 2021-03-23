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

        public int ClassWiseSectionId { get; set; }

        public int ExamId { get; set; }

        public int ClassWiseExamId { get; set; }

        public int SessionId { get; set; }

        public int SubjectId { get; set; }

        public int ClassWiseSubjectId { get; set; }

        private static readonly String tblResultDetails = "view_result_details";

        public DataSet Select()
        {
            //String queryString = "SELECT rct.marks, vcswst.*, rmt.EXAM_DATE , rmt.SESSION_ID, rmt.TOTAL_MARKS FROM result_child_tbl rct " +
            //                        "LEFT JOIN result_master_tbl rmt ON rmt.ID = rct.RESULTMASTER_ID " +
            //                        "LEFT JOIN view_class_section_wise_student_tbl vcswst ON vcswst.ID = rct.CLASSSECTIONSTUDENT_ID " +
            //    "WHERE CLASS_ID = @classId and SECTION_ID = @sectionId and EXAM_ID = @examId and SESSION_ID = @sessionId";

            String queryString = "SELECT * from " + tblResultDetails +
                " WHERE CLASSSECTION_ID = @sectionId and CLASSEXAM_ID = @examId and CLASSSUBJECT_ID = @subjectId";

            Command = CommandBuilder(queryString);
            //Command.Parameters.AddWithValue("@examDate", ExamDate.Date);
            Command.Parameters.AddWithValue("@sectionId", ClassWiseSectionId);
            //Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@examId", ClassWiseExamId);
            //Command.Parameters.AddWithValue("@sessionId", SessionId);
            Command.Parameters.AddWithValue("@subjectId", ClassWiseSubjectId);
            return ExecuteDataSet(Command);
        }

        public DataSet SelectStudentWiseResult()
        {
            //String queryString = "SELECT rct.marks, vcswst.*, rmt.EXAM_DATE , rmt.SESSION_ID, rmt.TOTAL_MARKS FROM result_child_tbl rct " +
            //                        "LEFT JOIN result_master_tbl rmt ON rmt.ID = rct.RESULTMASTER_ID " +
            //                        "LEFT JOIN view_class_section_wise_student_tbl vcswst ON vcswst.ID = rct.CLASSSECTIONSTUDENT_ID " +
            //    "WHERE CLASS_ID = @classId and SECTION_ID = @sectionId and EXAM_ID = @examId and SESSION_ID = @sessionId";

            String queryString = "SELECT * from " + tblResultDetails +
                " WHERE SECTION_ID = @sectionId and EXAM_ID = @examId and STUDENT_ID = @studentId and SESSION_ID = @sessionId and CLASS_ID = @classId";
            Console.WriteLine("section "+ClassWiseSectionId);
            Console.WriteLine("class "+ ClassId);
            Console.WriteLine("exam "+ ClassWiseExamId);
            Console.WriteLine("session "+ SessionId);
            Console.WriteLine("student "+ StudentId);
            Command = CommandBuilder(queryString);
            Command.Parameters.AddWithValue("@sectionId", ClassWiseSectionId);
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@examId", ClassWiseExamId);
            Command.Parameters.AddWithValue("@sessionId", SessionId);
            Command.Parameters.AddWithValue("@studentId", StudentId);
            return ExecuteDataSet(Command);
        }

        public DataSet SelectUniqueClass()
        {
            String queryString = "SELECT CLASS_NAME, CLASS_ID from " + tblResultDetails + " where STUDENT_ID = @studentId and CLASS_NAME is not null group by CLASS_ID";
            Command = CommandBuilder(queryString);
            Command.Parameters.AddWithValue("@studentId", StudentId);

            return ExecuteDataSet(Command);
        }

        public DataSet SelectUniqueClassWiseSession()
        {
            String queryString = "SELECT SESSION_YEAR, SESSION_ID from " + tblResultDetails + " where STUDENT_ID = @studentId and CLASS_ID = @classId and SESSION_YEAR is not null group by SESSION_ID";
            Command = CommandBuilder(queryString);
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@studentId", StudentId);

            return ExecuteDataSet(Command);
        }

        public DataSet SelectUniqueClassSessionWiseSection()
        {
            String queryString = "SELECT SECTION_NAME, SECTION_ID from " + tblResultDetails + " where STUDENT_ID = @studentId and CLASS_ID = @classId and SESSION_ID = @sessionId and SECTION_ID is not null group by SECTION_ID";
            Command = CommandBuilder(queryString);
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@sessionId", SessionId);
            Command.Parameters.AddWithValue("@studentId", StudentId);

            return ExecuteDataSet(Command);
        }

        public DataSet SelectUniqueClassWiseExam()
        {
            String queryString = "SELECT EXAM_NAME, EXAM_ID from " + tblResultDetails + " where STUDENT_ID = @studentId and CLASS_ID = @classId and EXAM_NAME is not null group by EXAM_ID";
            Command = CommandBuilder(queryString);
            Command.Parameters.AddWithValue("@classId", ClassId);
            Command.Parameters.AddWithValue("@studentId", StudentId);

            return ExecuteDataSet(Command);
        }


    }
}
