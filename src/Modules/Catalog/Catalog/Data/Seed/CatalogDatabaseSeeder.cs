using Shared.Data.Seed;

namespace Catalog.Data.Seed;

public class CatalogDatabaseSeeder(CatalogDbContext context) : IDatabaseSeeder
{
    public async Task SeedAllAsync()
    {
        if (!await context.Products.AnyAsync())
        {
            await context.Products.AddRangeAsync(InitialData.Products);
            await context.SaveChangesAsync();
        }
    }
}