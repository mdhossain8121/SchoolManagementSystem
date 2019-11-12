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
    class StudentManager
    {
        public string SaveStudent(Student aStudent)
        {
            if (aStudent.Insert())
            {
                return "New Student has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting Student " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aStudent.Error + Environment.NewLine);
                return aStudent.Error;
            }
        }

        public String UpdateStudent(Student aStudent)
        {
            if (aStudent.Update())
            {
                return "Student has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating Student " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aStudent.Error + Environment.NewLine);
                return aStudent.Error;
            }
        }

        public string DeleteStudent(Student aStudent)
        {
            if (aStudent.Delete())
            {
                return "Student has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting Student " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aStudent.Error + Environment.NewLine);
                return aStudent.Error;
            }
        }

        public DataTable GetAllStudentData(Student aStudent)
        {
            DataSet ds = aStudent.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }

        public string SaveFingerInfo(Student aStudent)
        {
            if (aStudent.InsertFinger())
            {
                return "New Finger information has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting Student " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aStudent.Error + Environment.NewLine);
                return aStudent.Error;
            }
        }

        public byte[] GetFingerDataById(Student aStudent)
        {
            return aStudent.SelectFingerById();
        }

        public DataTable GetAllFingerData(Student aStudent)
        {
            DataSet ds = aStudent.SelectAllFinger();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
