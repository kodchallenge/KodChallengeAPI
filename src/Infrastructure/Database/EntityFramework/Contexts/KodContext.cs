﻿using Kod.Domain.Models;
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

        public virtual DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public virtual DbSet<User> Users{ get; set; }
    }
}