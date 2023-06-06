using Hospital_Management_System_BLL.Services;
using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces;
using Hospital_Management_System_DAL.Generic_Repository_Pattern;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern;
using Hospital_Management_System_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital_Management_System_WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<HospitalManagementContext>(configurations =>
            {
                configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<IEmployeesServices, EmployeesServices>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}