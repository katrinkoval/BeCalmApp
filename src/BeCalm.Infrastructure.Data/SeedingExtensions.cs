using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BeCalm.Infrastructure.Data
{
    public static class SeedingExtensions
    {
        public static async Task DatabaseEnsureCreated(this IApplicationBuilder applicationBuilder)
        {
            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<BeCalmDbContext>();
                var database = dbContext.Database;

                await database.EnsureDeletedAsync();
                await database.EnsureCreatedAsync();

            }
        }
    }
}
