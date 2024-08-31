[assembly: HostingStartup(typeof(HealthCare.Areas.Identity.IdentityHostingStartup))]
namespace HealthCare.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}