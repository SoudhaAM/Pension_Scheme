using Microsoft.EntityFrameworkCore;
using PravasiPensionScheme.Data;
using PravasiPensionScheme.Data.UnitOfWorks;
using PravasiPensionScheme.Helpers;
using PravasiPensionScheme.Interfaces;

namespace PravasiPensionScheme.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            return services;
        }
    }
}
