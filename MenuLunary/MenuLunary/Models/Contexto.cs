using Microsoft.EntityFrameworkCore;

namespace MenuLunary.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Restaurante> Restaurante { get; set; }
    }
}
