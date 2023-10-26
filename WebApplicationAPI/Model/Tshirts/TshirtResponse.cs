using WebApplicationAPI.Entities;
using WebApplicationAPI.Model.Colors;
using WebApplicationAPI.Model.Fabrics;
using WebApplicationAPI.Model.TshirtImages;

namespace WebApplicationAPI.Model.Tshirts
{
    public class TshirtResponse
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public IEnumerable<ColorResponse> Colors { get; set; } = new List<ColorResponse>();
        public IEnumerable<FabricResponse> Fabrics { get; set; } = new List<FabricResponse>();
        public IEnumerable<TshirtImageResponse> TshirtImages { get; set; } = new List<TshirtImageResponse>();
        public int ColorsNumber { get; set; }
        public int FabricsNumber { get; set; }
        public int TshirtImagesNumber { get; set; }

        public TshirtResponse(Tshirt tshirt)
        {
            Id = tshirt.Id;
            Code = tshirt.Code;
            ModelName = tshirt.ModelName;
            Colors = ColorResponseMapper.Map(tshirt.Colors);
            Fabrics = FabricResponseMappers.Map(tshirt.Fabrics);
            TshirtImages = TshirtImageResponseMapper.Map(tshirt.TshirtImages);
            ColorsNumber = tshirt.Colors.Count();
            FabricsNumber = tshirt.Fabrics.Count();
            TshirtImagesNumber = tshirt.TshirtImages.Count();
        }
    }
}