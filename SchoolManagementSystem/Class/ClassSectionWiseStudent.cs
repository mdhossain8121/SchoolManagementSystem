﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class ClassSectionWiseStudent: Base
    {
        public int Id { get; set; }

        public int ClassSectionId { get; set; }

        public int StudentId { get; set; }

        public int Roll { get; set; }

        public int Year { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String tblClassSectionWiseStudent = "class_section_wise_student_tbl";

        private static readonly String tblClassSectionWiseStudentView = "view_class_section_wise_student_tbl";


        public bool Insert()
        {
            Command = CommandBuilder("insert into " + tblClassSectionWiseStudent + " (CLASSSECTION_ID, STUDENT_ID, ROLL, YEAR) values(@classSectionId, @studentId, @roll, @year)");
            Command.Parameters.AddWithValue("@classSectionId", ClassSectionId);
            Command.Parameters.AddWithValue("@studentId", StudentId);
            Command.Parameters.AddWithValue("@roll", Roll);
            Command.Parameters.AddWithValue("@year", Year);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + tblClassSectionWiseStudent + " set CLASSSECTION_ID = @classSectionId, STUDENT_ID = @studentId, ROLL = @roll, YEAR = @year where ID = @id");
            Command.Parameters.AddWithValue("@classSectionId", ClassSectionId);
            Command.Parameters.AddWithValue("@studentId", StudentId);
            Command.Parameters.AddWithValue("@roll", Roll);
            Command.Parameters.AddWithValue("@year", Year);
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from " + tblClassSectionWiseStudent + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select ID, CLASS_NAME from " + tblClassSectionWiseStudent + " where ID = @id");
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
