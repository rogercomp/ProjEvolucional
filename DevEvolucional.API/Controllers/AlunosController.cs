using DevEvolucional.API.Models;
using DevEvolucional.Application.Commands.LoginUser;
using DevEvolucional.Application.Commands.CreateUser;
using DevEvolucional.Application.Queries.GetUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using DevEvolucional.Application.Commands.CreateStudent;
using DevEvolucional.Application.Queries;
using DevEvolucional.Application.Queries.GetStudentById;

namespace DevEvolucional.API.Controllers
{
    [Route("api/alunos")]
    [Authorize]
    public class AlunosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AlunosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // api/alunos?query=net core
        [HttpGet]
        //[Authorize(Roles = "client, freelancer")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(string query)
        {
            var getAllStudentsQuery = new GetAllStudentsQuery(query);

            var students = await _mediator.Send(getAllStudentsQuery);

            return Ok(students);
        }

        // api/students
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] CreateStudentCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        // api/alunos/2
        [HttpGet("{id}")]
        //[Authorize(Roles = "client, freelancer")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetStudentByIdQuery(id);

            var aluno = await _mediator.Send(query);

            if (aluno == null)
            {
                return NotFound();
            }

            return Ok(aluno);
        }


    }
}
