using CODERURALAPI.Data.Mapings;
using CODERURALAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CODERURALAPI.Data.Context
{
    public class DataContext : DbContext

    {
        public DataContext( DbContextOptions<DataContext> options):base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SalaMap());
        }
        public DbSet<Sala> Salas{ get; set; }
    }
}
