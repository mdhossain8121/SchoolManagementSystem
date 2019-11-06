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
    class ResultManager
    {
        public string SaveResult(ResultMaster aResultMaster)
        {
            aResultMaster.Id = aResultMaster.Insert();
            if (aResultMaster.Id > 0)
            {
                return "Data has been successfully saved";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Result Submission (Insert)" + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aResultMaster.Error + Environment.NewLine);
                return aResultMaster.Error;
            }
        }

        public String UpdateResult(ResultMaster aResultMaster)
        {
            if (aResultMaster.Update())
            {
                return "Data has been successfully updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Result Submission (Update)" + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aResultMaster.Error + Environment.NewLine);
                return aResultMaster.Error;
            }
        }

        public string DeleteResult(ResultMaster aResultMaster)
        {
            if (aResultMaster.Delete())
            {
                return "Data has been successfully deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Result Submission (Delete) " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aResultMaster.Error + Environment.NewLine);
                return aResultMaster.Error;
            }
        }

        public DataTable GetAllResultData(ResultMaster aResultMaster)
        {
            DataSet ds = aResultMaster.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
