using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityAnalysis
{
    class Exchange
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public List<Security> Securities { get; set; }
    }
}
