using Microsoft.Extensions.DependencyInjection;
//using BlazorApp1.Clients;
using BlazorApp1.Components;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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

//builder.Services.AddSingleton<DocumentClient>();

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
