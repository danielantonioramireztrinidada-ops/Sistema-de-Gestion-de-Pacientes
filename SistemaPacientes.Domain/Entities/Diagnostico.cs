namespace SistemaPacientes.Domain.Entities;

public class Diagnostico
{
    public int Id { get; set; }

    public int HistorialMedicoId { get; set; }
    public HistorialMedico? HistorialMedico { get; set; }

    public int MedicoId { get; set; }
    public Medico? Medico { get; set; }

    public DateTime FechaDiagnostico { get; set; } = DateTime.Now;

    public string Descripcion { get; set; } = string.Empty;
    public string Observaciones { get; set; } = string.Empty;
}