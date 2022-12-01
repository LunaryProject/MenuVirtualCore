using SistemaDeCadastros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeCadastros.Data.Map
{
    public class PratosMap : IEntityTypeConfiguration<PratosModel>
    {
        public void Configure(EntityTypeBuilder<PratosModel> builder)
        {
            builder.HasKey(x => x.RESTAUID);
            builder.Property(x => x.RESTANOME).IsRequired();
            builder.Property(x => x.RESTAPRECO).IsRequired();
            builder.Property(x => x.RESTADESCRICAO).IsRequired();
            builder.Property(x => x.RESTACATEGORIA).IsRequired();
            builder.Property(x => x.RESTAPREPROMOCAO).IsRequired();
        }
    }
}
