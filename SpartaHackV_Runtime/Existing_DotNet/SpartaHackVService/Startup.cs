using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SpartaHackVService.Startup))]

namespace SpartaHackVService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}