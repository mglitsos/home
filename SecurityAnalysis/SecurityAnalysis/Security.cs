using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityAnalysis
{
    public class Security
    {
        public enum ExchangeSymbol
        {
            NYSE,
            NASDAQ
        }
        public string TickerSymbol { get; set; }
        public string Name { get; set; }
        public List<FinancialStatement> FinancialStatements { get; set; }
    }
}
