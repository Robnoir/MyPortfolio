using MyPortfolio.Domain.Entities;

namespace MyPortfolio.Application.Services
{
    public interface IProjectService
    {
        Task<Guid> CreateProjectAsync(string title, string description, string link);
        Task<List<Projects>> GetAllProjectsAsync();
        Task<Projects?> GetProjectByIdAsync(Guid id);

    }
}
