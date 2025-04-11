using AgendamentoDeConsultas.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoDeConsultas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) { }

        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Consulta> Consultas     { get; set; }

    }
}
