using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCIProject.Startup))]
namespace TestCIProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
