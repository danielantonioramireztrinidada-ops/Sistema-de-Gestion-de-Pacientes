using Microsoft.EntityFrameworkCore;
using SistemaPacientes.Domain.Entities;

namespace SistemaPacientes.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Paciente> Pacientes => Set<Paciente>();
    public DbSet<Medico> Medicos => Set<Medico>();
    public DbSet<Especialidad> Especialidades => Set<Especialidad>();
    public DbSet<Consultorio> Consultorios => Set<Consultorio>();
    public DbSet<Cita> Citas => Set<Cita>();
    public DbSet<HistorialMedico> HistorialesMedicos => Set<HistorialMedico>();
    public DbSet<Diagnostico> Diagnosticos => Set<Diagnostico>();
    public DbSet<Tratamiento> Tratamientos => Set<Tratamiento>();
    public DbSet<Medicamento> Medicamentos => Set<Medicamento>();
    public DbSet<RecetaMedica> RecetasMedicas => Set<RecetaMedica>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Especialidad - Medicos
    modelBuilder.Entity<Medico>()
        .HasOne(m => m.Especialidad)
        .WithMany(e => e.Medicos)
        .HasForeignKey(m => m.EspecialidadId)
        .OnDelete(DeleteBehavior.Restrict);

    // Paciente - Citas
    modelBuilder.Entity<Cita>()
        .HasOne(c => c.Paciente)
        .WithMany()
        .HasForeignKey(c => c.PacienteId)
        .OnDelete(DeleteBehavior.Restrict);

    // Medico - Citas
    modelBuilder.Entity<Cita>()
        .HasOne(c => c.Medico)
        .WithMany()
        .HasForeignKey(c => c.MedicoId)
        .OnDelete(DeleteBehavior.Restrict);

    // Consultorio - Citas
    modelBuilder.Entity<Cita>()
        .HasOne(c => c.Consultorio)
        .WithMany(co => co.Citas)
        .HasForeignKey(c => c.ConsultorioId)
        .OnDelete(DeleteBehavior.Restrict);

    // Paciente - Historial medico
    modelBuilder.Entity<HistorialMedico>()
        .HasOne(h => h.Paciente)
        .WithMany()
        .HasForeignKey(h => h.PacienteId)
        .OnDelete(DeleteBehavior.Restrict);

    // Historial medico - Diagnosticos
    modelBuilder.Entity<Diagnostico>()
        .HasOne(d => d.HistorialMedico)
        .WithMany()
        .HasForeignKey(d => d.HistorialMedicoId)
        .OnDelete(DeleteBehavior.Restrict);

    // Medico - Diagnosticos
    modelBuilder.Entity<Diagnostico>()
        .HasOne(d => d.Medico)
        .WithMany()
        .HasForeignKey(d => d.MedicoId)
        .OnDelete(DeleteBehavior.Restrict);

    // Diagnostico - Tratamientos
    modelBuilder.Entity<Tratamiento>()
        .HasOne(t => t.Diagnostico)
        .WithMany()
        .HasForeignKey(t => t.DiagnosticoId)
        .OnDelete(DeleteBehavior.Restrict);

    // Paciente - Recetas
    modelBuilder.Entity<RecetaMedica>()
        .HasOne(r => r.Paciente)
        .WithMany()
        .HasForeignKey(r => r.PacienteId)
        .OnDelete(DeleteBehavior.Restrict);

    // Medico - Recetas
    modelBuilder.Entity<RecetaMedica>()
        .HasOne(r => r.Medico)
        .WithMany()
        .HasForeignKey(r => r.MedicoId)
        .OnDelete(DeleteBehavior.Restrict);

    // Cita - Recetas
    modelBuilder.Entity<RecetaMedica>()
        .HasOne(r => r.Cita)
        .WithMany()
        .HasForeignKey(r => r.CitaId)
        .OnDelete(DeleteBehavior.Restrict);

    // Precision del costo de consulta
    modelBuilder.Entity<Especialidad>()
        .Property(e => e.CostoConsulta)
        .HasPrecision(10, 2);
}
}