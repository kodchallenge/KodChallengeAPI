﻿using Kod.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Security.Principal;

namespace Kod.Infrastructure.Database.EntityFramework.Contexts
{
    internal class KodContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Categories>().ToTable("categories", "public");
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public KodContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public virtual DbSet<ProgrammingLanguages> languages { get; set; }
        
        public virtual DbSet<Users> users{ get; set; }

        public virtual DbSet<Problems> problems { set; get; }

        public virtual DbSet<Categories> Categories { get; set; }

        public virtual DbSet<ScriptedProblems> scripted_problems { set; get; }  

        public virtual DbSet<ProblemSolutions> problem_solutions { set; get; }

        public virtual DbSet<UserSolutions> user_solutions { set; get; }


    }
}
