using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models;
using Data;
using Services; // Make sure this is the correct namespace for UserService

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "FarmerApp API",
        Version = "v1"
    });
});

builder.Services.AddDbContext<UserDbContext>();
builder.Services.AddScoped<UserRegistration>(); // Corrected to UserService

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "FarmerApp API V1");
        c.RoutePrefix = string.Empty;
    });
}

// app.UseHttpsRedirection();

// User Management Endpoints
app.MapPost("/users/register", async (User registration, UserRegistration userRegistration) =>
{
    try
    {
        var user = await userRegistration.RegisterUserAsync(registration);
        return Results.Created($"/users/{user.Id}", new { user.Id, user.Name, user.Email });
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});


app.MapGet("/users/{id}", async (int id, UserDbContext dbContext) =>
{
    var user = await dbContext.Users.FindAsync(id);
    if (user == null) return Results.NotFound();
    return Results.Ok(new { user.Id, user.Name, user.Email }); // Exclude sensitive data
});


app.Run();
