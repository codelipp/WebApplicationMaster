using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Model.Colors
{
    public class ColorResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ColorResponse(Color color)
        {
            Id = color.Id;
            Name = color.Name;
        }
    }
}