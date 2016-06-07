using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorteVerde.Startup))]
namespace NorteVerde
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
