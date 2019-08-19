using AutoMapper;
using Klient.Application.Klients.Queries.GetKlientById;
using Klient.DTO.Models;
using Klient.Model.Entities;

namespace Klient.Application.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<KlientEntity, KlientViewModel>()
                .ForMember(pDTO => pDTO.Miasto, opt => opt.MapFrom(p => p.Adres != null ? p.Adres.Miasto : string.Empty));
            CreateMap<KlientEntity, KlientDTO>();
        }
    }
}
