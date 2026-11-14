using SistemaPacientes.Application.DTOs;
using SistemaPacientes.Application.Interfaces;
using SistemaPacientes.Domain.Entities;

namespace SistemaPacientes.Application.Services;

public class PacienteService : IPacienteService
{
    private readonly IPacienteRepository _repository;

    public PacienteService(IPacienteRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PacienteDto>> ObtenerTodosAsync()
    {
        var pacientes = await _repository.ObtenerTodosAsync();

        return pacientes.Select(p => new PacienteDto
        {
            Id = p.Id,
            Nombres = p.Nombres,
            Apellidos = p.Apellidos,
            Cedula = p.Cedula,
            Telefono = p.Telefono,
            Correo = p.Correo,
            FechaNacimiento = p.FechaNacimiento,
            Direccion = p.Direccion,
            Sexo = p.Sexo
        });
    }

    public async Task<PacienteDto?> ObtenerPorIdAsync(int id)
    {
        var paciente = await _repository.ObtenerPorIdAsync(id);

        if (paciente == null)
            return null;

        return ConvertirADto(paciente);
    }

    public async Task<PacienteDto> CrearAsync(CrearPacienteDto dto)
    {
        var paciente = new Paciente
        {
            Nombres = dto.Nombres,
            Apellidos = dto.Apellidos,
            Cedula = dto.Cedula,
            Telefono = dto.Telefono,
            Correo = dto.Correo,
            FechaNacimiento = dto.FechaNacimiento,
            Direccion = dto.Direccion,
            Sexo = dto.Sexo
        };

        await _repository.AgregarAsync(paciente);
        await _repository.GuardarCambiosAsync();

        return ConvertirADto(paciente);
    }

    public async Task<bool> ActualizarAsync(int id, CrearPacienteDto dto)
    {
        var paciente = await _repository.ObtenerPorIdAsync(id);

        if (paciente == null)
            return false;

        paciente.Nombres = dto.Nombres;
        paciente.Apellidos = dto.Apellidos;
        paciente.Cedula = dto.Cedula;
        paciente.Telefono = dto.Telefono;
        paciente.Correo = dto.Correo;
        paciente.FechaNacimiento = dto.FechaNacimiento;
        paciente.Direccion = dto.Direccion;
        paciente.Sexo = dto.Sexo;

        await _repository.GuardarCambiosAsync();

        return true;
    }

    public async Task<bool> EliminarAsync(int id)
    {
        var paciente = await _repository.ObtenerPorIdAsync(id);

        if (paciente == null)
            return false;

        _repository.Eliminar(paciente);
        await _repository.GuardarCambiosAsync();

        return true;
    }

    private static PacienteDto ConvertirADto(Paciente paciente)
    {
        return new PacienteDto
        {
            Id = paciente.Id,
            Nombres = paciente.Nombres,
            Apellidos = paciente.Apellidos,
            Cedula = paciente.Cedula,
            Telefono = paciente.Telefono,
            Correo = paciente.Correo,
            FechaNacimiento = paciente.FechaNacimiento,
            Direccion = paciente.Direccion,
            Sexo = paciente.Sexo
        };
    }
}