using MitDataoverblik.Models;

namespace MitDataoverblik.Services
{
    public class RettelsesanmodningService
    {
        private readonly List<Rettelsesanmodning> anmodninger = new();
        private int naesteId = 1;

        public void OpretAnmodning(Rettelsesanmodning anmodning)
        {
            anmodning.Id = naesteId++;
            anmodning.Oprettelsesdato = DateTime.Now;
            anmodning.Status = "Afventer";

            anmodninger.Add(anmodning);
        }

        public List<Rettelsesanmodning> HentAnmodninger(int borgerId)
        {
            return anmodninger
                .Where(a => a.BorgerId == borgerId)
                .ToList();
        }
    }
}