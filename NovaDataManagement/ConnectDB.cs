using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NovaDataManagement
{
    sealed class ConnectDB
    {
        public static Script errorScript = null;
        private static string[] attConnect = { "Data Source=", ";Initial Catalog=" ,
                                        ";Persist Security Info=True;User ID=",
                                        ";Password="};
        private static string connectString =
                                attConnect[0] + frmLogin.login.Machine +
                                attConnect[2] + frmLogin.login.User +
                                attConnect[3] + frmLogin.login.Password;
        private ConnectDB() { }
        public static List<InfoDB> GetDBs()
        {
            List<InfoDB> list = new List<InfoDB>();
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                string query = "with fs as " +
                    "(select database_id, type, size * 8.0 / (1024) as size from sys.master_files)" +
                    "select name," +
                    "(select sum(size) from fs where type = 0 and fs.database_id = db.database_id) + " +
                    "(select sum(size) from fs where type = 1 and fs.database_id = db.database_id)" +
                    "from sys.databases db " +
                    "where suser_sname(owner_sid) = @owner";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@owner", frmLogin.login.User);
                    using (SqlDataReader dbList = cmd.ExecuteReader())
                    {
                        while (dbList.Read())
                        {
                            InfoDB dB = new InfoDB();
                            dB.Name = dbList[0].ToString();
                            float fSize = float.Parse(dbList[1].ToString());
                            dB.Size = string.Format("{0:0.00}", fSize);
                            dB.UpdateChoice = false;
                            list.Add(dB);
                        }
                    }
                }
            }
            return list;
        }
        public static bool UpgradeDB(List<Script> list, string dbName)
        {
            string upgradeDbConnect = attConnect[0] + frmLogin.login.Machine +
                                attConnect[1] + dbName +
                                attConnect[2] + frmLogin.login.User +
                                attConnect[3] + frmLogin.login.Password;
            using (SqlConnection con = new SqlConnection(upgradeDbConnect))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                foreach (Script item in list)
                {
                    List<string> scripts = GetScript(item.ScriptLine);
                    foreach (string line in scripts)
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(line, con, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception bl)
                        {
                            errorScript = item;
                            errorScript.ErrorQuery = line;

                            transaction.Rollback();
                            return false;
                            throw bl;
                        }
                    }                    
                }                
                transaction.Commit();                
            }
            return true;
        }
        private static List<string> GetScript(string rawScript)
        {
            //Get string script by spliting "go"
            Regex regexCmd = new Regex("go");
            List<string> result = new List<string>();
            string[] tempScript = regexCmd.Split(rawScript);            
            foreach (string item in tempScript)
            {
                if (item != "go")
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
