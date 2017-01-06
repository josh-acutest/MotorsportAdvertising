using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotorsportAdvertising.Startup))]
namespace MotorsportAdvertising
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
