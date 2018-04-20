using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootData.Startup))]
namespace BootData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
