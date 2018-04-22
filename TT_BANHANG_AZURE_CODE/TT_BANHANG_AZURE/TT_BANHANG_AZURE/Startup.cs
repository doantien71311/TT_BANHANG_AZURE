using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TT_BANHANG_AZURE.Startup))]
namespace TT_BANHANG_AZURE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
