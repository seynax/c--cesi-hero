namespace Cesi__Hero.Model
{
    public class Power
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<Hero> Heroes { get; set; }

        public Power(int id, string name,string description)
        {
            Id = id;
            Name = name;
            Description = description;
            Heroes = new List<Hero>();
        }
    }
}

