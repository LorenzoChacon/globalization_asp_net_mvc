using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobalizationDemo.Startup))]
namespace GlobalizationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
