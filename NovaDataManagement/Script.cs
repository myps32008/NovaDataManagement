using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovaDataManagement
{
    class Script
    {
        public string Name { get; set; }
        public string Folder { get; set; }
        public string ScriptLine { get; set; }
        public string ErrorQuery { get; set; }
        public Script(string name, string folder, string script)
        {
            this.Name = name;
            this.Folder = folder;
            this.ScriptLine = script;
        }
    }
}
