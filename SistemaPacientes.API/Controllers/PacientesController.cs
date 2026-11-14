
using Microsoft.AspNetCore.Mvc;
using SistemaPacientes.Application.DTOs;
using SistemaPacientes.Application.Interfaces;

namespace SistemaPacientes.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PacientesController : ControllerBase
{
    private readonly IPacienteService _service;

    public PacientesController(IPacienteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PacienteDto>>> ObtenerTodos()
    {
        var pacientes = await _service.ObtenerTodosAsync();
        return Ok(pacientes);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<PacienteDto>> ObtenerPorId(int id)
    {
        var paciente = await _service.ObtenerPorIdAsync(id);

        if (paciente == null)
            return NotFound();

        return Ok(paciente);
    }

    [HttpPost]
    public async Task<ActionResult<PacienteDto>> Crear(CrearPacienteDto dto)
    {
        var paciente = await _service.CrearAsync(dto);

        return CreatedAtAction(
            nameof(ObtenerPorId),
            new { id = paciente.Id },
            paciente
        );
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Actualizar(int id, CrearPacienteDto dto)
    {
        var actualizado = await _service.ActualizarAsync(id, dto);

        if (!actualizado)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Eliminar(int id)
    {
        var eliminado = await _service.EliminarAsync(id);

        if (!eliminado)
            return NotFound();

        return NoContent();
    }
}
