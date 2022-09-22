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
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new UsuarioPerfilMap());
        }
        public DbSet<Sala> Salas{ get; set; }
        public DbSet<UsuarioPerfil> UsuariosPerfis { get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Perfil> Perfis { get; set; }
    }

}
