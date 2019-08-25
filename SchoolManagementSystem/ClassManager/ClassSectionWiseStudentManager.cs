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
    class ClassSectionWiseStudentManager
    {
        public string SaveClass(ClassSectionWiseStudent aClassSectionWiseStudent)
        {
            if (aClassSectionWiseStudent.Insert())
            {
                return "Data has been successfully saved";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Assigning student to class (Insert)" + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClassSectionWiseStudent.Error + Environment.NewLine);
                return aClassSectionWiseStudent.Error;
            }
        }

        public String UpdateClass(ClassSectionWiseStudent aClassSectionWiseStudent)
        {
            if (aClassSectionWiseStudent.Update())
            {
                return "Data has been successfully updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Assigning student to class (Update)" + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClassSectionWiseStudent.Error + Environment.NewLine);
                return aClassSectionWiseStudent.Error;
            }
        }

        public string DeleteClass(ClassSectionWiseStudent aClassSectionWiseStudent)
        {
            if (aClassSectionWiseStudent.Delete())
            {
                return "Data has been successfully deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Assigning student to class (Delete) " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClassSectionWiseStudent.Error + Environment.NewLine);
                return aClassSectionWiseStudent.Error;
            }
        }

        public DataTable GetAllClassData(ClassSectionWiseStudent aClassSectionWiseStudent)
        {
            DataSet ds = aClassSectionWiseStudent.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
