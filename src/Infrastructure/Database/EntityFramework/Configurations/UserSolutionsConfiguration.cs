using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.EntityFramework.Configurations
{
    internal class UserSolutionsConfiguration : IEntityTypeConfiguration<UserSolutions>
    {
        public void Configure(EntityTypeBuilder<UserSolutions> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Score).IsRequired();    
            builder.Property(x => x.UserId).IsRequired(); 
            builder.Property(x=> x.SolutionPath).IsRequired();  
        }
    }
}
