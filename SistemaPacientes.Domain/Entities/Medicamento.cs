namespace SistemaPacientes.Domain.Entities;

public class Medicamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Presentacion { get; set; } = string.Empty;
    public string Concentracion { get; set; } = string.Empty;

    public string Laboratorio { get; set; } = string.Empty;
    public bool EstaActivo { get; set; } = true;
}