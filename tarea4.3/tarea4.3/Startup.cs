using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tarea4._3.Startup))]
namespace tarea4._3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
