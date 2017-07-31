using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWebApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreWebApp.Middlewares
{
    public class DemoMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IMessage _message;

        public DemoMiddleware(RequestDelegate next, IMessage message)
        {
            _next = next;
            _message = message;
        }
        public async Task Invoke(HttpContext context)
        {
            System.Diagnostics.Debug.WriteLine(_message.CustomMessage());
            await _next(context);
        }
    }
    public static class DemoMiddlewareExtensions
    {
        public static void UseDemoMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<DemoMiddleware>();       
        }
    }
}
