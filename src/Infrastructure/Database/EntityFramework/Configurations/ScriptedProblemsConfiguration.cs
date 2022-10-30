using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kod.Infrastructure.Database.EntityFramework.Configurations
{
    internal class ScriptedProblemsConfiguration : IEntityTypeConfiguration<ScriptedProblems>
    {
        public void Configure(EntityTypeBuilder<ScriptedProblems> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.ProblemId).IsRequired();    
            builder.Property(x => x.LanguageId).IsRequired();   
        }
    }
}
