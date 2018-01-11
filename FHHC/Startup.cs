using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FHHC.Startup))]
namespace FHHC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
