using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevEvolucional.API.Controllers
{
    [Route("api/skills")]
    public class DisciplinasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DisciplinasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var query = new GetAllSkillsQuery();

        //    var skills = await _mediator.Send(query);

        //    return Ok(skills);
        //}
    }
}
