using System.Collections.Generic;
using System.Threading.Tasks;
using Tripoint.Test.StockBalance.Models;
using Tripoint.Test.StockBalance.Utilities;

namespace Tripoint.Test.StockBalance.Remote
{
    /*
     * To keep things simple in this programming test, we fake the
     * remote stock service API by using an in-memory collection of
     * all articles. In a real-world scenario, this class would
     * probably call an external API to retrieve the stock balance.
     */
    public class FakeRemoteStockService : IRemoteStockService
    {
        private readonly Dictionary<string, int> _remoteStock;

        public FakeRemoteStockService()
        {
            _remoteStock = new Dictionary<string, int>
            {
                {"Nishiki All Road", 44},
                {"Speedster Gravel 30", 3},
                {"Merida Reacto Disc 7000-E", 58},
                {"Trek Checkpoint ALR 4", 43}
            };
        }

        public Task<StockBalanceDetails> GetBalance(string articleName)
        {
            int result;

            var key = RetrieveKeyCaseInsensitive.RetrieveKey(articleName, _remoteStock);

            return _remoteStock.TryGetValue(key ?? articleName, out result)
                ? Task.FromResult(new StockBalanceDetails(key, result))
                : null;
        }
    }
}