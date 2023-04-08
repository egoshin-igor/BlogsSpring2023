using Blogs.Api.Dtos;
using Blogs.Domain.Authors;

namespace Blogs.Api.Mappers
{
    public static class AuthorMapper
    {
        public static AuthorDto Map( this Author author )
        {
            return new AuthorDto
            {
                Id = author.Id,
                Name = author.Name
            };
        }
    }
}
