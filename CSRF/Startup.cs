using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01_Start_Unsecured.Startup))]
namespace _01_Start_Unsecured
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
