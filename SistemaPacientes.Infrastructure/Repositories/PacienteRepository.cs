using Microsoft.EntityFrameworkCore;
using SistemaPacientes.Application.Interfaces;
using SistemaPacientes.Domain.Entities;
using SistemaPacientes.Infrastructure.Data;

namespace SistemaPacientes.Infrastructure.Repositories;

public class PacienteRepository : IPacienteRepository
{
    private readonly ApplicationDbContext _context;

    public PacienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Paciente>> ObtenerTodosAsync()
    {
        return await _context.Pacientes
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Paciente?> ObtenerPorIdAsync(int id)
    {
        return await _context.Pacientes.FindAsync(id);
    }

    public async Task AgregarAsync(Paciente paciente)
    {
        await _context.Pacientes.AddAsync(paciente);
    }

    public void Eliminar(Paciente paciente)
    {
        _context.Pacientes.Remove(paciente);
    }

    public async Task GuardarCambiosAsync()
    {
        await _context.SaveChangesAsync();
    }
}