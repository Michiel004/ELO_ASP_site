using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELOASP.Startup))]
namespace ELOASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
