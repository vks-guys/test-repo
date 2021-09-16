using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AspCoreDemoProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreDemoProject.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Error(int statusCode)
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            switch (statusCode)
            {
                case 404:
                    return Json(new ResponseFormatData() { Message = "Failed", Status = statusCode, Error = "Requested Url not Found!" });
                default:
                    return Json(new ResponseFormatData() { Message = "Failed", Status = (int)HttpStatusCode.InternalServerError, Error = exceptionDetails.Error.Message });
            }
        }

        [Route("Error")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Error()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            return Json(new ResponseFormatData() { Message = "Failed", Status = (int)HttpStatusCode.InternalServerError });
        }
    }
}