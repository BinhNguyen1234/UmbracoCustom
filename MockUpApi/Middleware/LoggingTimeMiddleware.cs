using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace MockUpApi.Middleware
{
    public class LoggingTimeMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingTimeMiddleware(RequestDelegate next) => _next = next;
        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Start___________________________");
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(httpContext.Request.Path);
            Console.WriteLine();
            await _next(httpContext);
            Console.WriteLine("End_____________________________");
            Console.WriteLine();
        }
    }
    public static class LogginTimeExtension
    {
        public static void AddLoggingTimeMiddleWare(this WebApplication app) {
            app.UseMiddleware<LoggingTimeMiddleware>();
        }
    }
}
