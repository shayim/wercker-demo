using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var webhost = new WebHostBuilder()
                .ConfigureServices(config => config.AddMvc())
                .Configure(app =>
                {
                    app.UseMvcWithDefaultRoute();
                    app.Run(async (context) => await context.Response.WriteAsync("Hello World from app run"));
                })
                .UseKestrel()
                .Build();

            webhost.Run();
        }
    }
}
