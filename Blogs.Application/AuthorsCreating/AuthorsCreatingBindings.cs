using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Application.AuthorsCreating
{
    public static class AuthorsCreatingBindings
    {
        public static IServiceCollection AddAuthorsCreating( this IServiceCollection services )
        {
            services.AddScoped<IAuthorCreator, AuthorCreator>();

            return services;
        }
    }
}
