using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaDataManagement
{
    class Result: Script
    {
        private string backUp;
        public string BackUpResult 
        { 
            get { return backUp.Equals("")? "Done": ("Failed: " + this.backUp); }
            set { this.backUp = value; } 
        }        
        public Result()
        {

        }
        //when bakup fail
        public Result(string stateBackup)
        {
            this.BackUpResult = stateBackup;
        }
        //When upgrade fail
        public Result(string stateBackup, Script script)
        {
            this.backUp = stateBackup;
            this.Folder = script.Folder;
            this.ResultUpgrade = script.ResultUpgrade;
        }        
    }
}
