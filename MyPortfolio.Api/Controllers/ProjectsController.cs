using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Application.ProjectManagement.Commands;
using MyPortfolio.Application.ProjectManagement.Queries;
using MyPortfolio.Application.ProjectManagement.Queries.GetProjectById;
using MyPortfolio.Domain.Entities;

namespace MyPortfolio.Api.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Projects>>> GetAllProjects()
        {
            var result = await _mediator.Send(new GetAllProjectsQuery());
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Projects>> GetProjectById(Guid id)
        {
            var result = await _mediator.Send(new GetProjectByIdQuery(id));
            if (result == null)
            {
                return NotFound($"Project with id {id} not found.");
            }
            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> CreateProject([FromBody] CreateProjectCommand command)
        {
            var projectId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProjectById), new { id = projectId }, projectId);
        }



    }
}
