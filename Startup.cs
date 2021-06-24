using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB23.Startup))]
namespace LAB23
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
