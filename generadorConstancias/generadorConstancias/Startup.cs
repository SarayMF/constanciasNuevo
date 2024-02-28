using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(generadorConstancias.Startup))]
namespace generadorConstancias
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
