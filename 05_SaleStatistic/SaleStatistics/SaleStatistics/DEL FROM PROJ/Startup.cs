using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaleStatistics.Startup))]
namespace SaleStatistics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
