using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaCartas.Startup))]
namespace TiendaCartas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
