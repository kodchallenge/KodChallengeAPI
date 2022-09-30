
using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kod.Infrastructure.Database.EntityFramework.Configurations
{
    public class ProblemSolutionsConfiguration : IEntityTypeConfiguration<ProblemSolutions>
    {
        public void Configure(EntityTypeBuilder<ProblemSolutions> builder)
        {
            throw new NotImplementedException();
        }
    }
}
