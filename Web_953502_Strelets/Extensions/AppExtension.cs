using Microsoft.AspNetCore.Builder;
using Web_953502_Strelets.Middleware;

namespace Web_953502_Strelets.Extensions
{
    public static class AppExtension
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}
