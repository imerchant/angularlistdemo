using System.Web.Http;
using AngularListDemo;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace AngularListDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            app.UseWebApi(config);

            config.EnsureInitialized();
        }
    }
}