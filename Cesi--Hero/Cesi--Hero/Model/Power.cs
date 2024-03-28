namespace Cesi__Hero.Model
{
    public class Power
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Power(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

