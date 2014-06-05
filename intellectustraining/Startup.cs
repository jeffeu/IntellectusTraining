using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(intellectustraining.Startup))]
namespace intellectustraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
