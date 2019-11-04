using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ResultChild:Base
    {
        public int Id { get; set; }

        public int ClassSectionStudentId { get; set; }

        public int Marks { get; set; }

        private static readonly String tblResultChild = "result_child_tbl";

        private static readonly String tblClassSectionWiseStudentView = "view_class_section_wise_student_tbl";


        public bool Insert()
        {
            Command = CommandBuilder("insert into " + tblResultChild + " (CLASSSECTIONSTUDENT_ID, STUDENT_ID, ROLL, YEAR) values(@classSectionId, @marks, @roll, @year)");
            Command.Parameters.AddWithValue("@classSectionId", ClassSectionStudentId);
            Command.Parameters.AddWithValue("@marks", Marks);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + tblResultChild + " set CLASSSECTIONSTUDENT_ID = @classSectionId, STUDENT_ID = @marks, ROLL = @roll, YEAR = @year where ID = @id");
            Command.Parameters.AddWithValue("@classSectionId", ClassSectionStudentId);
            Command.Parameters.AddWithValue("@marks", Marks);
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from " + tblResultChild + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, CLASS_NAME from " + tblResultChild + " where ID = @id");
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

        public DataSet SelectBySection()
        {
            Command = CommandBuilder("select ID, STUDENT_NAME, ROLL from " + tblClassSectionWiseStudentView + " where ACTIVE_STATUS = @activeStatus ORDER BY ROLL");
            return ExecuteDataSet(Command);
        }
    }
}
