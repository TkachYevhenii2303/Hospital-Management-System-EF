using Hospital_Management_System_API.CustomMiddlewares;
using Hospital_Management_System_BLL.Services;
using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Generic_Repository_Pattern;
using Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Hospital_Management_System_DAL.Pagination.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;
using System.Reflection;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().WriteTo.File("logs.txt").CreateLogger();

try
{
    Log.Information("Startring the localhost application!");

    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog();

    builder.Services.AddAutoMapper(typeof(Program).Assembly);

    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo()
        {
            Title = "Hospital Management System API",
            Description = "The Hospital Management System API is a powerful and flexible application programming interface (API) built on the .NET framework. It provides a set of web services that allow seamless integration and interaction with the hospital management system, enabling developers to build robust healthcare applications and enhance the functionalities of existing systems. This document serves as a guide for developers, providing an overview of the API and instructions for its usage.",
            Version = "v1"
        });

        var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    });

    builder.Services.AddDbContext<HospitalContext>(configurations =>
    {
        configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            options => options.MigrationsAssembly("Hospital_Management_System_MIG"));
    });

    builder.Services.SetUriConfigurations();

    builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

    builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

    builder.Services.AddScoped<IEmployeesServices, EmployeesServices>();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();

        app.UseSwaggerUI();
    }

    app.UseRouting();

    app.ConfigureExceptionHandler();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
    
    app.Run();
}
catch (Exception exception)
{
    Log.Fatal(exception.Message, "Host terminated unexpectedly!!!");
}
finally { await Log.CloseAndFlushAsync(); }