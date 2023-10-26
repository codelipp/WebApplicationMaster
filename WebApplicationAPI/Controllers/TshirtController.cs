using WebApplicationAPI.Data;
using WebApplicationAPI.Model.Tshirts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPI.Controllers
{
    [Route("tshirts")]
    [ApiController]
    public class TshirtController : ControllerBase
    {
        private readonly DataContext _context;

        public TshirtController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<TshirtResponse>> GetAllAsync()
        {
            var tshirts = await _context.Tshirts
                .Include(x => x.Colors)
                .Include(x => x.Fabrics)
                .Include(x => x.TshirtImages)
                .ToListAsync();

            return TshirtResponseMapper.Map(tshirts);
        }
    }
}