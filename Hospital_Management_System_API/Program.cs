using Hospital_Management_System_DAL.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HospitalContext>(configurations =>
{
    configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        options => options.MigrationsAssembly("Hospital_Management_System_Mig"));
});

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