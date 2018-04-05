using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bus_Reservation_System.Startup))]
namespace Bus_Reservation_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
