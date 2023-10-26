using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Model.Tshirts
{
    public class TshirtResponseMapper
    {
        public static IEnumerable<TshirtResponse> Map(IEnumerable<Tshirt> tshirts)
            => tshirts.Select(Map);

        public static TshirtResponse Map(Tshirt tshirt)
        {
            if (tshirt is null)
                throw new Exception("T-shirt not found.");

            return new TshirtResponse(tshirt);
        }
    }
}