using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movielogue.Web.Startup))]
namespace Movielogue.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
