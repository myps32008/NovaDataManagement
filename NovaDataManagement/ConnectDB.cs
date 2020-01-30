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
                string query = "SELECT s.datasource, ds.[catalog] , d.brandname, d.domainname, d.createdDate FROM (" +
                            "([CRM_Domain_Monitoring].[dbo].[storage] as s " +
                            "inner join " +
                            "[CRM_Domain_Monitoring].[dbo].[domain_storage] as ds " +
                            "on ds.storageid IN " +
                                "(SELECT ID FROM [CRM_Domain_Monitoring].[dbo].[storage] " +
                                "WHERE [user] = @user) AND s.[user] = @user) " +
                            "inner join " +
                            "[CRM_Domain_Monitoring].[dbo].[domain] as d " +
                            "on d.id = ds.domainid)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user", frmLogin.login.User);
                    using (SqlDataReader dbList = cmd.ExecuteReader())
                    {
                        while (dbList.Read())
                        {
                            InfoDB dB = new InfoDB();
                            dB.DataSource   = dbList[0].ToString();
                            dB.Catalog      = dbList[1].ToString();
                            dB.BrandName    = dbList[2].ToString();
                            dB.DomainName   = dbList[3].ToString();
                            dB.CreatedDate  = dbList[4].ToString();
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
