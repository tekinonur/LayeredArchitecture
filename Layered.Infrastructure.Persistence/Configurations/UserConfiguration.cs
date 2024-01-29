using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Layered.Domain.Entities;

namespace Layered.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // User entity konfigürasyonları
        // Örneğin, anahtarlar, ilişkiler, alan adları vb.
    }
}
