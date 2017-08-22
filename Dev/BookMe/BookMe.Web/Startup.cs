using BookMe.BusinessLogic;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMe.Web.Startup))]
namespace BookMe.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Mappings.RegisterMappings();
        }
    }
}
