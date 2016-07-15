using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MHCloudTest.Startup))]
namespace MHCloudTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
