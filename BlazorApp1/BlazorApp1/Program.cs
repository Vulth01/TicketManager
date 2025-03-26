using BlazorApp1.Components;
using BlazorApp1.Data;
using BlazorApp1.Services; // Added this for HashPasswordService
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the required services
builder.Services.AddControllersWithViews();

builder.Services.AddDbContextFactory<TicketContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TicketContext")
                         ?? throw new InvalidOperationException("Connection string 'TicketContext' not found.")));

// Adding quick grid and exception filter services
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Registering Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Authentication service configuration
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "auth_token";
    options.LoginPath = "/login";
    options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
    options.AccessDeniedPath = "/access-denied";
});

builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();

// Register the HashPasswordService for DI
builder.Services.AddSingleton<HashPasswordService>();  // This is the service you moved the hashing logic to

// Register the HttpClient to interact with HaloPSA's API
builder.Services.AddHttpClient();  // Registers HttpClient for DI

// Register the HaloPSAService to interact with HaloPSA API
builder.Services.AddSingleton<HaloPSAService>();  // This is your custom service to integrate HaloPSA

var app = builder.Build();

// Middlewares for handling requests
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

// Map Razor components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Run the application
app.Run();
