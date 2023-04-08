using Blogs.Domain.Authors;
using Blogs.Infrastructure.Foundation;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Infrastructure.Data.Authors
{
    internal class AuthorRepository : IAuthorRepository
    {
        private readonly BlogsDbContext _dbContext;

        private DbSet<Author> _authors => _dbContext.Set<Author>();

        public AuthorRepository( BlogsDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public void Add( Author author )
        {
            _authors.Add( author );
        }

        public void Delete( Author author )
        {
            _authors.Remove( author );
        }

        public Author GetById( int id )
        {
            return _authors.SingleOrDefault( a => a.Id == id );
        }

        public IReadOnlyList<Author> GetAll()
        {
            return _authors.ToList();
        }
    }
}
