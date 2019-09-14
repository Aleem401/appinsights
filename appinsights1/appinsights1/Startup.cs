using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appinsights1.Startup))]
namespace appinsights1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
