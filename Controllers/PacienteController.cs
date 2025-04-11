using AgendamentoDeConsultas.Models;
using AgendamentoDeConsultas.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AgendamentoDeConsultas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;

        public PacienteController(IPacienteRepository repository)
        {
            _repository = repository;   
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetAll()
        {
            var pacientes = await _repository.GetAllAsync();
            return Ok(pacientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetById(int id)
        {
            var paciente = await _repository.GetByIdAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente); 
        }

        [HttpPost]
        public async Task<ActionResult<Paciente>> Create(Paciente paciente)
        {
            var novoPaciente = await _repository.CreateAsync(paciente);
            return CreatedAtAction(nameof(GetById), new { id = novoPaciente.Id }, novoPaciente);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Paciente>> Update(int id, Paciente paciente)
        {
            if( id != paciente.Id)
            {
                return BadRequest();
            }

            var atualizado = await _repository.UpdateAsync(paciente);
            return Ok(atualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var sucesso = await _repository.DeleteAsync(id);
            if (!sucesso)
            {
                return NotFound();

            }
            return NoContent();
        }



    }
}
