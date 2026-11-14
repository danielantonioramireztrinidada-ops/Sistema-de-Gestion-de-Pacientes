using SistemaPacientes.Application.DTOs;

namespace SistemaPacientes.Application.Interfaces;

public interface IPacienteService
{
    Task<IEnumerable<PacienteDto>> ObtenerTodosAsync();

    Task<PacienteDto?> ObtenerPorIdAsync(int id);

    Task<PacienteDto> CrearAsync(CrearPacienteDto dto);

    Task<bool> ActualizarAsync(int id, CrearPacienteDto dto);

    Task<bool> EliminarAsync(int id);
}