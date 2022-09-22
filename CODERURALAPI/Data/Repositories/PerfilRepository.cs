using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.Data.Context;
using CODERURALAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CODERURALAPI.Data.Repositories
{
    public class PerfilRepository : IPerfilRepository
    {
        private readonly DataContext _dbContext;

        public PerfilRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task CadastrarAsync(Perfil perfil)
        {
            _dbContext.Entry(perfil).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Perfil perfil)
        {
            _dbContext.Entry(perfil).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task ExcluirAsync(Perfil perfil)
        {
            _dbContext.Entry(perfil).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }

        public async  Task<List<Perfil>> BuscarTodosAsync()
        {
            return await _dbContext.Perfis.ToListAsync();
        }

        public async Task<Perfil> BuscarPorIdAsync(Guid id)
        {
            return await _dbContext.Perfis.FindAsync(id);
        }
    }
}
