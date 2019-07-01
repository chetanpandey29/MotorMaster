using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MM.Web.Startup))]
namespace MM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
