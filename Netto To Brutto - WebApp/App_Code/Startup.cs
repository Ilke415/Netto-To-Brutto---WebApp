using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Netto_To_Brutto___WebApp.Startup))]
namespace Netto_To_Brutto___WebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
