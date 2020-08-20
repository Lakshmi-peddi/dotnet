using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieCustomerMvcAppWithAuth.Startup))]
namespace MovieCustomerMvcAppWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
