using Blogs.Domain.Authors;

namespace Blogs.Application.AuthorsCreating
{
    public interface IAuthorCreator
    {
        void Create( AddAuthorCommand command );
    }

    public class AuthorCreator : IAuthorCreator
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorCreator( IAuthorRepository authorRepository )
        {
            _authorRepository = authorRepository;
        }

        public void Create( AddAuthorCommand command )
        {
            var author = new Author( command.Name );

            _authorRepository.Add( author );
        }
    }
}
