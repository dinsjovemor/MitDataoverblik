using System.ComponentModel.DataAnnotations;

namespace MitDataoverblik.Models
{
    public class Rettelsesanmodning
    {
        public int Id { get; set; }

        public int BorgerId { get; set; }

        [Range(1, int.MaxValue,
            ErrorMessage = "Vælg den oplysning, du ønsker rettet.")]
        public int BorgeroplysningId { get; set; }

        [Required(ErrorMessage = "Skriv den ønskede rettelse.")]
        public string OensketRettelse { get; set; } = "";

        [Required(ErrorMessage = "Skriv en begrundelse.")]
        public string Begrundelse { get; set; } = "";

        public DateTime Oprettelsesdato { get; set; }

        public string Status { get; set; } = "Afventer";
    }
}