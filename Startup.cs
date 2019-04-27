using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sound_Fury.Startup))]
namespace Sound_Fury
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
