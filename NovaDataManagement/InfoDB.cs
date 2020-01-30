using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovaDataManagement
{
    class InfoDB
    {
        public string DataSource { get; set; }
        public string Catalog { get; set; }
        public string BrandName { get; set; }
        public string DomainName { get; set; }
        public string CreatedDate { get; set; }
        public bool UpdateChoice { get; set; }
    }
}
