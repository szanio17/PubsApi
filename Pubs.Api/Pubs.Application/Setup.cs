using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Pubs.Application
{
    public static class Setup
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
