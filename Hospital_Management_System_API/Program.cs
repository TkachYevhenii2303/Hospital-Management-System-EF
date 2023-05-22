using Hospital_Management_System_BLL.Services;
using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Generic_Repository_Pattern;
using Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HospitalContext>(configurations =>
{
    configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        options => options.MigrationsAssembly("Hospital_Management_System_MIG"));
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IEmployeesServices, EmployeesServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();