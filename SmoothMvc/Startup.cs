using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmoothMvc.Startup))]
namespace SmoothMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
