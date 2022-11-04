using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Kod.Infrastructure.Database.EntityFramework.Contexts
{
    internal class KodContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
        public KodContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public virtual DbSet<ProgrammingLanguages> languages { get; set; }
        
        public virtual DbSet<Users> users{ get; set; }

        public virtual DbSet<Problems> problems { set; get; }

        public virtual DbSet<Categories> categories { get; set; }

        public virtual DbSet<ScriptedProblems> scripted_problems { set; get; }  

        public virtual DbSet<ProblemSolutions> problem_solutions { set; get; }

        public virtual DbSet<UserSolutions> user_solutions { set; get; }


    }
}
