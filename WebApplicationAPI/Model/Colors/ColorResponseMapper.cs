using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Model.Colors
{
    public class ColorResponseMapper
    {
        public static IEnumerable<ColorResponse> Map(IEnumerable<Color> colors)
            => colors.Select(Map);

        public static ColorResponse Map(Color color)
        {
            if (color is null)
                throw new Exception("Color not found.");

            return new ColorResponse(color);
        }
    }
}