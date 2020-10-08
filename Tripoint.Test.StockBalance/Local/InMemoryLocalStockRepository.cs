using System.Collections.Generic;
using System.Threading.Tasks;

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
            /*
             * Implement this method as part of your test.
             *
             * The return statement below is just a placeholder in order
             * to be able to compile the project.
             */
            return Task.FromResult(new StockBalanceDetails(default, default));
        }
    }
}