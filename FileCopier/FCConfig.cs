using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopier
{
    public class FCConfigPackage
    {
        public bool showDetail { get; set; }
        public bool countOnly { get; set; }
        public List<FCConfig> configList = new List<FCConfig>();
    }

    public class FCConfig
    {
        public string idName { get; set; }
        public string description { get; set; }
        public string sourceDir { get; set; }
        public string targetDir { get; set; }
        public List<string> ignoreList { get; set; }
        public List<string> allowList { get; set; }
    }
}
