using System.Web.Http;
using Gencodemy.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Gencodemy.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            WebApiConfig.Register(httpConfiguration);
             
            app
                .UseWebApi(httpConfiguration)
                .UseIoC(httpConfiguration);
        }
    }
}