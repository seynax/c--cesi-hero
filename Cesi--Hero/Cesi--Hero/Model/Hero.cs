using System.Collections.Generic; 

namespace Cesi__Hero.Model
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; } // Foreign key for School
        public School School { get; set; } // Navigation property

        // Navigation property for many-to-many relationship
        public ICollection<Power> Powers { get; set; }

        public Hero(int id, string name, School school)
        {
            Id = id;
            Name = name;
            School = school;
            Powers = new List<Power>(); 
        }
    }
}
