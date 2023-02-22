using Microsoft.EntityFrameworkCore;

namespace ResimGalerisi.Models
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }

        public DbSet<Resim> Resimler => Set<Resim>();
    }
}
