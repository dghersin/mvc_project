using AutoMapper;
using Microsoft.EntityFrameworkCore;
using mvc_project.Context;
using mvc_project.Models;
using mvc_project.Models.Binding;
using mvc_project.Models.Dbo;
using mvc_project.Models.ViewModel;
using mvc_project.Services.Interfaces;



namespace mvc_project.Services.Implementations
{
    public class UpravljanjeRezervacijamaServis

    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext db;

        public UpravljanjeRezervacijamaServis(IMapper mapper, ApplicationDbContext db)
        {
            this.mapper = mapper;
            this.db = db;
        }

            private readonly ApplicationDbContext _dbContext;

            public UpravljanjeRezervacijamaServis(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void DodajRezervaciju(int klijentId, DateTime datum, decimal iznos)
            {
                // Provjeri postoji li klijent s danim ID-om
                var klijent = _dbContext.Klijenti.FirstOrDefault(k => k.KlijentId == klijentId);
                if (klijent == null)
                {
                    throw new ArgumentException("Klijent s danim ID-om ne postoji.");
                }

                // Stvori novu rezervaciju
                var novaRezervacija = new Rezervacija
                {
                    KlijentId = klijentId,
                    Datum = datum,
                    Iznos = iznos
                };

                // Dodaj rezervaciju u bazu podataka
                _dbContext.Rezervacije.Add(novaRezervacija);
                _dbContext.SaveChanges();
            }

            public decimal UkupanIznosRezervacija(int klijentId)
            {
                // Pronađi sve rezervacije za danog klijenta
                var rezervacijeKlijenta = _dbContext.Rezervacije.Where(r => r.KlijentId == klijentId);

                // Izračunaj ukupan iznos rezervacija
                decimal ukupanIznos = rezervacijeKlijenta.Sum(r => r.Iznos);

                return ukupanIznos;
            }
        }

    
}
