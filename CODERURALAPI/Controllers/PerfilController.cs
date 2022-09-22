using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.Data.Repositories;
using CODERURALAPI.DTOs;
using CODERURALAPI.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CODERURALAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerfilController : ControllerBase
    {
        private readonly IPerfilRepository _perfilRepository;

        public PerfilController(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CadastrarPerfilDTO dto)
        {
            try
            {
                var perfil = new Perfil();
                perfil.Id = Guid.NewGuid();
                perfil.Nome = dto.Nome;                
                await _perfilRepository.CadastrarAsync(perfil);
                return StatusCode(200, "Perfil criado com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
