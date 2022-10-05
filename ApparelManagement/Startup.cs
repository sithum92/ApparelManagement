using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApparelManagement.Startup))]
namespace ApparelManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
