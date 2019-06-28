using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_VS.Startup))]
namespace MVC_VS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
