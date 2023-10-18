using FeatureManagement.Client;
using FeatureManagement.Shared.Features;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FeatureManagement;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddFeatureManagement();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOptions<FeatureFlagOptions>()
    .BindConfiguration("FeatureManagement")
    .ValidateDataAnnotations();

await builder.Build().RunAsync();
