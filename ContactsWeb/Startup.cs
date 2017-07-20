using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsWeb.Startup))]
namespace ContactsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
