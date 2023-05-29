using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Hospital_Management_System_API.CustomMiddlewares
{
    public static class IdentityMiddleware
    {
        public static void IdentityConfigurations(this IServiceCollection services) 
        {
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<HospitalContext>();
        }
    }
}
