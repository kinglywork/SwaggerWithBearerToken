using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerWithBearerToken.Controllers
{
    [Authorize]
    public class ValueController : ApiController
    {
        public string Get()
        {
            return "hello";
        }
    }
}
