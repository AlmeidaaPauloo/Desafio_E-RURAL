using CODERURALAPI.Entidades;
using System.Threading.Tasks;

namespace CODERURALAPI.Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        Task CadastrarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
        Task ExcluirAsync(Usuario usuario);
        Task<List<Usuario>> BuscarTodosAsync();
        Task<Usuario> BuscarPorIdAsync(Guid id);
    }
}

