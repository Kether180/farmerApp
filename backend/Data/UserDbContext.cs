using Microsoft.EntityFrameworkCore;
using Models;
namespace Data;


public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        // Example: Getting connection string from configuration (appsettings.json)
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseNpgsql(connectionString);
    }
}
}