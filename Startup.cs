using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoletoMVC.Startup))]
namespace BoletoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
