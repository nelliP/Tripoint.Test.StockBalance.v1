using System.Threading.Tasks;

namespace Tripoint.Test.StockBalance.Local
{
    public interface ILocalStockRepository
    {
        public Task<StockBalanceDetails> GetBalance(string articleName);
    }
}