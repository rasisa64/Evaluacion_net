using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBanco.Startup))]
namespace MVCBanco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
