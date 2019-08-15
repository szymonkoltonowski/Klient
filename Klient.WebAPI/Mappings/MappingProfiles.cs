using AutoMapper;
using Klient.DTO.Models;
using Klient.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klient.WebAPI.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //CreateMap<KlientEntity, KlientDTO>();
            CreateMap<KlientEntity, KlientDTO>()
                .ForMember(dest => dest.Miasto,
                opts => opts.MapFrom(
                    src => src.Adres.Miasto));
        }
    }
}
