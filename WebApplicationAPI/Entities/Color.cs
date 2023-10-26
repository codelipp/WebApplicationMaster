namespace WebApplicationAPI.Entities
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Tshirt> Tshirts { get; set; } = new List<Tshirt>();
        public IEnumerable<TshirtImage> TshirtImages { get; set; } = new List<TshirtImage>();

        public Color() { }

        public Color(string name)
        {
            Name = name;
        }
    }
}