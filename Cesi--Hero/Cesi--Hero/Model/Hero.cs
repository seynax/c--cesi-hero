using System.Collections.Generic;

namespace Cesi__Hero.Model
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Power> Powers { get; set; }
        public School School { get; set; }

        public Hero(int id, string name, School school)
        {
            Id = id;
            Name = name;
            School = school;
            Powers = new List<Power>(); 
        }
    }
}
