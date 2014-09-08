using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityAnalysis
{
    public sealed class SecurityCsvMap : CsvClassMap<Security>
    {
        public SecurityCsvMap()
        {
            Map(m => m.FinancialStatements);
        }
    }
}
