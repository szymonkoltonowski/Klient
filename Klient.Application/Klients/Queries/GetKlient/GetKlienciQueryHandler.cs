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

namespace Klient.Application.Klients.Queries.GetKlient
{
    public class GetKlienciQueryHandler : IRequestHandler<GetKlienciQuery, IEnumerable<KlientDTO>>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public GetKlienciQueryHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<KlientDTO>> Handle(GetKlienciQuery request, CancellationToken cancellationToken)
        {

            var klientEntityList = await _dataContext.Klient.ToListAsync(cancellationToken) ;

            var dupa = _mapper.Map<List<KlientDTO>>(klientEntityList);

            return dupa;
        }


    }
}
