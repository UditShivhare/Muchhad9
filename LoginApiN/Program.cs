

using LoginApiN.Data;
using LoginApiN.Models;
using LoginApiN.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;



var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
// Add services to the container.
//builder.Services.AddDBContext()
builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var connection = Configuration["DbConnectionString"];
//builder.Services.AddDbContext<LoginAPINContext>(options => options.UseSqlServer());
builder.Services.AddDbContext<LoginAPINContext>(options => options.UseSqlServer("Server=LAPTOP-8R42GL8Q;Database=LoginAPIN;Integrated Security=true"));
builder.Services.AddIdentity<ApplicationUser,IdentityRole>()
    .AddEntityFrameworkStores<LoginAPINContext>().AddDefaultTokenProviders();

builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = "http";
    option.DefaultScheme = "https";

}).AddJwtBearer(option =>
{
    option.SaveToken = true;
    option.RequireHttpsMetadata = false;
    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"])),
    };
});


builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddTransient<IAccountRepository, AccountRepository>();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
//app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.Run();
