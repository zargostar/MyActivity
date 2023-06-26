using Application;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
    // services.AddMediatR(cfg =>
                // cfg.RegisterServicesFromAssembly(typeof(GetActivitiesQuery).Assembly));
builder.Services.AddControllers();
builder.Services.AddInfrastrauctureService();
builder.Services.AddApplicationService();

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
