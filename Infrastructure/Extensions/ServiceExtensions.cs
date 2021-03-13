using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<LibraryContext>(options =>
                options.UseNpgsql(connectionString));
    }
}
