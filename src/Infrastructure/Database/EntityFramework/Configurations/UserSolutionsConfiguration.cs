using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.EntityFramework.Configurations
{
    internal class UserSolutionsConfiguration : IEntityTypeConfiguration<UserSolutions>
    {
        public void Configure(EntityTypeBuilder<UserSolutions> builder)
        {
            throw new NotImplementedException();
        }
    }
}
