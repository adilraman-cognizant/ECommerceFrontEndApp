using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ECommerceFrontEndApp;
using EComBlazor.Services;
using EComBlazor.AuthServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://adilecombackendapp-hub0erhqgabhbvgr.northcentralus-01.azurewebsites.net") });

// Register the ProductService in the DI container
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<BasketService>();
builder.Services.AddScoped<WishlistService>();
builder.Services.AddScoped<ReviewService>();
builder.Services.AddScoped<ProfileService>();
builder.Services.AddScoped<AuthService>();


builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
