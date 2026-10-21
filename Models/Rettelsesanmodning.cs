using System.ComponentModel.DataAnnotations;

namespace MitDataoverblik.Models
{
    public class Rettelsesanmodning
    {
        //Hvilken anmodning er det ?
        public int Id { get; set; }

        // Hvilken borger er det ?
        public int BorgerId { get; set; }

        //Valideringen over BorgeroplysningsId. Kræver et ID på mindst 1, så standardvalget med værdien 0 afvises
        [Range(1, int.MaxValue,
            ErrorMessage = "Vælg den oplysning, du ønsker rettet.")]

        // Hvilken borgeroplysning ønsker borgeren rettet ?
        public int BorgeroplysningId { get; set; }

        // Required: obligatoriske felter. Viser en fejlbesked, hvis rettelsen mangler

        [Required(ErrorMessage = "Skriv den ønskede rettelse.")]
        public string OensketRettelse { get; set; } = "";

        [Required(ErrorMessage = "Skriv en begrundelse.")]
        public string Begrundelse { get; set; } = "";

        // Dato og tidspunkt sættes af servicen ved oprettelse
        public DateTime Oprettelsesdato { get; set; }

        // Startstatus for en ny anmodning
        public string Status { get; set; } = "Afventer";
    }
}