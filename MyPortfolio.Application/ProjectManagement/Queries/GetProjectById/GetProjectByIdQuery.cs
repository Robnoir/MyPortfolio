using MediatR;
using MyPortfolio.Domain.Entities;

namespace MyPortfolio.Application.ProjectManagement.Queries.GetProjectById
{
    public class GetProjectByIdQuery : IRequest<Projects>
    {
        public Guid Id { get; }

        public GetProjectByIdQuery(Guid id)
        {
            Id = id;
        }

    }
}
