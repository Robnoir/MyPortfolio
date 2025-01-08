using MediatR;
using System;


namespace MyPortfolio.Application.Projects.Commands 
{
    public class CreateProjectCommand :IRequest<Guid>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;

    }

}