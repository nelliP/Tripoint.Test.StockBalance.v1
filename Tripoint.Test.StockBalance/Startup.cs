using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Tripoint.Test.StockBalance.Local;
using Tripoint.Test.StockBalance.Remote;

namespace Tripoint.Test.StockBalance
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<ILocalStockRepository, InMemoryLocalStockRepository>();
            services.AddScoped<IRemoteStockService, FakeRemoteStockService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}