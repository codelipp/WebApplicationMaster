using System.Net.Mail;
using WebApplicationAPI.Data;
using WebApplicationAPI.Entities;
using WebApplicationAPI.Model.Tshirts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPI.Controllers
{
    [Route("tshirt-images")]
    [ApiController]
    public class TshirtImageController : ControllerBase
    {
        private readonly DataContext _context;

        public TshirtImageController(DataContext context)
        {
            _context = context;
        }

        [HttpPut("{tshirtId}/{colorId}/{fabricId}")]
        public async Task<TshirtResponse> UploadAsync(IFormFile file, [FromRoute] int tshirtId, int colorId, int fabricId)
        {
            if (file.Length > 2097152)
                throw new SmtpException("File is too large.");

            var filePath = Path.GetTempFileName();

            using (var stream = System.IO.File.Create(filePath))
            {
                await file.CopyToAsync(stream);
            }

            var tshirt = await _context.Tshirts
                .Include(x => x.Colors)
                .Include(x => x.Fabrics)
                .Include(x => x.TshirtImages)
                .FirstOrDefaultAsync(x => x.Id == tshirtId);
            
            if (tshirt is null)
                throw new SmtpException("T-Shirt could not been found.");

            var color = await _context.Colors.FirstOrDefaultAsync(x => x.Id == colorId);
            if (color is null)
                throw new SmtpException("Color could not been found.");

            var fabric = await _context.Fabrics.FirstOrDefaultAsync(x => x.Id == fabricId);
            if (fabric is null)
                throw new SmtpException("Fabric could not been found.");

            var tshirtImage = new TshirtImage(filePath, tshirt, color, fabric);

            _context.TshirtImages.Add(tshirtImage);
            await _context.SaveChangesAsync();

            return TshirtResponseMapper.Map(tshirt);
        }

        [HttpGet("{id}")]
        public async Task<FileStreamResult> GetAsync([FromRoute] int id)
        {
            var tshirtImage = await _context.TshirtImages.FirstOrDefaultAsync(x => x.Id == id);
            if (tshirtImage is null)
                throw new SmtpException("Image could not been found.");

            return new FileStreamResult(System.IO.File.OpenRead(tshirtImage.Url), "image/png");
        }

        [HttpDelete("{id}")]
        public async Task<TshirtResponse> DeleteAsync([FromRoute] int id)
        {
            var tshirtImage = await _context.TshirtImages
                .Include(x => x.Tshirt)
                    .ThenInclude(x => x.Colors)
                .Include(x => x.Tshirt)
                    .ThenInclude(x => x.Fabrics)
                .Include(x => x.Tshirt)
                    .ThenInclude(x => x.TshirtImages)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (tshirtImage is null)
                throw new SmtpException("T-Shirt image could not been found.");

            var tshirt = tshirtImage.Tshirt;

            _context.TshirtImages.Remove(tshirtImage);
            await _context.SaveChangesAsync();

            return TshirtResponseMapper.Map(tshirt);
        }
    }
}