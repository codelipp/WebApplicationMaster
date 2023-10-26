namespace WebApplicationAPI.Entities
{
    public class TshirtImage
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public int TshirtId { get; set; }
        public Tshirt Tshirt { get; set; } = new Tshirt();
        public int ColorId { get; set; }
        public Color Color { get; set; } = new Color();
        public int FabricId { get; set; }
        public Fabric Fabric { get; set; } = new Fabric();

        private TshirtImage() { }

        public TshirtImage(string url, Tshirt tshirt, Color color, Fabric fabric)
        {
            Url = url;
            Tshirt = tshirt;
            TshirtId = tshirt.Id;
            ColorId = color.Id;
            Color = color;
            FabricId = fabric.Id;
            Fabric = fabric;
        }
    }
}