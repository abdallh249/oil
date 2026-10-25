
using Microsoft.EntityFrameworkCore;

public static class DatabaseConfiguration
{
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration
            .GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                "Connection string not found.");

        services.AddDbContext<AppDbContext>(options =>
            options.UseMySQL(connectionString));

        return services;
    }
}
