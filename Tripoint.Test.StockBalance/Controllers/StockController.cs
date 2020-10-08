using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tripoint.Test.StockBalance.Local;
using Tripoint.Test.StockBalance.Models;
using Tripoint.Test.StockBalance.Remote;

namespace Tripoint.Test.StockBalance.Controllers
{
    [ApiController]
    [Route("stock-balance")]
    public class StockController : ControllerBase
    {
        private readonly ILocalStockRepository _localStockRepository = null;
        private readonly IRemoteStockService _remoteStockService = null;

        public StockController(ILocalStockRepository localStockRepository, IRemoteStockService remoteStockService)
        {
            _localStockRepository = localStockRepository;
            _remoteStockService = remoteStockService;
        }

        [HttpGet]
        [Route("{articleName}")]
        public async Task<IActionResult> Get([FromRoute] string articleName)
        {
            var totalStockBalance = GetTotalStockBalance(articleName);

            if (totalStockBalance == null)
            {
                return NotFound();
            }

            return Ok($"\n'Total stock balance ({totalStockBalance.ArticleName}): {totalStockBalance.StockBalance}'");
        }

        private StockBalanceDetails GetTotalStockBalance(string articleName)
        {
            StockBalanceDetails totalStock = null;
            var localStockBalance = _localStockRepository.GetBalance(articleName)?.Result;
            var remoteStockService = _remoteStockService.GetBalance(articleName)?.Result;
            if (localStockBalance != null || remoteStockService != null)
            {

                int totalStockBalance = 0;
                if (localStockBalance != null && remoteStockService != null)
                {
                    totalStockBalance = localStockBalance.StockBalance + remoteStockService.StockBalance;
                }
                else if (localStockBalance == null)
                {
                    totalStockBalance = remoteStockService.StockBalance;
                }
                else
                {
                    totalStockBalance = localStockBalance.StockBalance;
                }

                totalStock = new StockBalanceDetails(
                    localStockBalance?.ArticleName ?? remoteStockService.ArticleName,
                    totalStockBalance);
            }
            return totalStock;
        }
    }
}