namespace Blogs.Domain.Authors
{
    public interface IAuthorRepository
    {
        IReadOnlyList<Author> GetAll();
        Author GetById( int id );
        void Add( Author author );
        void Delete( Author author );
    }
}
