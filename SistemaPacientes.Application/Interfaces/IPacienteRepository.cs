using SistemaPacientes.Domain.Entities;

namespace SistemaPacientes.Application.Interfaces;

public interface IPacienteRepository
{
    Task<List<Paciente>> ObtenerTodosAsync();

    Task<Paciente?> ObtenerPorIdAsync(int id);

    Task AgregarAsync(Paciente paciente);

    void Eliminar(Paciente paciente);

    Task GuardarCambiosAsync();
}