using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaMVC.Startup))]
namespace PruebaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
