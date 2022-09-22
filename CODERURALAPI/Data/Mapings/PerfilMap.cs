using CODERURALAPI.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CODERURALAPI.Data.Mapings
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>

    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {

            builder.ToTable("Perfil");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}