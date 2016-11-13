using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hexebook.Startup))]
namespace Hexebook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
