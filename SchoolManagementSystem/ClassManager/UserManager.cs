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
    class UserManager
    {
        public string SaveUser(User aUser)
        {
            if (aUser.SelectByName())
                return "This user name is already exist";

            if (aUser.Insert())
            {
                return "New user has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting User " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aUser.Error + Environment.NewLine);
                return aUser.Error;
            }
        }

        public String UpdateUser(User aUser)
        {
            if (aUser.SelectByName())
                return "This user name is already exist";

            if (aUser.Update())
            {
                return "User has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating User " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aUser.Error + Environment.NewLine);
                return aUser.Error;
            }
        }

        public string DeleteUser(User aUser)
        {
            if (aUser.Delete())
            {
                return "Role has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting User " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aUser.Error + Environment.NewLine);
                return aUser.Error;
            }
        }

        public DataTable GetAllUserData(User aUser)
        {
            DataSet ds = aUser.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
