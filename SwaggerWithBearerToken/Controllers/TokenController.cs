using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.OAuth;
using SwaggerWithBearerToken.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace SwaggerWithBearerToken.Controllers
{
    public class TokenController : ApiController
    {
        public string Get()
        {
            var identity = new ClaimsIdentity("Bearer");
            identity.AddClaim(new Claim(ClaimTypes.Name, "Roy"));

            var ticket = new AuthenticationTicket(identity, new AuthenticationProperties());

            var tokenFormat = Startup.OAuthBearerOptions.AccessTokenFormat;

            var accessToken = tokenFormat.Protect(ticket);

            return accessToken;
        }
    }
}
