using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sales1.Backend.Startup))]
namespace Sales1.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
