namespace SistemaPacientes.Domain.Entities;

public class Consultorio
{
    public int Id { get; set; }

    public string Numero { get; set; } = string.Empty;
    public string Ubicacion { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;

    public bool EstaDisponible { get; set; } = true;

    public ICollection<Cita> Citas { get; set; } = new List<Cita>();
}