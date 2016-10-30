using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstadoCidade.Startup))]
namespace EstadoCidade
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
