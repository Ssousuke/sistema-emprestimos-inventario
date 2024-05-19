using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ConfigEntity
{
    public class CategoriaConfigEntity : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataCriacao).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.DataAtualizacao).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.NomeCategoria).HasMaxLength(25).IsRequired();
        }
    }
}
