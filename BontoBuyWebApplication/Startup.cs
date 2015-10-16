using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BontoBuyWebApplication.Startup))]
namespace BontoBuyWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
