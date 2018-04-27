using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(littleP5AccountingWebForm.Startup))]
namespace littleP5AccountingWebForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
