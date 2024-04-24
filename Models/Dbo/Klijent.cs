using mvc_project.Models.Base;

namespace mvc_project.Models.Dbo
{
    public class Klijent
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }
    }

    public class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public decimal Iznos { get; set; }
    }
}
