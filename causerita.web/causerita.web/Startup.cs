using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(causerita.web.Startup))]
namespace causerita.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
