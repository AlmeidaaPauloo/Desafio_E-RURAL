using CODERURALAPI.Entidades;

namespace CODERURALAPI.Contracts.Repositories
{
    public interface IPerfilRepository
    {
        Task CadastrarAsync(Perfil perfil);
        Task AtualizarAsync(Perfil perfil);
        Task ExcluirAsync(Perfil perfil);
        Task<List<Perfil>> BuscarTodosAsync();
        Task<Perfil> BuscarPorIdAsync(Guid id);
    }
}
    
