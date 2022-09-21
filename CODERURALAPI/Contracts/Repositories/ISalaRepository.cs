using CODERURALAPI.Entidades;
using System.Threading.Tasks;

namespace CODERURALAPI.Contracts.Repositories
{
    public interface ISalaRepository
    {
        Task CadastrarAsync(Sala sala);
        Task AtualizarAsync(Sala sala);
        Task ExcluirAsync(Sala sala);        
        Task<List<Sala>> BuscarTodosAsync();
        Task<Sala> BuscarPorIdAsync(Guid id);
    }
}
