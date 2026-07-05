using POSBicipartes.Infrastructure.Persistence.Context;

namespace POSBicipartes.Infrastructure.Persistence.Seed;

public static class DbInitializer
{
    public static async Task InitializeAsync(ApplicationDbContext context)
    {
        await context.Database.EnsureCreatedAsync();
    }
}