using MitDataoverblik.Components;
using Microsoft.EntityFrameworkCore;
using MitDataoverblik.Data;
using MitDataoverblik.Models;
using MitDataoverblik.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlite("Data Source=mitdataoverblik.db"));
builder.Services.AddScoped<BorgerService>(); //Dependency Injection for BorgerService, sørger for at levere
                                             //services til de sider, der skal bruge den
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

