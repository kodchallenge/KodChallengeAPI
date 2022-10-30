using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Kod.Infrastructure.Database.EntityFramework.Configurations
{
    public class ProblemsConfiguration : IEntityTypeConfiguration<Problems>
    {
        public void Configure(EntityTypeBuilder<Problems> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(2000);
            
        }
    }
}
