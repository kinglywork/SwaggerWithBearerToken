using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(SwaggerWithBearerToken.App_Start.Startup))]
namespace SwaggerWithBearerToken.App_Start
{
    public class Startup
    {
        public static OAuthBearerAuthenticationOptions OAuthBearerOptions = new OAuthBearerAuthenticationOptions();

        public void Configuration(IAppBuilder app)
        {
            app.UseOAuthBearerAuthentication(OAuthBearerOptions);
        }
    }
}