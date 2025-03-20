using BlazorApp1.Components;
using BlazorApp1.Data;
using BlazorApp1.Services; // Add this for HaloPSAService
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContextFactory<TicketContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TicketContext")
                         ?? throw new InvalidOperationException("Connection string 'TicketContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "auth_token";
    options.LoginPath = "/login";
    options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
    options.AccessDeniedPath = "/access-denied";
});

builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();

// Register the HttpClient to interact with HaloPSA's API
builder.Services.AddHttpClient();  // This registers HttpClient for DI
// Register the HaloPSAService to interact with HaloPSA API
builder.Services.AddSingleton<HaloPSAService>(); // This is your custom service to integrate HaloPSA

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
    app.UseAuthentication();
    app.UseAuthorization();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
