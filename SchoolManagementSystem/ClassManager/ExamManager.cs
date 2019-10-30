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
    class ExamManager
    {
        public string SaveExam(Exam aExam)
        {
            if (aExam.SelectByName())
                return "This exam is already exist";

            if (aExam.Insert())
            {
                return "New exam has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting exam " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aExam.Error + Environment.NewLine);
                return aExam.Error;
            }
        }

        public String UpdateExam(Exam aExam)
        {
            if (aExam.SelectByName())
                return "This exam is already exist";

            if (aExam.Update())
            {
                return "Exam has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating exam " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aExam.Error + Environment.NewLine);
                return aExam.Error;
            }
        }

        public string DeleteExam(Exam aExam)
        {
            if (aExam.Delete())
            {
                return "Exam has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting exam " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aExam.Error + Environment.NewLine);
                return aExam.Error;
            }
        }

        public DataTable GetAllExamData(Exam aExam)
        {
            DataSet ds = aExam.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
