using System.ComponentModel.DataAnnotations;

namespace Blogs.Domain.Authors
{
    public class Author
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Author( string name )
        {
            Name = name;
        }

        public void UpdateName( string name )
        {
            Name = name;
        }
    }
}
