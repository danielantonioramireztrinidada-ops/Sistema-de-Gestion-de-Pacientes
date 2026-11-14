# SaludPlus - Sistema de Gestión de Pacientes

Sistema de gestión de pacientes desarrollado con ASP.NET Core Web API, Blazor WebAssembly y SQLite.

## Tecnologías utilizadas

- C#
- .NET 10
- ASP.NET Core Web API
- Blazor WebAssembly
- Entity Framework Core
- SQLite

## Arquitectura del proyecto

- Domain: entidades del sistema.
- Application: DTOs, interfaces y servicios.
- Infrastructure: repositorios y acceso a datos.
- API: controladores y servicios web.
- Client: interfaz web con Blazor WebAssembly.

## Entidades de la base de datos

1. Paciente
2. Medico
3. Especialidad
4. Consultorio
5. Cita
6. HistorialMedico
7. Diagnostico
8. Tratamiento
9. Medicamento
10. RecetaMedica
## Funcionalidades implementadas

- Registrar pacientes.
- Consultar pacientes.
- Buscar pacientes por ID.
- Editar pacientes.
- Eliminar pacientes.
- Visualizar pacientes desde la interfaz web.

## Ejecutar el proyecto

API (puerto 5000):

dotnet run --project SistemaPacientes.API/SistemaPacientes.API.csproj --urls http://0.0.0.0:5000

Cliente Blazor (puerto 5001):

dotnet run --project SistemaPacientes.Client/SistemaPacientes.Client.csproj --urls http://0.0.0.0:5001

## Compilar la solución

dotnet build SistemaPacientes.slnx

## Endpoints de pacientes

- GET /api/Pacientes - Listar pacientes.
- GET /api/Pacientes/{id} - Buscar paciente.
- POST /api/Pacientes - Registrar paciente.
- PUT /api/Pacientes/{id} - Actualizar paciente.
- DELETE /api/Pacientes/{id} - Eliminar paciente.

## Base de datos

SQLite y Entity Framework Core con migraciones.

## Objetivo

Proyecto académico para aplicar arquitectura por capas, desarrollo de API REST y aplicaciones web con C#.
