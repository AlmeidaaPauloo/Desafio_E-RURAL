using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.DTOs;
using CODERURALAPI.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CODERURALAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CadastrarUsuarioDTO dto)
        {
            try
            {
                var usuario = new Usuario();
                usuario.Id = Guid.NewGuid();
                usuario.Name = dto.Name;
                usuario.Email = dto.Email;
                usuario.Senha = dto.Senha;
                await _usuarioRepository.CadastrarAsync(usuario);
                return StatusCode(200, "Sala criada com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return StatusCode(200, await _usuarioRepository.BuscarTodosAsync());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(AtualizarUsuarioDTO dto)
        {
            try
            {
                var usuario = new Usuario();
                usuario.Name = dto.Name;
                usuario.Senha = dto.Senha;
                await _usuarioRepository.AtualizarAsync(usuario);
                return StatusCode(200, "Atualizado com sucesso");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(ConsultarUsuarioDTO dto)
        {
            try
            {
                var usuario = new Usuario();
                usuario.Id = dto.Id;
                usuario.Name = dto.Name;
                usuario.Email = dto.Email;
                await _usuarioRepository.ExcluirAsync(usuario);
                return StatusCode(200, "Excluido com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var usuario = await _usuarioRepository.BuscarPorIdAsync(id);
                var dto = new ConsultarUsuarioDTO();
                dto.Id = usuario.Id;
                dto.Name = usuario.Name;                
                return StatusCode(200, dto);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
