namespace SistemaPacientes.Domain.Entities;

public class HistorialMedico
{
    public int Id { get; set; }

    public int PacienteId { get; set; }
    public Paciente? Paciente { get; set; }

    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    public string AntecedentesPersonales { get; set; } = string.Empty;
    public string AntecedentesFamiliares { get; set; } = string.Empty;
    public string Alergias { get; set; } = string.Empty;
    public string Observaciones { get; set; } = string.Empty;
}