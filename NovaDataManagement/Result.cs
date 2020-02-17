using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaDataManagement
{
    public class Result: Script
    {
        private string backUp = null;
        public string note = null;
        public string DB { get; set; }
        public string Catalog { get; set; }
        public string Note
        {
            get { return note == null ? "" : "Tables error"; }
            private set { note = value; }
        }
        public string BackupResult 
        { 
            get { return (backUp == null)? "Done": ("Failed: " + backUp); }
            set { backUp = value; } 
        }       
        public Result()
        {

        } 
        //When backup failed        
        public Result(string stateBackup, InfoDB db)
        {
            DB = db.DataSource;
            Catalog = db.Catalog;
            BackupResult = stateBackup;            
        }
        public Result(string stateBackup, string dataSource, string catalog)
        {
            backUp = stateBackup;
            DB = dataSource;
            Catalog = catalog;
        }
    }
}
