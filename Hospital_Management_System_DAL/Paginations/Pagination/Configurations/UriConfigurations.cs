using Hospital_Management_System_DAL.Pagination.Services;
using Hospital_Management_System_DAL.Pagination.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Pagination.Configurations
{
    public static class UriConfigurations
    {
        public static void SetUriConfigurations(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<IUriService>(configurations =>
            {
                var accessor = configurations.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext?.Request;
                var uri = string.Concat(request?.Scheme, "://", request?.Host.ToUriComponent());

                return new UriService(uri);
            });
        }
    }
}
