using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Model.TshirtImages
{
    public class TshirtImageResponse
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int TshirtId { get; set; }
        public int ColorId { get; set; }
        public int FabricId { get; set; }


        public TshirtImageResponse(TshirtImage tshirtImage)
        {
            Id = tshirtImage.Id;
            Url = tshirtImage.Url;
            TshirtId = tshirtImage.TshirtId;
            ColorId = tshirtImage.ColorId;
            FabricId = tshirtImage.FabricId;
        }
    }
}