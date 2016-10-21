using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOM2.Startup))]
namespace SOM2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
