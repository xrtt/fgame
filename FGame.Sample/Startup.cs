using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FGame.Sample.Startup))]
namespace FGame.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
