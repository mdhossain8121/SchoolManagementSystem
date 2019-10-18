using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ClassSectionWiseTeacher: Base
    {
        public int Id { get; set; }

        public int ClassSectionId { get; set; }

        public int TeacherId { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String tblClassSectionWiseTeacher = "class_section_wise_teacher_tbl";

        private static readonly String tblClassSectionWiseTeacherView = "view_class_section_wise_teacher_tbl";


        public bool Insert()
        {
            //Command = CommandBuilder("insert into " + tblClassSectionWiseTeacher + " (CLASSSECTION_ID, TEACHER_ID) values(@classSectionId, @teacherId)");
            Command = CommandBuilder("insert into " + tblClassSectionWiseTeacher + " (CLASSSECTION_ID, TEACHER_ID) values(@classSectionId, @teacherId) ON DUPLICATE KEY UPDATE ACTIVE_STATUS = (CASE WHEN ACTIVE_STATUS = 1 THEN 0 ELSE 1 END)");
            Command.Parameters.AddWithValue("@classSectionId", ClassSectionId);
            Command.Parameters.AddWithValue("@teacherId", TeacherId);

            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + tblClassSectionWiseTeacher + " set CLASSSECTION_ID = @classSectionId, TEACHER_ID = @teacherId, ROLL = @roll, YEAR = @year where ID = @id");
            Command.Parameters.AddWithValue("@classSectionId", ClassSectionId);
            Command.Parameters.AddWithValue("@teacherId", TeacherId);
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("update " + tblClassSectionWiseTeacher + " set ACTIVE_STATUS = @activeStatus where ID = @id");
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, CLASS_NAME from " + tblClassSectionWiseTeacher + " where ID = @id");
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
            Command = CommandBuilder("select ID, TEACHER_NAME, CLASS_NAME, SECTION_NAME from " + tblClassSectionWiseTeacherView + " where ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            //if (ClassName != null && !ClassName.Trim().Equals(""))
            //{
            //    Command.CommandText += " Where CLASS_NAME like @search";
            //    Command.Parameters.AddWithValue("@search", "%" + ClassName + "%");
            //}
            return ExecuteDataSet(Command);
        }

        public DataSet SelectNotAssignedClasses()
        {
            Command = CommandBuilder("select ID, CLASS_NAME, SECTION_NAME from view_class_wise_section_tbl where ACTIVE_STATUS = @activeStatus and ID not in (select CLASSSECTION_ID from class_section_wise_teacher_tbl where TEACHER_ID != @teacherId)");
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);
            Command.Parameters.AddWithValue("@teacherId", TeacherId);
            //if (ClassName != null && !ClassName.Trim().Equals(""))
            //{
            //    Command.CommandText += " Where CLASS_NAME like @search";
            //    Command.Parameters.AddWithValue("@search", "%" + ClassName + "%");
            //}
            return ExecuteDataSet(Command);
        }
    }
}
