using EZching.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZching.Api
{
    public static class ServiceExtensions
    {
        //Extended this Startup class's service method to just call this method from ConfigureSerivce method
        //to avoid much code in startup class

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EZching.Api", Version = "v1" });
            });
        }

        public static void ConfigureCORs(this IServiceCollection services)
        {
            //CORS - cross origin resource sharing - used to allow or disallow api access (e.g. in company to thirdparty)
            services.AddCors(o =>
            {
                o.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:4000", "https://EZching.com", "http://localhost:60477")
                    .SetIsOriginAllowedToAllowWildcardSubdomains()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials());
            });
        }

        public static void ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EZChingContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DevConnection"));
            });
        }
    }
}
