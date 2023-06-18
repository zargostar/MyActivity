using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddInfrastrauctureService();
//builder.Services.AddAutoMapper();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ActivityDbContext>(p=>p.UseSqlServer(builder.Configuration["ActivityDb"]));
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
   
    var context = services.GetRequiredService<ActivityDbContext>();    
   await context.Database.MigrateAsync();
   await SeedData.Craete(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
