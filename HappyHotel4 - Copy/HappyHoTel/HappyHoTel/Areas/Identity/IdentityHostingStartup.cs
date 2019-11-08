using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(HappyHoTel.Areas.Identity.IdentityHostingStartup))]
namespace HappyHoTel.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}