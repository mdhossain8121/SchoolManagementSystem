using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace SchoolManagementSystem.Class
{
    class User:Base
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public int ActiveStatus { get; set; }

        private static readonly String tblUser = "user_tbl";

        private static readonly String tblRole = "role_setup_tbl";

        MD5 md5Hash = MD5.Create();


        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert()
        {
            Command = CommandBuilder("insert into " + tblUser + " (USER_NAME, Password, ROLE_ID) values(@userName, @password, @roleId)");
            Command.Parameters.AddWithValue("@userName", UserName);
            Command.Parameters.AddWithValue("@roleId", RoleId);
            Command.Parameters.AddWithValue("@password", GetMd5Hash(md5Hash, Password));
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update " + tblUser + " set USER_NAME = @userName, ROLE_ID = @roleId where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@userName", UserName);
            Command.Parameters.AddWithValue("@roleId", RoleId);
            //Console.WriteLine(Command.CommandText.ToString());
            //Console.WriteLine(Id);
            //Console.WriteLine(UserName);
            //Console.WriteLine(RoleId);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("update " + tblUser + " set ACTIVE_STATUS = @activeStatus where ID = @id");
            //Command = CommandBuilder("delete from " + tblUser + " where ID = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@activeStatus", ActiveStatus);

            return Execute(Command);
        }

        public int CheckUserRole()
        {
            Command = CommandBuilder("select * from " + tblUser + " where USER_NAME = @userName and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@userName", UserName);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command); 
            if (Reader.Read())
            {
                if(VerifyMd5Hash(md5Hash, Password, Reader["PASSWORD"].ToString().Trim()))
                {
                    return (int)Reader["ROLE_ID"];
                }
            }
            return 0;
        }


        public bool SelectByName()
        {
            Command = CommandBuilder("select * from " + tblUser + " where USER_NAME = @userName and ID <> @id and ACTIVE_STATUS = @activeStatus");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@userName", UserName);
            Command.Parameters.AddWithValue("@activeStatus", 1);
            Reader = ExecuteReader(Command);
            if (Reader.HasRows)
            {

            }
            return Reader.HasRows;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("SELECT U.ID, U.USER_NAME, R.ROLE_NAME from " + tblUser + " as U left join " + tblRole + " as R on U.ROLE_ID = R.ID where U.ACTIVE_STATUS = @activeStatus");

            if (UserName != null && UserName != "")
            {
                Command.CommandText += " and U.USER_NAME like @search";
                Command.Parameters.AddWithValue("@search", "%" + UserName + "%");
            }
            Command.Parameters.AddWithValue("@activeStatus", 1);

            return ExecuteDataSet(Command);
        }
    }
}
