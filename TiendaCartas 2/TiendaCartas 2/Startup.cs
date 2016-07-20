using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaCartas_2.Startup))]
namespace TiendaCartas_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
