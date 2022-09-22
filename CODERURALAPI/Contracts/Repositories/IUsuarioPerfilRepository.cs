using CODERURALAPI.Entidades;

namespace CODERURALAPI.Contracts.Repositories
{
    public interface IUsuarioPerfilRepository
    {
        Task CadastrarAsync(UsuarioPerfil usarioperfil);
        Task AtualizarAsync(UsuarioPerfil usarioperfil);
        Task ExcluirAsync(UsuarioPerfil usarioperfil);
        Task<List<UsuarioPerfil>> BuscarTodosAsync();
        Task<UsuarioPerfil> BuscarPorIdAsync(Guid id);
    }
}
