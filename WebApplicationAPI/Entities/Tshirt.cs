namespace WebApplicationAPI.Entities
{
    public class Tshirt
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public IEnumerable<Color> Colors { get; set; } = new List<Color>();
        public IEnumerable<Fabric> Fabrics { get; set; } = new List<Fabric>();
        public IEnumerable<TshirtImage> TshirtImages { get; set; } = new List<TshirtImage>();

        public Tshirt() { }

        public Tshirt(string code, string modelName)
        {
            Code = code;
            ModelName = modelName;
        }

        public void AttributeColors(IEnumerable<Color> colors)
            => Colors = colors;

        public void AttributeFabrics(IEnumerable<Fabric> fabrics)
            => Fabrics = fabrics;
    }
}