using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ConfigEntity
{
    public class EquipamentoConfigEntity : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataCriacao).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.DataAtualizacao).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.NomeEquipamento).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(100);
            builder.Property(x => x.Quantidade);

            builder.HasOne(x => x.Categoria)
                   .WithMany(x => x.Equipamentos)
                   .HasForeignKey(x => x.CategoriaId);
        }
    }
}
