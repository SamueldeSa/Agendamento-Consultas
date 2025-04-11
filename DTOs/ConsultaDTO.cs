namespace AgendamentoDeConsultas.DTOs
{
    public class ConsultaDTO
    {
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime DataHora { get; set; }
    }
}
