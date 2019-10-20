using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Class
{
    class DatabaseManager:Base
    {
        public string FilePath { get; set; }

        public void DatabaseBackup()
        {
            if(ReadyDBBackupOrRestore())
                mb.ExportToFile(FilePath);
        }

        public void DatabaseRestore()
        {
            if (ReadyDBBackupOrRestore())
                mb.ImportFromFile(FilePath);
        }

        
    }
}
