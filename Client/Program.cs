using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using Data;
using Microsoft.Net.Http.Headers;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Configuration.GetSection("googleAPIKey");

builder.Services.AddScoped<GoogleAuthorizationMessageHandler>();

builder.Services.AddHttpClient("GoogleSheets",
        client => client.BaseAddress = new Uri("https://sheets.googleapis.com/v4/spreadsheets"))
    .AddHttpMessageHandler<GoogleAuthorizationMessageHandler>();


builder.Services.AddSingleton<StaticData>();

builder.Services.AddMudServices();

builder.Services
    .AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("Local", options.ProviderOptions);
    options.ProviderOptions.ResponseType = "id_token token";
    options.ProviderOptions.DefaultScopes.Add("https://www.googleapis.com/auth/drive.file");
});

await builder.Build().RunAsync();
