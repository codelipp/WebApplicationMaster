using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Model.Fabrics
{
    public class FabricResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public FabricResponse(Fabric fabric)
        {
            Id = fabric.Id;
            Name = fabric.Name;
        }
    }
}