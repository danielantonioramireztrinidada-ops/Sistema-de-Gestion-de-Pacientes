namespace SistemaPacientes.Domain.Entities;

public class RecetaMedica
{
    public int Id { get; set; }

    public int PacienteId { get; set; }
    public Paciente? Paciente { get; set; }

    public int MedicoId { get; set; }
    public Medico? Medico { get; set; }

    public int CitaId { get; set; }
    public Cita? Cita { get; set; }

    public DateTime FechaEmision { get; set; } = DateTime.Now;

    public string IndicacionesGenerales { get; set; } = string.Empty;
    public string Observaciones { get; set; } = string.Empty;
}