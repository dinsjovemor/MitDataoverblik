using MitDataoverblik.Models;

namespace MitDataoverblik.Services
{
    public class BorgeroplysningService
    {
        private readonly List<Borgeroplysning> oplysninger = new()
        {
            new Borgeroplysning
            {
                Id = 1,
                BorgerId = 1,
                Betegnelse = "Folkeregisteradresse",
                Værdi = "Hovedgaden 1, 8600 Silkeborg",
                DataType = "Tekst",
                Myndighed = "Silkeborg Kommune"
            },
            new Borgeroplysning
            {
                Id = 2,
                BorgerId = 1,
                Betegnelse = "Tilflytningsdato",
                Værdi = "01-08-2024",
                DataType = "Dato",
                Myndighed = "Silkeborg Kommune"
            },
            new Borgeroplysning
            {
                Id = 3,
                BorgerId = 1,
                Betegnelse = "Matrikelnummer",
                Værdi = "12a, Demo By",
                DataType = "Tekst",
                Myndighed = "Geodatastyrelsen"
            },
            new Borgeroplysning
            {
                Id = 4,
                BorgerId = 1,
                Betegnelse = "Grundareal",
                Værdi = "750 m²",
                DataType = "Tal",
                Myndighed = "Geodatastyrelsen"
            },
            new Borgeroplysning
            {
                Id = 5,
                BorgerId = 1,
                Betegnelse = "Breddegrad",
                Værdi = "56,1700",
                DataType = "Tal",
                Myndighed = "Klimadatastyrelsen"
            },
            new Borgeroplysning
            {
                Id = 6,
                BorgerId = 1,
                Betegnelse = "Længdegrad",
                Værdi = "9,5500",
                DataType = "Tal",
                Myndighed = "Klimadatastyrelsen"
            },

            new Borgeroplysning
{
    Id = 7,
    BorgerId = 2,
    Betegnelse = "Folkeregisteradresse",
    Værdi = "Demovej 2, 8600 Silkeborg",
    DataType = "Tekst",
    Myndighed = "Silkeborg Kommune"
}
        };

        public List<Borgeroplysning> HentOplysninger(int borgerId)
        {
            return oplysninger
                .Where(oplysning => oplysning.BorgerId == borgerId)
                .ToList();
        }
    }
}