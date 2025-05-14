using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SimpleCRM.Data;

public class AppDbContext : DbContext
{
    private readonly string _connectionString;

    public AppDbContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }
}