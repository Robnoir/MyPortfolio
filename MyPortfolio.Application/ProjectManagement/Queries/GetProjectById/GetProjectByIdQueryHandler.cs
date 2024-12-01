using MediatR;
using MyPortfolio.Application.Services;
using MyPortfolio.Domain.Entities;

namespace MyPortfolio.Application.ProjectManagement.Queries.GetProjectById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, Projects>
    {
        private readonly IProjectService _projectService;

        public GetProjectByIdQueryHandler(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task<Projects> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            return await _projectService.GetProjectByIdAsync(request.Id);
        }
    }
}
