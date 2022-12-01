using Microsoft.EntityFrameworkCore;
using SistemaDeCadastros.Models;
using SistemaDeCadastros.Data.Map;

namespace SistemaDeCadastros.Data
{
    public class DbSistemas : DbContext
    {
        public DbSistemas(DbContextOptions<DbSistemas> options) : base(options)
        {
        }

        public DbSet<PratosModel> Pratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PratosMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
