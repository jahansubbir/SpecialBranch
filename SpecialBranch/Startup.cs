using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpecialBranch.Startup))]
namespace SpecialBranch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
