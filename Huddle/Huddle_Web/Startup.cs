using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Huddle_Web.Startup))]
namespace Huddle_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
