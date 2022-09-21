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
            var sala = new Sala();
            sala.Id = Guid.NewGuid();
            sala.Name = dto.Name;
            sala.Link = dto.Link;
            await _salaRepository.CadastrarAsync(sala);
            return StatusCode(200);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return  StatusCode(200, await _salaRepository.BuscarTodosAsync());
        }

        [HttpPut]
        public async Task<IActionResult> Put(AtualizarSalaDTO dto)
        {
            var sala = new Sala();
            sala.Id = dto.Id;
            sala.Name = dto.Name;
            sala.Link = dto.Link;
            await _salaRepository.AtualizarAsync(sala);
            return StatusCode(200);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(ConsultarSalaDTO dto)
        {
            var sala = new Sala();
            sala.Id = dto.Id;
            sala.Name = dto.Name;
            sala.Link = dto.Link;
            await _salaRepository.ExcluirAsync(sala);
            return StatusCode(200);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var sala = await _salaRepository.BuscarPorIdAsync(id);
            var dto = new ConsultarSalaDTO();
            dto.Id = sala.Id;
            dto.Name = sala.Name;
            dto.Link = sala.Link;
            return StatusCode(200, dto);
        }

    }
}
