namespace MitDataoverblik.Models
{
    public class Borgeroplysning
    {
        public int Id { get; set; }
        public int BorgerId { get; set; }
        public string Betegnelse { get; set; } = "";
        public string Værdi { get; set; } = "";
        public string DataType { get; set; } = "";
        public string Myndighed { get; set; } = "";
    }
}
