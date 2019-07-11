using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Class;
using System.IO;
using System.Data;

namespace SchoolManagementSystem.ClassManager
{
    class ClassSetupManager
    {
        public string SaveClass(ClassSetup aClass)
        {
            if (aClass.SelectByName())
                return "This class is already exist";

            if (aClass.Insert())
            {
                return "New class has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting class " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClass.Error + Environment.NewLine);
                return aClass.Error;
            }
        }

        public String UpdateClass(ClassSetup aClass)
        {
            if (aClass.SelectByName())
                return "This class is already exist";

            if (aClass.Update())
            {
                return "Class has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating class " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClass.Error + Environment.NewLine);
                return aClass.Error;
            }
        }

        public string DeleteClass(ClassSetup aClass)
        {
            if (aClass.Delete())
            {
                return "Class has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting class " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aClass.Error + Environment.NewLine);
                return aClass.Error;
            }
        }

        public DataTable GetAllClassData(ClassSetup aClass)
        {
            DataSet ds = aClass.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
