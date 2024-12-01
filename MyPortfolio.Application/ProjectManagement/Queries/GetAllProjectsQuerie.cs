using MediatR;
using MyPortfolio.Domain.Entities;

namespace MyPortfolio.Application.ProjectManagement.Queries
{
    public class GetAllProjectsQuery : IRequest<List<Projects>>
    {

    }

}