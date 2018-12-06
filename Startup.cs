using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myDempProj.Startup))]
namespace myDempProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
