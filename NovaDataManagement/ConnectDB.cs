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
        private static string[] attConnect = { "Data Source=", ";Initial Catalog=" ,
                                        ";Persist Security Info=True;User ID=",
                                        ";Password="};        
        private ConnectDB() { }
        public static List<InfoDB> GetDBs(InfoLogin infoLogin)
        {
            List<InfoDB> list = new List<InfoDB>();
            string connectString =  attConnect[0] + infoLogin.Machine +
                                    attConnect[2] + infoLogin.User +
                                    attConnect[3] + infoLogin.Password;
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                string query = "SELECT s.datasource, ds.[catalog] , d.createdDate, d.brandname, d.domainname FROM (" +
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
                    cmd.Parameters.AddWithValue("@user", infoLogin.User);
                    using (SqlDataReader dbList = cmd.ExecuteReader())
                    {
                        while (dbList.Read())
                        {
                            InfoDB dB = new InfoDB();
                            dB.DataSource = dbList["datasource"].ToString();
                            dB.Catalog = dbList["catalog"].ToString();
                            dB.CreatedDate = dbList["createdDate"].ToString();
                            dB.BrandName = dbList["brandName"].ToString();
                            dB.DomainName = dbList["domainName"].ToString();
                          dB.UpdateChoice = false;
                            list.Add(dB);
                        }
                    }
                }
            }
            return list;
        }       
    }
}
