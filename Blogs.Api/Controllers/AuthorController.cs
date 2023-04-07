using Blogs.Api.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Api.Controllers
{
    [ApiController]
    [Route( "authors" )]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public List<AuthorDto> GetAll()
        {
            return new List<AuthorDto>
            {
                new AuthorDto{ Id = 1, Name = "Ivan" }
            };
        }

        [HttpGet( "{id}" )]
        public AuthorDto GetById( [FromRoute] int id )
        {
            return new AuthorDto { Id = id, Name = "Ivan" };
        }

        [HttpDelete( "{id}" )]
        public void DeleteById( [FromRoute] int id )
        {

        }

        [HttpPost]
        public void Add( [FromBody] object command )
        {

        }

        [HttpPut( "{id}" )]
        public void Update( [FromBody] object command )
        {

        }
    }
}
