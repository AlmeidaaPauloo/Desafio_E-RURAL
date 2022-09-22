using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.Data.Context;
using CODERURALAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CODERURALAPI.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _dbContext;
        public UsuarioRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task CadastrarAsync(Usuario usuario)
        {
            _dbContext.Entry(usuario).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Usuario usuario)
        {
            _dbContext.Entry(usuario).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task ExcluirAsync(Usuario usuario)
        {
            _dbContext.Entry(usuario).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Usuario>> BuscarTodosAsync()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario> BuscarPorIdAsync(Guid id)
        {
            return await _dbContext.Usuarios.FindAsync(id);
        }             
    }
}
