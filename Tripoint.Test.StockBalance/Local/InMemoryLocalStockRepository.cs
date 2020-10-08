using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tripoint.Test.StockBalance.Models;
using Tripoint.Test.StockBalance.Utilities;

namespace Tripoint.Test.StockBalance.Local
{
    /*
     * To keep things simple in this programming test, we use an in-memory
     * storage for the local stock. In a real-world scenario, this class would
     * probably access a database.
     */
    public class InMemoryLocalStockRepository : ILocalStockRepository
    {
        private readonly Dictionary<string, int> _localStock;

        public InMemoryLocalStockRepository()
        {
            _localStock = new Dictionary<string, int>
            {
                {"Merida Reacto Disc 7000-E", 15},
                {"Scott Contessa Addict 35 Disc", 5},
                {"Trek Checkpoint ALR 4", 8}
            };
        }

        public Task<StockBalanceDetails> GetBalance(string articleName)
        {            
            int result;

            var key = RetrieveKeyCaseInsensitive.RetrieveKey(articleName, _localStock);

            return _localStock.TryGetValue(key ?? articleName, out result)
                ? Task.FromResult(new StockBalanceDetails(key, result))
                : null;
        }
    }
}