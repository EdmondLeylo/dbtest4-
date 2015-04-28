using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbtest4.Startup))]
namespace dbtest4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
