namespace Shared.Data.Seed;

public interface IDatabaseSeeder
{
    Task SeedAllAsync();
}