using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasketballAcademyBlog.Startup))]
namespace BasketballAcademyBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
