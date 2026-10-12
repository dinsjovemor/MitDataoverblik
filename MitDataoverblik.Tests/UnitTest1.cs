using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MitDataoverblik.Data;
using MitDataoverblik.Models;
using MitDataoverblik.Services;
using Xunit;

namespace MitDataoverblik.Tests;

public class BorgerServiceTests
{
    [Fact]
    public async Task HentBorgerAsync_ReturnererDenRigtigeBorger()
    {
        // Arrange: Opret en separat testdatabase.
        using var connection = new SqliteConnection("Data Source=:memory:");
        await connection.OpenAsync();

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite(connection)
            .Options;

        var factory = new PooledDbContextFactory<AppDbContext>(options);

        using (var db = factory.CreateDbContext())
        {
            await db.Database.EnsureCreatedAsync();

            db.Borgere.Add(new Borger
            {
                Id = 1,
                Navn = "Test Borger",
                Adresse = "Testvej 1",
                Myndighed = "Testkommune"
            });

            await db.SaveChangesAsync();
        }

        var service = new BorgerService(factory);

        // Act: Hent borgeren gennem servicen.
        var resultat = await service.HentBorgerAsync(1);

        // Assert: Kontroller oplysningerne.
        Assert.NotNull(resultat);
        Assert.Equal("Test Borger", resultat.Navn);
        Assert.Equal("Testvej 1", resultat.Adresse);
        Assert.Equal("Testkommune", resultat.Myndighed);
    }
    [Fact]
    public async Task HentBorgerAsync_ReturnererNullNaarIdIkkeFindes()
    {
        // Arrange: Databasen indeholder borger 1, men ikke borger 999.
        using var connection = new SqliteConnection("Data Source=:memory:");
        await connection.OpenAsync();

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite(connection)
            .Options;

        var factory = new PooledDbContextFactory<AppDbContext>(options);

        using (var db = factory.CreateDbContext())
        {
            await db.Database.EnsureCreatedAsync();

            db.Borgere.Add(new Borger
            {
                Id = 1,
                Navn = "Test Borger",
                Adresse = "Testvej 1",
                Myndighed = "Testkommune"
            });

            await db.SaveChangesAsync();
        }

        var service = new BorgerService(factory);

        // Act: Søg efter et ID, der ikke findes.
        var resultat = await service.HentBorgerAsync(999);

        // Assert: Servicen skal returnere null.
        Assert.Null(resultat);
    }
}