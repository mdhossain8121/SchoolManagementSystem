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
    class SectionManager
    {
        public string SaveSection(Section aSection)
        {
            if (aSection.SelectByName())
                return "This section is already exist";

            if (aSection.Insert())
            {
                return "New section has been inserted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Inserting section " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSection.Error + Environment.NewLine);
                return aSection.Error;
            }
        }

        public String UpdateSection(Section aSection)
        {
            if (aSection.SelectByName())
                return "This section is already exist";

            if (aSection.Update())
            {
                return "Section has been updated";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Updating section " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSection.Error + Environment.NewLine);
                return aSection.Error;
            }
        }

        public string DeleteSection(Section aSection)
        {
            if (aSection.Delete())
            {
                return "Section has been deleted";
            }
            else
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Deleting section " + Environment.NewLine);
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: " + aSection.Error + Environment.NewLine);
                return aSection.Error;
            }
        }

        public DataTable GetAllSectionData(Section aSection)
        {
            DataSet ds = aSection.Select();
            if (ds == null)
                return null;
            return ds.Tables[0];
        }
    }
}
