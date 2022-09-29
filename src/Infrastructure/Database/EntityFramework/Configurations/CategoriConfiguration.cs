using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kod.Infrastructure.Database.EntityFramework.Configurations
{
    public class CategoriConfiguration : IEntityTypeConfiguration<Categori>
    {
        public void Configure(EntityTypeBuilder<Categori> builder)
        {
            // TODO: Ad Configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(24).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(24).IsRequired();
        }
    }
}
