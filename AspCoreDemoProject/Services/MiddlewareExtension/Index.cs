using AspCoreDemoProject.Services.Pipeline;
using Microsoft.AspNetCore.Builder;

namespace AspCoreDemoProject.Services.MiddlewareExtension
{
    public static class Index
    {
        public static IApplicationBuilder UseHeaderService(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HeaderService>();
        }

        public static IApplicationBuilder UseLogToDataBase(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogToDataBaseService>();
        }

        public static IApplicationBuilder UseLogToFile(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogToFileService>();
        }
    }
}
