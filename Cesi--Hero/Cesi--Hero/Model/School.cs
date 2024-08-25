using System.Collections.Generic;

namespace Cesi__Hero.Model
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // Navigation property for one-to-many relationship
        public ICollection<Hero> Heroes { get; set; }
        public School(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
            Heroes = new List<Hero>(); 
        }
    }
}

