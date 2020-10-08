using System.Threading.Tasks;
using Tripoint.Test.StockBalance.Models;

namespace Tripoint.Test.StockBalance.Remote
{
    public interface IRemoteStockService
    {
        public Task<StockBalanceDetails> GetBalance(string articleName);
    }
}