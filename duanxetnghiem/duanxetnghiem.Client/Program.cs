using duanxetnghiem.Client;
using duanxetnghiem.Client.Services;
using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared.ketnoi;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Web;
using duanxetnghiem.Client.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSession();
builder.Services.AddMemoryCache();
builder.Services.AddBlazoredSessionStorageAsSingleton();
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddScoped<IUser, UserServices>();
builder.Services.AddScoped<IBacSi, BacSiServices>();
builder.Services.AddScoped<IDonXetNghiem, DonXetNghiemServices>();
builder.Services.AddScoped<IGoiXetNghiem, GoiXetNghiemServices>();
builder.Services.AddScoped<IKetQuaXetNghiem, KetQuaXetNghiemServices>();
builder.Services.AddScoped<Iaccount, AccService>();
builder.Services.AddSingleton<User>();
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddBlazoredLocalStorageAsSingleton();
await builder.Build().RunAsync();
