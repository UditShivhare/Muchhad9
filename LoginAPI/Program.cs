// See https://aka.ms/new-console-template for more information

using LoginAPI.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace LoginAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LoginAPIContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LoginAPIDB")));
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost =>
            {
                webHost.UseStartup<Startup>();
            });
        }
    }
}
