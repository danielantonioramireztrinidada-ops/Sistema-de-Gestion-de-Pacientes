namespace SistemaPacientes.Domain.Entities;

public class Paciente
{
    public int Id { get; set; }
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string Direccion { get; set; } = string.Empty;
    public string Sexo { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; } = DateTime.Now;
}