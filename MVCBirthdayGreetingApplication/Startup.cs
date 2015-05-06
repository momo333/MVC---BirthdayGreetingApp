using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BirthdayGreetingAPI.Startup))]
namespace BirthdayGreetingAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
