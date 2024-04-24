using Microsoft.AspNetCore.Mvc;
using mvc_project.Services.Implementations;

namespace mvc_project.Controllers
{
    public class RezervacijeController : Controller
    {
        private readonly UpravljanjeRezervacijamaServis _rezervacijeServis;

        public RezervacijeController(UpravljanjeRezervacijamaServis rezervacijeServis)
        {
            _rezervacijeServis = rezervacijeServis;
        }

        public IActionResult Index(int klijentId)
        {
            // Prikazuje ukupan iznos rezervacija za određenog klijenta
            decimal ukupanIznos = _rezervacijeServis.UkupanIznosRezervacija(klijentId);
            return View(ukupanIznos);
        }

        [HttpPost]
        public IActionResult DodajRezervaciju(int klijentId, DateTime datum, decimal iznos)
        {
            try
            {
                // Dodaj rezervaciju za određenog klijenta
                _rezervacijeServis.DodajRezervaciju(klijentId, datum, iznos);
                return RedirectToAction("Index", new { klijentId = klijentId });
            }
            catch (Exception ex)
            {
                // U slučaju greške, prikaži poruku greške
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index", new { klijentId = klijentId });
            }
        }
    }
}
