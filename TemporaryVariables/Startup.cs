using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemporaryVariables.Startup))]
namespace TemporaryVariables
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
