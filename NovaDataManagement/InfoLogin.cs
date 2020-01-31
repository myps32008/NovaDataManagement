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
        public InfoLogin(string machine, string server, string user, string password)
        {
            this.Machine = machine;
            this.SeverName = server;
            this.User = user;
            this.Password = password;
        }
    }
}
