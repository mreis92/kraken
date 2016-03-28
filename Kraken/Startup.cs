using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kraken.Startup))]
namespace Kraken
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
