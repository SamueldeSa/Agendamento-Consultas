using AgendamentoDeConsultas.Models;

namespace AgendamentoDeConsultas.Repositories.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetAllAsync();
        Task<Paciente> GetByIdAsync(int id);
        Task<Paciente> CreateAsync(Paciente paciente);
        Task<Paciente> UpdateAsync(Paciente paciente);  
        Task<bool> DeleteAsync(int id);
    }
}
