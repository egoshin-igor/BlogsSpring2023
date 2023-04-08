using Blogs.Api.Dtos;
using Blogs.Api.Mappers;
using Blogs.Application;
using Blogs.Application.AuthorsCreating;
using Blogs.Domain.Authors;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Api.Controllers
{
    [ApiController]
    [Route( "authors" )]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IAuthorCreator _authorCreator;
        private readonly IUnitOfWork _unitOfWork;

        public AuthorController(
            IAuthorRepository authorRepository,
            IAuthorCreator authorCreator,
            IUnitOfWork unitOfWork )
        {
            _authorRepository = authorRepository;
            _authorCreator = authorCreator;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public List<AuthorDto> GetAll()
        {
            IReadOnlyList<Author> authors = _authorRepository.GetAll();

            return authors.Select( x => x.Map() ).ToList();
        }

        [HttpGet( "{id}" )]
        public AuthorDto GetById( [FromRoute] int id )
        {
            Author author = _authorRepository.GetById( id );

            return author.Map();
        }

        [HttpPost]
        public void Add( [FromBody] AddAuthorCommandDto command )
        {
            _authorCreator.Create( command.Map() );
            _unitOfWork.Commit();
        }

        [HttpDelete( "{id}" )]
        public void DeleteById( [FromRoute] int id )
        {

        }


        [HttpPut( "{id}" )]
        public void Update( [FromBody] object command )
        {

        }
    }
}
