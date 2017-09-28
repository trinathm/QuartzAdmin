using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuartzAdmin.Web.Startup))]
namespace QuartzAdmin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
