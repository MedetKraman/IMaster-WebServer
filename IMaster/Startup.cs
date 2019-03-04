using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IMaster.Startup))]
namespace IMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
