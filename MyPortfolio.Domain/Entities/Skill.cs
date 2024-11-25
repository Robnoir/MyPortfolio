using System.Diagnostics.Contracts;

namespace MyPortfolio.Domain.Entities
{
    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public int Proficiency { get; set; } // Scale 1-10

        public Skill (string name, int proficiency) 
        {
            Name = name;
            Proficiency = Proficiency;
        } 



    }


}

  