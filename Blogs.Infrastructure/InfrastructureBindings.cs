using Blogs.Application;
using Blogs.Domain.Authors;
using Blogs.Infrastructure.Data.Authors;
using Blogs.Infrastructure.Foundation;
using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Infrastructure
{
    public static class InfrastructureBindings
    {
        public static IServiceCollection AddInfrastructure( this IServiceCollection services )
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
