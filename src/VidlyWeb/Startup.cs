using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyWeb.Startup))]
namespace VidlyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
