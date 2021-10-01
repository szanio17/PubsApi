using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;

namespace Pubs.Infrastructure
{
    public static class Setup
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services.AddRepositories();
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.RegisterAssemblyPublicNonGenericClasses()
                        .Where(s => s.Name.EndsWith("Repository"))
                        .AsPublicImplementedInterfaces(ServiceLifetime.Scoped);
            return services;
        }
    }
}
