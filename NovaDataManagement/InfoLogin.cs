using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovaDataManagement
{
    public class InfoLogin
    {
        public string SeverName { get; set; }
        public string Machine { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public InfoLogin(string a, string b, string c, string d)
        {
            this.Machine = a;
            this.SeverName = b;
            this.User = c;
            this.Password = d;
        }
    }
}
