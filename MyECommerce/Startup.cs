using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyECommerce.Startup))]
namespace MyECommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
