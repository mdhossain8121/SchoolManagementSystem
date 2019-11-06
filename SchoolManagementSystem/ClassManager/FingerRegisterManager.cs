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
    class FingerRegisterManager
    {
        public string SaveFingerInfo(FingerRegister aFinger)
        {
            if (aFinger.Insert())
            {
                return "New Finger information has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting Student " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aFinger.Error + Environment.NewLine);
                return aFinger.Error;
            }
        }

        public byte[] GetFingerDataById(FingerRegister aFinger)
        {
            return aFinger.SelectById();
        }

        public DataTable GetAllFingerData(FingerRegister aFinger)
        {
            DataSet ds = aFinger.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
