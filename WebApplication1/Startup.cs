using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinahProject.Startup))]
namespace FinahProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
