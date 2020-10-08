using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tripoint.Test.StockBalance
{
    [ApiController]
    [Route("stock-balance")]
    public class StockController : ControllerBase
    {
        [HttpGet]
        [Route("{articleName}")]
        public async Task<IActionResult> Get([FromRoute] string articleName)
        {
            /*
             * Implement this method.
             */
            return Ok("This is where the stock balance will be returned. Display the result in the format:\n'Total stock balance (Trek Checkpoint ALR 4): 100'");
        }
    }
}