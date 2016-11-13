using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HexeBook_WebApp.Startup))]
namespace HexeBook_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
