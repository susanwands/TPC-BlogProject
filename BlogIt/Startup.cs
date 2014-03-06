using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogIt.Startup))]
namespace BlogIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
