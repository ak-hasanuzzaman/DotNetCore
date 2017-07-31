using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreWebApp
{
    public class ErrorLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                //await context.Response.WriteAsync($"The following error happened: {ex}");
                await context.Response.WriteAsync($"The following error happened: {ex}");

            }
        }
    }
}
