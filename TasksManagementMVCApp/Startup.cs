using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TasksManagementMVCApp.Startup))]
namespace TasksManagementMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
