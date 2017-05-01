using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoSecurity.Startup))]
namespace DemoSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }
    }
}
