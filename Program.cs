using MitDataoverblik.Components;
using Microsoft.EntityFrameworkCore;
using MitDataoverblik.Data;
using MitDataoverblik.Models;
using MitDataoverblik.Services;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlite("Data Source=mitdataoverblik.db"));
builder.Services.AddScoped<BorgerService>(); //Dependency Injection for BorgerService, sørger for at levere services til de sider, der skal bruge den
builder.Services.AddScoped<BorgeroplysningService>();
builder.Services.AddScoped<RettelsesanmodningService>();
builder.Services
    .AddAuthentication(
        Microsoft.AspNetCore.Authentication.Cookies
            .CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/login";
    });
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<DemoAuthenticationStateProvider>();

builder.Services.AddScoped<AuthenticationStateProvider>(services =>
    services.GetRequiredService<DemoAuthenticationStateProvider>());

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    if (!db.Borgere.Any())
    {
        db.Borgere.Add(new Borger
        {
            Navn = "Anna Hansen",
            Adresse = "Hovedgaden 1, 8600 Silkeborg",
            Myndighed = "Silkeborg Kommune"
        });

        db.SaveChanges();
    }
    if (!db.Borgere.Any(b => b.Id == 2))
    {
        db.Borgere.Add(new Borger
        {
            Id = 2,
            Navn = "Bo Nielsen",
            Adresse = "Demovej 2, 8600 Silkeborg",
            Myndighed = "Silkeborg Kommune"
        });

        db.SaveChanges();
    }
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
    app.UseHttpsRedirection();

    app.UseAntiforgery();

    app.MapStaticAssets();
    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

    app.Run();

