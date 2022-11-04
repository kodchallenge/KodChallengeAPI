using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kod.Infrastructure.Database.EntityFramework.Configurations
{
    internal class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            // TODO: Ad Configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");   
            builder.Property(x => x.Name).HasMaxLength(24).IsRequired().HasColumnName("name");
            builder.Property(x => x.Slug).HasMaxLength(24).IsRequired().HasColumnName("slug");
        }
    }
}
