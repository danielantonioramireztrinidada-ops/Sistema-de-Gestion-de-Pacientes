namespace SistemaPacientes.Domain.Entities;

public class Cita
{
    public int Id { get; set; }

    public int PacienteId { get; set; }
    public Paciente? Paciente { get; set; }

    public int MedicoId { get; set; }
    public Medico? Medico { get; set; }

    public int ConsultorioId { get; set; }
    public Consultorio? Consultorio { get; set; }

    public DateTime FechaHora { get; set; }

    public string Motivo { get; set; } = string.Empty;
    public string Estado { get; set; } = "Pendiente";
    public string Observaciones { get; set; } = string.Empty;
}