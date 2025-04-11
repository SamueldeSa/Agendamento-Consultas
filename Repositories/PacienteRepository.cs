using AgendamentoDeConsultas.Data;
using AgendamentoDeConsultas.Models;
using AgendamentoDeConsultas.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoDeConsultas.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {

        private readonly AppDbContext _context;

        public PacienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Paciente>> GetAllAsync()
        {
            return await _context.Paciente.ToListAsync();
        }

        public async Task<Paciente> GetByIdAsync(int id)
        {
            return await _context.Paciente.FindAsync(id);
        }

        public async Task<Paciente> CreateAsync(Paciente paciente)
        {
            _context.Paciente.Add(paciente); // prepara o INSERT
            await _context.SaveChangesAsync(); // executa no banco
            return paciente;
        }

        public async Task<Paciente> UpdateAsync(Paciente paciente)
        {
            _context.Paciente.Update(paciente);
            await _context.SaveChangesAsync();
            return paciente;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var paciente = await _context.Paciente.FindAsync(id);
            if (paciente == null)
            {
                return false; 
            }
            _context.Paciente.Remove(paciente);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
