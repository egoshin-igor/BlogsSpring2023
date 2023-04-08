using Blogs.Api.Dtos;
using Blogs.Application.AuthorsCreating;

namespace Blogs.Api.Mappers
{
    public static class AddAuthorCommandMapper
    {
        public static AddAuthorCommand Map( this AddAuthorCommandDto command )
        {
            return new AddAuthorCommand
            {
                Name = command.Name
            };
        }
    }
}
