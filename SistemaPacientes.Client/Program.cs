
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SistemaPacientes.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Conexion con la API
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://zany-robot-4q677r79jx99hqp-5000.app.github.dev/")
});

await builder.Build().RunAsync();
