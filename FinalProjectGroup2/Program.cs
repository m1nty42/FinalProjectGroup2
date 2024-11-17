using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Data;
using Microsoft.AspNetCore.Builder;
using NSwag.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FinalProjectGroup2DB"));

// Add NSwag services
builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "FinalProjectGroup2 API";
    config.Version = "v1";
});

var app = builder.Build();

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
