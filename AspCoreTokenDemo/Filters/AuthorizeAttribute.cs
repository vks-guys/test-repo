using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspCoreTokenDemo.Filters
{
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var IsAuthenticated = context.HttpContext.User.Identity.IsAuthenticated;
            if (!IsAuthenticated)
            {
                context.Result = new JsonResult(new { message = "Unauthorized", statusCode = 401 }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
