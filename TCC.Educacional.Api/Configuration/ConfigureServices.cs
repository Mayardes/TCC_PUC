using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCC.Educacional.Api.Data;

namespace TCC.Educacional.Api.Configuration
{
    public static class ConfigureServices
    {
        public static void AddConfigurationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EducationalContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("EducationalConnection")));
            services.AddScoped<EducationalContext>();
        }
    }
}
