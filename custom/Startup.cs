using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(custom.Startup))]
namespace custom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
