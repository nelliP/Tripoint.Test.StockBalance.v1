using System.Threading.Tasks;

namespace Tripoint.Test.StockBalance.Remote
{
    public interface IRemoteStockService
    {
        public Task<StockBalanceDetails> GetBalance(string articleName);
    }
}