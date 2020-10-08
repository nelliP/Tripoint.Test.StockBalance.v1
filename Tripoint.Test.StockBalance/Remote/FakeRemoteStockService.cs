using System.Collections.Generic;
using System.Threading.Tasks;

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
        private readonly Dictionary<string, int> _localStock;

        public FakeRemoteStockService()
        {
            _localStock = new Dictionary<string, int>
            {
                {"Nishiki All Road", 44},
                {"Speedster Gravel 30", 3},
                {"Merida Reacto Disc 7000-E", 58},
                {"Trek Checkpoint ALR 4", 43}
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