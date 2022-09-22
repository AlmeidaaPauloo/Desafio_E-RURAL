using CODERURALAPI.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CODERURALAPI.Data.Mapings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>

    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasMaxLength(200)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
