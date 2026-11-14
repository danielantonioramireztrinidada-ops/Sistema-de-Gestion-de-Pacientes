namespace SistemaPacientes.Domain.Entities;

public class Tratamiento
{
    public int Id { get; set; }

    public int DiagnosticoId { get; set; }
    public Diagnostico? Diagnostico { get; set; }

    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;

    public DateTime FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; }

    public string Indicaciones { get; set; } = string.Empty;
    public string Estado { get; set; } = "Activo";
}