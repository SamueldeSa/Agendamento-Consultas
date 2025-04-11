namespace AgendamentoDeConsultas.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }

        //Relacionamento com paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        //Relacionamento com medico
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
    }
}
