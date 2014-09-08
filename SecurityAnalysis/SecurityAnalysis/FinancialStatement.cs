using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityAnalysis
{
    public class FinancialStatement
    {
        public DateTime StatmentDate { get; set; }

        #region Financials

        public decimal Revenue { get; set; }
        public decimal GrossMarginPct { get; set; }
        public decimal OperatingIncome { get; set; }
        public decimal OperratingMarginPct { get; set; }
        public decimal NetIncome { get; set; }
        public decimal EarningsPerShareRatio { get; set; }
        public decimal Dividends { get; set; }
        public decimal PayoutPct { get; set; }
        public decimal Shares { get; set; }
        public decimal BookValuePerShareRatio { get; set; }
        public decimal OperatingCashFlow { get; set; }
        public decimal CapSpending { get; set; }
        public decimal FreeCashFlow { get; set; }
        public decimal FreeCashFlowPerShareRatio { get; set; }
        public decimal WorkingCapital { get; set; }

        #endregion Financials

        #region MarginOfSalesPct

        public decimal RevenuePct { get; set; }
        public decimal CogsPct { get; set; }
        public decimal GrossMarginOfSalesPct { get; set; }
        public decimal SgaPct { get; set; }
        public decimal RdPct { get; set; }
        public decimal OtherPct { get; set; }
        public decimal OperatingMarginPct { get; set; }
        public decimal NetIntIncOtherPct { get; set; }
        public decimal EbtPct { get; set; }

        #endregion MarginOfSalesPct

        #region Profitablitly

        public decimal TaxRatePct { get; set; }
        public decimal NetMarginPct { get; set; }
        public decimal AssetTurnoverAvg { get; set; }
        public decimal ReturnOnAssetsPct { get; set; }
        public decimal FinancialLeverageAvg { get; set; }
        public decimal ReturnOnEquityPct { get; set; }
        public decimal ReturnOnInvestedCapitalPct { get; set; }
        public decimal InterestCoverage { get; set; }

        #endregion Profitablity

    }
}
