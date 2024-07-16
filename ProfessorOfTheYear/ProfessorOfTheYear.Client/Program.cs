using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProfessorOfTheYear.Client;
using ProfessorOfTheYear.Client.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazorBootstrap();
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped<IDataServiceTeaching, MockDataTeaching>();

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
