using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SchoolManagementSystem.Class;
using System.Data;

namespace SchoolManagementSystem.ClassManager
{
    class ClassSectionWiseTeacherManager
    {
        public string SaveClassSectionWiseTeacher(ClassSectionWiseTeacher aClassSectionWiseTeacher)
        {
            if (aClassSectionWiseTeacher.Insert())
            {
                return "Data has been successfully saved";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Assigning teacher to class (Insert)" + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClassSectionWiseTeacher.Error + Environment.NewLine);
                return aClassSectionWiseTeacher.Error;
            }
        }

        public String UpdateClassSectionWiseTeacher(ClassSectionWiseTeacher aClassSectionWiseTeacher)
        {
            if (aClassSectionWiseTeacher.Update())
            {
                return "Data has been successfully updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Assigning teacher to class (Update)" + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClassSectionWiseTeacher.Error + Environment.NewLine);
                return aClassSectionWiseTeacher.Error;
            }
        }

        public string DeleteClassSectionWiseTeacher(ClassSectionWiseTeacher aClassSectionWiseTeacher)
        {
            if (aClassSectionWiseTeacher.Delete())
            {
                return "Data has been successfully deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Assigning teacher to class (Delete) " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClassSectionWiseTeacher.Error + Environment.NewLine);
                return aClassSectionWiseTeacher.Error;
            }
        }

        public DataTable GetAllClassSectionWiseTeacherData(ClassSectionWiseTeacher aClassSectionWiseTeacher)
        {
            DataSet ds = aClassSectionWiseTeacher.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
