using DirectBusiness.Shared;
using Microsoft.EntityFrameworkCore;

namespace DirectBusiness.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options){}

        public DbSet<Imovel> imoveis { get; set; }
    }
}