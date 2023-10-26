namespace WebApplicationAPI.Entities
{
    public class Fabric
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Tshirt> Tshirts { get; set; } = new List<Tshirt>();
        public IEnumerable<TshirtImage> TshirtImages { get; set; } = new List<TshirtImage>();

        public Fabric() { }

        public Fabric(string name)
        {
            Name = name;
        }
    }
}