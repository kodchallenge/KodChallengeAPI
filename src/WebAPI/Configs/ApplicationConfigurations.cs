using Microsoft.AspNetCore.Rewrite;
using Kod.Core;

namespace Kod.WebAPI.Configs;
public static class ApplicationConfigurations
{
    public static void ApplyConfiguration(this IApplicationBuilder builder)
    {
        builder.UseAuthentication();
        //builder.UseAuthorization();
        builder.ConfigureExceptionMiddleware();
        builder.UseRouting();
        builder.UseCors("CorsPolicity");
        builder.UseHealthChecks("/healthapp");
        builder.UseSwagger();
        builder.UseSwaggerUI();
        builder.UseRewriter(new RewriteOptions().AddRedirect("^$", "swagger"));
    }
}