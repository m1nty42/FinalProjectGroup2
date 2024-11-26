using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Data;
using Microsoft.AspNetCore.Builder;
using NSwag.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
<<<<<<< HEAD
=======

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

>>>>>>> fd8c11841c5b92f84dc444cc5f4459f79c3e70e6

// Add NSwag services
builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "FinalProjectGroup2 API";
    config.Version = "v1";
});

var app = builder.Build();

// Use CORS
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseOpenApi(); // Generates the OpenAPI/Swagger document
    app.UseSwaggerUi(); // Serves the Swagger UI
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
