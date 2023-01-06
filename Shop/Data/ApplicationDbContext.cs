using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models;

namespace Shop.Data;

public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Rating> Ratings => Set<Rating>();
    public DbSet<SaleFact> SaleFacts => Set<SaleFact>();
    public DbSet<Position> Positions => Set<Position>();

    private readonly string _connectionString;

    public ApplicationDbContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Default")!;
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }
}