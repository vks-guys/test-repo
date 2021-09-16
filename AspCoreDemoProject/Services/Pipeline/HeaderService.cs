using AspCoreDemoProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspCoreDemoProject.Services.Pipeline
{
    public class HeaderService
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public HeaderService(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            bool IsClientId = context.Request.Headers.ContainsKey("ClientId");
            string ClientValue = _configuration["ClientId"];
            if (IsClientId)
                await _next.Invoke(context);
            else
                await ResponseFormat(context, HttpStatusCode.Forbidden, "ClientId not Found");
        }

        private async Task ResponseFormat(HttpContext context, HttpStatusCode httpStatusCode, string ErrorMessage)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)httpStatusCode;

            var appendError = new ResponseFormatData
            {
                Status = (int)httpStatusCode,
                Message = "Failed",
                Error = ErrorMessage
            };
            var responseBodyStream = context.Response.Body;
            await JsonSerializer.SerializeAsync(responseBodyStream, appendError);
        }
    }
}
