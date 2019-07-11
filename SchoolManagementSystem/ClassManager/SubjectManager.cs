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
    class SubjectManager
    {
        public string SaveSubject(Subject aSubject)
        {
            if (aSubject.SelectByName())
                return "This subject is already exist";

            if (aSubject.Insert())
            {
                return "New subject has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting subject " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSubject.Error + Environment.NewLine);
                return aSubject.Error;
            }
        }

        public String UpdateSubject(Subject aSubject)
        {
            if (aSubject.SelectByName())
                return "This subject is already exist";

            if (aSubject.Update())
            {
                return "Subject has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating subject " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSubject.Error + Environment.NewLine);
                return aSubject.Error;
            }
        }

        public string DeleteSubject(Subject aSubject)
        {
            if (aSubject.Delete())
            {
                return "Subject has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting subject " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSubject.Error + Environment.NewLine);
                return aSubject.Error;
            }
        }

        public DataTable GetAllSubjectData(Subject aSubject)
        {
            DataSet ds = aSubject.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
