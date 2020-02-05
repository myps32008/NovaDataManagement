using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovaDataManagement
{
    class Script
    {
        public string Folder { get; set; }
        public string Query { get; set; }
        public string Error { get; set; }
        public Script()
        {

        }
        public Script(string folder, string query)
        {
            this.Folder = folder;
            this.Query = query;
        }
        
        public string DisplayError()
        {
            return this.Folder + ": " + this.Error;
        }
    }
}
