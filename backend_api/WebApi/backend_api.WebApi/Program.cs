using backend_api.Core.DataService;
using backend_api.Core.DataService.EFCore;
using backend_api.Core.DomainService;
using backend_api.DataServices.EFCore;
using backend_api.DataServices.EFCore.DataContext;
using backend_api.DataServices.Interfaces;
using backend_api.DomainServices;
using backend_api.EFCore.Setup;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "backend_api.WebApi",
        Version = "v9.0.32",
        Description =
            "EISK makes it easy to write scalable and secured web api on top of Microsoft's new cutting edge .net based technologies.",
        Contact = new OpenApiContact
        {
            Name = "EISK Web Api",
            Email = string.Empty,
            Url = new Uri("https://backend_api.github.io")
        }
    });
});

//generic services

builder.Services.AddScoped(typeof(IEntityDataService<>), typeof(EntityDataService<>));
builder.Services.AddScoped(typeof(DomainService<,>));

//custom services

builder.Services.AddScoped<AppDbContext, InMemoryDbContext>();
builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();
builder.Services.AddScoped<EmployeeDomainService>();

DbContextDataInitializer.Initialize(new InMemoryDbContext());

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v2");
    options.RoutePrefix = string.Empty;
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();