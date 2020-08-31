using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVL.WebUI.Startup))]
namespace AVL.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
