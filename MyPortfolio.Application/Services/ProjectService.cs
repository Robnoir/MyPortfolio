using MyPortfolio.Domain.Entities;

namespace MyPortfolio.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly List<Projects> _projects = new();


        public async Task<Guid> CreateProjectAsync(string title, string description, string link)
        {
            var project = new Projects(title, description, link);
            _projects.Add(project);
            return await Task.FromResult(project.Id);
        }

        public async Task<List<Projects>> GetAllProjectsAsync()
        {
            return await Task.FromResult(_projects);
        }


        public async Task<Projects?> GetProjectByIdAsync(Guid id)
        {
            var project = _projects.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(project);

        }

    }
}
