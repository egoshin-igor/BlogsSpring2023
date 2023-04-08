using Blogs.Infrastructure.Data.Authors;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Infrastructure.Foundation
{
    public class BlogsDbContext : DbContext
    {
        public BlogsDbContext( DbContextOptions options ) : base( options )
        {
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfigurationsFromAssembly( typeof( AuthorConfiguration ).Assembly );
        }
    }
}
