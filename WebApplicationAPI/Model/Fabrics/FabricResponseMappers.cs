using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Model.Fabrics
{
    public class FabricResponseMappers
    {
        public static IEnumerable<FabricResponse> Map(IEnumerable<Fabric> fabric)
            => fabric.Select(Map);

        public static FabricResponse Map(Fabric fabric)
        {
            if (fabric is null)
                throw new Exception("Fabric not found.");

            return new FabricResponse(fabric);
        }
    }
}