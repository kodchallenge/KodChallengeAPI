using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Kod.Infrastructure.Database.EntityFramework.Configurations
{
    public class ProblemsConfiguration : IEntityTypeConfiguration<Problems>
    {
        public void Configure(EntityTypeBuilder<Problems> builder)
        {
            
        }
    }
}
