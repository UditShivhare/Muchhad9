

using LoginApiN.Data;
using LoginApiN.Repository;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDBContext()
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//var connection = Configuration["DbConnectionString"];
//builder.Services.AddDbContext<LoginAPINContext>(options => options.UseSqlServer());
builder.Services.AddDbContext<LoginAPINContext>(options => options.UseSqlServer("Server=DESKTOP-LK9QR3K\\SQLEXPRESS01;Database=LoginAPIN;Integrated Security=true"));
builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
