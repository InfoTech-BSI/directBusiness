using DirectBusiness.Shared;
using Microsoft.EntityFrameworkCore;

namespace DirectBusiness.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options){}

        public DbSet<Imovel> Imovel { get; set; }
        //public DbSet<CaracteristicaImovel> CaracteristicaImovel { get; set; }
        //public DbSet<TipoImovel> TipoImovel { get; set; }
        public DbSet<Midia> Midia { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<TipoContrato> TipoContrato { get; set; }
    }
}