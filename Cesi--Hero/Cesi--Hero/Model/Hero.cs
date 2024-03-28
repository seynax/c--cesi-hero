namespace Cesi__Hero.Model
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Superpower { get; set; }
        public Hero(int id, string name, string superpower)
        {
            Id = id;
            Name = name;
            Superpower = superpower;
        }
    }
}
