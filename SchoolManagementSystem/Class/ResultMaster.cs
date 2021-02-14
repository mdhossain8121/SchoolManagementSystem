using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ResultMaster:Base
    {
        public long Id { get; set; }

        public int ClassExamId { get; set; }

        public int ClassSubjectId { get; set; }

        public int TotalMarks { get; set; }

        public DateTime ExamDate { get; set; }

        public int SessionId { get; set; }

        public List<ResultChild> ResultChild { get; set; }

        private static readonly String tblResultMaster = "result_master_tbl";

        private static readonly String tblClassSectionWiseStudentView = "view_class_section_wise_student_tbl";


        public long Insert()
        {
            Command = CommandBuilder("insert into " + tblResultMaster + " (CLASSEXAM_ID, CLASSSUBJECT_ID, TOTAL_MARKS, SESSION_ID,EXAM_DATE) values(@classExamId, @classSubjectId, @totalMarks, @session,  @examDate)");
            //Command = CommandBuilder("insert into " + tblResultMaster + " (CLASSEXAM_ID, CLASSSUBJECT_ID, TOTAL_MARKS, EXAM_DATE) values(@classExamId, @classSubjectId, @totalMarks, @examDate)");
            Command.Parameters.AddWithValue("@classExamId", ClassExamId);
            Command.Parameters.AddWithValue("@classSubjectId", ClassSubjectId);
            Command.Parameters.AddWithValue("@totalMarks", TotalMarks);
            Command.Parameters.AddWithValue("@examDate", ExamDate);
            Command.Parameters.AddWithValue("@session", SessionId);
            return ExecuteAndReturnId(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + tblResultMaster + " set CLASSEXAM_ID = @classExamId, STUDENT_ID = @marks, ROLL = @roll, YEAR = @year where ID = @id");
            Command.Parameters.AddWithValue("@classExamId", ClassExamId);
            Command.Parameters.AddWithValue("@marks", ClassSubjectId);
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from " + tblResultMaster + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, CLASS_NAME from " + tblResultMaster + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            //while (Reader.Read())
            //{
            //    ClassName = Reader["CLASS_NAME"].ToString();
            //    return true;
            //}
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ID, STUDENT_NAME, CLASS_NAME, SECTION_NAME,ROLL,YEAR from " + tblClassSectionWiseStudentView + " where ACTIVE_STATUS = @activeStatus");
            //if (ClassName != null && !ClassName.Trim().Equals(""))
            //{
            //    Command.CommandText += " Where CLASS_NAME like @search";
            //    Command.Parameters.AddWithValue("@search", "%" + ClassName + "%");
            //}
            return ExecuteDataSet(Command);
        }

        public int CheckIfResultExist()
        {
            //Command = CommandBuilder("select count(*) from " + tblResultMaster + " where CLASSEXAM_ID = @classExamId and CLASSSUBJECT_ID = @classSubjectId and YEAR(EXAM_DATE) = @examDate");
            Command = CommandBuilder("select count(*) from " + tblResultMaster + " where CLASSEXAM_ID = @classExamId and CLASSSUBJECT_ID = @classSubjectId and SESSION_ID = @session");
            Command.Parameters.AddWithValue("@classExamId", ClassExamId);
            Command.Parameters.AddWithValue("@classSubjectId", ClassSubjectId);
            //Command.Parameters.AddWithValue("@examDate", ExamDate.Year);
            Command.Parameters.AddWithValue("@session", SessionId);
            return ExecuteCount(Command);
        }
    }
}
