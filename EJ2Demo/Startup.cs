using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EJ2Demo.Startup))]
namespace EJ2Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
