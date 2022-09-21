using CODERURALAPI.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CODERURALAPI.Data.Mapings
{
    public class SalaMap : IEntityTypeConfiguration<Sala>

    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Sala");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Link)
                .HasColumnName("Link")
                .HasMaxLength(200)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
