using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetFranco.Startup))]
namespace NetFranco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
