using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSF_Project.Startup))]
namespace BSF_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
