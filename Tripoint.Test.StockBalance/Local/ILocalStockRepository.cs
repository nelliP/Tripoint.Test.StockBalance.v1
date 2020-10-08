using System.Threading.Tasks;
using Tripoint.Test.StockBalance.Models;

namespace Tripoint.Test.StockBalance.Local
{
    public interface ILocalStockRepository
    {
        public Task<StockBalanceDetails> GetBalance(string articleName);
    }
}