using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hwApp.Startup))]
namespace hwApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
