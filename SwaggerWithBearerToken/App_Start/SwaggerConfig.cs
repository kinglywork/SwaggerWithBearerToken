using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Swashbuckle.Application;

namespace SwaggerWithBearerToken
{
    public static class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "TestApiWithToken");

                c.ApiKey("Token")
                .Description("Filling bearer token here")
                .Name("Authorization")
                .In("header");
            })
            .EnableSwaggerUi(c =>
            {
                c.EnableApiKeySupport("Authorization", "header");
            });
        }
    }
}
