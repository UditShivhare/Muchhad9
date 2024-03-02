using LoginAPI.Data;
using LoginAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Threading.Tasks;

namespace LoginAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LoginAPIContext>(options => options.UseSqlServer("Server=DESKTOP-LK9QR3K\\SQLEXPRESS01;Database=LoginAPIN;Integrated Security=true"));

            services.AddDbContext<LoginAPIContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LoginAPIDB")));
            //services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LoginAPIDB")));
            services.AddControllers().AddNewtonsoftJson();
            
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IBookRepository,BookRepository>();
             
        }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment environment)
        {
            app.UseRouting();
            //app.MapControllers();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllers();
            //    endpoint.MapGet("/", async context =>
            //{
            //    await context.Response.WriteAsync("Hello from new Loginwebapi");
            //});

            });
           
        }
    }
}
