using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bsfpractice1.Startup))]
namespace bsfpractice1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
