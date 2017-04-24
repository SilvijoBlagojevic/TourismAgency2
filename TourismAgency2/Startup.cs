using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TourismAgency2.Startup))]
namespace TourismAgency2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
