using Kod.Application.Abstractions.Repositories;
using Kod.Infrastructure.Database.EntityFramework.Contexts;
using Kod.Infrastructure.Database.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Kod.Infrastructure
{
    public static class InfrastructureConfiguration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDatabases(services, configuration);
            AddInfrastructureDependencies(services);
        }
        
        private static void AddDatabases(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KodContext>(options => {
                options.UseNpgsql(configuration.GetConnectionString("Kod_DevDB"));
                options.UseSnakeCaseNamingConvention();
            });
        }

        private static void AddInfrastructureDependencies(this IServiceCollection services)
        {
            //Repositories
            services.AddScoped<IProgrammingLanguagesRepository, ProgrammingLanguagesRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            services.AddScoped<IProblemsRepository, ProblemsRepository>();   
            services.AddScoped<IUserSolutionsRepository, UserSolutionsRepository>();   
            services.AddScoped<IProblemSolutionsRepository, ProblemSolutionsRepository>();   
            services.AddScoped<IScriptedProblemsRepository, ScriptedProblemsRepository>();   
        }
    }
}
