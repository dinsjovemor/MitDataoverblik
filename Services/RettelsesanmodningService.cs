using MitDataoverblik.Models;

namespace MitDataoverblik.Services
{
    public class RettelsesanmodningService
    {
        // Opretter en tom liste til anmodninger i denne serviceinstans
        private readonly List<Rettelsesanmodning> anmodninger = new();
        // Starter ID-tælleren på 1 i denne serviceinstans
        private int naesteId = 1;

        public void OpretAnmodning(Rettelsesanmodning anmodning)
        {
            // Giver anmodningen det næste ID og øger derefter tælleren med 1
            anmodning.Id = naesteId++;
            anmodning.Oprettelsesdato = DateTime.Now;
            anmodning.Status = "Afventer";
            // Tilføjer den udfyldte anmodning til listen i hukommelsen
            anmodninger.Add(anmodning);
        }
        // Henter kun anmodninger, der tilhører det angivne borger-ID
        public List<Rettelsesanmodning> HentAnmodninger(int borgerId)
        {
            return anmodninger
                .Where(a => a.BorgerId == borgerId)
                .ToList();
        }
        public void OpdaterStatus(int anmodningId, string nyStatus)
        {
            // Stopper metoden, hvis den nye status ikke er en af de tre tilladte værdier
            if (nyStatus != "Afventer"
                && nyStatus != "Under behandling"
                && nyStatus != "Afsluttet")
            {
                return;
            }
            // Finder den første anmodning med det angivne ID eller giver null, hvis den ikke findes
            var anmodning = anmodninger
                .FirstOrDefault(a => a.Id == anmodningId);

            // Ændrer kun status, hvis anmodningen blev fundet
            if (anmodning is not null)
            {
                anmodning.Status = nyStatus;
            }
        }
        // Henter alle anmodninger i denne serviceinstans uden filtrering efter borger
        public List<Rettelsesanmodning> HentAlleAnmodninger()
        {
            return anmodninger.ToList();
        }
    }
}