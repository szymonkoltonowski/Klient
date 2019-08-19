using AutoMapper;
using Klient.DAO;
using Klient.DTO.Models;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Klients.Queries.GetKlientById
{
    public class GetKlientByIdQueryHandler : IRequestHandler<GetKlientByIdQuery, KlientDTO>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public GetKlientByIdQueryHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<KlientDTO> Handle(GetKlientByIdQuery request, CancellationToken cancellationToken)
        {
            //var klientEntity = await _dataContext.Klient
           //     .Where(klient => klient.Id == request.id)
            //    .FirstOrDefaultAsync(cancellationToken);
            
            //return klientEntity;


             var klientDTO = _mapper.Map<KlientDTO>(await _dataContext
                .Klient.Where(p => p.Id == request.id).Include(p =>p.Adres)
                .SingleOrDefaultAsync(cancellationToken));
            return klientDTO;

        }

    }
}
