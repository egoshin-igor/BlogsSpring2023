using Blogs.Application;

namespace Blogs.Infrastructure.Foundation
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly BlogsDbContext _dbContext;

        public UnitOfWork( BlogsDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
