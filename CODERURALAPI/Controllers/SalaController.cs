using CODERURALAPI.Contracts.Repositories;
using CODERURALAPI.DTOs;
using CODERURALAPI.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CODERURALAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaController : ControllerBase
    {
        private readonly ISalaRepository _salaRepository;

        public SalaController(ISalaRepository salaRepository)
        {
            _salaRepository = salaRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CadastrarSalaDTO dto)
        {
            try
            {
                var sala = new Sala();
                sala.Id = Guid.NewGuid();
                sala.Name = dto.Name;
                sala.Link = dto.Link;
                await _salaRepository.CadastrarAsync(sala);
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
                return StatusCode(200, await _salaRepository.BuscarTodosAsync());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }            
        }

        [HttpPut]
        public async Task<IActionResult> Put(AtualizarSalaDTO dto)
        {
            try
            {
                var sala = new Sala();
                sala.Id = dto.Id;
                sala.Name = dto.Name;
                sala.Link = dto.Link;
                await _salaRepository.AtualizarAsync(sala);
                return StatusCode(200, "Atualizado com sucesso");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(ConsultarSalaDTO dto)
        {
            try
            {
                var sala = new Sala();
                sala.Id = dto.Id;
                sala.Name = dto.Name;
                sala.Link = dto.Link;
                await _salaRepository.ExcluirAsync(sala);
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
                var sala = await _salaRepository.BuscarPorIdAsync(id);
                var dto = new ConsultarSalaDTO();
                dto.Id = sala.Id;
                dto.Name = sala.Name;
                dto.Link = sala.Link;
                return StatusCode(200, dto);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }            
        }
    }
}
