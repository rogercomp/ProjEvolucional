using DevEvolucional.API.Models;
using DevEvolucional.Application.Commands.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvolucional.API.Controllers
{
    [Route("api/users")]
    [Authorize]
    public class AlunosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AlunosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //// api/users/1
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var query = new GetUserQuery(id);

        //    var user = await _mediator.Send(query);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(user);
        //}

        // api/users/login
        [HttpPut("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        {
            var loginUserviewModel = await _mediator.Send(command);

            if (loginUserviewModel == null)
            {
                return BadRequest();
            }

            return Ok(loginUserviewModel);
        }
    }
}
