using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Appointment.WebApp.Startup))]
namespace Appointment.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
