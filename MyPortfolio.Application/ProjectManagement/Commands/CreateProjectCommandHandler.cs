using MediatR;
using MyPortfolio.Application.Services;

namespace MyPortfolio.Application.ProjectManagement.Commands
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Guid>
    {
        private readonly IProjectService _projectService;

        public CreateProjectCommandHandler(IProjectService projectService)
        {
            _projectService = projectService;
        }


        public async Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var projectId = await _projectService.CreateProjectAsync(request.Title, request.Description, request.Link);
            return projectId;
        }
    }
}
