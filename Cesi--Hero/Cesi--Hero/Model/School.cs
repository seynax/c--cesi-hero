using System.Collections.Generic;

namespace Cesi__Hero.Model
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Hero> Heroes { get; set; }

        public School(int id, string name)
        {
            Id = id;
            Name = name;
            Heroes = new List<Hero>(); 
        }
    }
}

