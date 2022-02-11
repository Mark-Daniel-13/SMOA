using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMOA.Web.Startup))]
namespace SMOA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
