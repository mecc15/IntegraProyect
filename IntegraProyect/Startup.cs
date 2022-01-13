using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntegraProyect.Startup))]
namespace IntegraProyect
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
