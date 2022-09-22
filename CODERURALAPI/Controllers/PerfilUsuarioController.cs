using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.DTOs;
using CODERURALAPI.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CODERURALAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PerfilUsuarioController : ControllerBase
    {
        private readonly IUsuarioPerfilRepository _perfilusuarioRepository;

        public PerfilUsuarioController(IUsuarioPerfilRepository perfilusuarioRepository)
        {
            _perfilusuarioRepository = perfilusuarioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CadastrarUsuarioPerfilDTO dto)
        {
            try
            {
                var usuarioPerfil = new UsuarioPerfil();
                usuarioPerfil.UsuarioId = Guid.NewGuid();
                usuarioPerfil.PerfilId = Guid.NewGuid();
                usuarioPerfil.Usuario = dto.Usuario;
                usuarioPerfil.Perfil = dto.Perfil;
                await _perfilusuarioRepository.CadastrarAsync(usuarioPerfil);
                return StatusCode(200, "Sala criada com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}