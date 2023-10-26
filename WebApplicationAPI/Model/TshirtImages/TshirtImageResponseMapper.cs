using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Model.TshirtImages
{
    public class TshirtImageResponseMapper
    {
        public static IEnumerable<TshirtImageResponse> Map(IEnumerable<TshirtImage> tshirtImages)
            => tshirtImages.Select(Map);

        public static TshirtImageResponse Map(TshirtImage tshirtImage)
        {
            if (tshirtImage is null)
                throw new Exception("Image not found.");

            return new TshirtImageResponse(tshirtImage);
        }
    }
}