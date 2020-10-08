namespace Tripoint.Test.StockBalance.Models
{
    public class StockBalanceDetails
    {
        public StockBalanceDetails(string articleName, int stockBalance)
        {
            ArticleName = articleName;
            StockBalance = stockBalance;
        }

        public string ArticleName { get; }
        public int StockBalance { get; }
    }
}