namespace SistemaPacientes.Domain.Entities;

public class Medico
{
    public int Id { get; set; }
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string NumeroColegiado { get; set; } = string.Empty;

    public int EspecialidadId { get; set; }
    public Especialidad? Especialidad { get; set; }

    public bool EstaActivo { get; set; } = true;
}