using AutoMapper;
using Klient.DAO;
using Klient.DTO.Models;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Adresses.Queries.GetAdresById
{
    public class GetAdresByIdQueryHandler : IRequestHandler<GetAdresByIdQuery,AdresDTO>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public GetAdresByIdQueryHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public IEnumerator<AdresEntity> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

   
        public async Task<AdresDTO> Handle(GetAdresByIdQuery request, CancellationToken cancellationToken)
        {
            var adresEntity = await _dataContext.Adres
                   .Where(adres => adres.Id == request._id)
                   .FirstOrDefaultAsync(cancellationToken);
            var adresDTO = _mapper.Map<AdresDTO>(adresEntity);
            return adresDTO;
        }
    }
}
