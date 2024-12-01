using MediatR;
using MyPortfolio.Application.Services;
using MyPortfolio.Domain.Entities;

namespace MyPortfolio.Application.ProjectManagement.Queries
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, List<Projects>>
    {
        private readonly IProjectService _projectService;

        public GetAllProjectsQueryHandler(IProjectService projectService)
        {
            _projectService = projectService;
        }


        public async Task<List<Projects>> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
        {
            return await _projectService.GetAllProjectsAsync();

        }
    }
}
