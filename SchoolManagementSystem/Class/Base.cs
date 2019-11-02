using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace SchoolManagementSystem.Class
{
    class Base
    {
        private static readonly String dbserver = "127.0.0.1";
        private static readonly String dbuser = "root";
        private static readonly String dbpassword = "";
        private static readonly String dbname = "sas_db";
        private static readonly String connStr = "server=" + dbserver + ";user=" + dbuser + ";database=" + dbname + ";password= " + dbpassword + ";";
        private MySqlConnection cn = new MySqlConnection(connStr);
        protected MySqlBackup mb; 

        public string Error { get; set; }


        private Boolean databaseConnectionOpen()
        {
            if (Reader != null && !Reader.IsClosed)
                Reader.Close();

            if (cn.State == ConnectionState.Open)
                return true;
            
            try
            {
                cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Can't create connection with database. " + Environment.NewLine);
                File.AppendAllText("logs.txt", " ------------------------------------------ " + Environment.NewLine);
                File.AppendAllText("logs.txt", ex.Message + Environment.NewLine);
                File.AppendAllText("logs.txt", ex.StackTrace + Environment.NewLine);
                Error = ex.Message;
                return false;
            }
        }


        private Boolean databaseConnectionClose()
        {
            if (cn.State == ConnectionState.Closed)
                return true;
            try
            {
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Can't close connection with database. " + Environment.NewLine);
                File.AppendAllText("logs.txt", " ------------------------------------------ " + Environment.NewLine);
                File.AppendAllText("logs.txt", ex.Message + Environment.NewLine);
                File.AppendAllText("logs.txt", ex.StackTrace + Environment.NewLine);
                return false;
            }
        }


        protected MySqlCommand Command { get; set; }
        protected MySqlCommand CommandBuilder(string SQL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = SQL;
            return cmd;
        }

        protected bool ReadyDBBackupOrRestore()
        {
            if (!databaseConnectionOpen())
                return false;
            MySqlCommand cmd = new MySqlCommand();
            mb = new MySqlBackup(cmd);
            cmd.Connection = cn;
            return true;
        }


        protected bool Execute(MySqlCommand cmd)
        {
            if (!databaseConnectionOpen())
                return false;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        protected MySqlDataReader Reader { get; set; }
        protected MySqlDataReader ExecuteReader(MySqlCommand cmd)
        {
            if (!databaseConnectionOpen())
                return null;
            return cmd.ExecuteReader();
        }


        protected DataSet ExecuteDataSet(MySqlCommand cmd)
        {
            if (!databaseConnectionOpen())
                return null;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(Command);
            da.Fill(ds);
            return ds;


            //try
            //{
            //    DataSet ds = new DataSet();
            //    MySqlDataAdapter da = new MySqlDataAdapter(Command);
            //    da.Fill(ds);
            //    return ds;
            //}
            //catch (Exception ex)
            //{
            //    Error = ex.Message;
            //    File.AppendAllText("logs.txt", DateTime.Now.ToString() + " :: Execute Dataset in Base. " + Environment.NewLine);
            //    File.AppendAllText("logs.txt", " ------------------------------------------ " + Environment.NewLine);
            //    File.AppendAllText("logs.txt", ex.Message + Environment.NewLine);
            //    File.AppendAllText("logs.txt", ex.StackTrace + Environment.NewLine);
            //    return null;
            //}
        }
    }
}
