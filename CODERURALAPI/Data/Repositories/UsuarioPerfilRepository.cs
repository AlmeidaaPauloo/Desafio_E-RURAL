using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.Data.Context;
using CODERURALAPI.Entidades;

namespace CODERURALAPI.Data.Repositories
{
    public class UsuarioPerfilRepository : IUsuarioPerfilRepository
    {
        private readonly DataContext _dbContext;

        public UsuarioPerfilRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Task CadastrarAsync(UsuarioPerfil usarioperfil)
        {
            throw new NotImplementedException();
        }
        public Task AtualizarAsync(UsuarioPerfil usarioperfil)
        {
            throw new NotImplementedException();
        }
        public Task ExcluirAsync(UsuarioPerfil usarioperfil)
        {
            throw new NotImplementedException();
        }
        public Task<List<UsuarioPerfil>> BuscarTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioPerfil> BuscarPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }    
    }
}
