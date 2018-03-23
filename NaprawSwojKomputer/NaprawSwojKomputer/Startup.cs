using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NaprawSwojKomputer.Startup))]
namespace NaprawSwojKomputer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
