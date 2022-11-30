using Microsoft.EntityFrameworkCore;
using SistemaDeCadastros.Models;

namespace SistemaDeCadastros.Data
{
    public class DbSistemas : DbContext
    {
        public DbSistemas(DbContextOptions<DbSistemas> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
