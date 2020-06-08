using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab04.Startup))]
namespace Lab04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
