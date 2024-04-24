using AutoMapper;
using mvc_project.Models.Binding;
using mvc_project.Models.Dbo;
using mvc_project.Models.ViewModel;

namespace mvc_project.Mapping
{
    public class Mapping:Profile
    {
        public Mapping() 
        {
            CreateMap<KlijentBinding, Klijent>();
            CreateMap<Klijent, KlijentViewModel>();
        }
    }
}
