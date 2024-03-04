using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeCalm.Infrastructure.Data
{
    public static class RegistrationExtensions
    {
        public static void AddStorage(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<BeCalmDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
