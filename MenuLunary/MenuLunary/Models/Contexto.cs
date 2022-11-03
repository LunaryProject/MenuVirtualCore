using Microsoft.EntityFrameworkCore;

namespace MenuLunary.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        
        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<Estabelicimento> Estabelicimento { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Campanhas> Campanhas { get; set; }


    }
}
