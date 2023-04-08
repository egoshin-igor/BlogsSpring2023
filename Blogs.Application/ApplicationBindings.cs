using Blogs.Application.AuthorsCreating;
using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Application
{
    public static class ApplicationBindings
    {
        public static IServiceCollection AddApplication( this IServiceCollection services )
        {
            services.AddAuthorsCreating();

            return services;
        }
    }
}
