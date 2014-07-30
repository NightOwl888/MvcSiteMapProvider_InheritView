using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSiteMapProvider_InheritView.Startup))]
namespace MvcSiteMapProvider_InheritView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
