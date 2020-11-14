using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eagle.Web.Startup))]
namespace Eagle.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
