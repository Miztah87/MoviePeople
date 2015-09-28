using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestForCompulsory.Startup))]
namespace TestForCompulsory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
