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
    class SessionManager
    {
        public string SaveSession(Session aSession)
        {
            if (aSession.SelectBySessionYear())
                return "This session is already exist";

            if (aSession.Insert())
            {
                return "New session has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting session " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSession.Error + Environment.NewLine);
                return aSession.Error;
            }
        }

        public String UpdateSession(Session aSession)
        {
            if (aSession.SelectBySessionYear())
                return "This session is already exist";

            if (aSession.Update())
            {
                return "Session has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating session " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSession.Error + Environment.NewLine);
                return aSession.Error;
            }
        }

        public string DeleteSession(Session aSession)
        {
            if (aSession.Delete())
            {
                return "Session has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting session " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSession.Error + Environment.NewLine);
                return aSession.Error;
            }
        }

        public DataTable GetAllSessionData(Session aSession)
        {
            DataSet ds = aSession.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
