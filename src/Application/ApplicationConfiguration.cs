using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using Kod.Application.Abstractions.Services;
using Kod.Application.Managers;

namespace Kod.Application
{
    public static class ApplicationConfiguration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddApplicationDependencyInjection();
        }

        public static void AddApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IProgrammingLanguagesService, ProgrammingLanguagesManager>();
            services.AddTransient<IUsersService, UsersManager>();
            services.AddTransient<ICategoriesService, CategoriesManager>();
            services.AddTransient<IProblemsService, ProblemsManager>();
            services.AddTransient<IUserSolutionsService, UserSolutionsManager>();   
            services.AddTransient<IProblemSolutionsService, ProblemSolutionsManager>();
            services.AddTransient<IScriptedProblemsService, ScriptedProblemsManager>();
        }
    }
}
