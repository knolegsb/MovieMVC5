using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieMVC5.Startup))]
namespace MovieMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
