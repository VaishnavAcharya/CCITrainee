using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoIdentitySecurity.Startup))]
namespace DemoIdentitySecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
