using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FGame.Startup))]
namespace FGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
