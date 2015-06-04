using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Murray.BingoLotto.Web.Startup))]
namespace Murray.BingoLotto.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
