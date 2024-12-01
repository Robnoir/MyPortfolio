using MediatR;
using MyPortfolio.Application.Services;

namespace MyPortfolio.Api
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjections).Assembly;

            services.AddMediatR(assembly);
            services.AddScoped<IProjectService, ProjectService>();


            return services;
        }
    }

}
