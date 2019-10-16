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
            Command = CommandBuilder("insert into " + tblClassSectionWiseTeacher + " (CLASSSECTION_ID, TEACHER_ID) values(@classSectionId, @teacherId)");
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
            Command = CommandBuilder("delete from " + tblClassSectionWiseTeacher + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
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
    }
}
