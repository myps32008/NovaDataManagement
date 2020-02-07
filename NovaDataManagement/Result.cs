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
        public string DB { get; set; }
        public string Catalog { get; set; }
        public string BackUpResult 
        { 
            get { return (this.backUp == null)? "Done": ("Failed: " + this.backUp); }
            set { this.backUp = value; } 
        }       
        public Result()
        {

        }        
        //When upgrade fail
        public Result(string stateBackup, Script errorScript , InfoDB db)
        {
            this.backUp = stateBackup;
            this.Folder = errorScript.Folder;
            this.DB = db.DataSource;
            this.Catalog = db.Catalog;
            this.ResultUpgrade = errorScript.ResultUpgrade;
        }
        //When upgrade success
        public Result(InfoDB db)
        {                    
            this.DB = db.DataSource;
            this.Catalog = db.Catalog;
        }
        public Result(string stateBackup,InfoDB db)
        {
            this.DB = db.DataSource;
            this.Catalog = db.Catalog;
            this.BackUpResult = stateBackup;
        }
    }
}
