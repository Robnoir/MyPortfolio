namespace MyPortfolio.Domain.Entities
{
    public class Projects
    {
        public Guid Id { get; set;}
        public string Title {get; set;}
        public string Description { get; private set; }
        public string Link { get; private set; }

        public Projects(string title, string description, string link)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Link = link;
        }
        


        
    }



}

