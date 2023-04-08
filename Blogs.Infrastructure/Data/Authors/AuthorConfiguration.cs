using Blogs.Domain.Authors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogs.Infrastructure.Data.Authors
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure( EntityTypeBuilder<Author> builder )
        {
            builder.ToTable( "Author" );

            builder.HasKey( x => x.Id );

            builder.Property( x => x.Name ).HasMaxLength( 200 );
        }
    }
}
