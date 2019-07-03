using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Saman.Startup))]
namespace Saman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
