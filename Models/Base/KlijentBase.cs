namespace mvc_project.Models.Base
{
    public abstract class KlijentBase
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }
        public DateTime Datum { get; set; }
        public decimal Iznos { get; set; }
    }
}