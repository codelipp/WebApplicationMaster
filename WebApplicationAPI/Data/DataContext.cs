using WebApplicationAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Color = WebApplicationAPI.Entities.Color;

namespace WebApplicationAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TshirtImage> TshirtImages => Set<TshirtImage>();
        public DbSet<Tshirt> Tshirts => Set<Tshirt>();
        public DbSet<Color> Colors => Set<Color>();
        public DbSet<Fabric> Fabrics => Set<Fabric>();
    }
}