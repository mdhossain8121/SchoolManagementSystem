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
    class RoleManager
    {
        public string  SaveRole(Role aRole)
        {
            if (aRole.SelectByName())
                return "This role is already exist";

            if (aRole.Insert())
            {
                return "New role has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting Role " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aRole.Error + Environment.NewLine);
                return aRole.Error;
            }
        }

        public String UpdateRole(Role aRole)
        {
            if (aRole.SelectByName())
                return "This role is already exist";

            if (aRole.Update())
            {
                return "Role has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating Role " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aRole.Error + Environment.NewLine);
                return aRole.Error;
            }
        }

        public string DeleteRole(Role aRole)
        {
            if (aRole.Delete())
            {
                return "Role has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting Role " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aRole.Error + Environment.NewLine);
                return aRole.Error;
            }
        }

        public DataTable GetAllRoleData(Role aRole)
        {
            DataSet ds = aRole.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
