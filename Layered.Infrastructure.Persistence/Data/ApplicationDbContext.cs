using Layered.Domain.Entites;
using Layered.Infrastructure.Persistence.Configurations;

namespace Layered.Infrastructure.Persistence.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    // Diğer DbSet'ler

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Entity konfigürasyonları
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        // Diğer konfigürasyonları ekle
    }
}