using MediatR;
using MyPortfolio.Domain.Entities;
using System;
using System.Data.Common;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MyPortfolio.Application.Projects.Commands  
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Guid>
    {
        public async Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new ProjectsEntities (request.Title, request.Description, request.Link);

            return project.Id;
        }
    }

}