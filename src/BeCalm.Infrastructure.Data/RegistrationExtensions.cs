using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeCalm.Infrastructure.Data
{
    public static class RegistrationExtensions
    {
        public static void AddStorage(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<BeCalmDbContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionStrings:BeCalmConnectionString"]);
            });
        }
    }
}
