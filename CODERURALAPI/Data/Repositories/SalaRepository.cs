using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.Data.Context;
using CODERURALAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CODERURALAPI.Data.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        private readonly DataContext _dbContext;

        public SalaRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task CadastrarAsync(Sala sala)
        {
            _dbContext.Entry(sala).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Sala sala)
        {
            _dbContext.Entry(sala).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task ExcluirAsync(Sala sala)
        {
            _dbContext.Entry(sala).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Sala>> BuscarTodosAsync()
        {
            return await _dbContext.Salas.ToListAsync();
        }
        public async Task<Sala> BuscarPorIdAsync(Guid id)
        {
            return await _dbContext.Salas.FindAsync(id);
        }
    }
}
