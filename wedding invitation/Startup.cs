using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wedding_invitation.Startup))]
namespace wedding_invitation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
