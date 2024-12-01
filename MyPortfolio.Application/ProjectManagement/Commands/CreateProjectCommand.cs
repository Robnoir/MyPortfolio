using MediatR;

namespace MyPortfolio.Application.ProjectManagement.Commands
{
    public class CreateProjectCommand : IRequest<Guid>
    {
        public string Title { get; }
        public string Description { get; }

        public string Link { get; }

        public CreateProjectCommand(string title, string description, string link)
        {
            Title = title;
            Description = description;
            Link = link;



        }
    }
}
