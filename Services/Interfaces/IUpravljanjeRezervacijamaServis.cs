using mvc_project.Models.Binding;
using mvc_project.Models.ViewModel;

namespace mvc_project.Services.Interfaces
{
    public interface IUpravljanjeRezervacijamaServis
    {
        KlijentViewModel DodajRezervaciju(string naziv, int kolicina);

        KlijentViewModel UkupanIznosRezervacija(int id);
    }

}
