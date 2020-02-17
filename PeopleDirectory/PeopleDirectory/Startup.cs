using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeopleDirectory.Startup))]
namespace PeopleDirectory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
