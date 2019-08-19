using AutoMapper;
using Klient.DAO;
using Klient.DTO.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Adresses.Queries.GetAdres
{
    public class GetAdresQueryHandler : IRequestHandler<GetAdresQuery, IEnumerable<AdresDTO>>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public GetAdresQueryHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AdresDTO>> Handle(GetAdresQuery request, CancellationToken cancellationToken)
        {
            var adresEntityList = await _dataContext.Adres.ToListAsync(cancellationToken);
            var adresDTOList = _mapper.Map<List<AdresDTO>>(adresEntityList);
            return adresDTOList;
        }
    }
}
