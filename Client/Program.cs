using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<StaticData>();

await builder.Build().RunAsync();
